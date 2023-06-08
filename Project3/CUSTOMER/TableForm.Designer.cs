
namespace Project3
{
    partial class TableForm
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
            this.labelSum = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.DigiClock = new System.Windows.Forms.Label();
            this.buttonMakeBill = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelTableID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(402, 501);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(51, 18);
            this.labelSum.TabIndex = 45;
            this.labelSum.Text = "Tổng:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(584, 42);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(50, 17);
            this.labelInfo.TabIndex = 42;
            this.labelInfo.Text = "Mã số:";
            // 
            // DigiClock
            // 
            this.DigiClock.AutoSize = true;
            this.DigiClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiClock.Location = new System.Drawing.Point(579, 7);
            this.DigiClock.Name = "DigiClock";
            this.DigiClock.Size = new System.Drawing.Size(67, 29);
            this.DigiClock.TabIndex = 41;
            this.DigiClock.Text = "timer";
            // 
            // buttonMakeBill
            // 
            this.buttonMakeBill.Location = new System.Drawing.Point(584, 457);
            this.buttonMakeBill.Name = "buttonMakeBill";
            this.buttonMakeBill.Size = new System.Drawing.Size(129, 41);
            this.buttonMakeBill.TabIndex = 39;
            this.buttonMakeBill.Text = "XUẤT HÓA ĐƠN";
            this.buttonMakeBill.UseVisualStyleBackColor = true;
            this.buttonMakeBill.Click += new System.EventHandler(this.buttonMakeBill_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(584, 527);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 41);
            this.exitButton.TabIndex = 38;
            this.exitButton.Text = "THOÁT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelTableID
            // 
            this.labelTableID.AutoSize = true;
            this.labelTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableID.Location = new System.Drawing.Point(8, 10);
            this.labelTableID.Name = "labelTableID";
            this.labelTableID.Size = new System.Drawing.Size(59, 20);
            this.labelTableID.TabIndex = 36;
            this.labelTableID.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownNumberOfPeople
            // 
            this.numericUpDownNumberOfPeople.Location = new System.Drawing.Point(658, 422);
            this.numericUpDownNumberOfPeople.Name = "numericUpDownNumberOfPeople";
            this.numericUpDownNumberOfPeople.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownNumberOfPeople.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Số người:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 465);
            this.dataGridView1.TabIndex = 48;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(449, 527);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 41);
            this.buttonDelete.TabIndex = 49;
            this.buttonDelete.Text = "XÓA";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 576);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDownNumberOfPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.DigiClock);
            this.Controls.Add(this.buttonMakeBill);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelTableID);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label DigiClock;
        private System.Windows.Forms.Button buttonMakeBill;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelTableID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
    }
}