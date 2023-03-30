
using SendGrid.Helpers.Mail;
using SendGrid;

namespace Library;
public class Ticket
{
    public int Id { get; set; }
    public string? Name { get; set; }   

    public string? Email { get; set; }

    public string? Seat { get; set;}

    public string? PaymentMethod { get; set; }

    public string? SelectedClass { get; set; }

    public int? PhoneNumber { get; set; }

    public int? Nif { get; set; }

    public string? TicketStatus { get; set; }

    public double? TicketValue { get; set; }

    public Flight? FlightBought { get; set; }

    public override string ToString()
    {
        return $"{Id},{Name},{Email},{Seat},{PaymentMethod},{SelectedClass},{PhoneNumber},{Nif},{TicketValue},{TicketStatus}";
    }

    /// <summary>
    /// Set the SendGridApi request to send emails
    /// </summary>
    /// <param name="ticket"></param>
    /// <param name="path"></param>
    /// <param name="subjectText"></param>
    /// <returns></returns>
    public static async Task Execute(Ticket ticket, string path, string subjectText)
    {
        try
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("brgodoicinthia@gmail.com", "Easy Flight");
            var subject = subjectText;
            var to = new EmailAddress(ticket.Email, ticket.Name);
            var plainTextContent = "Notificação Easy Flight";
            var htmlContent = path;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
        catch (Exception err)
        {
            string message = $"E-mail não enviado!{err}";
        }
    }
}
