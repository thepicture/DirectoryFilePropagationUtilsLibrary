# DirectoryFilePropagationUtilsLibrary
Utils for copying files recursively in every folder under root folder path.
## Goals
Create a library to propagate the given file to child directories in C#.
## API
To propagate without a history of the child files inserting, use
```
Propagate(string rootFolderPath, OpenFileDialog fileDialog)
```
Where the root folder path is the first argument and the file dialog as the second argument is an instance of file dialog to get the file.

To propagate with a history of the child files inserting, use
```
Propagate(string rootFolderPath, OpenFileDialog fileDialog, string historyFilePath)
```
Where the root folder path is the first argument, the file dialog is an instance of file dialog to get the file, the third argument is the path where the history will be saved.
