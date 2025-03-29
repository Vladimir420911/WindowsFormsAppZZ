namespace WindowsFormsApp1
{
    partial class AppointmentForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MasterComboBox = new System.Windows.Forms.ComboBox();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(24, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(115, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(24, 80);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(115, 21);
            this.ServiceComboBox.TabIndex = 2;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Услуга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // MasterComboBox
            // 
            this.MasterComboBox.FormattingEnabled = true;
            this.MasterComboBox.Location = new System.Drawing.Point(24, 173);
            this.MasterComboBox.Name = "MasterComboBox";
            this.MasterComboBox.Size = new System.Drawing.Size(115, 21);
            this.MasterComboBox.TabIndex = 6;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.DecimalPlaces = 2;
            this.PriceNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PriceNumericUpDown.Location = new System.Drawing.Point(24, 129);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.ReadOnly = true;
            this.PriceNumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.PriceNumericUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мастер";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(182, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(182, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 305);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.MasterComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MasterComboBox;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}