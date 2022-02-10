//Сборку mscorlib компилятор ilasm создает автоматически и ее можно не добавлять в определение файла
// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}

//Название создаваемой сборки и указание версии
.assembly CILTypes
{
    .ver 1:0:0:0
}
//Название модуля
.module CILTypes.dll

// =============== CLASS MEMBERS DECLARATION ===================
//Создание собственного пространства имен
.namespace MyNameSpace
{
    //Создание интерфейса
    .class public interface IMyInterface{}

    //расширение интерфейса
    .class public interface IMyOtherInterface
        implements MyNameSpace.IMyInterface{}

    //создание структуры
    .class public sealed value MyStruct{}

    //создание перечисления
    .class public sealed enum MyEnum
    {
        //Добавление полей в перечисление
        .field public static literal valuetype
            MyNameSpace.MyEnum A = int32(0)
        .field public static literal valuetype
            MyNameSpace.MyEnum B = int32(1) 
        .field public static literal valuetype
            MyNameSpace.MyEnum C = int32(2) 

    }

    //создание класса
    .class public MyBaseClass
    {  
        //добавление полей в класс
        .field private string _stringFiled = "Hello!"
        .field private int32 _intField = int32 (45)

        //добавление конструктора
        .method public hidebysig specialname rtspecialname
            instance void .ctor(string s, int32 i) cil managed
        {
            //Реализация конструктора
        }

        //Реализация методов
        .method public hidebysig specialname rtspecialname
            instance string GetString() cil managed
        {
            //Реализация 
        }

        .method public hidebysig specialname rtspecialname
            instance void SetString(string 'value') cil managed
        {
            //Реализация 
        }

        //свойство
        .property instance string TheString()
        {
            .get instance string
                MyNameSpace.MyBaseClass :: GetString()
            .set instance void
                MyNameSpace.MyBaseClass :: SetString(string)
        }

    }

    //Создание класса наследника MyBaseClass{}
    //требуется указывать полное имя класса включая название пространства имен
    .class public MyDerrivesClass
        //Класс родитель
        extends MyNameSpace.MyBaseClass
        //Реализация интерфеса классом
        implements MyNameSpace.IMyInterface{}
}

// =============================================================