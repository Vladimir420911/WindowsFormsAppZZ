namespace WindowsFormsApp1
{
    partial class ReportForm
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
            this.EmployeeReportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenueReportButton = new System.Windows.Forms.Button();
            this.DateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.DateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.ReportTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeReportButton
            // 
            this.EmployeeReportButton.Location = new System.Drawing.Point(138, 289);
            this.EmployeeReportButton.Name = "EmployeeReportButton";
            this.EmployeeReportButton.Size = new System.Drawing.Size(111, 23);
            this.EmployeeReportButton.TabIndex = 26;
            this.EmployeeReportButton.Text = "Рейтинг мастеров";
            this.EmployeeReportButton.UseVisualStyleBackColor = true;
            this.EmployeeReportButton.Click += new System.EventHandler(this.EmployeeReportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Конечная дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Начальная дата";
            // 
            // RevenueReportButton
            // 
            this.RevenueReportButton.Location = new System.Drawing.Point(12, 289);
            this.RevenueReportButton.Name = "RevenueReportButton";
            this.RevenueReportButton.Size = new System.Drawing.Size(111, 23);
            this.RevenueReportButton.TabIndex = 23;
            this.RevenueReportButton.Text = "Отчет по доходам";
            this.RevenueReportButton.UseVisualStyleBackColor = true;
            this.RevenueReportButton.Click += new System.EventHandler(this.RevenueReportButton_Click);
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.Location = new System.Drawing.Point(138, 253);
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.Size = new System.Drawing.Size(111, 20);
            this.DateTimeEnd.TabIndex = 22;
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.Location = new System.Drawing.Point(12, 253);
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.Size = new System.Drawing.Size(111, 20);
            this.DateTimeStart.TabIndex = 21;
            // 
            // ReportTable
            // 
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Location = new System.Drawing.Point(12, 12);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.Size = new System.Drawing.Size(742, 197);
            this.ReportTable.TabIndex = 27;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 370);
            this.Controls.Add(this.ReportTable);
            this.Controls.Add(this.EmployeeReportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RevenueReportButton);
            this.Controls.Add(this.DateTimeEnd);
            this.Controls.Add(this.DateTimeStart);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeReportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RevenueReportButton;
        private System.Windows.Forms.DateTimePicker DateTimeEnd;
        private System.Windows.Forms.DateTimePicker DateTimeStart;
        private System.Windows.Forms.DataGridView ReportTable;
    }
}