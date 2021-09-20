using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class FormConfiguration : Form
    {
        Manager _manager;
        Button[] _placess = new Button[24];

        public FormConfiguration(Manager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {            
            AddPlacesToSystem();
            chBxShowFreeSpaces.Checked = true;
        }

        private void btnShowConfiguration_Click(object sender, EventArgs e)
        {
            FormParkingInfo newForm = new FormParkingInfo(_manager, "ParkingConfiguration");
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void btnShowPlaceConfiguration_Click(object sender, EventArgs e)
        {
            FormParkingInfo newForm = new FormParkingInfo(_manager, CheckedSpaceNumber());
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private string CheckedSpaceNumber()
        {            
            int index=0;
            foreach (Button place in _placess)
                if (place.Focused)
                    index = place.TabIndex;
            return (index).ToString();
        }

        private void chBxShowFreeSpaces_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxShowFreeSpaces.Checked)
                ShowFreeSpaces();
            else
                foreach (Button place in _placess)
                    place.BackColor = Color.White;
        }

        public void ShowFreeSpaces()
        {
            for (int i = 0; i <= 23; i++)
            {
                if (_manager.SpaceIsFree(i.ToString()))
                    _placess[i].BackColor = Color.SpringGreen;
                else _placess[i].BackColor = Color.Red;
            }
        }

        private void AddPlacesToSystem()
        {
            for (int index = 0; index <= 23; index++)
                _placess[index] = Controls["btnSpace" + index.ToString()] as Button;                        
        }

        private void FormConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMainPage parent = this.Owner as FormMainPage;
            if (parent != null)
            {
                parent.ShowSpacesAmount();
            }
        }
    }
}
