using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class FormClientSearch : Form
    {
        Manager _manager;

        public FormClientSearch(Manager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rTxtBxClientsInfo.Text = _manager.ShowClientsBySearch(cBxSearchOption.Text, txtBxClientsInfo.Text);
            rTxtBxClientsInfo.ForeColor = Color.Black;
        }

        private void btnShowDebtors_Click(object sender, EventArgs e)
        {
            rTxtBxClientsInfo.Text = _manager.ShowDebtors();
            rTxtBxClientsInfo.ForeColor = Color.IndianRed;
        }

        private void btnShowClientsBase_Click(object sender, EventArgs e)
        {
            rTxtBxClientsInfo.Text = _manager.ShowClientsBase();
            rTxtBxClientsInfo.ForeColor = Color.Black;
        }

        private void cBxSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxSearchOption.SelectedIndex == 0)
                lblHelp.Text = "(Иванов Иван Иванович)";
            else if (cBxSearchOption.SelectedIndex == 1)
                lblHelp.Text = "(Х000ХX000)";
            else if (cBxSearchOption.SelectedIndex == 2)
                lblHelp.Text = "(Введите номер в диапазоне: 0-23)";
            else
                lblHelp.Text = "";
        }

    }
}
