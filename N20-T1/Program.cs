// var emailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";
// var usernameRegex = "^[a-zA-Z0-9]{3,20}$\r\n";
// var nameRegex = "^[a-zA-Z]{2,30}$\r\n";
//


// N1 Oraliq Nazorat Imtihoni Loyihalari
//
// 1. Foydalanuvchi Registratsiyasi
//
// - quyidagi model va servicelardan foydalaning
// - konsolda foydalanuvchidan ismi, familyasi, email addressi va username so’rang
// - foydalanuvchini ro’yxatdan o’tkazing
// - ro’yxatdan o’tgan foydalanuvchilar ro’yxatini ekranga chiqaring
//
// User modeli - foydalanuvchi ismi, familyasi, sharifi, email addresi, username va aktiv foydalanuvchi ekanligi haqidagi ma’lumotlarni saqlovchi model
//
// RegistrationService servisi
//
// - Users kolleksiyasi - foydalanuvchilar ma’lumotlarini saqlab turuvchi User tipidagi kollesiya bo’lsin va unga shu tip ichidangina murojaat qilish mumkin bo’lsin
// - CheckName - ism / familya / sha’rif ni tekshiradi, valid bo’lsa true, invalid bo’lsa false qaytaradi
// - CheckEmailAddress - email manzilini tekshiradi, valid bo’lsa true, invalid bo’lsa false qaytaradi
// - GenerateUserName methodi - unique username generate qiladi
// - Add methodi
//     - parameterlari - ism, sharif, email address va ixtiyoriy username
//     - methodda ism, sharif, email address valid ekanligini tekshirilsin
//     - agar ism, sharif, email address valid bo’lmasa ekranga qaysi biri invalid ekanligi chiqarilsin
//     - username invalid yoki unique bo’lmasa GenerateUsername orqali yangi generate qilinsin
//     - foydalanuvchi hamma ma’lumotlarni valid bolsa foydalanuvchilar kolleksiyasiga qo’shsin va true qaytarsin aks holda false
//     - method faqat tip ichidangina murojaat qilish mumkin bo’lsin
// - Register methodi
//     - parameterlari - ism, sharif, email address va ixtiyoriy username
//     - Add methodi orqali foydalanuvchini qo’shsin
//     - agar Add methodi true qaytarsa foydalanuvchiga SendEmail orqali email jo’natsin
//     - agar SendEmail true qaytarsa foydalanuvchidagi aktiv ekanligini bildiruvchi property ga true qiymat yozilsin
// - SendEmail methodi
//     - parameterlari ( receiverAddress )
//     - berilgan addressga email jo’natsin
//     - jo’natish jarayonida error bo’lsa false, aks holda true qaytarsin
// - Display methodi
//     - foydalanuvchilarni ekranga chiqarsin

using System.Text.RegularExpressions;

namespace N20_T1;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string EmailAddress { get; set; }
    public string Username { get; set; }
    public bool IsActive { get; set; }
}

public class RegistrationService
{
    private const string _emailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";
    private const string _usernameRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";
    private const string nameRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";

    private bool Add(string firstName, string lastName, string middleName, string emailAddress, string username = default)
    {
    }

    private bool SendEmail()
    {
    }

    private static bool CheckName(in string name)
    {
        return Regex.IsMatch(nameRegex, _emailRegex);
    }

    private static bool CheckUserName(in string name)
    {
        return Regex.IsMatch(_usernameRegex, _emailRegex);
    }

    private static bool CheckEmailAddress(in string emailAddress)
    {
        return Regex.IsMatch(emailAddress, _emailRegex);
    }

    private static List<string> Validate(in User user)
    {
        var errorList = new List<string>();

        if (string.IsNullOrWhiteSpace(user.FirstName) || !CheckName(user.FirstName))
            errorList.Add("Invalid first name");

        if (string.IsNullOrWhiteSpace(user.LastName) || !CheckName(user.LastName))
            errorList.Add("Invalid last name");

        if (string.IsNullOrWhiteSpace(user.MiddleName) ||!CheckName(user.MiddleName))
            errorList.Add("Invalid middle name");

        if (string.IsNullOrWhiteSpace(user.EmailAddress) ||!CheckEmailAddress(user.EmailAddress))
            errorList.Add("Invalid email address");

        return errorList;
    }

    private void GenerateUserName(ref string username)
    {
        if(string.IsNullOrWhiteSpace(username) || )

    }

    private bool EnsureUniqueUserName(ref string username)
    {
        if (string.IsNullOrWhiteSpace(username) || CheckUserName(username))



    }

    public bool Register(string firstName, string lastName, string middleName, string emailAddress, string username = default)
    {
    }

    public void Display()
    {
    }
}