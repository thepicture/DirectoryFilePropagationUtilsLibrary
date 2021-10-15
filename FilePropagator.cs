using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace DirectoryFilePropagationUtilsLibrary
{
    public class FilePropagator
    {
        /// <summary>
        /// Propagates the given file to every subfolder and to the root folder.
        /// </summary>
        /// <param name="rootFolderPath">The root folder path.</param>
        /// <param name="sourceFileName">The file path.</param>
        /// <returns>Boolean which indicates if the propagating ran correctly.</returns>
        public static bool Propagate(string rootFolderPath, OpenFileDialog fileDialog)
        {
            try
            {
                FileCopyUtils.CopyFile(rootFolderPath, fileDialog);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            string[] directories = Directory
                .GetDirectories(rootFolderPath);

            if (ChildDirectoriesChecker.IsNoChildDirectories(directories))
            {
                return true;
            }

            foreach (var childDirectory in directories)
            {
                Propagate(childDirectory, fileDialog);
            }

            return true;
        }
    }
}
