namespace ParkingSystem
{
    partial class FormRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtBxCarNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cBxDiscountCard = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbxMark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxFIO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxTotalDue = new System.Windows.Forms.TextBox();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxParkingSpaceNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtBxLeaseTerm = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Lavender;
            this.btnOrder.Enabled = false;
            this.btnOrder.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnOrder.Location = new System.Drawing.Point(93, 538);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(256, 38);
            this.btnOrder.TabIndex = 82;
            this.btnOrder.Text = "Оформить заказ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtBxCarNumber
            // 
            this.txtBxCarNumber.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtBxCarNumber.Location = new System.Drawing.Point(233, 177);
            this.txtBxCarNumber.Name = "txtBxCarNumber";
            this.txtBxCarNumber.Size = new System.Drawing.Size(134, 27);
            this.txtBxCarNumber.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label13.Location = new System.Drawing.Point(74, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 94;
            this.label13.Text = "Выезд до:";
            // 
            // cBxDiscountCard
            // 
            this.cBxDiscountCard.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.cBxDiscountCard.FormattingEnabled = true;
            this.cBxDiscountCard.Items.AddRange(new object[] {
            "Да! Оформляем",
            "Нет, спасибо",
            "Уже есть дисконтная карта"});
            this.cBxDiscountCard.Location = new System.Drawing.Point(94, 389);
            this.cBxDiscountCard.Name = "cBxDiscountCard";
            this.cBxDiscountCard.Size = new System.Drawing.Size(257, 25);
            this.cBxDiscountCard.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(128, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 46);
            this.label10.TabIndex = 92;
            this.label10.Text = "ОФОРМЛЯЕМ \r\nДИСКОНТНУЮ КАРТУ?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label11.Location = new System.Drawing.Point(73, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 91;
            this.label11.Text = "Марка:";
            // 
            // txtbxMark
            // 
            this.txtbxMark.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtbxMark.Location = new System.Drawing.Point(77, 177);
            this.txtbxMark.Name = "txtbxMark";
            this.txtbxMark.Size = new System.Drawing.Size(142, 27);
            this.txtbxMark.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(229, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 89;
            this.label7.Text = "Номер машины:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(74, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 23);
            this.label8.TabIndex = 88;
            this.label8.Text = "ФИО: (Иванов Иван Иванович)";
            // 
            // txtbxFIO
            // 
            this.txtbxFIO.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtbxFIO.Location = new System.Drawing.Point(77, 120);
            this.txtbxFIO.Name = "txtbxFIO";
            this.txtbxFIO.Size = new System.Drawing.Size(290, 27);
            this.txtbxFIO.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(244, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 86;
            this.label9.Text = "Номер места:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 102;
            // 
            // txtBxTotalDue
            // 
            this.txtBxTotalDue.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBxTotalDue.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtBxTotalDue.Location = new System.Drawing.Point(95, 488);
            this.txtBxTotalDue.Name = "txtBxTotalDue";
            this.txtBxTotalDue.ReadOnly = true;
            this.txtBxTotalDue.Size = new System.Drawing.Size(255, 27);
            this.txtBxTotalDue.TabIndex = 93;
            this.txtBxTotalDue.Text = "Итого к оплате:";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.BackColor = System.Drawing.Color.Lavender;
            this.btnCalculateCost.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnCalculateCost.Location = new System.Drawing.Point(94, 439);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(259, 38);
            this.btnCalculateCost.TabIndex = 82;
            this.btnCalculateCost.Text = "Посчитать стоимость";
            this.btnCalculateCost.UseVisualStyleBackColor = false;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.label2.Location = new System.Drawing.Point(55, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 32);
            this.label2.TabIndex = 100;
            this.label2.Text = "Аренда парковочного места";
            // 
            // txtBxParkingSpaceNumber
            // 
            this.txtBxParkingSpaceNumber.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtBxParkingSpaceNumber.Location = new System.Drawing.Point(247, 292);
            this.txtBxParkingSpaceNumber.Mask = "00";
            this.txtBxParkingSpaceNumber.Name = "txtBxParkingSpaceNumber";
            this.txtBxParkingSpaceNumber.Size = new System.Drawing.Size(120, 27);
            this.txtBxParkingSpaceNumber.TabIndex = 91;
            this.txtBxParkingSpaceNumber.ValidatingType = typeof(int);
            this.txtBxParkingSpaceNumber.TextChanged += new System.EventHandler(this.txtBxParkingSpaceNumber_TextChanged);
            // 
            // txtBxLeaseTerm
            // 
            this.txtBxLeaseTerm.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtBxLeaseTerm.Location = new System.Drawing.Point(77, 293);
            this.txtBxLeaseTerm.Name = "txtBxLeaseTerm";
            this.txtBxLeaseTerm.Size = new System.Drawing.Size(157, 27);
            this.txtBxLeaseTerm.TabIndex = 90;
            // 
            // FormRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 615);
            this.Controls.Add(this.txtBxLeaseTerm);
            this.Controls.Add(this.txtBxParkingSpaceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtBxCarNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cBxDiscountCard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbxMark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxFIO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxTotalDue);
            this.Controls.Add(this.btnCalculateCost);
            this.Name = "FormRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRent_FormClosing);
            this.Load += new System.EventHandler(this.FormRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtBxCarNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBxDiscountCard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbxMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxFIO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBxTotalDue;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBxParkingSpaceNumber;
        private System.Windows.Forms.DateTimePicker txtBxLeaseTerm;
    }
}