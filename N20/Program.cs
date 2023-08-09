using System.Net;
using System.Net.Mail;

// Inteface - klassdan farqi - multiple inheritance o'rnida ishlaydi
// nomida - I bilan boshlanadi
// memberlari - faqat methodlar va property

// Implement - inheritance dan farqi - e'lon qilingan methodni asosiy logikasini yozish

var emailService = new EmailService();
var smsService = new SmsService();
var registrationService = new RegistrationService();

// Abstraction
// Loose Coupling - biror vazifani bajarishda aynan bitta type/instance ga bog'lanib qolmaslik

var accountService = new AccountService(smsService, registrationService);

var c = new C();
c.DoSomething()

((A)c).DoSomething();
((B)c).DoSomething();

public interface A
{
    string DoSomething();
}

public interface B
{
    string DoSomething();
}

public class C : A, B
{
    string A.DoSomething()
    {
        Console.WriteLine("DoSomething from A");
    }

    protected string DoSomething()
    {
        Console.WriteLine("DoSomething from B");
    }
}


public interface INotificationService
{
    bool Send(User user, string subject, string body);
}

public interface IRegistrationService
{
    User Register(string emailAddress, string password);
}

public interface IAccountService
{
    bool Create(string emailAddress, string password);
}

public interface IEmailService
{
    IEnumerable<object> SearchForUser(string emailAddress);
}

public class EmailService : INotificationService, IEmailService
{
    public SmtpClient SmtpClientInstance { get; init; }

    public EmailService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        SmtpClientInstance.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        SmtpClientInstance.EnableSsl = true;
    }

    public bool Send(User user, string subject, string body)
    {
        var mail = new MailMessage("g`isthmat@gmail.com", user.EmailAddress);
        mail.Subject = subject;
        mail.Body = body;

        SmtpClientInstance.Send(mail);

        return true;
    }

    public IEnumerable<object> SearchForUser(string emailAddress)
    {
        throw new NotImplementedException();
    }
}

public class SmsService : INotificationService
{
    public bool Send(User user, string subject, string body)
    {
        throw new NotImplementedException();
    }
}

public class RegistrationService : IRegistrationService
{
    private List<User> _users = new();

    public User Register(string emailAddress, string password)
    {
        throw new NotImplementedException();
    }
}

public class AccountService : IAccountService
{
    private readonly INotificationService _notificationService;
    private readonly IRegistrationService _registrationService;

    public AccountService(INotificationService notificationService, IRegistrationService registrationService)
    {
        _notificationService = notificationService;
        _registrationService = registrationService;
    }

    public bool Create(string emailAddress, string password)
    {
        var newUser = _registrationService.Register(emailAddress, password);
        if (newUser is not null)
            return _notificationService.Send(newUser, "Welcome", "Welcome to our website");

        return false;
    }
}

public class User
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
}


// public interface IEntity
// {
//     Guid Id { get; set; }
// }
//
// public class User : IEntity
// {
//     public Guid Id { get; set; }
//     public string Name { get; set; }
//     public string Password { get; set; }
//     public string EmailAddress { get; set; }
// }

// public class EmailTemplate : IEntity
// {
//     public Guid Id { get; set; }
// }


// public class PriorityQueue
// {
//     private List<ITaskEvent> _items = new();
//
//     public void Enqueue(ITaskEvent item)
//     {
//         _items.Add(item);
//
//         // _items.Where(item => item.Priority > 10);
//         _items.OrderBy(item => item.Priority);
//
//
//
//
//         item.Priority
//     }
//
//     // public void Enqueue<T>(T item) where T : ITaskEvent, ICloneable
//     // {
//     //
//     //     // item.Clone();
//     // }
// }

// public interface IFileLocationService
// {
// }
//
// public interface IFileManagementService
// {
//     public void Write(Stream stream);
// }
//
// public class FileService : IFileLocationService, IFileManagementService
// {
//     public void Write(Stream stream)
//     {
//         // to'g'ridan to'g'ri yozib qo'yadi
//     }
// }
//
// public class ImageFileService : IFileManagementService
// {
//     public void Write(Stream stream)
//     {
//         // imageni qisqartirib, keyin yozadi
//     }
// }


public interface ITaskEvent
{
    string Name { get; }
    int Priority { get; }
}

public class TaskItem : ITaskEvent
{
    public string Name { get; set; }


    public int Priority { get; set; }

    public void DoSomething()
    {
    }
}

public class EventItem : ITaskEvent
{
    public string Name { get; set; }
    public int Priority { get; set; }


    public DateTime Date { get; set; }
}