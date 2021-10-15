using Microsoft.Win32;
using System.IO;

namespace DirectoryFilePropagationUtilsLibrary
{
    class FileCopyUtils
    {
        public static void CopyFile(string rootFolderPath, OpenFileDialog fileDialog)
        {
            File.Copy(
                fileDialog.FileName,
                Path.Combine(
                        rootFolderPath,
                        fileDialog.SafeFileName
                )
            );
        }
    }
}