using System.Linq;

namespace DirectoryFilePropagationUtilsLibrary
{
    public class ChildDirectoriesChecker
    {
        public static bool IsNoChildDirectories(string[] childDirectories)
        {
            return childDirectories.Count() == 0;
        }
    }
}