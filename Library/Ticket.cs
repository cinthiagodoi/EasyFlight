﻿
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

    public Flight? FlightBought { get; set; }

    public override string ToString()
    {
        return $"{Id},{Name},{Email},{Seat},{PaymentMethod},{SelectedClass},{PhoneNumber},{Nif},{TicketStatus}";
    }

    public static async Task Execute(Ticket ticket, string path, string subjectText)
    {
        try
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("ptgodoicinthia@gmail.com", "Easy Flight");
            var subject = subjectText;
            var to = new EmailAddress(ticket.Email, ticket.Name);
            var plainTextContent = "Notificação Easy Flight";
            var htmlContent = path;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
        catch (Exception err)
        {
            string messa = $"E-mail não enviado!{err}";
        }
    }
}