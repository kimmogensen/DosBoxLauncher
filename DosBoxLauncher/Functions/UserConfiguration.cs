// <copyright file="UserConfiguration.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// This class can be used to retrieve and save userconfiguration
/// </summary>
namespace DosBoxLauncher.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;    
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using DosBoxLauncher.Models;
    
    /// <summary>
    /// A class which saves and loads the xml file
    /// </summary>
    public class UserConfiguration
    {
        /// <summary>
        /// Loads the configuration.
        /// </summary>
        /// <param name="xmlFile">The XML file.</param>
        /// <returns>A LauncherConfiguration</returns>
        /// <exception cref="ApplicationException">exception from read</exception>
        public static LauncherConfiguration LoadConfiguration(string xmlFile)
        {
            LauncherConfiguration lc;

            if (!File.Exists(xmlFile))
            {
                try
                {
                    lc = Functions.UserConfiguration.CreateConfiguration(xmlFile);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException(ex.ToString());
                }
            }

            try
            {
                XmlSerializer serializerObj = new XmlSerializer(typeof(LauncherConfiguration));
                FileStream readFileStream = new FileStream(xmlFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                LauncherConfiguration loadedObj = (LauncherConfiguration)serializerObj.Deserialize(readFileStream);
                readFileStream.Close();
                lc = loadedObj;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

            return lc;
        }

        /// <summary>
        /// Saves the configuration in users AppData\local\DosBoxLauncher folder.
        /// </summary>
        /// <param name="lc">The launcher configuration.</param>
        /// <param name="xmlFile">The XML file.</param>
        /// <returns>returns a timestamp</returns>
        /// <exception cref="ApplicationException">An exception when writing a file</exception>
        public static DateTime SaveConfiguration(LauncherConfiguration lc, string xmlFile)
        {
            DateTime now = DateTime.Now;
            lc.DateUpdated = now;

            try
            {
                XmlSerializer serializerObj = new XmlSerializer(typeof(LauncherConfiguration));
                TextWriter writeFileStream = new StreamWriter(xmlFile);
                serializerObj.Serialize(writeFileStream, lc);
                writeFileStream.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

            return now;
        }

        /// <summary>
        /// Creates the configuration.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>a new LauncherConfiguration</returns>
        /// <exception cref="ApplicationException">exception from write</exception>
        private static LauncherConfiguration CreateConfiguration(string filename)
        {
            LauncherConfiguration newConfig = new LauncherConfiguration();
            DateTime now = DateTime.Now;
            newConfig.DateCreated = now;
            newConfig.DosBoxExecutable = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + System.Configuration.ConfigurationManager.AppSettings["ExpectedFilePathDosBoxExe"];
            newConfig.DosBoxConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + System.Configuration.ConfigurationManager.AppSettings["ExpectedFilePathDosBoxConfig"];
            newConfig.WorkspaceRootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            newConfig.ShowConfigurationDosBox = true;
            newConfig.ShowConfigurationWorkspace = true;
            string folderPath = Path.GetDirectoryName(filename);
            if (!File.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException(ex.ToString());
                }
            }
 
            try
            {
                XmlSerializer serializerObj = new XmlSerializer(typeof(LauncherConfiguration));
                TextWriter writeFileStream = new StreamWriter(filename);
                serializerObj.Serialize(writeFileStream, newConfig);
                writeFileStream.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

            return newConfig;
        }
    }
}
