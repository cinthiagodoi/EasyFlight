using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Library;
using System.Globalization;
using ScottPlot.Ticks.DateTimeTickUnits;
using ScottPlot;
using System.Windows.Forms;

namespace Aviacao;

public partial class MainPage : Form
{
    List<Plane> Planes;
    List<Airport> Airports;
    List<Flight> Flights;
    List<Ticket> Tickets;

    SaveFiles SaveFiles;
    LoadFiles LoadFiles;

    //Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;
    public MainPage()
    {
        //loadFilesLists
        LoadFiles = new LoadFiles();
        Planes = LoadFiles.LoadPlanesList();
        Airports = LoadFiles.LoadAiportList();
        Flights = LoadFiles.LoadFlightlList(Planes);
        Tickets = LoadFiles.LoadTicketList(Flights);


        InitializeComponent();
        AirportsAPI.InitializeApi();
        CustomDateTime();


        leftBorderBtn = new Panel();
        leftBorderBtn.Size = new Size(7, 60);
        panelMenu.Controls.Add(leftBorderBtn);

        //Form
        this.Text = string.Empty;
        this.ControlBox = false;
        this.DoubleBuffered = true;
        this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }

    #region Interface
    /// <summary>
    /// Set colors that will be used in the form as a variable.
    /// </summary>
    /// 
    private void CustomDateTime()
    {
        dateTimePickerSelectYear.Format = DateTimePickerFormat.Custom;
        dateTimePickerSelectYear.CustomFormat = "yyyy";
        dateTimePickerSelectYear.ShowUpDown = true;
    }
    private struct RGBColors
    {
        public static Color color1 = Color.FromArgb(220, 184, 46);
        public static Color color2 = Color.FromArgb(2, 108, 182);
        public static Color color3 = Color.FromArgb(8, 57, 155);
    }

    /// <summary>
    /// set style on button when active
    /// </summary>
    /// <param name="senderBtn"></param>
    /// <param name="color"></param>
    private void ActivateButton (object senderBtn, Color color)
    {
        if(senderBtn != null)
        {
            DisableButton();
            //Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = RGBColors.color2;
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();  
            //Icon Current Child Form
            iconCurrentChildFormIcon.IconChar = currentBtn.IconChar;
            iconCurrentChildFormIcon.IconColor = color;

        }
    }

    /// <summary>
    /// Set style on button when desable.
    /// </summary>
    private void DisableButton()
    {
        if(currentBtn != null)
        {
            currentBtn.BackColor = RGBColors.color3;
            currentBtn.ForeColor = Color.Gainsboro;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            currentBtn.IconColor = Color.Gainsboro;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }

    /// <summary>
    /// Open the other forms as a child in the panelDesktop
    /// </summary>
    /// <param name="childForm"></param>
    public void OpenChildForm(Form childForm)
    {
        if(currentChildForm != null)  currentChildForm.Close();
        currentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;   
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        lblTitleChildForm.Text = childForm.Text;
    }

   
    /// <summary>
    /// Return to home page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnHome_Click(object sender, EventArgs e)
    {
        
        if(currentChildForm != null)
        {
            currentChildForm.Close();
            CreateFormPlot(DateTime.Now.Year);
            DisplaySoldTickets(DateTime.Now.Year);
            dateTimePickerSelectYear.Value = new DateTime(DateTime.Now.Year,1,1);
            Reset();
        }
       
    }
    
    /// <summary>
    /// Reset the title bar label to Home Page
    /// </summary>
    private void Reset()
    {
        DisableButton();
        leftBorderBtn.Visible = false;
        iconCurrentChildFormIcon.IconChar = IconChar.Home;
        iconCurrentChildFormIcon.IconColor = Color.White;
        lblTitleChildForm.Text = "Home";
    }

    /// <summary>
    /// minimizes or maximizes the screen by dragging
    /// </summary>
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
    #endregion

    /// <summary>
    /// Close form.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void iconButtonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Save all the lists in files when the form close.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveFiles = new SaveFiles();
        SaveFiles.SavePlanesList(Planes);
        SaveFiles.SaveFligthsList(Flights,Planes);
        SaveFiles.SaveTicketsList(Tickets, Flights);
    }

    /// <summary>
    /// Open the flights form.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnManageFlights_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new CRUDFlight(Planes, this, Flights, Tickets, Airports));
    }

    /// <summary>
    /// Open the tickets form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnTickets_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new CRUDTickets(Tickets, Flights, this));
    }
    /// <summary>
    /// Open the Planes form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void iconButtonManagePlanes_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new CRUDPlanes(Planes, this, Flights));
    }

    private void MainPage_Load(object sender, EventArgs e)
    {
        CreateFormPlot(DateTime.Now.Year);
        DisplaySoldTickets(DateTime.Now.Year);
    }

    private void CreateFormPlot(int year)
    {
        formsPlot1.Plot.Clear();

        double[] dataX = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        double[] dataY = new double[12];

        int count = 0;
        foreach (Flight flight in Flights)
        {
            DateTime date = DateTime.Parse(flight.Date!);
            if(date.Year == year)
            {
                dataY[date.Month - 1]++;
                if (flight.FlightStatus == "Cancelado") count++;
            }
        }

        lblCanceledFlights.Text = count.ToString();

        formsPlot1.Plot.Title("Vôos");
        formsPlot1.Plot.XLabel("Mês");
        formsPlot1.Plot.YLabel("Total Vôos");

        formsPlot1.Plot.AddScatter(dataX, dataY, color: Color.Yellow, lineWidth: 7, markerSize: 0);
        //formsPlot1.Plot.AddScatter(dataX, dataY);
        formsPlot1.Plot.Style(Style.Blue2);

    

        formsPlot1.Refresh();
    }

    private void DisplaySoldTickets(int year)
    {
        int count = 0;
        int countCanceled = 0;
        foreach(Ticket ticket in Tickets)
        {
            DateTime d = DateTime.Parse(ticket.FlightBought.Date);
            if(d.Year == year)
            {
                count++;
                if (ticket.TicketStatus == "Cancelado") countCanceled++;
            }

        }

        labelPassagensVendidas.Text = count.ToString();
        lblCanceledTickets.Text = countCanceled.ToString();
    }

    private void btnShowResults_Click(object sender, EventArgs e)
    {
        int year = Convert.ToInt32(dateTimePickerSelectYear.Text);
        CreateFormPlot(year);
        DisplaySoldTickets(year);
    }

    private void iconButton4_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new AboutUS());
    }
}