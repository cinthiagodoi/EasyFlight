using Library;
using System.Text.RegularExpressions;

namespace Aviacao
{
    public partial class CreatePlane : Form
    {
        Plane AddPlane;
        List<Plane> Planes;
        List<Flight> Flights;
        MainPage _form;

        public CreatePlane(Plane plane, List <Plane> planes, MainPage form, List<Flight> flights)
        {
            InitializeComponent();
            AddPlane = plane;
            Planes = planes;
            Flights = flights;

            _form = form;
            PopulateTextBox();
        }

        /// <summary>
        /// If the plane has values-edited-fill the page with the plane's data
        /// </summary>
        private void PopulateTextBox()
        {
            if(AddPlane.Id != 0)
            {
                txtMarca.Text = AddPlane.Brand;
                txtModelo.Text = AddPlane.Model;
                numericUpDownClasseEconomica.Value = AddPlane.SeatsPerRowEconomy;
                numericUpDownPrimeiraClasse.Value = AddPlane.SeatsPerRowFirstClass;
                numericUpDownColunaClasseEconomica.Value = AddPlane.NumberRowsEconomy;
                numericUpDownColunasPrimeiraClasse.Value = AddPlane.NumberRowsFirstClass;

            }
        }

        /// <summary>
        /// if AddPlane is new - without a Id -calls the method to create a new plane
        /// else call the method to edit the plane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (AddPlane.Id == 0) NewPlane();
            else EditPlane();
        }

        /// <summary>
        /// Create a new plane and add to the Planes List
        /// </summary>
        private void NewPlane()
        {
            int contId = GetLastId(Planes) + 1;

            if (ValidateUserInputs())
            {
                AddPlane = new Plane
                {
                    Id = contId,
                    Brand = txtMarca.Text,
                    Model = txtModelo.Text,
                    SeatsPerRowEconomy = (int)numericUpDownPrimeiraClasse.Value,
                    SeatsPerRowFirstClass = (int)numericUpDownClasseEconomica.Value,
                    NumberRowsFirstClass = (int)numericUpDownColunasPrimeiraClasse.Value,
                    NumberRowsEconomy = (int)numericUpDownColunaClasseEconomica.Value,
                    Status = "Ativo",
                };
                Planes.Add(AddPlane);
                CloseForm();
            }
        }

        /// <summary>
        /// Edit Plane with the new values;
        /// </summary>
        private void EditPlane()
        {
            if (ValidateUserInputs())
            {
                AddPlane.Brand = txtMarca.Text;
                AddPlane.Model = txtModelo.Text;
                AddPlane.SeatsPerRowFirstClass = (int)numericUpDownClasseEconomica.Value;
                AddPlane.SeatsPerRowEconomy = (int)numericUpDownPrimeiraClasse.Value;
                AddPlane.NumberRowsEconomy = (int)numericUpDownColunaClasseEconomica.Value;
                AddPlane.NumberRowsFirstClass = (int)numericUpDownColunasPrimeiraClasse.Value;
                CloseForm();
            }
        }

        /// <summary>
        /// check if all the user inputs are in a valid format.
        /// </summary>
        /// <returns></returns>
        public bool ValidateUserInputs()
        {
            bool isValid = true;

            if ((Regex.IsMatch(txtMarca.Text, @"^[a-zA-Z]+$")) == false || string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Insira a marca da aeronave", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if ((Regex.IsMatch(txtModelo.Text, @"^[a-zA-Z0-9-]+$")) == false || string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Insira o modelo da aeronave", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;

        }

        /// <summary>
        /// return the last Id in Planes List
        /// </summary>
        /// <param name="avioes"></param>
        /// <returns></returns>
        private int GetLastId(List<Plane> planes)
        {
            string[] getLastId = new string[5];
            if (planes.Count == 0) return 0;
            else
            {
                getLastId = (planes.LastOrDefault()!.ToString()).Split(",");
                return Convert.ToInt32(getLastId[0]);
            }
        }

        /// <summary>
        /// When close the current form open the form CRUD Plane - return page
        /// </summary>
        private void CloseForm()
        {
            _form.OpenChildForm(new CRUDPlanes(Planes, _form, Flights));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
