using Library;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Windows.Ink;
using System.Reflection;
using System.Drawing.Imaging;

namespace Aviacao;

public partial class CreateTicket : Form
{
    List<Flight> Flights;
    List<Ticket> Tickets;
    Ticket BoughtTicket;
    MainPage _form;

    public CreateTicket(List<Flight> flights, Ticket editTicket, List<Ticket>tickets, MainPage form)
    {
        InitializeComponent();
        Flights = flights;
        Tickets = tickets;
        _form = form;
        BoughtTicket = editTicket;
        InitList();
    }

    /// <summary>
    /// Create the columns in the list view 
    /// </summary>
    private void InitList()
    {
        listViewVoos.Columns.Add("Id", 50);
        listViewVoos.Columns.Add("Numero", 100);
        listViewVoos.Columns.Add("Destino", 300);
        listViewVoos.Columns.Add("Origem", 300);
        listViewVoos.View = View.Details;
        PopulateList();
        PopulateComboBoxPaymentMethod();
        PopulateTextBox();
    }

    /// <summary>
    /// if the ticket has values-edit- set the text boxs with the values
    /// </summary>
    private void PopulateTextBox()
    {
        txtName.Text = BoughtTicket.Name;
        txtEmail.Text = BoughtTicket.Email;
        comboBoxPaymenthMethod.Text = BoughtTicket.PaymentMethod;
        txtPhoneNumber.Text = BoughtTicket.PhoneNumber.ToString();
        txtNif.Text = BoughtTicket.Nif.ToString();
    }

