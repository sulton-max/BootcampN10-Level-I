// Validate - data validation
// Verify - email address, phone number

// B2C - Business to Consumer/Client/Customer - Landing Page, Telegram Bot
// B2B - Business to Business - CRM, ERP, SAP
// B2D - Business to Developer - Visual Studio, GitHub, Azure

// Intern                        B2B, B2C
// Junior                        B2B, B2C
// Middle                        B2D, B2C, B2B
// Senior                        B2D, B2B
// Team Lead                     B2D, B2B
// Architect                     B2D, B2B
// Developer Advocate            B2D

// Select

using System.Text.Json;

var users = new List<User>
{
    new User("John", "Doe"),
    new User("Jane", "Smith"),
    new User("Michael", "Johnson"),
    new User("Emily", "Williams"),
    new User("Robert", "Brown"),
    new User("Sophia", "Jones"),
    new User("William", "Davis"),
    new User("Olivia", "Miller"),
    new User("David", "Wilson"),
    new User("Emma", "Taylor"),
};

// working solution -  ishlaydigan yechim - to lower, to upper
// right solution - enum

// 10 000 * 2 = 20 000 * $200


var index = 0;
var talents = new List<Talent>
{
    new (TalentLevel.Intern, "Front-end Development", users[index++].Id),
    new (TalentLevel.Junior, "Back-end Development", users[index++].Id),
    new (TalentLevel.Middle, "Mobile App Development", users[index++].Id),
    new (TalentLevel.Middle, "Data Science", users[index++].Id),
    new (TalentLevel.TeamLead, "DevOps", users[index++].Id),
    new (TalentLevel.Architect, "Cloud Computing", users[index++].Id),
    new (TalentLevel.DeveloperAdvocate, "Full-stack Development", users[index++].Id),
    new (TalentLevel.Intern, "UI/UX Design", users[index++].Id),
    new (TalentLevel.Junior, "QA Testing", users[index++].Id),
    new (TalentLevel.Middle, "Embedded Systems", users[index].Id)
};

// firstname - x
// lastname - x
// email address - x
// age - x
// username - x
// password - x
// talent level - v
// english level - v
// rating - v qachonki double bo'lmasa
// score - x
// id - x
// balance - x
// name - x
// author - x
// title - x
// subject - x
// body - x
// examPass -

// Level I
// Level II
// Level III


var talentFilterDataModel = new TalentFilterDataModel
{
    Levels = talents.Select(talent => talent.Level.ToString()).Distinct(),
    Stacks = talents.Select(talent => talent.Stack).Distinct()
};

Console.WriteLine(JsonSerializer.Serialize(talentFilterDataModel));


Console.WriteLine((int)TalentLevel.Intern);

// solishtirish
var valueA = TalentLevel.Intern;
var valueB = TalentLevel.Intern;
var result = valueA > valueB;
Console.WriteLine(default(TalentLevel));

// var score = 60;
// var englishLevel = score switch
// {
//
// }

public class MessageConstants
{
    public const string UserToken = "{{User}}";
}

//
// public class TalentFilterModel
// {
//     public string TalentLevel { get; set; }
//     public string Stack { get; set; }
//     public string SearchKeyword { get; set; }
// }

// Principle - Composition over Inheritance

var service = new();

// validation -
// verification -
// email sending -
// create user -
// create credential -

// compose - logikani bir joyga jamlash
// composition - service lar uchun ishlatiladi
// abstraction - compositon uchun abstraction ishlatiladi

// muammo - Register
service.Register("john", "doe", "john.doe@gmail.com", "asdfasdf");

public interface IUserService
{
    User AddUser(string emailAddress);
}

public class UserService : IUserService
{
    public User AddUser(string emailAddress)
    {
    }
}

public interface IEmailService
{
    void SendEmail(string emailAddress, string subject, string body);
}

public class EmailService : IEmailService
{
    public void SendEmail(string emailAddress, string subject, string body)
    {
        throw new NotImplementedException();
    }
}

// dependency - service, configuration
// dependency narsalar doim konstruktordan kiritilsin

public class AccountService
{
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;

    public AccountService(IUserService userService, IEmailService emailService)
    {
        _userService = userService;
        _emailService = emailService;
    }

    public void Register(string emailAddress, string password)
    {
        // working solution - hamma ishni shu methodda yozish
        // right solution - har bir ishni alohida methodda yozish, inheritance
        // better solution - email - EmailService, user - UserService, credential - CredentialService
        // perfect solution - interfeys lar orqali qilish

        var user = _userService.AddUser(emailAddress);
        if (user is not null)
        {
            // _emailService.SendEmail();
        }
    }
}






