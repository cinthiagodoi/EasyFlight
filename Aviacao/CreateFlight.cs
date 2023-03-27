 using Library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Aviacao;

public partial class CreateFlight : Form
{
    AirportsAPI Api;
    ListConvertAiports.Root AirportsList;
    List<Airport> Airports;
    List<Plane> Planes;
    List<Flight> Flights;
    Flight selectedFlight;
    MainPage _form;
    List<Ticket> Tickets;
    List<Ticket> SoldTickets;
    LoadFiles Load;
    public CreateFlight(Flight flight, List<Airport> airports, List<Plane> planes, List<Flight> flights, MainPage form, List<Ticket>tickets)
    {
        InitializeComponent();
        Api = new AirportsAPI();
        AirportsList = new ListConvertAiports.Root();
        Load = new LoadFiles();

        Airports = airports;
        Planes = planes;
        Flights = flights;
        selectedFlight = flight;
        Tickets = tickets;

        SoldTickets = Tickets.FindAll(ticket => ticket.FlightBought!.Id == selectedFlight.Id);

        _form = form;

        GetAiportsList();
        AutoCompleteTextBox();
        CreateComboBoxList();
        SetMyCustomFormat();
        PopulateTextBox();
        
    }

    /// <summary>
    /// If the project dont contain the file with the airport list, create a new list with the API
    /// </summary>
    private async void GetAiportsList()
    {
        string file = @"aeroportos.txt";

        if(!File.Exists(file)) 
        {
            AirportsList = await Api.GetJson();

            if (AirportsList.response!.Count > 0)
            {
                using (TextWriter tw = new StreamWriter(file))
                {
                    for(int i = 0; i < AirportsList.response.Count ; i++)
                    {
                        if (AirportsList.response[i].iata_code != null && AirportsList.response[i].iata_code != "" && AirportsList.response[i].iata_code != "0")
                        {
                            tw.WriteLine(AirportsList.response[i].ToString());
                        }
                    }tw.Close();
                }
            }
            Airports = Load.LoadAiportList();
        } 
    }

    /// <summary>
    /// Populate the textbox if there are values in the Flight
    /// if the flight have ticket solds destiny and origen cannot be changed
    /// </summary>
    private void PopulateTextBox()
    {
        if (selectedFlight.Id != 0)
        {
            txtOrigemCountry.Text = selectedFlight.Origen;
            txtDestinyCountry.Text = selectedFlight.Destiny;
            dateTimePickerSelectedFlightDate.Text = selectedFlight.Date;
            dateTimePickerHour.Text = selectedFlight.Time;
            comboBoxAvioes.Text = selectedFlight.UsePlane!.PlaneName;
            numericUpDownEconomica.Value = (decimal)selectedFlight.EconomyClassPrice;
            numericUpDownPrimeiraClasse.Value = (decimal)selectedFlight.FirstClassPrice;
        }
        if (SoldTickets.Count > 0)
        {
            txtDestinyCountry.Enabled = false;
            txtOrigemCountry.Enabled = false;
            ChangeComboBox();
            comboBoxAvioes.Text = selectedFlight.UsePlane!.PlaneName;

        }
    }

