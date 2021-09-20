namespace ParkingSystem
{
    partial class FormMainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenConfiguration = new System.Windows.Forms.Button();
            this.btnOpenRentForm = new System.Windows.Forms.Button();
            this.btnOpenClientSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenConfiguration
            // 
            this.btnOpenConfiguration.BackColor = System.Drawing.Color.Lavender;
            this.btnOpenConfiguration.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnOpenConfiguration.Location = new System.Drawing.Point(78, 116);
            this.btnOpenConfiguration.Name = "btnOpenConfiguration";
            this.btnOpenConfiguration.Size = new System.Drawing.Size(159, 69);
            this.btnOpenConfiguration.TabIndex = 0;
            this.btnOpenConfiguration.Text = "Конфигурация стоянки";
            this.btnOpenConfiguration.UseVisualStyleBackColor = false;
            this.btnOpenConfiguration.Click += new System.EventHandler(this.btnOpenConfiguration_Click);
            // 
            // btnOpenRentForm
            // 
            this.btnOpenRentForm.BackColor = System.Drawing.Color.Lavender;
            this.btnOpenRentForm.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnOpenRentForm.Location = new System.Drawing.Point(243, 116);
            this.btnOpenRentForm.Name = "btnOpenRentForm";
            this.btnOpenRentForm.Size = new System.Drawing.Size(158, 69);
            this.btnOpenRentForm.TabIndex = 1;
            this.btnOpenRentForm.Text = "Аренда места";
            this.btnOpenRentForm.UseVisualStyleBackColor = false;
            this.btnOpenRentForm.Click += new System.EventHandler(this.btnOpenRentForm_Click);
            // 
            // btnOpenClientSearch
            // 
            this.btnOpenClientSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnOpenClientSearch.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnOpenClientSearch.Location = new System.Drawing.Point(407, 116);
            this.btnOpenClientSearch.Name = "btnOpenClientSearch";
            this.btnOpenClientSearch.Size = new System.Drawing.Size(153, 69);
            this.btnOpenClientSearch.TabIndex = 2;
            this.btnOpenClientSearch.Text = "Клиентская база";
            this.btnOpenClientSearch.UseVisualStyleBackColor = false;
            this.btnOpenClientSearch.Click += new System.EventHandler(this.btnOpenClientSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Система автомобильного паркинга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(653, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenClientSearch);
            this.Controls.Add(this.btnOpenRentForm);
            this.Controls.Add(this.btnOpenConfiguration);
            this.Name = "FormMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.FormMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenConfiguration;
        private System.Windows.Forms.Button btnOpenRentForm;
        private System.Windows.Forms.Button btnOpenClientSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

