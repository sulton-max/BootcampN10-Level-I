#region Constructor

// Konstruktor - objectlarni validatsiyadan o'tibgina yaratish uchun
// Static konstruktor - static tiplarni validatsiyadan o'tibgina dasturda ishlata olishimiz uchun

//Validator.TestMethod();-


//Console.WriteLine(Validator.IsValidName(""));



public class RegistartionService
{
    public bool Registratsiya(string username)
    {
        return AddUser(username) && SendEmail(username);
    }

    private bool SendEmail(string username)
    {
        return true;
    }

    private bool AddUser(string username)
    {
        return true;
    }
}

#endregion