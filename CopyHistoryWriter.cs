using Microsoft.Win32;
using System.IO;

namespace DirectoryFilePropagationUtilsLibrary
{
    class CopyHistoryWriter
    {
        public static void Write(string rootFolderPath,
                                 OpenFileDialog fileDialog,
                                 string historyFilePath)
        {
            File.AppendAllText(historyFilePath, $"Writing " +
                 $"{Path.Combine(rootFolderPath, fileDialog.SafeFileName)}" +
                 $"\n");
        }
    }
}
