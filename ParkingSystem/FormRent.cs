using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class FormRent : Form
    {
        Manager _manager;
        public FormRent(Manager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private void txtBxParkingSpaceNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBxParkingSpaceNumber != null && txtBxParkingSpaceNumber.Text != "")
            {
                if (Convert.ToInt64(txtBxParkingSpaceNumber.Text) >= 0 && Convert.ToInt64(txtBxParkingSpaceNumber.Text) < 24)
                {
                    if (_manager.SpaceIsFree(txtBxParkingSpaceNumber.Text))
                    {
                        txtBxParkingSpaceNumber.BackColor = Color.White;
                        btnCalculateCost.Enabled = true;
                        return;
                    }
                }                
            }
            CalculateCostIsNotEnabled();
        }

        void CalculateCostIsNotEnabled()
        {
            txtBxParkingSpaceNumber.BackColor = Color.IndianRed;
            btnCalculateCost.Enabled = false;
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            txtBxTotalDue.Text = _manager.CalculateTotalDue(txtBxParkingSpaceNumber.Text, cBxDiscountCard.Text , txtbxFIO.Text);
            btnOrder.Enabled = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (AllDataIsEntered())
            {
                _manager.MakingOrder(txtbxFIO.Text, txtBxCarNumber.Text, txtbxMark.Text, txtBxParkingSpaceNumber.Text, txtBxLeaseTerm.Value, cBxDiscountCard.Text);
                MessageBox.Show("Бронь места оформлена. \nВы должны выехать до: " + txtBxLeaseTerm.Value.ToLongDateString());
                AllDataClear();                
            }
            else
                MessageBox.Show("УПС! Какие-то данные введены некорректно.\n\nДля оформления заказа:\n1)Проверьте корректность всех введенных данных\n2)Подберите правильную дату\n3)Выберете для парковки свободное место\n\n(Текущую конфигурацию паркинга можно посмотреть в разделе \"Конфигурация\")");
        }

        bool AllDataIsEntered()
        {
            return txtbxFIO.TextLength > 0
                && txtBxCarNumber.TextLength > 0
                && txtbxMark.TextLength > 0
                && txtBxLeaseTerm.Value.Date >= DateTime.Now.Date
                && txtBxParkingSpaceNumber.TextLength > 0
                && cBxDiscountCard.SelectedIndex > -1
                && _manager.SpaceIsFree(txtBxParkingSpaceNumber.Text);
        }

        void AllDataClear()
        {
            txtbxFIO.Text = null;
            txtBxCarNumber.Text = null;
            txtbxMark.Text = null;
            txtBxLeaseTerm.Text = null;
            txtBxParkingSpaceNumber.Text = null;
            txtBxParkingSpaceNumber.BackColor = Color.White;
            cBxDiscountCard.SelectedIndex = 0;
            txtBxTotalDue.Text = "";
            btnOrder.Enabled = false;
        }

        private void FormRent_Load(object sender, EventArgs e)
        {
            btnCalculateCost.Enabled = false;
            btnOrder.Enabled = false;
        }

        private void FormRent_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMainPage parent = this.Owner as FormMainPage;
            if (parent != null)
            {
                parent.ShowSpacesAmount();
            }
        }
    }
}
