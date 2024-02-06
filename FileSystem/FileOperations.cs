using System.IO;

[assembly: CLSCompliant(false)]

namespace FileSystem
{
    public static class FileOperations
    {
        public static void CreatingFileAndReturnFilePath(string filePath)
        {
            File.Create(filePath).Close();
        }

        public static void WriteTextToFileReadAppendedText(string filePath, string msgToWrite)
        {
            using StreamWriter sw = File.AppendText(filePath);
            sw.WriteLine(msgToWrite);
        }

        public static string ReadingFileContentAndValidateText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static void MoveFileFromOneFolderToNewFolderAndValidateFile(string filePath, string destinationPath)
        {
            File.Move(filePath, destinationPath);
        }

        public static void CopyFileFromOneFolderToNewFolder(string filePath, string destinationPath)
        {
            File.Copy(filePath, destinationPath);
        }

        public static void DeleteFileAndValidateFileExistOrNot(string filePath)
        {
            File.Delete(filePath);
        }
    }
}
