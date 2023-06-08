
namespace Project3.QUANLY
{
    partial class StaticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSumOfBill = new System.Windows.Forms.Label();
            this.dateTimePickerBill = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartDay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDay
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDay.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDay.Legends.Add(legend3);
            this.chartDay.Location = new System.Drawing.Point(12, 12);
            this.chartDay.Name = "chartDay";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số lượng";
            this.chartDay.Series.Add(series3);
            this.chartDay.Size = new System.Drawing.Size(572, 426);
            this.chartDay.TabIndex = 0;
            this.chartDay.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Day";
            this.chartDay.Titles.Add(title3);
            // 
            // labelSumOfBill
            // 
            this.labelSumOfBill.AutoSize = true;
            this.labelSumOfBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumOfBill.Location = new System.Drawing.Point(9, 469);
            this.labelSumOfBill.Name = "labelSumOfBill";
            this.labelSumOfBill.Size = new System.Drawing.Size(100, 18);
            this.labelSumOfBill.TabIndex = 2;
            this.labelSumOfBill.Text = "TỔNG THU:";
            // 
            // dateTimePickerBill
            // 
            this.dateTimePickerBill.Location = new System.Drawing.Point(12, 444);
            this.dateTimePickerBill.Name = "dateTimePickerBill";
            this.dateTimePickerBill.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBill.TabIndex = 3;
            this.dateTimePickerBill.ValueChanged += new System.EventHandler(this.dateTimePickerBill_ValueChanged);
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 507);
            this.Controls.Add(this.dateTimePickerBill);
            this.Controls.Add(this.labelSumOfBill);
            this.Controls.Add(this.chartDay);
            this.Name = "StaticForm";
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDay;
        private System.Windows.Forms.Label labelSumOfBill;
        private System.Windows.Forms.DateTimePicker dateTimePickerBill;
    }
}