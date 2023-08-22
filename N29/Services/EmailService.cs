using System.Net;
using System.Net.Mail;

namespace N29.Services;

public class EmailService
{
    public SmtpClient SmtpClientInstance { get; init; }

    public EmailService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587);
        SmtpClientInstance.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        SmtpClientInstance.EnableSsl = true;
    }

    // 1 - asinxron method tipi Task bo'lishi shart
    // 2. async/await qatnashishi shart qachonki ishni resultatini o'sha methodda kutib olib, yana boshqa ishlar qiladigan bo'lsa
    // 3. async/await ishlatilgan bo'lsa - resultat to'gridan to'g'ridan qaytarsa bo'ladi, yo'qsa Task ga o'rab qaytarishimiz
    // 4. yoki methodni yoki return value ni Task ga o'rash shart - qachonki async/await ishlatilmagan bo'lsa
    // 5. async / await umuman ishlatilmasa - methodni ishlashi sinxron bo'lib qoladi qachonki Task.Run ham bo'lmasa

    public Task<bool> SendAsync(string receiverEmailAddress, string subject, string body)
    {
        return Task.Run(async () =>
        {
            var result = true;
            try
            {
                var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
                smtp.EnableSsl = true;

                var mail = new MailMessage("sultonbek.rakhimov@gmail.com", receiverEmailAddress);
                mail.Subject = subject;
                mail.Body = body;

                await smtp.SendMailAsync(mail);
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        });
    }
}