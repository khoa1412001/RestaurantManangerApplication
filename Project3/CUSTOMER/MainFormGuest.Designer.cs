
namespace Project3
{
    partial class MainFormGuest
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
            this.components = new System.ComponentModel.Container();
            this.labelTableID = new System.Windows.Forms.Label();
            this.buttonSelectTable = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DigiClock = new System.Windows.Forms.Label();
            this.checkinButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTableID
            // 
            this.labelTableID.AutoSize = true;
            this.labelTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableID.Location = new System.Drawing.Point(12, 9);
            this.labelTableID.Name = "labelTableID";
            this.labelTableID.Size = new System.Drawing.Size(59, 20);
            this.labelTableID.TabIndex = 0;
            this.labelTableID.Text = "label1";
            // 
            // buttonSelectTable
            // 
            this.buttonSelectTable.Location = new System.Drawing.Point(97, 6);
            this.buttonSelectTable.Name = "buttonSelectTable";
            this.buttonSelectTable.Size = new System.Drawing.Size(97, 29);
            this.buttonSelectTable.TabIndex = 1;
            this.buttonSelectTable.Text = "CHỌN BÀN";
            this.buttonSelectTable.UseVisualStyleBackColor = true;
            this.buttonSelectTable.Click += new System.EventHandler(this.buttonSelectTable_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // DigiClock
            // 
            this.DigiClock.AutoSize = true;
            this.DigiClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiClock.Location = new System.Drawing.Point(583, 6);
            this.DigiClock.Name = "DigiClock";
            this.DigiClock.Size = new System.Drawing.Size(67, 29);
            this.DigiClock.TabIndex = 24;
            this.DigiClock.Text = "timer";
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(588, 409);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(129, 41);
            this.checkinButton.TabIndex = 19;
            this.checkinButton.Text = "CHECK-IN";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(588, 456);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(129, 41);
            this.checkoutButton.TabIndex = 18;
            this.checkoutButton.Text = "THANH TOÁN";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(588, 526);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 41);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "THOÁT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(588, 41);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(50, 17);
            this.labelInfo.TabIndex = 28;
            this.labelInfo.Text = "Mã số:";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(588, 362);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(129, 41);
            this.buttonOrder.TabIndex = 29;
            this.buttonOrder.Text = "GỌI MÓN";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 456);
            this.dataGridView1.TabIndex = 30;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(458, 500);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(51, 18);
            this.labelSum.TabIndex = 33;
            this.labelSum.Text = "Tổng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Số người:";
            // 
            // numericUpDownNumberOfPeople
            // 
            this.numericUpDownNumberOfPeople.Location = new System.Drawing.Point(659, 329);
            this.numericUpDownNumberOfPeople.Name = "numericUpDownNumberOfPeople";
            this.numericUpDownNumberOfPeople.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownNumberOfPeople.TabIndex = 35;
            // 
            // MainFormGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 577);
            this.Controls.Add(this.numericUpDownNumberOfPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.DigiClock);
            this.Controls.Add(this.checkinButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonSelectTable);
            this.Controls.Add(this.labelTableID);
            this.Name = "MainFormGuest";
            this.Text = "MainFormGuest";
            this.Load += new System.EventHandler(this.MainFormGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTableID;
        private System.Windows.Forms.Button buttonSelectTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DigiClock;
        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfPeople;
    }
}