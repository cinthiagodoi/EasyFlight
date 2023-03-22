using Library;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviacao;

public partial class CRUDFlight : Form
{
    List<Plane> Planes;
    List<Flight> Flights;
    List<Ticket> Tickets;
    MainPage _form;
    List<Airport> Airports;
    public CRUDFlight(List<Plane> planes, MainPage form, List<Flight> flights, List<Ticket> tickets, List<Airport>airports)
    {
        InitializeComponent();
        Planes = planes;
        _form = form;
        Flights = flights;
        Tickets = tickets;
        Airports = airports;

        InitList();
    }

    /// <summary>
    /// create the columns in the list view
    /// </summary>
    private void InitList()
    {
        listViewFlights.Clear();
        listViewFlights.Columns.Add("ID", 50);
        listViewFlights.Columns.Add("Número", 100);
        listViewFlights.Columns.Add("Status", 300);
        listViewFlights.Columns.Add("Origem", 300);
        listViewFlights.Columns.Add("Destino", 300);
        listViewFlights.Columns.Add("Data", 200);
        listViewFlights.Columns.Add("Hora", 100);
        listViewFlights.View = View.Details;
        PopulateList();
    }

    /// <summary>
    /// populate the items in list view
    /// </summary>
    private void PopulateList()
    {
        foreach (Flight item in Flights)
        {
            listViewFlights.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Number, item.FlightStatus, item.Origen, item.Destiny, item.Date, item.Time }));
        }
    }

    /// <summary>
    /// return the select item in list view
    /// </summary>
    /// <returns></returns>
    private string ReturnSelectedItem()
    {
        string? listView = null;
        if (listViewFlights.SelectedItems.Count == 1) listView = listViewFlights.FocusedItem.Text;

        return listView!;
    }

    /// <summary>
    /// when click in this button open the forms to create a new flight
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnNewFlight_Click(object sender, EventArgs e)
    {
        Flight newFlight = new Flight();
        _form.OpenChildForm(new CreateFlight(newFlight, Airports, Planes, Flights, _form, Tickets));
    }

    /// <summary>
    /// when click in the edit button if the list view selected item is not null and the flight status is "Confirmado
    /// "open the new form to edit flight
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEdit_Click(object sender, EventArgs e)
    {
        string selectedItem = ReturnSelectedItem();
      
        if (selectedItem != null)
        {
            Flight returnSelectedFlight = Flights.Find(flight => flight.Id == Convert.ToInt32(selectedItem));
            if (returnSelectedFlight != null && returnSelectedFlight.FlightStatus == "Confirmado")
            {
                _form.OpenChildForm(new CreateFlight(returnSelectedFlight, Airports, Planes, Flights, _form, Tickets));
            }
            else MessageBox.Show("Vôo selecionado não pode ser editado");
          
        }
        else MessageBox.Show("Nenhum avião selecionado", "Erro", MessageBoxButtons.OK);
    }

    /// <summary>
    ///compare the list view subitem with the text return true if there are any matches
    /// </summary>
    /// <param name="item"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    private bool ItemMatches(ListViewItem item, string text)
    {
        bool matches = false;

        matches |= item.Text.ToLower().Contains(text.ToLower());

        if (matches)
        {
            return true;
        }

        foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
        {
            matches |= subitem.Text.ToLower().Contains(text.ToLower());
            if (matches)
            {
                return true;
            }
        }

        return false;
    }
    
    /// <summary>
    /// return the matcher when the user insert a input in the text box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void txtSearchFlight_TextChanged(object sender, EventArgs e)
    {
        InitList();

        string search = txtSearchFlight.Text;
        if (search != String.Empty)
        {
            for (int i = listViewFlights.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem currentItem = listViewFlights.Items[i];
                if (ItemMatches(currentItem, search))
                {
                    currentItem.Focused= true;
                }
                else
                {
                    listViewFlights.Items.RemoveAt(i);
                }
            }
        }

        listViewFlights.EndUpdate();
    }

    /// <summary>
    /// Cancel the flight
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        string selectedItem = ReturnSelectedItem();
        Flight canceledFlight = Flights.Find(flight => flight.Id == Convert.ToInt32(selectedItem));
        if (selectedItem != null && canceledFlight!.FlightStatus == "Confirmado")
        {
            var confirmResult = MessageBox.Show($"Você tem certeza que deseja cancelar o Vôo {canceledFlight.Number}", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Flights[canceledFlight.Id - 1].FlightStatus = "Cancelado";
                List<Ticket> canceledTickets = Tickets.FindAll(ticket => ticket.FlightBought!.Id == canceledFlight.Id && ticket.TicketStatus == "Ativo");
                if (canceledTickets.Count > 0)
                {
                    SendCancelEmail(canceledTickets);
                    CancelTickets(canceledTickets);
                }
                InitList();
            }
        }
        else MessageBox.Show("Vôo não pode ser cancelado!", "Erro", MessageBoxButtons.OK);
    }

    /// <summary>
    /// Cancel the ticket associated with the canceled flight
    /// </summary>
    /// <param name="canceledTicket"></param>
    private void CancelTickets(List<Ticket>canceledTicket)
    {
        foreach(Ticket ticket in Tickets)
        {
            foreach(Ticket t in canceledTicket)
            {
                if (ticket.Id == t.Id) ticket.TicketStatus = "Cancelado";
            }
        }
    }

    /// <summary>
    /// send a email to the clients with the ticket canceled
    /// </summary>
    /// <param name="canceledTickets"></param>
    private async void SendCancelEmail(List<Ticket>canceledTickets)
    {
        foreach (Ticket ticket in canceledTickets)
        {
            await Ticket.Execute(ticket, LoadHtml(ticket), "Vôo Cancelado");
        }

        static string LoadHtml(Ticket ticket)
        {
            StreamReader sr = new StreamReader(@"emailcancelamento.txt");
            string s = sr.ReadToEnd();
            s = s.Replace("{Nome}", ticket.Name).Replace("{numero_passagem}", ticket.FlightBought.Number).Replace("{Origem}", ticket.FlightBought.Origen).Replace("{Destino}", ticket.FlightBought.Destiny
                ).Replace("{Dia}", ticket.FlightBought.Date).Replace("{Hora}", ticket.FlightBought.Time).Replace("{Acento}", ticket.Seat).Replace
                ("{Classe}", ticket.SelectedClass).Replace("{logo}", "http://cdn.mcauto-images-production.sendgrid.net/c3759a398af145f9/80027bb1-001d-4ee1-88e9-e15ec09291ee/1006x607.png");
            sr.Close();
            return s;
        }
    }
}



