
namespace Project3
{
    partial class MainForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.checkinButton = new System.Windows.Forms.Button();
            this.checkCalButton = new System.Windows.Forms.Button();
            this.calManagerButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.DigiClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDeleteBill = new System.Windows.Forms.Button();
            this.buttonStatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(634, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "THOÁT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.Location = new System.Drawing.Point(634, 54);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(129, 41);
            this.informationButton.TabIndex = 3;
            this.informationButton.Text = "THÔNG TIN ";
            this.informationButton.UseVisualStyleBackColor = true;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(635, 114);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(129, 41);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "ĐĂNG KÝ";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(636, 233);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(129, 41);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "CHECK-OUT";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(634, 173);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(129, 41);
            this.checkinButton.TabIndex = 6;
            this.checkinButton.Text = "CHECK-IN";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // checkCalButton
            // 
            this.checkCalButton.Location = new System.Drawing.Point(282, 7);
            this.checkCalButton.Name = "checkCalButton";
            this.checkCalButton.Size = new System.Drawing.Size(129, 41);
            this.checkCalButton.TabIndex = 7;
            this.checkCalButton.Text = "XEM CA";
            this.checkCalButton.UseVisualStyleBackColor = true;
            this.checkCalButton.Click += new System.EventHandler(this.checkCalButton_Click);
            // 
            // calManagerButton
            // 
            this.calManagerButton.Location = new System.Drawing.Point(147, 7);
            this.calManagerButton.Name = "calManagerButton";
            this.calManagerButton.Size = new System.Drawing.Size(129, 41);
            this.calManagerButton.TabIndex = 8;
            this.calManagerButton.Text = "CA LÀM";
            this.calManagerButton.UseVisualStyleBackColor = true;
            this.calManagerButton.Click += new System.EventHandler(this.calManagerButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.Location = new System.Drawing.Point(12, 7);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(129, 41);
            this.managerButton.TabIndex = 9;
            this.managerButton.Text = "QUẢN LÝ";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(636, 294);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(129, 41);
            this.changePasswordButton.TabIndex = 10;
            this.changePasswordButton.Text = "ĐỔI MẬT KHẨU";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // DigiClock
            // 
            this.DigiClock.AutoSize = true;
            this.DigiClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiClock.Location = new System.Drawing.Point(644, 19);
            this.DigiClock.Name = "DigiClock";
            this.DigiClock.Size = new System.Drawing.Size(67, 29);
            this.DigiClock.TabIndex = 11;
            this.DigiClock.Text = "timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(12, 444);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(129, 41);
            this.buttonAddTable.TabIndex = 13;
            this.buttonAddTable.Text = "THÊM BÀN";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(616, 384);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // buttonDeleteBill
            // 
            this.buttonDeleteBill.Location = new System.Drawing.Point(147, 444);
            this.buttonDeleteBill.Name = "buttonDeleteBill";
            this.buttonDeleteBill.Size = new System.Drawing.Size(129, 41);
            this.buttonDeleteBill.TabIndex = 15;
            this.buttonDeleteBill.Text = "XÓA BILL";
            this.buttonDeleteBill.UseVisualStyleBackColor = true;
            this.buttonDeleteBill.Click += new System.EventHandler(this.buttonDeleteBill_Click);
            // 
            // buttonStatic
            // 
            this.buttonStatic.Location = new System.Drawing.Point(636, 354);
            this.buttonStatic.Name = "buttonStatic";
            this.buttonStatic.Size = new System.Drawing.Size(128, 44);
            this.buttonStatic.TabIndex = 16;
            this.buttonStatic.Text = "THỐNG KÊ";
            this.buttonStatic.UseVisualStyleBackColor = true;
            this.buttonStatic.Click += new System.EventHandler(this.buttonStatic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 496);
            this.Controls.Add(this.buttonStatic);
            this.Controls.Add(this.buttonDeleteBill);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.DigiClock);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.calManagerButton);
            this.Controls.Add(this.checkCalButton);
            this.Controls.Add(this.checkinButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.exitButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button checkCalButton;
        private System.Windows.Forms.Button calManagerButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label DigiClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDeleteBill;
        private System.Windows.Forms.Button buttonStatic;
    }
}