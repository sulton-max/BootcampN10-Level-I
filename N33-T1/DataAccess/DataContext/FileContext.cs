using System.Reflection;
using N33_T1.DataAccess.Configurations;
using N33_T1.DataAccess.EntityContext;
using N33_T1.DataAccess.FileContext;

namespace N33_T1.DataAccess.DataContext;

public abstract class FileContext
{
    private readonly List<IFileSet<IUpdatableEntity<IEntity>>> _entities = new();
    private readonly FileContextOptions _options;

    #region Query

    private IEnumerable<PropertyInfo> GetAllEntitiesInfo()
    {
        return GetType()
            .GetProperties()
            .Where(property => property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(FileSet<>));
    }

    private IEnumerable<IFileSet<IUpdatableEntity<IEntity>>> GetAllEntities(IEnumerable<PropertyInfo> entitiesInfo)
    {
        return entitiesInfo.Select(entityInfo => entityInfo.GetValue(this)).OfType<IFileSet<IUpdatableEntity<IEntity>>>().ToList();
    }

    private IEnumerable<IFileSet<IUpdatableEntity<IEntity>>> GetModifiedEntities(IEnumerable<IFileSet<IUpdatableEntity<IEntity>>> entities)
    {
        return entities.Where(entity => entity.IsModified);
    }

    #endregion

    #region Initialization

    private void Initialize()
    {
        _entities.AddRange(GetAllEntities(GetAllEntitiesInfo()));
    }

    private Task FetchAllEntitiesAsync()
    {
        return Task.WhenAll(_entities.Select(async entity => await entity.FetchDataAsync()));
    }

    #endregion

    #region Synchronization

    private async ValueTask<int> SaveAsync()
    {
        var changedEntities = await Task.WhenAll(GetModifiedEntities(_entities).Select(entity => entity.SaveChangesAsync()));
        return changedEntities.Aggregate((sum, value) => sum + value);
    }

    #endregion

    #region Public API

    protected IFileSet<TEntity> Set<TEntity>() where TEntity : class, IEntity, IUpdatableEntity<IEntity> =>
        new FileSet<TEntity>(_options.StorageDirectoryPath);

    protected FileContext(FileContextOptions options)
    {
        if (string.IsNullOrWhiteSpace(options.StorageDirectoryPath))
            throw new ArgumentException("Storage directory path cannot be null or empty", nameof(options.StorageDirectoryPath));

        EnsureDirectoryExists();
        Initialize();
        FetchAllEntitiesAsync().Wait();

        _options = options;
    }

    private void EnsureDirectoryExists()
    {
        if (!Directory.Exists(_options.StorageDirectoryPath))
            Directory.CreateDirectory(_options.StorageDirectoryPath);
    }

    public async Task<bool> SaveChangesAsync()
    {
        var changedEntities = await SaveAsync();
        return changedEntities > 0;
    }

    public bool SaveChanges()
    {
        var resultTask = SaveChangesAsync();
        resultTask.Wait();
        return resultTask.Result;
    }

    #endregion

    // protected static FileSet<T> Set<T>() where T : class, IUpdatable<T> => new();


    // private IEnumerable<PropertyInfo> GetModifiedEntities()
    // {
    //     return GetType()
    //         .GetProperties()
    //         .Where(property => property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(FileSet<>));
    // }

    // private IEnumerable<(PropertyInfo EntityInfo, string FilePath, int LastHashCode)> GetModifiedEntities()
    // {
    //     return _entities.Where(entity => entity.EntityInfo.GetValue(this)?.GetHashCode() != entity.LastHashCode);
    // }

    // private IEnumerable<(PropertyInfo EntityType, string FilePath)> GetStorageFilePaths(IEnumerable<PropertyInfo> entityNames)
    // {
    //     return entityNames.Select(entityName => (entityName, Path.Combine(_storageDirectory, $"{entityName.Name.ToLower()}.json")));
    // }

    // private IEnumerable<(PropertyInfo EntityInfo, string FilePath, int LastHashCode)> GetEntityHashCodes(
    //     IEnumerable<(PropertyInfo EntityType, string FilePath)> entities
    // )
    // {
    //     return entities.Select(entity => (entity.EntityType, FileName: entity.FilePath,
    //         entity.EntityType.GetValue(this)?.GetHashCode() ?? throw new InvalidOperationException("Entity value is null")));
    // }

