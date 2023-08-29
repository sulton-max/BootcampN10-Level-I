using System.Text;
using N33_T1.DataAccess.EntityContext;
using N33_T1.Extensions;
using Newtonsoft.Json;

namespace N33_T1.DataAccess.FileContext;

public class FileSet<TEntity> : List<TEntity>, IFileSet<TEntity> where TEntity : class, IUpdatableEntity<TEntity>
{
    private readonly string _filePath;
    private int _lastHashCode;

    internal FileSet(string folderPath)
    {
        _filePath = Path.Combine(folderPath, $"{typeof(TEntity).Name.ToLower()}.json");
    }

    internal async Task FetchAsync()
    {
        if (!File.Exists(_filePath)) return;

        var fileData = await File.ReadAllTextAsync(_filePath);
        var previousData = JsonConvert.DeserializeObject<FileSet<TEntity>>(fileData) ?? throw new InvalidOperationException("File data is null");

        Clear();
        AddRange(previousData);

        _lastHashCode = GetHashCode();
    }

    public bool IsModified => _lastHashCode != GetHashCode();

    public Task FetchDataAsync()
    {
        var fileStream = File.Open(_filePath, FileMode.OpenOrCreate);
        if (fileStream.Length == 0)
        {
            var json = JsonConvert.SerializeObject(this);
            var test = fileStream.WriteAsync(Encoding.UTF8.GetBytes(json));

            fileStream.Flush();
            fileStream.Close();
            return Task.CompletedTask;
        }

        var fileData = fileStream.ReadAsync()

        JsonConvert.DeserializeObject<FileSet<TEntity>>();

        var previousData = JsonSerializer.Deserialize<FileSet<TEntity>>(fileStream);
        fileStream.SetLength(0);

        // listni yangi ma'lumotlar bilan to'ldirish
        previousData.Update(this);
        JsonSerializer.Serialize(fileStream, previousData);

        fileStream.Flush();
        fileStream.Close();

        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}