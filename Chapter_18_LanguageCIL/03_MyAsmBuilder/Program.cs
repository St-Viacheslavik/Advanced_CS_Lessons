using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace MyAsmBuilder
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Создание динамической сборки";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Приложение для формирования динамической сборки с помощью пространства имен System.Reflection.Emit\n" +
                              "Создание происходит в методе CreateMyAsm");

            Console.WriteLine("Созданная сборка загрузится в приложение с использованием позднего связывания");
            Console.WriteLine("-----------------------------------------------------------------------------\n\n");
            Console.WriteLine("Вызов метода CreateMyAsm\n");
            CreateMyAsm(Thread.GetDomain());
            Console.WriteLine("Был создан файл DynamicAssemblyWithCIL.dll");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------");
            Console.WriteLine("Загрузки новой сборки из созданного файла");
            var assembly = Assembly.Load("DynamicAssemblyWithCIL");
            //получить тип HelloWorld
            var hello = assembly.GetType("DynamicAssemblyWithCIL.HelloWorld");
            //создать объект HelloWorld и вызвать корректный конструктор
            Console.Write("Введите слово для создания объекта: ");
            var msg = Console.ReadLine();
            var ctorArgs = new object[1];
            ctorArgs[0] = msg;
            var obj = Activator.CreateInstance(hello, ctorArgs);

            //Вызвать метод SayHello
            Console.WriteLine("Вызов метода SayHello");
            var mi = hello.GetMethod("SayHello");
            mi?.Invoke(obj, null);

            //Вызвать метод GetMsg()
            Console.WriteLine("Вызов метода GetMsg");
            mi = hello.GetMethod("GetMsg");
            Console.WriteLine(mi?.Invoke(obj,null));

            Console.WriteLine("\n\nРабота приложения завершена\n-----------------------------------------------------------------------------");
            Console.ReadLine();

        }

        private static void CreateMyAsm(AppDomain curAppDomain)
        {
            #region Set assembly characteristic

            var assemblyName = new AssemblyName
            {
                Name = "DynamicAssemblyWithCIL", Version = Version.Parse("1.0.0.0")
            };

            #endregion

            #region Create new assembly in current domain

            var assembly = curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);

            //Задание имени модуля
            var module = assembly.DefineDynamicModule(assemblyName.Name, $"{assemblyName.Name}.dll");

            //Определить открытый класс внутри сборки
            var helloWorldClass = module.DefineType($"{assemblyName.Name}.HelloWorld", TypeAttributes.Public);

            //Определить закрытую переменную член типа String с именем _theMessage
            var msgField =
                helloWorldClass.DefineField("_theMessage", typeof(string), FieldAttributes.Private);

            #region Create Constructor for new class in dynamic assembly

            var constructorArgs = new Type[1];
            constructorArgs[0] = typeof(string);
            var constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public,
                CallingConventions.Standard,
                constructorArgs);
            var constructorIl = constructor.GetILGenerator();
            constructorIl.Emit(OpCodes.Ldarg_0);
            var objectClass = typeof(object);
            var superConstructor = objectClass.GetConstructor(new Type[0]);
            constructorIl.Emit(OpCodes.Call, superConstructor ?? throw new InvalidOperationException());
            constructorIl.Emit(OpCodes.Ldarg_0);
            constructorIl.Emit(OpCodes.Ldarg_1);
            constructorIl.Emit(OpCodes.Stfld, msgField);
            constructorIl.Emit(OpCodes.Ret);

            //Создать конструктор
            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);

            #endregion

            #region Create Method GetMsg

            var getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof(string), null);
            var getMsgMethodIlGenerator = getMsgMethod.GetILGenerator();
            getMsgMethodIlGenerator.Emit(OpCodes.Ldarg_0);
            getMsgMethodIlGenerator.Emit(OpCodes.Ldfld, msgField);
            getMsgMethodIlGenerator.Emit(OpCodes.Ret);

            #endregion

            #region Create Method SayHello

            var sayHelloMethod = helloWorldClass.DefineMethod("SayHello", MethodAttributes.Public, null, null);
            var sayHelloMethodIlGenerator = sayHelloMethod.GetILGenerator();
            sayHelloMethodIlGenerator.EmitWriteLine("Hello from the HelloWorld class in dynamic assembly");
            sayHelloMethodIlGenerator.Emit(OpCodes.Ret);

            #endregion

            //Выпустить класс
            helloWorldClass.CreateType();

            //Сохранение сборки
            assembly.Save("DynamicAssemblyWithCIL.dll");

            #endregion
        }
    }
}
