#region Constructor

// Konstruktor - objectlarni validatsiyadan o'tibgina yaratish uchun
// Static konstruktor - static tiplarni validatsiyadan o'tibgina dasturda ishlata olishimiz uchun

//Validator.TestMethod();-


//Console.WriteLine(Validator.IsValidName(""));

public class UltimateLibraryManagement : LibraryManagement
{
    public UltimateLibraryManagement(object admin) : base(new List<object>(), new List<object> { admin })
    {

    }
}

#endregion