using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Library;

namespace Aviacao;

public partial class MainPage : Form
{
    List<Plane> Planes;
    List<Airport> Airports;
    List<Flight> Flights;
    List<Ticket> Ticketes;

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
        Ticketes = LoadFiles.LoadTicketList(Flights);


        InitializeComponent();
        AirportsAPI.InitializeApi();

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
        currentChildForm.Close();
        Reset();
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
        SaveFiles.SaveTicketsList(Ticketes, Flights);
    }

    /// <summary>
    /// Open the flights form.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnManageFlights_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new CRUDFlight(Planes, this, Flights, Ticketes, Airports));
    }

    /// <summary>
    /// Open the tickets form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnTickets_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.color1);
        OpenChildForm(new CRUDTickets(Ticketes, Flights, this));
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

}