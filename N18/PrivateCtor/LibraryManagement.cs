#region Constructor

// Konstruktor - objectlarni validatsiyadan o'tibgina yaratish uchun
// Static konstruktor - static tiplarni validatsiyadan o'tibgina dasturda ishlata olishimiz uchun

//Validator.TestMethod();-


//Console.WriteLine(Validator.IsValidName(""));

public class LibraryManagement
{
    private List<object> Books = new List<object>();
    private List<object> Reader = new List<object>();

    public LibraryManagement() : this(new List<object>(), new List<object>())
    {
    }

    protected LibraryManagement(List<object> books, List<object> reader)
    {
        Books = books;
        Reader = reader;
    } 
}

#endregion