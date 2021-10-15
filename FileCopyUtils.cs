using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace DirectoryFilePropagationUtilsLibrary
{
    class FileCopyUtils
    {
        public static bool CopyFile(string rootFolderPath, OpenFileDialog fileDialog)
        {
            try
            {
                File.Copy(fileDialog.FileName,
                          Path.Combine(rootFolderPath,
                                       fileDialog.SafeFileName
                                       )
                          );
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
    }
}