// <copyright file="WorkSpace.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// A simple modelclass
/// </summary>
namespace DosBoxLauncher.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DosBoxLauncher.Functions;

    public class Workspace
    {
        // Default constructor:
        public Workspace()
        {
            this.Index = 0;
            this.Path = null;
            this.Title = null;
        }

        public Workspace(int index, string path, string title)
        {
            this.Index = index;
            this.Path = path;
            this.Title = title;
        }
        
        public Validation.ErrorType Error { get; set; }

        public int Index { get; set; }

        public string Path { get; set; }

        public string Title { get; set; }

        public override string ToString()
        { 
            return this.Path;
        }
    }
}
