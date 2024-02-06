namespace FileSystem
{
    public static class DirectoryOperations
    {
        public static void DirectoryIsCreatedOrNotValidateDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                _ = Directory.CreateDirectory(dirPath);
            }
        }

        public static void DirectoryIsDeletedOrNotValidateDirectory(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath);
            }
        }

        public static void DirectoryIsMovedToOtherDirectoryValidateDirectory(string sourceDirPath, string destinationDirPath)
        {
            if (Directory.Exists(sourceDirPath))
            {
                Directory.Move(sourceDirPath, destinationDirPath);
            }
        }

        public static void SubDirectoryIsCreatedOrNotValidateSubDirectory(string dirPath, string subDirPath)
        {
            if (Directory.Exists(dirPath))
            {
                _ = Directory.CreateDirectory(subDirPath);
            }
        }

        public static void DeleteSubDirectoryValidateSubDirectoryDeletedOrNot(string subDirPath)
        {
            if (Directory.Exists(subDirPath))
            {
                Directory.Delete(subDirPath);
            }
        }

        public static void MoveSubDirectoryValidateSubDirMovedOrNot(string sourcePath, string destinationPath)
        {
            if (Directory.Exists(sourcePath))
            {
                Directory.Move(sourcePath, destinationPath);
            }
        }
    }
}