    /// <summary>
    /// create auto complete in the origen and destiny text box with the aiports names
    /// </summary>
    private void AutoCompleteTextBox()
    {
        AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();

        foreach (Airport airport in Airports)
        {
            {
                sourceName.Add($"{airport.country_code} {airport.name} ({airport.iata_code})");
            }

            txtOrigemCountry.Enabled = true;
            txtOrigemCountry.AutoCompleteCustomSource = sourceName;
            txtOrigemCountry.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOrigemCountry.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtDestinyCountry.Enabled = true;
            txtDestinyCountry.AutoCompleteCustomSource = sourceName;
            txtDestinyCountry.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDestinyCountry.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

    }

    /// <summary>
    /// pass the planes to combobox
    /// </summary>
    private void CreateComboBoxList()
    {
        List<Plane> activePlanes = Planes.FindAll(plane => plane.Status == "Ativo");
        comboBoxAvioes.DataSource = activePlanes;
        comboBoxAvioes.ValueMember = "PlaneName";
    }

    /// <summary>
    /// change the format of dateTimePicker to show only hours
    /// </summary>
    private void SetMyCustomFormat()
    {
        dateTimePickerSelectedFlightDate.MinDate = DateTime.Now.Date;
        dateTimePickerHour.ShowUpDown = true;
        dateTimePickerHour.CustomFormat = "HH:mm";
        dateTimePickerHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
    }

    /// <summary>
    /// check if all the user inputs are in the correct format
    /// </summary>
    /// <returns></returns>
    private bool IsValid()
    {
        bool isValid = true;

        if (string.IsNullOrEmpty(txtOrigemCountry.Text))
        {
            isValid = false;
            MessageBox.Show("Preencha paíse de origem", "Erro", MessageBoxButtons.OK);
        }
        if(string.IsNullOrEmpty(txtDestinyCountry.Text))
        {
            MessageBox.Show("Preencha país de destino", "Erro", MessageBoxButtons.OK);
            isValid = false;
        }
        if(txtDestinyCountry.Text == txtOrigemCountry.Text)
        {
            isValid = false;
            MessageBox.Show("Vôo com destino inválido!", "Erro", MessageBoxButtons.OK);
        }
        if (string.IsNullOrEmpty(comboBoxAvioes.Text)) isValid = false;
        if(numericUpDownEconomica.Value == 0 || numericUpDownPrimeiraClasse.Value == 0) 
        {
            isValid = false;
            MessageBox.Show("Preencha valor da passagem", "Erro", MessageBoxButtons.OK);
        }
            return isValid;
    }

    /// <summary>
    /// create a new flight and add to the flights list
    /// </summary>
    private void CreateFligth()
    {
        int contId = GetLastId(Flights) + 1;
        Flight addVoo;

        if(IsValid() == true)
        {
            addVoo = new Flight
            {
                Id = contId,
                Number = $"EF{contId}",
                Origen = txtOrigemCountry.Text,
                Destiny = txtDestinyCountry.Text,
                Date = dateTimePickerSelectedFlightDate.Value.ToShortDateString(),
                Time = dateTimePickerHour.Value.ToString("HH:mm"),
                FirstClassPrice = (double)numericUpDownEconomica.Value,
                EconomyClassPrice = (double)numericUpDownPrimeiraClasse.Value,
                FlightStatus = "Confirmado",
                UsePlane = SelectedPlane(),
            };
            Flights.Add(addVoo);
            CloseForm();
         }
    }

    /// <summary>
    /// method to open the CRUDFlight and close this form
    /// </summary>
    private void CloseForm()
    {
        _form.OpenChildForm(new CRUDFlight(Planes,_form, Flights,Tickets, Airports));
    }

    /// <summary>
    /// return selected plane in combobox
    /// </summary>
    /// <returns></returns>
    private Plane SelectedPlane()
    {
        string text =  comboBoxAvioes.Text;
        string[] ids = comboBoxAvioes.Text.Split("-");

        int id = Convert.ToInt32(ids[0]);

        Plane usePlane = Planes.Find(x => x.Id == id)!;

        return usePlane;
    }

    /// <summary>
    /// return the last id in the flights list
    /// </summary>
    /// <param name="flights"></param>
    /// <returns></returns>
    private int GetLastId(List<Flight> flights)
    {
        string[] getLastId = new string[5];
        if (flights.Count == 0) return 0;
        else
        {
            getLastId = (flights.LastOrDefault()!.ToString()).Split(",");
            return Convert.ToInt32(getLastId[0]);
        }
    }
 
    /// <summary>
    /// clise form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancel_Click(object sender, EventArgs e)
    {
        CloseForm();
    }

    /// <summary>
    /// if there are no values in the flight calls the createFlight
    /// else calls the editflight
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (selectedFlight.Id == 0) CreateFligth();
        else EditFlight();
    }

