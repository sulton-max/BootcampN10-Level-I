using System.Text.Json;
using N28.Extensions;
using N28.Models.Common;

namespace N28.DataAccess;

public class FileSet<T> : List<T> where T : class, IEntity, IUpdatableEntity<T>
{
    private readonly string _name;

    public FileSet(string name)
    {
        _name = name;
    }

    public void Initialize()
    {
        var fileName = $"{_name.ToLower()}.json";
        var folderName =  Path.Combine(Directory.GetCurrentDirectory(), "Storage");
        var filePath = Path.Combine(folderName, fileName);
        if (!File.Exists(filePath))
            return;

        // file ichidagi ma'lutmolarni json shaklida o'qib, listga o'girib  va posts ga o'zlashtirish
        var fileStream = File.Open(filePath, FileMode.Open);
        var previousData = JsonSerializer.Deserialize<List<T>>(fileStream);

        Clear();
        AddRange(previousData);

        fileStream.Flush();
        fileStream.Close();
    }

    public void SaveChanges()
    {
        // file va papka nameini hisoblash
        // posts.json
        var fileName = $"{_name.ToLower()}.json";

        // shu dastur ishlayotgan papkani olish
        // D:/Projects/N28
        var folderName = Path.Combine(Directory.GetCurrentDirectory(), "Storage");

        // agar papka bo'lmasa papkani yaratish
        if (!Directory.Exists(folderName))
            Directory.CreateDirectory(folderName);

        // filega bo'lgan yo'lni hisoblash
        // filename - D:/Projects/N28/posts.json
        var filePath = Path.Combine(folderName, fileName);

        // file ni ochish yoki yaratish
        var fileStream = File.Open(filePath, FileMode.OpenOrCreate);

        // file yangi ochilgan bo'lsa, ichiga to'g'ridan to'g'ri listni yozish
        if (fileStream.Length == 0)
        {
            JsonSerializer.Serialize(fileStream, this);
            fileStream.Flush();
            fileStream.Close();
            return;
        }

        // agar file da eski ma'lumotlar bo'lsa
        // filedagi ma'lumotni listga o'girish
        var previousData = JsonSerializer.Deserialize<List<T>>(fileStream);
        fileStream.SetLength(0);

        // listni yangi ma'lumotlar bilan to'ldirish
        previousData.Update(this);
        JsonSerializer.Serialize(fileStream, previousData);

        fileStream.Flush();
        fileStream.Close();
    }
}