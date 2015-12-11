//-----------------------------------------------------------------------
// <copyright file="Validation.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// This class is used for validation functions
/// </summary>
namespace DosBoxLauncher.Functions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class Validation
    {
        [Flags]
        public enum ErrorType
        {
            Valid = 0x0,
            Cancel = 0x1,
            NoSuchDirectory = 0x10,
            DirectoryNotWriteable = 0x11,
            NoSuchFile = 0x20,
            FileNotWriteable = 0x21,
            IndexNotInteger = 0x30,
            EmptyValues = 0x31
        }

        [Flags]
        public enum ValidationType
        {
            WorkspaceRoot = 0x0,
            DosBoxExe = 0x1,
            DosBoxConfig = 0x2
        }

        /// <summary>
        /// Determines whether [is row row] [the specified row].
        /// Button logic implementation
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="index">The index.</param>
        /// <param name="title">The title.</param>
        /// <returns>
        /// boolean row If row true
        /// </returns>
        public static ErrorType IsRowValid(string path, string index, string title)
        {
            ErrorType errors = new ErrorType();

            // if (row.Cells["WorkspacePath"].Value == null)
            // {
            //     Do nothing (new row)
            // }
            // else
            // {
            if (path == null ||
                title == null ||
                index == null)
            {
                errors |= ErrorType.EmptyValues;
            }

            if (index != null)
            {
                int i = 0;
                string s = index;
                bool result = int.TryParse(s, out i);
                if (!result)
                {
                    errors |= ErrorType.IndexNotInteger;
                }
            }

            if (path != null)
            {
                string remotePath = path;

                if (Directory.Exists(remotePath))
                {
                    Uri outUri;
                    remotePath = new Uri(remotePath).LocalPath.ToString();

                    if (Uri.TryCreate(remotePath, UriKind.Absolute, out outUri))
                    {
                        DirectoryInfo di = new DirectoryInfo(outUri.LocalPath.ToString());
                        try
                        {
                            var acl = di.GetAccessControl();
                        }
                        catch (UnauthorizedAccessException uae)
                        {
                            if (!uae.Message.Contains("read-only"))
                            {
                                errors |= ErrorType.DirectoryNotWriteable;
                            }
                        }
                    }
                }
                else
                {
                    errors |= ErrorType.NoSuchDirectory;
                }
            }

            return errors;
        }

        public static ErrorType IsDosBoxExeValid(string fileName)
        {
            ErrorType errors = new ErrorType();
            if (!File.Exists(fileName))
            {
                errors |= ErrorType.NoSuchFile;
            }

            return errors;
        }

        public static ErrorType IsDosBoxConfigValid(string fileName)
        {
            ErrorType errors = new ErrorType();
            if (!File.Exists(fileName))
            {
                errors |= ErrorType.NoSuchFile;
            }
            else
            {
                var file = new FileInfo(fileName);
                if ((file.Attributes & FileAttributes.ReadOnly) != 0)
                {
                    errors |= ErrorType.FileNotWriteable;            
                }
            }

            return errors;
        }

        public static ErrorType IsPcPlusFolderValid(string foldername)
        {
            ErrorType errors = new ErrorType();
            if (!Directory.Exists(foldername))
            {
                errors |= ErrorType.NoSuchDirectory;
            }
            else
            {
                errors |= ErrorType.Valid;
            }
            
            return errors;
        }

        /// <summary>
        /// Prints the tips.
        /// TODO: Get rid of this
        /// </summary>
        /// <param name="log">The log.</param>
        private void PrintTips(TextBox log)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is just a 'launcher'" + Environment.NewLine);
            sb.Append("=========================" + Environment.NewLine);
            sb.Append("You need to install DOSBox prior using this progam." + Environment.NewLine);
            sb.Append("1. Download DOSBox from http://www.dosbox.com/download.php?main=1" + Environment.NewLine);
            sb.Append("2. Install DOSBox: During the installation a DOSBox.exe should be available" + Environment.NewLine);
            sb.Append("3. Start DOSBox at least 1 time: Upon first time use, the configuration file for DOSBox is created" + Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("Correct following errors (for each error restart denne launcheren:" + Environment.NewLine);
            sb.Append("=========================" + Environment.NewLine);
            log.AppendText(sb.ToString());
       }
    }
}
