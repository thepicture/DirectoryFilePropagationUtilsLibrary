using System.IO;
using System.Windows.Forms;

namespace DirectoryFilePropagationUtilsLibrary
{
    public class FilePropagator
    {
        /// <summary>
        /// Propagates the given file to every subfolder and 
        /// to the root folder.
        /// </summary>
        /// <param name="rootFolderPath">The root folder path.</param>
        /// <param name="sourceFileName">The OpenFileDialog result.</param>
        /// <returns>Boolean which indicates if the propagating ran 
        /// correctly.</returns>
        public static bool Propagate(string rootFolderPath, OpenFileDialog fileDialog)
        {
            if (!FileCopyUtils.CopyFile(rootFolderPath, fileDialog))
            {
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

        /// <summary>
        /// Propagates the given file to every subfolder and 
        /// to the root folder with history in the text file output.
        /// </summary>
        /// <param name="rootFolderPath">The root folder path.</param>
        /// <param name="fileDialog">The OpenFileDialog result.</param>
        /// <param name="historyFilePath">Boolean which indicates 
        /// if the propagating ran correctly.</param>
        /// <returns></returns>
        public static bool PropagateWithHistory(string rootFolderPath, OpenFileDialog fileDialog, string historyFilePath)
        {
            CopyHistoryWriter.Write(rootFolderPath, fileDialog,
                                    historyFilePath);

            if (!FileCopyUtils.CopyFile(rootFolderPath, fileDialog))
            {
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
                PropagateWithHistory(childDirectory, fileDialog,
                                     historyFilePath);
            }

            return true;
        }
    }
}
