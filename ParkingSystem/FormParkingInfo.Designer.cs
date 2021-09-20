namespace ParkingSystem
{
    partial class FormParkingInfo
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
            this.lvParkingConfiguration = new System.Windows.Forms.ListView();
            this.spaceNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spaceCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleCathegory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forDisabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowClientsInfo = new System.Windows.Forms.Button();
            this.btnMakeSpaceFree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvParkingConfiguration
            // 
            this.lvParkingConfiguration.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spaceNumber,
            this.spaceCondition,
            this.vehicleCathegory,
            this.price,
            this.forDisabled});
            this.lvParkingConfiguration.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.lvParkingConfiguration.FullRowSelect = true;
            this.lvParkingConfiguration.GridLines = true;
            this.lvParkingConfiguration.Location = new System.Drawing.Point(32, 23);
            this.lvParkingConfiguration.Name = "lvParkingConfiguration";
            this.lvParkingConfiguration.Size = new System.Drawing.Size(545, 201);
            this.lvParkingConfiguration.TabIndex = 4;
            this.lvParkingConfiguration.UseCompatibleStateImageBehavior = false;
            this.lvParkingConfiguration.View = System.Windows.Forms.View.Details;
            // 
            // spaceNumber
            // 
            this.spaceNumber.Text = "№";
            this.spaceNumber.Width = 33;
            // 
            // spaceCondition
            // 
            this.spaceCondition.Text = "Состояние";
            this.spaceCondition.Width = 91;
            // 
            // vehicleCathegory
            // 
            this.vehicleCathegory.Text = "Категория";
            this.vehicleCathegory.Width = 97;
            // 
            // price
            // 
            this.price.Text = "Цена";
            this.price.Width = 78;
            // 
            // forDisabled
            // 
            this.forDisabled.Text = "Льготы";
            this.forDisabled.Width = 100;
            // 
            // btnShowClientsInfo
            // 
            this.btnShowClientsInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnShowClientsInfo.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnShowClientsInfo.Location = new System.Drawing.Point(32, 244);
            this.btnShowClientsInfo.Name = "btnShowClientsInfo";
            this.btnShowClientsInfo.Size = new System.Drawing.Size(245, 35);
            this.btnShowClientsInfo.TabIndex = 5;
            this.btnShowClientsInfo.Text = "Вывести данные о клиенте";
            this.btnShowClientsInfo.UseVisualStyleBackColor = false;
            this.btnShowClientsInfo.Click += new System.EventHandler(this.btnShowClientsInfo_Click);
            // 
            // btnMakeSpaceFree
            // 
            this.btnMakeSpaceFree.BackColor = System.Drawing.Color.Lavender;
            this.btnMakeSpaceFree.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btnMakeSpaceFree.Location = new System.Drawing.Point(332, 244);
            this.btnMakeSpaceFree.Name = "btnMakeSpaceFree";
            this.btnMakeSpaceFree.Size = new System.Drawing.Size(245, 35);
            this.btnMakeSpaceFree.TabIndex = 6;
            this.btnMakeSpaceFree.Text = "Освободить место";
            this.btnMakeSpaceFree.UseVisualStyleBackColor = false;
            this.btnMakeSpaceFree.Click += new System.EventHandler(this.btnMakeSpaceFree_Click);
            // 
            // FormParkingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(624, 303);
            this.Controls.Add(this.btnMakeSpaceFree);
            this.Controls.Add(this.btnShowClientsInfo);
            this.Controls.Add(this.lvParkingConfiguration);
            this.Name = "FormParkingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParkingInfo_FormClosing);
            this.Load += new System.EventHandler(this.FormParkingInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvParkingConfiguration;
        private System.Windows.Forms.ColumnHeader spaceNumber;
        private System.Windows.Forms.ColumnHeader spaceCondition;
        private System.Windows.Forms.ColumnHeader vehicleCathegory;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader forDisabled;
        private System.Windows.Forms.Button btnShowClientsInfo;
        private System.Windows.Forms.Button btnMakeSpaceFree;
    }
}