namespace DosBoxLauncher.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RegExExpressions
    {
        public static string GetPcPlusFilesRegEx()
        {
            StringBuilder filePattern = new StringBuilder();
            filePattern.Append(@"^.{8}\.FDA$|");
            filePattern.Append(@"^.{8}\.FJI$|");
            filePattern.Append(@"^.{8}\.FOS$|");
            filePattern.Append(@"^.{8}\.FPK$|");
            filePattern.Append(@"^.{8}\.PKD$|");
            filePattern.Append(@"^.{8}\.PKT$|");
            filePattern.Append(@"^.{8}\.PPD$|");
            filePattern.Append(@"^.{8}\.PPI$|");
            filePattern.Append(@"^.{8}\.STD$");
           return filePattern.ToString();
        }

        public static string GetPcPlusFilesRegEx(string filename)
        {
            StringBuilder filePattern = new StringBuilder();
            filePattern.Append("^" + filename + @"\.FDA$|");
            filePattern.Append("^" + filename + @"\.FJI$|");
            filePattern.Append("^" + filename + @"\.FOS$|");
            filePattern.Append("^" + filename + @"\.FPK$|");
            filePattern.Append("^" + filename + @"\.PKD$|");
            filePattern.Append("^" + filename + @"\.PKT$|");
            filePattern.Append("^" + filename + @"\.PPD$|");
            filePattern.Append("^" + filename + @"\.PPI$|");
            filePattern.Append("^" + filename + @"\.STD$");
            return filePattern.ToString();
        }
    }
}
