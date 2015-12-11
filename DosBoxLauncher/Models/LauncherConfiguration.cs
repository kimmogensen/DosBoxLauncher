//-----------------------------------------------------------------------
// <copyright file="LauncherConfiguration.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// A simple class which is serializeable
/// </summary>
namespace DosBoxLauncher.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class LauncherConfiguration
    {
        private string dosBoxExecutable;
        private string dosBoxConfigFile;
        private string workspaceRootFolder;
        private bool showConfigurationDosBox;
        private bool showConfigurationWorkspaceRoot;
        private DateTime dateCreated;
        private DateTime dateUpdated;
        private List<Workspace> workspaces = new List<Workspace>();

        public string DosBoxExecutable
        {
            get { return this.dosBoxExecutable; }
            set { this.dosBoxExecutable = value; }
        }

        public string DosBoxConfigFile
        {
            get { return this.dosBoxConfigFile; }
            set { this.dosBoxConfigFile = value; }
        }

        public string WorkspaceRootFolder
        {
            get { return this.workspaceRootFolder; }
            set { this.workspaceRootFolder = value; }
        }
        
        public bool ShowConfigurationDosBox
        {
            get { return this.showConfigurationDosBox; }
            set { this.showConfigurationDosBox = value; }
        }

        public bool ShowConfigurationWorkspace
        {
            get { return this.showConfigurationWorkspaceRoot; }
            set { this.showConfigurationWorkspaceRoot = value; }
        }

        public DateTime DateCreated
        {
            get { return this.dateCreated; }
            set { this.dateCreated = value; }
        }
        
        public DateTime DateUpdated
        {
            get { return this.dateUpdated; }
            set { this.dateUpdated = value; }
        }

        public List<Workspace> Workspaces
        {
            get { return this.workspaces; }
            set { this.workspaces = value; }
        }
    }
}
