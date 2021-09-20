namespace ParkingSystem
{
    partial class FormClientSearch
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
            this.label16 = new System.Windows.Forms.Label();
            this.rTxtBxClientsInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowDebtors = new System.Windows.Forms.Button();
            this.cBxSearchOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxClientsInfo = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label16.Location = new System.Drawing.Point(48, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 23);
            this.label16.TabIndex = 66;
            this.label16.Text = "Осуществить поиск с помощью:";
            // 
            // rTxtBxClientsInfo
            // 
            this.rTxtBxClientsInfo.BackColor = System.Drawing.Color.White;
            this.rTxtBxClientsInfo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTxtBxClientsInfo.Location = new System.Drawing.Point(54, 253);
            this.rTxtBxClientsInfo.Name = "rTxtBxClientsInfo";
            this.rTxtBxClientsInfo.ReadOnly = true;
            this.rTxtBxClientsInfo.Size = new System.Drawing.Size(541, 124);
            this.rTxtBxClientsInfo.TabIndex = 60;
            this.rTxtBxClientsInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.label2.Location = new System.Drawing.Point(179, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Информация о клиентах:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnSearch.Location = new System.Drawing.Point(53, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(541, 38);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Поиск данных";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowDebtors
            // 
            this.btnShowDebtors.BackColor = System.Drawing.Color.Lavender;
            this.btnShowDebtors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowDebtors.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnShowDebtors.Location = new System.Drawing.Point(54, 394);
            this.btnShowDebtors.Name = "btnShowDebtors";
            this.btnShowDebtors.Size = new System.Drawing.Size(228, 38);
            this.btnShowDebtors.TabIndex = 73;
            this.btnShowDebtors.Text = "Информация о должниках";
            this.btnShowDebtors.UseVisualStyleBackColor = false;
            this.btnShowDebtors.Click += new System.EventHandler(this.btnShowDebtors_Click);
            // 
            // cBxSearchOption
            // 
            this.cBxSearchOption.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.cBxSearchOption.FormattingEnabled = true;
            this.cBxSearchOption.Items.AddRange(new object[] {
            "ФИО",
            "Номер машины",
            "Номер арендованного места"});
            this.cBxSearchOption.Location = new System.Drawing.Point(52, 101);
            this.cBxSearchOption.Name = "cBxSearchOption";
            this.cBxSearchOption.Size = new System.Drawing.Size(288, 27);
            this.cBxSearchOption.TabIndex = 70;
            this.cBxSearchOption.SelectedIndexChanged += new System.EventHandler(this.cBxSearchOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(50, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Введите данные о клиенте:";
            // 
            // txtBxClientsInfo
            // 
            this.txtBxClientsInfo.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txtBxClientsInfo.Location = new System.Drawing.Point(54, 166);
            this.txtBxClientsInfo.Name = "txtBxClientsInfo";
            this.txtBxClientsInfo.Size = new System.Drawing.Size(540, 27);
            this.txtBxClientsInfo.TabIndex = 71;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.lblHelp.Location = new System.Drawing.Point(341, 103);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(0, 19);
            this.lblHelp.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.button1.Location = new System.Drawing.Point(367, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 38);
            this.button1.TabIndex = 75;
            this.button1.Text = "Полная Клиентская база";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnShowClientsBase_Click);
            // 
            // FormClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(653, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtBxClientsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxSearchOption);
            this.Controls.Add(this.btnShowDebtors);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rTxtBxClientsInfo);
            this.Controls.Add(this.label2);
            this.Name = "FormClientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиентская База";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rTxtBxClientsInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowDebtors;
        private System.Windows.Forms.ComboBox cBxSearchOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxClientsInfo;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button button1;
    }
}