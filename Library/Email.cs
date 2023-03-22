using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;


namespace Library;

public class Email
{ 
    /// <summary>
    /// Execute SENDGRID API request
    /// </summary>
    /// <returns></returns>
    static async Task Execute()
    {
        var apiKey = "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";
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("ptgodoicinthia@gmail.com", "Example User");
        var subject = "Sending with SendGrid is Fun";
        var to = new EmailAddress("cinthiagodoi@hotmail.com", "Example User");
        var plainTextContent = "and easy to do anywhere, even with C#";
        var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        var response = await client.SendEmailAsync(msg);
    }

}