    /// <summary>
    /// Populate the list view with the Flight list data, only if the flight is confirmed
    /// </summary>
    private void PopulateList()
    {
        List<Flight> activeFlights = Flights.FindAll(flight => flight.FlightStatus == "Confirmado");
        foreach (Flight item in activeFlights)
        {
            listViewVoos.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Number, item.Origen, item.Destiny, item.FirstClassPrice.ToString(), item.EconomyClassPrice.ToString()}));
        }
    }

    /// <summary>
    /// Pass the values to display in the combobox
    /// </summary>
    private void PopulateComboBoxPaymentMethod()
    {
        comboBoxPaymenthMethod.DisplayMember = "Text";
        comboBoxPaymenthMethod.ValueMember = "Value";

        var items = new[] {
            new { Text = "Cartão", Value = "cartao" },
            new { Text = "MBWay", Value = "mbway" },
            new { Text = "Dinheiro", Value = "dinheiro" },
          
        };

        comboBoxPaymenthMethod.DataSource = items;
    }

    /// <summary>
    /// return selected item in the list view
    /// </summary>
    /// <returns></returns>
    private Flight ReturnSelectedItem()
    {
        string? listView = null;
        if (listViewVoos.SelectedItems.Count == 1) listView = listViewVoos.FocusedItem.Text;
        Flight selectedVoo = Flights.Where(voo => voo.Id == Convert.ToInt32(listView)).FirstOrDefault()!;

        return selectedVoo; 
    }

  
    /// <summary>
    /// check if all the user inputs are in the correct format
    /// </summary>
    /// <returns></returns>
    private bool IsValid()
    {
        bool valid = true;

        if (Regex.IsMatch(txtPhoneNumber.Text, @"^[0-9]+$") == false || string.IsNullOrEmpty(txtPhoneNumber.Text))
        {
            MessageBox.Show("Telefone inválido!", "Erro", MessageBoxButtons.OK);
            valid = false;
        }

        if (Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$") == false || string.IsNullOrEmpty(txtName.Text))
        {
            MessageBox.Show("Nome inválido!", "Erro", MessageBoxButtons.OK);
            valid = false;
        }
      
        if (Regex.IsMatch(txtNif.Text, @"^[0-9]+$") == false || string.IsNullOrEmpty(txtNif.Text))
        {
            MessageBox.Show("NIF inválido!", "Erro", MessageBoxButtons.OK);
            valid = false;
        }

        if (Regex.IsMatch(txtEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*") == false || string.IsNullOrEmpty(txtEmail.Text))
        {
            MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK);
            valid = false;
        }

        if(BoughtTicket.Seat == null )
        {
            MessageBox.Show("É necessário selecionar o acento!", "Erro", MessageBoxButtons.OK);
            valid = false;
        }

        return valid;
    }

    /// <summary>
    /// When clicked in the flight the Ticket receive the values the user already create and open the new form.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void listViewVoos_DoubleClick(object sender, EventArgs e)
    {
        Flight selectedFlight = ReturnSelectedItem();
        BoughtTicket.Name = txtName.Text;
        BoughtTicket.Email = txtEmail.Text;
        BoughtTicket.PaymentMethod = comboBoxPaymenthMethod.Text;
        if(txtPhoneNumber.Text != "") BoughtTicket.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
        if(txtNif.Text != "") BoughtTicket.Nif = Convert.ToInt32(txtNif.Text);

        if (selectedFlight != null)
        {
            BoughtTicket.FlightBought = selectedFlight;
            _form.OpenChildForm(new SeatsSelector(selectedFlight, Tickets, BoughtTicket, _form, Flights));
        }
    }

    /// <summary>
    /// If user confirms and the boughtTicket don't have an id call the method AddNewTicket
    /// else call the method EditTicket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEnviar_Click(object sender, EventArgs e)
    {
        if(IsValid() == true)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja confirmar a compra?", "Confirm", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                if (BoughtTicket.Id != 0) EditTicket();
                else AddNewTicket();
            }
         
        }
       
    }

    /// <summary>
    /// is all inputs are valid edit the values in the ticket
    /// </summary>
    private void EditTicket()
    {
        if (IsValid() == true)
        {
            BoughtTicket.Name = txtName.Text;
            BoughtTicket.Email = txtEmail.Text;
            BoughtTicket.PaymentMethod = comboBoxPaymenthMethod.Text;
            BoughtTicket.Nif = Convert.ToInt32(txtNif.Text);
            BoughtTicket.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
            CloseForm();

        }
    }

    /// <summary>
    /// return the last id in the ticket list
    /// </summary>
    /// <param name="tickets"></param>
    /// <returns></returns>
    private int GetLastId(List<Ticket> tickets)
    {
        string[] getLastId = new string[5];
        if (tickets.Count == 0) return 0;
        else
        {
            getLastId = (tickets.LastOrDefault()!.ToString()).Split(",");
            return Convert.ToInt32(getLastId[0]);
        }
    }

    /// <summary>
    /// add a new ticket if all the values are valid and send a email to the client with the confirmation
    /// </summary>
    private async void AddNewTicket()
    {
        Ticket addTicket;
        addTicket = new Ticket
        {
            Id = GetLastId(Tickets) + 1,
            Name = txtName.Text,
            Email = txtEmail.Text,
            PaymentMethod = comboBoxPaymenthMethod.Text,
            SelectedClass = BoughtTicket.SelectedClass,
            Seat = BoughtTicket.Seat,
            FlightBought = BoughtTicket.FlightBought,
            PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text),
            Nif = Convert.ToInt32(txtNif.Text),
            TicketStatus = "Ativo",
        };
        Tickets.Add(addTicket);
        await Ticket.Execute(addTicket, LoadHtml(addTicket), "Confirmação Compra");
        CloseForm();
    }
 
    /// <summary>
    /// load html file and replace the values
    /// </summary>
    /// <param name="ticket"></param>
    /// <returns></returns>
    static string LoadHtml(Ticket ticket)
    {
        string preco;
        if (ticket.SelectedClass == "Primeira Classe") preco = ticket.FlightBought!.FirstClassPrice.ToString();
        else preco = ticket.FlightBought!.EconomyClassPrice.ToString();

        StreamReader sr = new StreamReader(@"email.txt");
        string s = sr.ReadToEnd();
        s = s.Replace("{Nome}", ticket.Name).Replace("{numero_passagem}", ticket.FlightBought.Number).Replace("{Preco}", preco).Replace(
            "{forma_pagamento}", ticket.PaymentMethod).Replace("{Origem}", ticket.FlightBought.Origen).Replace("{Destino}", ticket.FlightBought.Destiny
            ).Replace("{Dia}", ticket.FlightBought.Date).Replace("{Hora}", ticket.FlightBought.Time).Replace("{Acento}", ticket.Seat).Replace
            ("{Classe}", ticket.SelectedClass).Replace("{logo}", "http://cdn.mcauto-images-production.sendgrid.net/c3759a398af145f9/80027bb1-001d-4ee1-88e9-e15ec09291ee/1006x607.png");
        sr.Close();
        return s;
    }

    /// <summary>
    /// close current form and open CRUDTickets- return
    /// </summary>
    private void CloseForm()
    {
        _form.OpenChildForm(new CRUDTickets(Tickets, Flights, _form));
    }
}


