using Library;
namespace Aviacao;

public partial class CRUDTickets : Form
{
    List<Ticket> Tickets;
    List<Flight> Flights;
    MainPage _form;
    public CRUDTickets(List<Ticket> tickets, List<Flight> flights, MainPage form)
    {
        Tickets = tickets;
        Flights = flights;
        _form = form;
        InitializeComponent();
        InitList();
    }

    /// <summary>
    /// create the columns in the listview
    /// </summary>
    private void InitList()
    {
        listViewTickets.Clear();
        listViewTickets.Columns.Add("ID", 50);
        listViewTickets.Columns.Add("Nome", 300);
        listViewTickets.Columns.Add("Voo", 100);
        listViewTickets.Columns.Add("Acento", 100);
        listViewTickets.Columns.Add("Nif", 200);
        listViewTickets.Columns.Add("Status", 100);
        listViewTickets.View = View.Details;
        PopulateList();
    }

    /// <summary>
    /// populate the listview with the list data
    /// </summary>
    private void PopulateList()
    {
        foreach (Ticket item in Tickets)
        {
            listViewTickets.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Name, item.FlightBought.Number, item.Seat, item.Nif.ToString(), item.TicketStatus }));
        }
    }

    /// <summary>
    /// return the select item in the listview
    /// </summary>
    /// <returns></returns>
    private string ReturnSelectedItem()
    {
        string? listView = null;
        if (listViewTickets.SelectedItems.Count == 1) listView = listViewTickets.FocusedItem.Text;

        return listView;
    }

    /// <summary>
    /// if the selected ticket is not canceled open the form to edit the ticket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void btnEdit_Click(object sender, EventArgs e)
    {
        string selectedItem = ReturnSelectedItem();

        if (selectedItem != null)
        {
            Ticket selectedTicket = Tickets.Find(ticket => ticket.Id == Convert.ToInt32(selectedItem))!;
            if (selectedTicket.TicketStatus == "Cancelado")
            {
                MessageBox.Show("Bilhete não pode ser editado!", "Erro", MessageBoxButtons.OK);
            }
            else _form.OpenChildForm(new CreateTicket(Flights, selectedTicket, Tickets, _form));
        }
        else MessageBox.Show("Nenhum bilhete selecionado", "Erro", MessageBoxButtons.OK);
    }

    /// <summary>
    /// open the form to create a new ticket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnNewTicket_Click(object sender, EventArgs e)
    {
        Ticket selectedTicket = new Ticket();
        _form.OpenChildForm(new CreateTicket(Flights, selectedTicket, Tickets, _form));
    }

    /// <summary>
    /// canceled a ticket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        string selectedItem = ReturnSelectedItem();
        if (selectedItem != null)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja confirmar o cancelamento da passagem?", "Confirm", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                Ticket selectedTicket = Tickets.Find(ticket => ticket.Id == Convert.ToInt32(selectedItem))!;
                selectedTicket.TicketStatus = "Cancelado";
                SendCancelEmail(selectedTicket);
                InitList();

            }

        }
    }

    /// <summary>
    /// send a email to the client when the ticket is canceled
    /// </summary>
    /// <param name="canceledTicket"></param>
    private async void SendCancelEmail(Ticket canceledTicket)
    {

        await Ticket.Execute(canceledTicket, LoadHtml(canceledTicket), "Vôo Cancelado");


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

    /// <summary>
    /// return true if the list contains a value that match with the string
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
    /// search the matches values when the user enter a text
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void txtSearchFlight_TextChanged(object sender, EventArgs e)
    {
        InitList();

        string search = txtSearchFlight.Text;
        if (search != String.Empty)
        {
            for (int i = listViewTickets.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem currentItem = listViewTickets.Items[i];
                if (ItemMatches(currentItem, search))
                {
                    currentItem.Focused = true;
                }
                else
                {
                    listViewTickets.Items.RemoveAt(i);
                }
            }
        }

        listViewTickets.EndUpdate();
    }
}