using System;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class FormMainPage : Form
    {
        Manager _manager;
        public FormMainPage(Manager manager)
        {
            _manager = manager;
            InitializeComponent();
            _manager.LoadParkingDatabase();
            label2.Text = GetAmountOfFreeSpaces();
        }


        private void btnOpenConfiguration_Click(object sender, EventArgs e)
        {
            FormConfiguration newForm = new FormConfiguration(_manager);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void btnOpenRentForm_Click(object sender, EventArgs e)
        {
            FormRent newForm = new FormRent(_manager);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void btnOpenClientSearch_Click_1(object sender, EventArgs e)
        {
            FormClientSearch newForm = new FormClientSearch(_manager);
            newForm.ShowDialog();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {
            _manager.LoadParkingDatabase();
            label2.Text = GetAmountOfFreeSpaces();
        }

        string GetAmountOfFreeSpaces()
        {
            string info = "Количество свободных мест: " + _manager.GetAmountOfFreeSpaces();
            info += "\nзанято мест: " + (24 - _manager.GetAmountOfFreeSpaces());
            return info;
        }

        public void ShowSpacesAmount()
        {
            label2.Text = GetAmountOfFreeSpaces();
        }
    }
}
