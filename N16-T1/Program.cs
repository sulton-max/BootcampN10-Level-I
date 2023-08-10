
// shart
//N16 - T1 init - only

//Registratsiyadan keyin email jo'natadigan dastur tuzing

//- email jo'natish uchun EmailService dan foydalaning 
//- unda CredentialAddress va CredentialPassword init only propertylar bo'lsin
//- methodlardan SendEmail( to ) methodi bo'lsin
//- foydalanuvchidan email addresin va username ini so'rang
//- kiritilgan email addressga "Siz muvaffaqiyatli registratsiyadan o'tdingiz" nomli email borsin

//Example 

//subject - Siz muvaffaqiyatli registratsiyadan o'tdingiz
//body - "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz"

// logika

// EmailService tipini yaratish
// CredentialAddress va CredentialPassword propertysi va ular uchun konstruktor e'lon qilamiz
// SendEmail( to, username ) - email jo'natadigan method bo'ladi
// unda body ni update qilish kerak
// EmailService dan object olib, kerakli address va parol bilan yaratish kerak
// foydalanuvchidan email address va username ni so'rab SendEmail ga bervorish kerak


// code

using System.Net;
using System.Net.Mail;
using N16_T1;

var emailService = new EmailService("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");

Console.Write("Enter your email address : ");
var emailAddress = Console.ReadLine();
Console.Write("Enter your username : ");
var userName = Console.ReadLine();

emailService.SendEmail(emailAddress, userName); 

//emailSender.CredentialPassword = "234324";

namespace N16_T1
{
    public class EmailService
    {
        public string CredentialAddress { get; init; }
        public string CredentialPassword { get; init; }

        public EmailService(string address, string password)
        {
            CredentialAddress = address;
            CredentialPassword = password;
        }

        public void SendEmail(string to, string userName)
        {
            var mail = new MailMessage("g`isthmat@gmail.com", to);
            mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
            mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}", userName);

            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
            smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }
}