    // private Task EnsureStorageFilesExistAsync()
    // {
    //     var tasks = _entities.Select(entity => EnsureFileExistsAsync(Path.Combine(_storageDirectory, entity.FilePath)));
    //     return Task.WhenAll(tasks.ToArray());
    // }
    //
    // private void EnsureStorageDirectoryExists()
    // {
    //     if (!Directory.Exists(_storageDirectory)) Directory.CreateDirectory(_storageDirectory);
    // }
    //
    // private async Task EnsureFileExistsAsync(string filePath)
    // {
    //     if (File.Exists(filePath))
    //         return;
    //
    //     var fileStream = File.Create(filePath);
    //     await fileStream.FlushAsync();
    //     fileStream.Close();
    // }

    // private async ValueTask FetchAllEntitiesAsync()
    // {
    //     var tasks = _entities.Select(FetchFileData);
    //     await Task.WhenAll(tasks.Select(task => task.AsTask()).ToArray());
    // }
    //
    // private async ValueTask FetchModifiedEntities()
    // {
    //     var tasks = GetModifiedEntities().Select(FetchFileData);
    //     await Task.WhenAll(tasks.Select(task => task.AsTask()).ToArray());
    // }
    //
    // private async ValueTask FetchFileData((PropertyInfo EntityInfo, string FilePath, int LastHashCode) entity)
    // {
    //     var fileData = await File.ReadAllTextAsync(entity.FilePath);
    //     if (string.IsNullOrWhiteSpace(fileData))
    //         return;
    //
    //     var entityData = JsonSerializer.Deserialize(fileData, entity.EntityInfo.PropertyType);
    //     entity.EntityInfo.SetValue(this, entityData);
    //     entity.LastHashCode = entity.GetHashCode();
    // }
    //
    // private void InitializeEntityInfo()
    // {
    //     _entities.AddRange(GetEntityHashCodes(GetStorageFilePaths(GetAllEntitiesInfo())));
    // }
    //
    // private void InitializeEntities()
    // {
    //     GetAllEntitiesInfo()
    //         .ToList()
    //         .ForEach(entityInfo =>
    //         {
    //             var entityValue = Activator.CreateInstance(entityInfo.PropertyType);
    //             entityInfo.SetValue(this, entityValue);
    //         });
    // }
    //
    // protected async Task FetchAsync()
    // {
    //     if (CheckEntitiesInitialized()) return;
    //
    //     InitializeEntities();
    //     InitializeEntityInfo();
    //     EnsureStorageDirectoryExists();
    //     await EnsureStorageFilesExistAsync();
    //     await FetchAllEntitiesAsync();
    // }
    //
    // #endregion
    //
    // #region Synchronization
    //
    // private bool UpdateFileData(object fileData, PropertyInfo entityInfo, out List<IUpdatableEntity<IEntity>> updatedData)
    // {
    //     updatedData = new List<IUpdatableEntity<IEntity>>();
    //
    //     // fileData has FileSet<Phone> value wrapped in object type, convert to it to its original type
    //
    //     var testA = fileData as FileSet<IUpdatableEntity<IEntity>>;
    //     var testB = entityInfo.GetValue(this) as FileSet<IUpdatableEntity<IEntity>>;
    //
    //     if (fileData is not FileSet<IUpdatableEntity<IEntity>> entityFileData ||
    //         entityInfo.GetValue(this) is not FileSet<IUpdatableEntity<IEntity>> entityData) return false;
    //
    //     entityFileData.Update(entityData);
    //     updatedData.AddRange(entityFileData);
    //     return true;
    // }
    //
    // private Task SaveChangesToFilesAsync()
    // {
    //     var tasks = GetModifiedEntities()
    //         .Select(async entity =>
    //         {
    //             await using var fileStream = File.Open(entity.FilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //             var fileData = await JsonSerializer.DeserializeAsync(fileStream, entity.EntityInfo.PropertyType);
    //
    //             var bytes = null as byte[];
    //             if (fileData is not null && UpdateFileData(fileData, entity.EntityInfo, out var updatedData))
    //             {
    //                 var json = JsonSerializer.Serialize(updatedData);
    //                 bytes = Encoding.UTF8.GetBytes(json);
    //             }
    //             else
    //             {
    //                 var json = JsonConvert.SerializeObject(entity.EntityInfo.GetValue(this));
    //                 bytes = Encoding.UTF8.GetBytes(json);
    //             }
    //
    //             entity.LastHashCode = entity.GetHashCode();
    //
    //             await fileStream.WriteAsync(bytes);
    //             fileStream.Flush();
    //             fileStream.Close();
    //         });
    //
    //     return Task.WhenAll(tasks.ToArray());
    // }
}