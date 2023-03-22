using Library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Windows.Documents;

namespace Aviacao;

public partial class SeatsSelector : Form
{
    Flight Flight;
    List<Ticket> Tickets;
    Ticket AddSelectedSeat;
    Button SelectedButton;
    List<Flight> Flights;
    MainPage _form;
    public SeatsSelector(Flight selected, List<Ticket>tickets, Ticket addSelectedTicket, MainPage form, List<Flight> flights)
    {
        InitializeComponent();
        Flight = selected;
        AddSelectedSeat = addSelectedTicket;
        Tickets = tickets;
        SelectedButton = null;
        _form = form;
        Flights = flights;
    }

    /// <summary>
    /// create the buttons dinamically 
    /// </summary>
    /// <param name="l"></param>
    /// <param name="rowNumber"></param>
    /// <param name="collumnNumber"></param>
    private void PopulateScreen(string l, int rowNumber, int collumnNumber)
    {
        panelSeatsSelector.Controls.Clear();
        int count = 0;
        
        for (int row = 0; row < rowNumber; row++)
        {
            count = 0;
            char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            for (int column = 0; column < collumnNumber; column++)
            {
                count++;
                string text = count.ToString() + alphabet[row];
                Button b = new Button();
                b.Text = text;
                b.Font = new Font("Arial", 4);
                b.Name = count.ToString() + alphabet[row] + l;
                b.Size = new Size(40, 40);
                b.BackColor = Color.FromArgb(8, 57, 155);
                b.ForeColor = Color.White;
                b.Location = new Point(45 * (column + 1), 45 * (row));
                b.Click += new EventHandler(ButtonClickOneEvent);
                panelSeatsSelector.Controls.Add(b);
               
            }
        }
        checkSelectedSeats();
       
     }

    /// <summary>
    /// check the list to the tickets already sold
    /// </summary>
    private void checkSelectedSeats()
    {
        List<Ticket> listFlightTicket = Tickets.FindAll(tickets => tickets.FlightBought!.Id == Flight.Id && tickets.TicketStatus == "Ativo");
        foreach(Ticket ticket in listFlightTicket)
        {
            foreach(Button b in panelSeatsSelector.Controls)
            {
                if(ticket.Seat == b.Name)
                {
                    b.BackColor = Color.Red;
                    b.Enabled = false;
                }
            }
        }
    }

    /// <summary>
    /// Change de back color of the selected button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void ButtonClickOneEvent(object sender, EventArgs e)
    {
        Button? btn = sender as Button;
        if (btn != null)
        {
            btn.BackColor = (btn.BackColor == Color.FromArgb(8, 57, 155)) ? Color.Green : Color.White;
            if (SelectedButton != null) SelectedButton.BackColor = Color.FromArgb(8, 57, 155);
            SelectedButton = btn;
        }
    }

    /// <summary>
    /// if there is a selected button add the seat to the ticket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnOk_Click(object sender, EventArgs e)
    {
        if(SelectedButton != null)
        {
            AddSelectedSeat.Seat = SelectedButton.Name;

            CloseForm();
        }else MessageBox.Show("Escolha um lugar");
    }

    /// <summary>
    /// populate screen with the first class data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnFirstClass_Click(object sender, EventArgs e)
    {
        PopulateScreen("F", Flight.UsePlane!.SeatsPerRowFirstClass, Flight.UsePlane.NumberRowsFirstClass);
        lblValor.Text = Flight.FirstClassPrice.ToString();
        AddSelectedSeat.SelectedClass = "Primeira Classe";
    }

    /// <summary>
    /// populate screen with economy class data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEconomy_Click(object sender, EventArgs e)
    {
        PopulateScreen("E", Flight.UsePlane!.SeatsPerRowEconomy, Flight.UsePlane.NumberRowsEconomy);
        lblValor.Text = Flight.EconomyClassPrice.ToString();
        AddSelectedSeat.SelectedClass = "Economica";
    }

    /// <summary>
    /// close the current form and open the createticket form
    /// </summary>
    private void CloseForm() 
    {
        _form.OpenChildForm(new CreateTicket(Flights, AddSelectedSeat, Tickets, _form));
    }

    /// <summary>
    /// close the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClose_Click(object sender, EventArgs e)
    {
        CloseForm();
    }
}



