// <summary>
//  External processes
// </summary>
namespace DosBoxLauncher.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class External
    {
        public static void StartExplorer(string path)
        {
            Process.Start(path);
        }
    }
}
