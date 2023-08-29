namespace N33_T1.DataAccess.Configurations;

public class FileContextOptions
{
    public string StorageDirectoryPath { get; init; }

    public FileContextOptions(string storageDirectoryPath)
    {
        StorageDirectoryPath = storageDirectoryPath;
    }
}