    /// <summary>
    /// Change the flight with the new values
    /// </summary>
    private void EditFlight()
    {
        if (selectedFlight.UsePlane != SelectedPlane())
        {
            ChangeEconomySeats(SelectedPlane());
            ChangeFirstClassSeat(SelectedPlane());
        }

        if (IsValid() == true)
        {
            selectedFlight.Origen = txtOrigemCountry.Text;
            selectedFlight.Destiny = txtDestinyCountry.Text;
            selectedFlight.Date = dateTimePickerSelectedFlightDate.Value.ToShortDateString();
            selectedFlight.Time = dateTimePickerHour.Value.ToString("HH:mm");
            selectedFlight.FirstClassPrice = (double)numericUpDownEconomica.Value;
            selectedFlight.EconomyClassPrice = (double)numericUpDownPrimeiraClasse.Value;
            selectedFlight.FlightStatus = "Confirmado";
            selectedFlight.UsePlane = SelectedPlane();
            SendChangeTicketEmail();
            CloseForm();
        }
    }
    
    /// <summary>
    /// send client email about the edit in the flight
    /// </summary>
    private async void SendChangeTicketEmail()
    {
        foreach(Ticket ticket in SoldTickets)
        {
            await Ticket.Execute(ticket, LoadHtml(ticket), "Alteração Vôo");
        }

        static string LoadHtml(Ticket ticket)
        {
            StreamReader sr = new StreamReader(@"alteracaovooemail.txt");
            string s = sr.ReadToEnd();
            s = s.Replace("{Nome}", ticket.Name).Replace("{numero_passagem}", ticket.FlightBought!.Number).Replace("{Origem}", ticket.FlightBought.Origen).Replace("{Destino}", ticket.FlightBought.Destiny
                ).Replace("{Dia}", ticket.FlightBought.Date).Replace("{Hora}", ticket.FlightBought.Time).Replace("{Acento}", ticket.Seat).Replace
                ("{Classe}", ticket.SelectedClass).Replace("{logo}", "http://cdn.mcauto-images-production.sendgrid.net/c3759a398af145f9/80027bb1-001d-4ee1-88e9-e15ec09291ee/1006x607.png");
            sr.Close();
            return s;
        }

    }

    /// <summary>
    /// change the seats that were sold in the economy to the new plane
    /// </summary>
    /// <param name="selectedPlane"></param>
    private  void ChangeEconomySeats(Plane selectedPlane)
    {
        List<Ticket> economy = SoldTickets.FindAll(ticket => ticket.SelectedClass == "Economica");

        int count = 1;
        int countColumn = 0;
        char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
        foreach (Ticket ticket in economy)
        {
            if (countColumn == selectedPlane.SeatsPerRowFirstClass) count++;
            Tickets[ticket.Id - 1].Seat = count.ToString() + alphabet[countColumn] + "E";
            countColumn++;
        }
    }

    /// <summary>
    /// change the seats that where sold in first class to the new plane
    /// </summary>
    /// <param name="selectedPlane"></param>
    private void ChangeFirstClassSeat(Plane selectedPlane)
    {
        List<Ticket> firstClass = SoldTickets.FindAll(ticket => ticket.SelectedClass == "Primeira Classe");
        int count = 1;
        int countColumn = 0;
        char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
        foreach (Ticket ticket in firstClass)
        {
            if (countColumn == selectedPlane.SeatsPerRowFirstClass) count++;
            Tickets[ticket.Id - 1].Seat = count.ToString() + alphabet[countColumn] + "F";
            countColumn++;
        }
    }

    /// <summary>
    /// only shows planes that have more seats than they have already sold
    /// </summary>
    private void ChangeComboBox()
    {
        int countFirst = 0;
        int countEconomy = 0;

        List<Ticket> soldTicket = Tickets.FindAll(ticket => ticket.FlightBought!.Id == selectedFlight.Id);
        foreach(Ticket ticket in soldTicket)
        {
            if (ticket.SelectedClass == "Primeira Classe") countFirst++;
            else countEconomy++;
        }

        List<Plane> possiblePlanes = Planes.FindAll(plane => plane.NumberRowsEconomy * plane.SeatsPerRowEconomy >= countEconomy && plane.SeatsPerRowFirstClass * plane.NumberRowsFirstClass >= countFirst);
        
        comboBoxAvioes.DataSource= possiblePlanes;
        comboBoxAvioes.ValueMember = "PlaneName";
    }
}
