using System;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class FormParkingInfo : Form
    {
        Manager _manager;
        string _objectToShow;

        public FormParkingInfo(Manager manager, string objectToShow)
        {
            _manager = manager;
            _objectToShow = objectToShow;
            InitializeComponent();
        }

        private void FormParkingInfo_Load(object sender, EventArgs e)
        {
            if (_objectToShow == "ParkingConfiguration")
                ShowConfiguration();            
            else
                ShowSpaceConfiguration(_objectToShow);
        }

        void ShowConfiguration()
        {
            for (int i = 0; i < 24; i++)
                ShowSpaceConfiguration(i.ToString());
        }

        void ShowSpaceConfiguration(string spaceNumber)
        {
            ListViewItem lvItem = new ListViewItem(_manager.GetConfigurationOf(spaceNumber));
            lvParkingConfiguration.Items.Add(lvItem);
        }

        private void btnShowClientsInfo_Click(object sender, EventArgs e)
        {
            if (lvParkingConfiguration.SelectedItems.Count == 0) return;
            string spaceNumber = lvParkingConfiguration.SelectedItems[0].SubItems[0].Text;
            string info = _manager.ShowClientsBySearch("Номер арендованного места", spaceNumber);
            MessageBox.Show(info);
        }

        private void btnMakeSpaceFree_Click(object sender, EventArgs e)
        {
            if (lvParkingConfiguration.SelectedItems.Count != 0)
                if (lvParkingConfiguration.SelectedItems[0].SubItems[1].Text == "Занято")
                {
                    string spaceNumber = lvParkingConfiguration.SelectedItems[0].SubItems[0].Text;
                    _manager.RemoveClientFromSpace(spaceNumber);
                    lvParkingConfiguration.SelectedItems[0].SubItems[1].Text = "Свободно";
                }                   
        }

        private void FormParkingInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormConfiguration parent = this.Owner as FormConfiguration;
            if (parent != null)
            {
                parent.ShowFreeSpaces();
            }
        }
    }
}
