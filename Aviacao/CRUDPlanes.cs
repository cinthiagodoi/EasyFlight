using Library;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Aviacao;

public partial class CRUDPlanes : Form
{
    List<Plane> Planes;
    List<Flight> Flights;
    MainPage _form;
    public CRUDPlanes(List<Plane> planes, MainPage form, List<Flight>flights)
    { 
        InitializeComponent();
        Planes = planes;
        Flights = flights;
        _form = form;
        InitList();

    }

    /// <summary>
    /// Create the Columns in the listView
    /// </summary>
    private void InitList()
    {
        listViewPlanes.Clear();
        listViewPlanes.Columns.Add("ID");
        listViewPlanes.Columns.Add("Marca");
        listViewPlanes.Columns.Add("Modelo");
        listViewPlanes.Columns.Add("Status");
        listViewPlanes.Columns.Add("Capacidade PC");
        listViewPlanes.Columns.Add("Capacidade E");
        listViewPlanes.View = View.Details;
        PopulateList();
    }

    /// <summary>
    /// Add values to display in the listView
    /// </summary>
    private void PopulateList()
    {
        foreach (Plane item in Planes)
        {
            int economy = item.SeatsPerRowEconomy * item.NumberRowsEconomy;
            int firstClass = item.SeatsPerRowFirstClass * item.NumberRowsFirstClass;
            listViewPlanes.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Brand, item.Model, item.Status, firstClass.ToString(), economy.ToString()  }));
        }
        for (int i = 0; i < 6; i++)
        {
            listViewPlanes.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }

    /// <summary>
    /// Return select item in listview
    /// </summary>
    /// <returns></returns>
    private string ReturnSelectedItem()
    {
        string? listView = null;
        if (listViewPlanes.SelectedItems.Count == 1) listView = listViewPlanes.FocusedItem.Text;

        return listView;
    }
  
    /// <summary>
    /// when click in the edit button if there are some selected item in listview create a Plane
    /// an open the CreatePlane form with the selected plane data.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEdit_Click(object sender, EventArgs e)
    {
        string selectedItem = ReturnSelectedItem();
        Plane selectedPlane = new Plane();
       
        if (selectedItem != null)
        {
            foreach (Plane item in Planes)
            {
                if (item.Id == Convert.ToInt32(selectedItem)) selectedPlane = item;
            }

            List<Flight> flight = Flights.FindAll(flight => flight.UsePlane == selectedPlane && flight.FlightStatus == "Confirmado");
            if(flight.Count > 0 )
            {
                MessageBox.Show("Avião possui vôo agendados, não " +
                    "é possível editar", "Erro", MessageBoxButtons.OK);
            }

            else if(selectedPlane.Status != "Ativo")
            {
                MessageBox.Show("Avião não pode ser editado", "Erro", MessageBoxButtons.OK);
            }
            
            else _form.OpenChildForm(new CreatePlane(selectedPlane, Planes, _form, Flights));
        }
        else MessageBox.Show("Nenhum avião selecionado", "Erro", MessageBoxButtons.OK);
    }

    /// <summary>
    /// when click in the new plane, open the createplane with a new and empty Plane
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnNewPlane_Click(object sender, EventArgs e)
    {
        Plane aviao = new Plane();
        _form.OpenChildForm(new CreatePlane(aviao, Planes, _form, Flights));
 
    }
    
    /// <summary>
    /// Check if there are items in the list that match with the input text
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
    /// Filter the listview when the user insert a text
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void txtSearchPlane_TextChanged(object sender, EventArgs e)
    {
        InitList();

        string search = txtSearchPlane.Text;
        if (search != String.Empty)
        {
            for (int i = listViewPlanes.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem currentItem = listViewPlanes.Items[i];
                if (ItemMatches(currentItem, search))
                {
                    currentItem.Focused = true;
                }
                else
                {
                    listViewPlanes.Items.RemoveAt(i);
                }
            }
        }

        listViewPlanes.EndUpdate();

    }

    /// <summary>
    /// Change de plane status with the text of the clicked button-
    /// if the plane has associated flights that will happen
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnChangeStatus_MouseClick(object sender, MouseEventArgs e)
    {
        string selectedItem = ReturnSelectedItem();
        Button? btn = sender as Button;

        if (selectedItem != null)
        {
            List<Flight> listFlights = Flights.FindAll(flight => flight.UsePlane.Id == Convert.ToInt32(selectedItem));
            Plane selectedPlane = Planes.Find(p => p.Id == Convert.ToInt32(selectedItem));
            if (listFlights.Count == 0)
            {
                if (btn!.Text == "Ativar") selectedPlane!.Status = "Ativo";
                else if (btn!.Text == "Inativar") selectedPlane!.Status = "Inativo";
                else if (btn!.Text == "Manutenção") selectedPlane!.Status = "Manutenção";
          
                InitList();
            }
            else
            {
                List<Flight> ConfirmFlights = listFlights.FindAll(flight => flight.FlightStatus == "Confirmado");

                if (ConfirmFlights.Count > 0) MessageBox.Show("Não é possível mudar o status, avião possui vôos agendados", "Alert", MessageBoxButtons.OK);
                else
                {
                    selectedPlane!.Status = btn!.Text;
                    InitList();
                }
            }
        }
        else MessageBox.Show("Selecione o avião!");
    }
}
