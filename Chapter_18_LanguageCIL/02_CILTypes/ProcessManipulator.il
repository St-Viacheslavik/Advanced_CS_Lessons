
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System.Core
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly ProcessManipulator
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 12 50 72 6F 63 65 73 73 4D 61 6E 69 70 75   // ...ProcessManipu
                                                                                              6C 61 74 6F 72 00 00 )                            // lator..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 12 50 72 6F 63 65 73 73 4D 61 6E 69 70 75   // ...ProcessManipu
                                                                                                6C 61 74 6F 72 00 00 )                            // lator..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 31 00 00 )                            //  2021..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 33 31 39 39 65 38 63 65 2D 65 61 34 38   // ..$3199e8ce-ea48
                                                                                                  2D 34 36 32 31 2D 39 36 31 39 2D 33 63 32 66 62   // -4621-9619-3c2fb
                                                                                                  62 35 37 30 33 30 32 00 00 )                      // b570302..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 38 01 00 54   // ,Version=v4.8..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 38 )                      // ework 4.8
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ProcessManipulator.exe
// MVID: {E43B567C-B6C2-4F07-838F-BE43B6E280D6}
.imagebase 0x0000000140000000
.file alignment 0x00000200
.stackreserve 0x0000000000400000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0CC50000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit ProcessManipulator.Program
       extends [mscorlib]System.Object
{
  .class auto ansi serializable sealed nested private beforefieldinit '<>c'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class ProcessManipulator.Program/'<>c' '<>9'
    .field public static class [mscorlib]System.Func`1<string> '<>9__0_0'
    .field public static class [mscorlib]System.Func`1<string> '<>9__0_1'
    .field public static class [mscorlib]System.Func`1<string> '<>9__0_2'
    .field public static class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,int32> '<>9__5_0'
    .field public static class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,class [System]System.Diagnostics.Process> '<>9__5_1'
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Размер кода:       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void ProcessManipulator.Program/'<>c'::.ctor()
      IL_0005:  stsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
      IL_000a:  ret
    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Размер кода:       8 (0x8)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  nop
      IL_0007:  ret
    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance string 
            '<Main>b__0_0'() cil managed
    {
      // Размер кода:       6 (0x6)
      .maxstack  8
      IL_0000:  ldstr      "a"
      IL_0005:  ret
    } // end of method '<>c'::'<Main>b__0_0'

    .method assembly hidebysig instance string 
            '<Main>b__0_1'() cil managed
    {
      // Размер кода:       6 (0x6)
      .maxstack  8
      IL_0000:  ldstr      "b"
      IL_0005:  ret
    } // end of method '<>c'::'<Main>b__0_1'

    .method assembly hidebysig instance string 
            '<Main>b__0_2'() cil managed
    {
      // Размер кода:       6 (0x6)
      .maxstack  8
      IL_0000:  ldstr      "c"
      IL_0005:  ret
    } // end of method '<>c'::'<Main>b__0_2'

    .method assembly hidebysig instance int32 
            '<ListAllRunningProcess>b__5_0'(class [System]System.Diagnostics.Process proc) cil managed
    {
      // Размер кода:       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  callvirt   instance int32 [System]System.Diagnostics.Process::get_Id()
      IL_0006:  ret
    } // end of method '<>c'::'<ListAllRunningProcess>b__5_0'

    .method assembly hidebysig instance class [System]System.Diagnostics.Process 
            '<ListAllRunningProcess>b__5_1'(class [System]System.Diagnostics.Process proc) cil managed
    {
      // Размер кода:       2 (0x2)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  ret
    } // end of method '<>c'::'<ListAllRunningProcess>b__5_1'

  } // end of class '<>c'

  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Размер кода:       222 (0xde)
    .maxstack  3
    .locals init (class [mscorlib]System.Func`1<string> V_0,
             int32 V_1)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (20 04 30 04 31 04 3E 04 42 04 30 04 20 00 41 04   //  .0.1.>.B.0. .A.
                                    20 00 3F 04 40 04 3E 04 46 04 35 04 41 04 41 04   //  .?.@.>.F.5.A.A.
                                    30 04 3C 04 38 04 )                               // 0.<.8.
    IL_0006:  call       void [mscorlib]System.Console::set_Title(string)
    IL_000b:  nop
    IL_000c:  ldc.i4.s   10
    IL_000e:  call       void [mscorlib]System.Console::set_ForegroundColor(valuetype [mscorlib]System.ConsoleColor)
    IL_0013:  nop
    IL_0014:  ldsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_0'
    IL_0019:  dup
    IL_001a:  brtrue.s   IL_0033

    IL_001c:  pop
    IL_001d:  ldsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
    IL_0022:  ldftn      instance string ProcessManipulator.Program/'<>c'::'<Main>b__0_0'()
    IL_0028:  newobj     instance void class [mscorlib]System.Func`1<string>::.ctor(object,
                                                                                    native int)
    IL_002d:  dup
    IL_002e:  stsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_0'
    IL_0033:  stloc.0
    IL_0034:  ldloc.0
    IL_0035:  ldsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_1'
    IL_003a:  dup
    IL_003b:  brtrue.s   IL_0054

    IL_003d:  pop
    IL_003e:  ldsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
    IL_0043:  ldftn      instance string ProcessManipulator.Program/'<>c'::'<Main>b__0_1'()
    IL_0049:  newobj     instance void class [mscorlib]System.Func`1<string>::.ctor(object,
                                                                                    native int)
    IL_004e:  dup
    IL_004f:  stsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_1'
    IL_0054:  call       class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate,
                                                                                            class [mscorlib]System.Delegate)
    IL_0059:  castclass  class [mscorlib]System.Func`1<string>
    IL_005e:  stloc.0
    IL_005f:  ldloc.0
    IL_0060:  ldsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_2'
    IL_0065:  dup
    IL_0066:  brtrue.s   IL_007f

    IL_0068:  pop
    IL_0069:  ldsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
    IL_006e:  ldftn      instance string ProcessManipulator.Program/'<>c'::'<Main>b__0_2'()
    IL_0074:  newobj     instance void class [mscorlib]System.Func`1<string>::.ctor(object,
                                                                                    native int)
    IL_0079:  dup
    IL_007a:  stsfld     class [mscorlib]System.Func`1<string> ProcessManipulator.Program/'<>c'::'<>9__0_2'
    IL_007f:  call       class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate,
                                                                                            class [mscorlib]System.Delegate)
    IL_0084:  castclass  class [mscorlib]System.Func`1<string>
    IL_0089:  stloc.0
    IL_008a:  ldloc.0
    IL_008b:  callvirt   instance !0 class [mscorlib]System.Func`1<string>::Invoke()
    IL_0090:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0095:  nop
    IL_0096:  call       void ProcessManipulator.Program::ListAllRunningProcess()
    IL_009b:  nop
    IL_009c:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    50 00 49 00 44 00 20 00 3D 00 20 00 )             // P.I.D. .=. .
    IL_00a1:  call       void [mscorlib]System.Console::Write(string)
    IL_00a6:  nop
    IL_00a7:  call       string [mscorlib]System.Console::ReadLine()
    IL_00ac:  dup
    IL_00ad:  brtrue.s   IL_00b6

    IL_00af:  pop
    IL_00b0:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor()
    IL_00b5:  throw

    IL_00b6:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_00bb:  stloc.1
    IL_00bc:  ldloc.1
    IL_00bd:  call       void ProcessManipulator.Program::GetSpecificProcess(int32)
    IL_00c2:  nop
    IL_00c3:  ldloc.1
    IL_00c4:  call       void ProcessManipulator.Program::GetEnumThreads(int32)
    IL_00c9:  nop
    IL_00ca:  ldloc.1
    IL_00cb:  call       void ProcessManipulator.Program::EnumModsByPid(int32)
    IL_00d0:  nop
    IL_00d1:  call       void ProcessManipulator.Program::StartAndKillProcess()
    IL_00d6:  nop
    IL_00d7:  call       string [mscorlib]System.Console::ReadLine()
    IL_00dc:  pop
    IL_00dd:  ret
  } // end of method Program::Main

  .method private hidebysig static void  StartAndKillProcess() cil managed
  {
    // Размер кода:       111 (0x6f)
    .maxstack  3
    .locals init (class [System]System.Diagnostics.ProcessStartInfo V_0,
             class [System]System.Diagnostics.Process V_1,
             class [mscorlib]System.InvalidOperationException V_2)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (17 04 30 04 3F 04 43 04 41 04 42 04 38 04 42 04   // ..0.?.C.A.B.8.B.
                                    4C 04 20 00 3F 04 40 04 3E 04 46 04 35 04 41 04   // L. .?.@.>.F.5.A.
                                    41 04 20 00 31 04 3B 04 3E 04 3A 04 3D 04 3E 04   // A. .1.;.>.:.=.>.
                                    42 04 2C 00 20 00 30 04 20 00 37 04 30 04 42 04   // B.,. .0. .7.0.B.
                                    35 04 3C 04 20 00 43 04 3D 04 38 04 47 04 42 04   // 5.<. .C.=.8.G.B.
                                    3E 04 36 04 38 04 42 04 4C 04 20 00 35 04 33 04   // >.6.8.B.L. .5.3.
                                    3E 04 )                                           // >.
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    .try
    {
      IL_000c:  nop
      IL_000d:  ldstr      "Notepad.exe"
      IL_0012:  newobj     instance void [System]System.Diagnostics.ProcessStartInfo::.ctor(string)
      IL_0017:  dup
      IL_0018:  ldc.i4.3
      IL_0019:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_WindowStyle(valuetype [System]System.Diagnostics.ProcessWindowStyle)
      IL_001e:  nop
      IL_001f:  stloc.0
      IL_0020:  ldloc.0
      IL_0021:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(class [System]System.Diagnostics.ProcessStartInfo)
      IL_0026:  stloc.1
      IL_0027:  ldstr      bytearray (27 04 42 04 3E 04 31 04 4B 04 20 00 37 04 30 04   // '.B.>.1.K. .7.0.
                                      32 04 35 04 40 04 48 04 38 04 42 04 4C 04 20 00   // 2.5.@.H.8.B.L. .
                                      3F 04 40 04 3E 04 46 04 35 04 41 04 41 04 20 00 ) // ?.@.>.F.5.A.A. .
      IL_002c:  ldloc.1
      IL_002d:  brtrue.s   IL_0032

      IL_002f:  ldnull
      IL_0030:  br.s       IL_0038

      IL_0032:  ldloc.1
      IL_0033:  call       instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_0038:  ldstr      bytearray (20 00 3D 04 30 04 36 04 3C 04 38 04 42 04 35 04   //  .=.0.6.<.8.B.5.
                                      20 00 45 00 6E 00 74 00 65 00 72 00 )             //  .E.n.t.e.r.
      IL_003d:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0042:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0047:  nop
      IL_0048:  call       string [mscorlib]System.Console::ReadLine()
      IL_004d:  pop
      IL_004e:  ldloc.1
      IL_004f:  brtrue.s   IL_0053

      IL_0051:  br.s       IL_005a

      IL_0053:  ldloc.1
      IL_0054:  call       instance void [System]System.Diagnostics.Process::Kill()
      IL_0059:  nop
      IL_005a:  nop
      IL_005b:  leave.s    IL_006e

    }  // end .try
    catch [mscorlib]System.InvalidOperationException 
    {
      IL_005d:  stloc.2
      IL_005e:  nop
      IL_005f:  ldloc.2
      IL_0060:  callvirt   instance string [mscorlib]System.Exception::get_Message()
      IL_0065:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_006a:  nop
      IL_006b:  nop
      IL_006c:  leave.s    IL_006e

    }  // end handler
    IL_006e:  ret
  } // end of method Program::StartAndKillProcess

  .method private hidebysig static void  EnumModsByPid(int32 pid) cil managed
  {
    // Размер кода:       182 (0xb6)
    .maxstack  4
    .locals init (class [System]System.Diagnostics.Process V_0,
             class [System]System.Diagnostics.ProcessModuleCollection V_1,
             class [mscorlib]System.Collections.IEnumerator V_2,
             class [System]System.Diagnostics.ProcessModule V_3,
             class [mscorlib]System.IDisposable V_4,
             class [mscorlib]System.ArgumentException V_5)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (12 04 4B 04 32 04 35 04 41 04 42 04 38 04 20 00   // ..K.2.5.A.B.8. .
                                    32 04 41 04 35 04 20 00 3C 04 3E 04 34 04 43 04   // 2.A.5. .<.>.4.C.
                                    3B 04 38 04 2C 00 20 00 38 04 41 04 3F 04 3E 04   // ;.8.,. .8.A.?.>.
                                    3B 04 4C 04 37 04 43 04 35 04 3C 04 4B 04 35 04   // ;.L.7.C.5.<.K.5.
                                    20 00 3F 04 40 04 3E 04 46 04 35 04 41 04 41 04   //  .?.@.>.F.5.A.A.
                                    3E 04 3C 04 20 00 50 00 49 00 44 00 20 00 3D 00   // >.<. .P.I.D. .=.
                                    20 00 7B 00 30 00 7D 00 )                         //  .{.0.}.
    IL_0006:  ldarg.0
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0011:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0016:  nop
    .try
    {
      IL_0017:  nop
      IL_0018:  ldarg.0
      IL_0019:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetProcessById(int32)
      IL_001e:  stloc.0
      IL_001f:  ldstr      bytearray (18 04 3C 04 4F 04 20 00 3F 04 40 04 3E 04 46 04   // ..<.O. .?.@.>.F.
                                      35 04 41 04 41 04 30 04 3A 00 20 00 )             // 5.A.A.0.:. .
      IL_0024:  ldloc.0
      IL_0025:  callvirt   instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_002a:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_002f:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0034:  nop
      IL_0035:  ldloc.0
      IL_0036:  callvirt   instance class [System]System.Diagnostics.ProcessModuleCollection [System]System.Diagnostics.Process::get_Modules()
      IL_003b:  stloc.1
      IL_003c:  nop
      IL_003d:  ldloc.1
      IL_003e:  callvirt   instance class [mscorlib]System.Collections.IEnumerator [mscorlib]System.Collections.ReadOnlyCollectionBase::GetEnumerator()
      IL_0043:  stloc.2
      .try
      {
        IL_0044:  br.s       IL_0080

        IL_0046:  ldloc.2
        IL_0047:  callvirt   instance object [mscorlib]System.Collections.IEnumerator::get_Current()
        IL_004c:  castclass  [System]System.Diagnostics.ProcessModule
        IL_0051:  stloc.3
        IL_0052:  nop
        IL_0053:  ldstr      "\tModule name = {0},\tBase Address = {1},\tModule Mem"
        + "ory Size = {2}"
        IL_0058:  ldloc.3
        IL_0059:  callvirt   instance string [System]System.Diagnostics.ProcessModule::get_ModuleName()
        IL_005e:  ldloc.3
        IL_005f:  callvirt   instance native int [System]System.Diagnostics.ProcessModule::get_BaseAddress()
        IL_0064:  box        [mscorlib]System.IntPtr
        IL_0069:  ldloc.3
        IL_006a:  callvirt   instance int32 [System]System.Diagnostics.ProcessModule::get_ModuleMemorySize()
        IL_006f:  box        [mscorlib]System.Int32
        IL_0074:  call       string [mscorlib]System.String::Format(string,
                                                                    object,
                                                                    object,
                                                                    object)
        IL_0079:  call       void [mscorlib]System.Console::WriteLine(string)
        IL_007e:  nop
        IL_007f:  nop
        IL_0080:  ldloc.2
        IL_0081:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
        IL_0086:  brtrue.s   IL_0046

        IL_0088:  leave.s    IL_009f

      }  // end .try
      finally
      {
        IL_008a:  ldloc.2
        IL_008b:  isinst     [mscorlib]System.IDisposable
        IL_0090:  stloc.s    V_4
        IL_0092:  ldloc.s    V_4
        IL_0094:  brfalse.s  IL_009e

        IL_0096:  ldloc.s    V_4
        IL_0098:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
        IL_009d:  nop
        IL_009e:  endfinally
      }  // end handler
      IL_009f:  nop
      IL_00a0:  leave.s    IL_00b5

    }  // end .try
    catch [mscorlib]System.ArgumentException 
    {
      IL_00a2:  stloc.s    V_5
      IL_00a4:  nop
      IL_00a5:  ldloc.s    V_5
      IL_00a7:  callvirt   instance string [mscorlib]System.Exception::get_Message()
      IL_00ac:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_00b1:  nop
      IL_00b2:  nop
      IL_00b3:  leave.s    IL_00b5

    }  // end handler
    IL_00b5:  ret
  } // end of method Program::EnumModsByPid

  .method private hidebysig static void  GetEnumThreads(int32 pid) cil managed
  {
    // Размер кода:       242 (0xf2)
    .maxstack  5
    .locals init (class [System]System.Diagnostics.Process V_0,
             class [System]System.Diagnostics.ProcessThreadCollection V_1,
             class [mscorlib]System.Collections.IEnumerator V_2,
             class [System]System.Diagnostics.ProcessThread V_3,
             valuetype [mscorlib]System.DateTime V_4,
             class [mscorlib]System.IDisposable V_5,
             class [mscorlib]System.ArgumentException V_6)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (1F 04 3E 04 3B 04 43 04 47 04 38 04 42 04 4C 04   // ..>.;.C.G.8.B.L.
                                    20 00 32 04 41 04 35 04 20 00 3F 04 3E 04 42 04   //  .2.A.5. .?.>.B.
                                    3E 04 3A 04 38 04 20 00 3F 04 40 04 3E 04 46 04   // >.:.8. .?.@.>.F.
                                    35 04 41 04 41 04 30 04 20 00 3F 04 3E 04 20 00   // 5.A.A.0. .?.>. .
                                    3E 04 3F 04 40 04 35 04 34 04 35 04 3B 04 35 04   // >.?.@.5.4.5.;.5.
                                    3D 04 3D 04 3E 04 3C 04 43 04 20 00 50 00 49 00   // =.=.>.<.C. .P.I.
                                    44 00 3A 00 20 00 7B 00 30 00 7D 00 )             // D.:. .{.0.}.
    IL_0006:  ldarg.0
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0011:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0016:  nop
    .try
    {
      IL_0017:  nop
      IL_0018:  ldarg.0
      IL_0019:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetProcessById(int32)
      IL_001e:  stloc.0
      IL_001f:  ldstr      bytearray (1F 04 3E 04 42 04 3E 04 3A 04 38 04 20 00 3A 04   // ..>.B.>.:.8. .:.
                                      3E 04 42 04 3E 04 40 04 4B 04 35 04 20 00 38 04   // >.B.>.@.K.5. .8.
                                      41 04 3F 04 3E 04 3B 04 4C 04 37 04 43 04 35 04   // A.?.>.;.L.7.C.5.
                                      42 04 20 00 3F 04 40 04 3E 04 46 04 35 04 41 04   // B. .?.@.>.F.5.A.
                                      41 04 3A 00 20 00 )                               // A.:. .
      IL_0024:  ldloc.0
      IL_0025:  callvirt   instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_002a:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_002f:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0034:  nop
      IL_0035:  ldloc.0
      IL_0036:  callvirt   instance class [System]System.Diagnostics.ProcessThreadCollection [System]System.Diagnostics.Process::get_Threads()
      IL_003b:  stloc.1
      IL_003c:  ldstr      "**************************************************"
      + "***********************************************************************"
      + "********************"
      IL_0041:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0046:  nop
      IL_0047:  nop
      IL_0048:  ldloc.1
      IL_0049:  callvirt   instance class [mscorlib]System.Collections.IEnumerator [mscorlib]System.Collections.ReadOnlyCollectionBase::GetEnumerator()
      IL_004e:  stloc.2
      .try
      {
        IL_004f:  br.s       IL_00b1

        IL_0051:  ldloc.2
        IL_0052:  callvirt   instance object [mscorlib]System.Collections.IEnumerator::get_Current()
        IL_0057:  castclass  [System]System.Diagnostics.ProcessThread
        IL_005c:  stloc.3
        IL_005d:  nop
        IL_005e:  ldstr      "\tID = {0},\t StartTime = {1},\t State = {2}, \t Prior"
        + "ity = {3}"
        IL_0063:  ldc.i4.4
        IL_0064:  newarr     [mscorlib]System.Object
        IL_0069:  dup
        IL_006a:  ldc.i4.0
        IL_006b:  ldloc.3
        IL_006c:  callvirt   instance int32 [System]System.Diagnostics.ProcessThread::get_Id()
        IL_0071:  box        [mscorlib]System.Int32
        IL_0076:  stelem.ref
        IL_0077:  dup
        IL_0078:  ldc.i4.1
        IL_0079:  ldloc.3
        IL_007a:  callvirt   instance valuetype [mscorlib]System.DateTime [System]System.Diagnostics.ProcessThread::get_StartTime()
        IL_007f:  stloc.s    V_4
        IL_0081:  ldloca.s   V_4
        IL_0083:  call       instance string [mscorlib]System.DateTime::ToShortDateString()
        IL_0088:  stelem.ref
        IL_0089:  dup
        IL_008a:  ldc.i4.2
        IL_008b:  ldloc.3
        IL_008c:  callvirt   instance valuetype [System]System.Diagnostics.ThreadState [System]System.Diagnostics.ProcessThread::get_ThreadState()
        IL_0091:  box        [System]System.Diagnostics.ThreadState
        IL_0096:  stelem.ref
        IL_0097:  dup
        IL_0098:  ldc.i4.3
        IL_0099:  ldloc.3
        IL_009a:  callvirt   instance valuetype [System]System.Diagnostics.ThreadPriorityLevel [System]System.Diagnostics.ProcessThread::get_PriorityLevel()
        IL_009f:  box        [System]System.Diagnostics.ThreadPriorityLevel
        IL_00a4:  stelem.ref
        IL_00a5:  call       string [mscorlib]System.String::Format(string,
                                                                    object[])
        IL_00aa:  call       void [mscorlib]System.Console::WriteLine(string)
        IL_00af:  nop
        IL_00b0:  nop
        IL_00b1:  ldloc.2
        IL_00b2:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
        IL_00b7:  brtrue.s   IL_0051

        IL_00b9:  leave.s    IL_00d0

      }  // end .try
      finally
      {
        IL_00bb:  ldloc.2
        IL_00bc:  isinst     [mscorlib]System.IDisposable
        IL_00c1:  stloc.s    V_5
        IL_00c3:  ldloc.s    V_5
        IL_00c5:  brfalse.s  IL_00cf

        IL_00c7:  ldloc.s    V_5
        IL_00c9:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
        IL_00ce:  nop
        IL_00cf:  endfinally
      }  // end handler
      IL_00d0:  ldstr      "**************************************************"
      + "***********************************************************************"
      + "********************"
      IL_00d5:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_00da:  nop
      IL_00db:  nop
      IL_00dc:  leave.s    IL_00f1

    }  // end .try
    catch [mscorlib]System.ArgumentException 
    {
      IL_00de:  stloc.s    V_6
      IL_00e0:  nop
      IL_00e1:  ldloc.s    V_6
      IL_00e3:  callvirt   instance string [mscorlib]System.Exception::get_Message()
      IL_00e8:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_00ed:  nop
      IL_00ee:  nop
      IL_00ef:  leave.s    IL_00f1

    }  // end handler
    IL_00f1:  ret
  } // end of method Program::GetEnumThreads

  .method private hidebysig static void  GetSpecificProcess(int32 pid) cil managed
  {
    // Размер кода:       74 (0x4a)
    .maxstack  2
    .locals init (class [System]System.Diagnostics.Process V_0,
             class [mscorlib]System.ArgumentException V_1)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (1F 04 3E 04 3B 04 43 04 47 04 38 04 42 04 4C 04   // ..>.;.C.G.8.B.L.
                                    20 00 3F 04 40 04 3E 04 46 04 35 04 41 04 41 04   //  .?.@.>.F.5.A.A.
                                    20 00 3F 04 3E 04 20 00 3E 04 3F 04 35 04 40 04   //  .?.>. .>.?.5.@.
                                    34 04 35 04 3B 04 35 04 3D 04 3D 04 3E 04 3C 04   // 4.5.;.5.=.=.>.<.
                                    43 04 20 00 50 00 49 00 44 00 3A 00 20 00 7B 00   // C. .P.I.D.:. .{.
                                    30 00 7D 00 20 00 38 04 3B 04 38 04 20 00 32 04   // 0.}. .8.;.8. .2.
                                    4B 04 32 04 35 04 41 04 42 04 38 04 20 00 3E 04   // K.2.5.A.B.8. .>.
                                    48 04 38 04 31 04 3A 04 43 04 )                   // H.8.1.:.C.
    IL_0006:  ldarg.0
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0011:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0016:  nop
    .try
    {
      IL_0017:  nop
      IL_0018:  ldarg.0
      IL_0019:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetProcessById(int32)
      IL_001e:  stloc.0
      IL_001f:  ldstr      "Process name: "
      IL_0024:  ldloc.0
      IL_0025:  callvirt   instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_002a:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_002f:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0034:  nop
      IL_0035:  nop
      IL_0036:  leave.s    IL_0049

    }  // end .try
    catch [mscorlib]System.ArgumentException 
    {
      IL_0038:  stloc.1
      IL_0039:  nop
      IL_003a:  ldloc.1
      IL_003b:  callvirt   instance string [mscorlib]System.Exception::get_Message()
      IL_0040:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_0045:  nop
      IL_0046:  nop
      IL_0047:  leave.s    IL_0049

    }  // end handler
    IL_0049:  ret
  } // end of method Program::GetSpecificProcess

  .method private hidebysig static void  ListAllRunningProcess() cil managed
  {
    // Размер кода:       191 (0xbf)
    .maxstack  3
    .locals init (class [mscorlib]System.Collections.Generic.IEnumerable`1<class [System]System.Diagnostics.Process> V_0,
             class [mscorlib]System.Collections.Generic.IEnumerator`1<class [System]System.Diagnostics.Process> V_1,
             class [System]System.Diagnostics.Process V_2)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (21 04 3F 04 38 04 41 04 3E 04 3A 04 20 00 32 04   // !.?.8.A.>.:. .2.
                                    41 04 35 04 45 04 20 00 3F 04 40 04 3E 04 46 04   // A.5.E. .?.@.>.F.
                                    35 04 41 04 41 04 3E 04 32 04 20 00 3D 04 30 04   // 5.A.A.>.2. .=.0.
                                    20 00 3B 04 3E 04 3A 04 30 04 3B 04 4C 04 3D 04   //  .;.>.:.0.;.L.=.
                                    3E 04 3C 04 20 00 3A 04 3E 04 3C 04 3F 04 4C 04   // >.<. .:.>.<.?.L.
                                    4E 04 42 04 35 04 40 04 35 04 )                   // N.B.5.@.5.
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ldstr      "."
    IL_0011:  call       class [System]System.Diagnostics.Process[] [System]System.Diagnostics.Process::GetProcesses(string)
    IL_0016:  ldsfld     class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,int32> ProcessManipulator.Program/'<>c'::'<>9__5_0'
    IL_001b:  dup
    IL_001c:  brtrue.s   IL_0035

    IL_001e:  pop
    IL_001f:  ldsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
    IL_0024:  ldftn      instance int32 ProcessManipulator.Program/'<>c'::'<ListAllRunningProcess>b__5_0'(class [System]System.Diagnostics.Process)
    IL_002a:  newobj     instance void class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,int32>::.ctor(object,
                                                                                                                            native int)
    IL_002f:  dup
    IL_0030:  stsfld     class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,int32> ProcessManipulator.Program/'<>c'::'<>9__5_0'
    IL_0035:  call       class [System.Core]System.Linq.IOrderedEnumerable`1<!!0> [System.Core]System.Linq.Enumerable::OrderBy<class [System]System.Diagnostics.Process,int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                                               class [mscorlib]System.Func`2<!!0,!!1>)
    IL_003a:  ldsfld     class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,class [System]System.Diagnostics.Process> ProcessManipulator.Program/'<>c'::'<>9__5_1'
    IL_003f:  dup
    IL_0040:  brtrue.s   IL_0059

    IL_0042:  pop
    IL_0043:  ldsfld     class ProcessManipulator.Program/'<>c' ProcessManipulator.Program/'<>c'::'<>9'
    IL_0048:  ldftn      instance class [System]System.Diagnostics.Process ProcessManipulator.Program/'<>c'::'<ListAllRunningProcess>b__5_1'(class [System]System.Diagnostics.Process)
    IL_004e:  newobj     instance void class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,class [System]System.Diagnostics.Process>::.ctor(object,
                                                                                                                                                               native int)
    IL_0053:  dup
    IL_0054:  stsfld     class [mscorlib]System.Func`2<class [System]System.Diagnostics.Process,class [System]System.Diagnostics.Process> ProcessManipulator.Program/'<>c'::'<>9__5_1'
    IL_0059:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<class [System]System.Diagnostics.Process,class [System]System.Diagnostics.Process>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                                                                                      class [mscorlib]System.Func`2<!!0,!!1>)
    IL_005e:  stloc.0
    IL_005f:  ldstr      "***********************************************"
    IL_0064:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0069:  nop
    IL_006a:  nop
    IL_006b:  ldloc.0
    IL_006c:  callvirt   instance class [mscorlib]System.Collections.Generic.IEnumerator`1<!0> class [mscorlib]System.Collections.Generic.IEnumerable`1<class [System]System.Diagnostics.Process>::GetEnumerator()
    IL_0071:  stloc.1
    .try
    {
      IL_0072:  br.s       IL_009e

      IL_0074:  ldloc.1
      IL_0075:  callvirt   instance !0 class [mscorlib]System.Collections.Generic.IEnumerator`1<class [System]System.Diagnostics.Process>::get_Current()
      IL_007a:  stloc.2
      IL_007b:  nop
      IL_007c:  ldstr      "\tPID = {0},\t Name = {1}"
      IL_0081:  ldloc.2
      IL_0082:  callvirt   instance int32 [System]System.Diagnostics.Process::get_Id()
      IL_0087:  box        [mscorlib]System.Int32
      IL_008c:  ldloc.2
      IL_008d:  callvirt   instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_0092:  call       string [mscorlib]System.String::Format(string,
                                                                  object,
                                                                  object)
      IL_0097:  call       void [mscorlib]System.Console::WriteLine(string)
      IL_009c:  nop
      IL_009d:  nop
      IL_009e:  ldloc.1
      IL_009f:  callvirt   instance bool [mscorlib]System.Collections.IEnumerator::MoveNext()
      IL_00a4:  brtrue.s   IL_0074

      IL_00a6:  leave.s    IL_00b3

    }  // end .try
    finally
    {
      IL_00a8:  ldloc.1
      IL_00a9:  brfalse.s  IL_00b2

      IL_00ab:  ldloc.1
      IL_00ac:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
      IL_00b1:  nop
      IL_00b2:  endfinally
    }  // end handler
    IL_00b3:  ldstr      "***********************************************"
    IL_00b8:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00bd:  nop
    IL_00be:  ret
  } // end of method Program::ListAllRunningProcess

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class ProcessManipulator.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 E:\Programming\C#\Advanced_CS_Lessons\Chapter_18_LanguageCIL\02_CILTypes\ProcessManipulator.res
