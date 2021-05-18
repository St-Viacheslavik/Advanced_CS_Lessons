Imports CommonSnappableTypes

' ReSharper disable StringLiteralTypo
<CommonSnappableTypes.CommonSnappableTypes.CompanyInfo(CompanyName:="Кроты и хомяки", CompanyUrl:="https://github.com/MrNerf/Advanced_CS_Lessons")>
Public Class VbSnapIn
    ' ReSharper restore StringLiteralTypo
    Implements CommonSnappableTypes.CommonSnappableTypes.IAppFunctionality

    Public Sub DoIt() Implements CommonSnappableTypes.CommonSnappableTypes.IAppFunctionality.DoIt
        ' ReSharper disable StringLiteralTypo
        Console.WriteLine("Вы находитесь в VB модуле")
        ' ReSharper restore StringLiteralTypo
    End Sub
End Class
