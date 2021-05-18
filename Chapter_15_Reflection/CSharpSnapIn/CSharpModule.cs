using System;
using System.Diagnostics.CodeAnalysis;


namespace CSharpSnapIn
{
    [CommonSnappableTypes.CommonSnappableTypes.CompanyInfo(CompanyName = "Кроты и хомяки", CompanyUrl = "https://github.com/MrNerf/Advanced_CS_Lessons")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class CSharpModule : CommonSnappableTypes.CommonSnappableTypes.IAppFunctionality
    {
        public void DoIt()
        {
            Console.WriteLine("Используется модуль C#");
        }
    }
}
