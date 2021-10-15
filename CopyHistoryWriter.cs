using System.IO;
using System.Windows.Forms;

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
