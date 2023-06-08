
namespace Project3
{
    partial class ManagerForm
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
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonIngrediant = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxWater = new System.Windows.Forms.TextBox();
            this.textBoxVeget = new System.Windows.Forms.TextBox();
            this.textBoxSeaFood = new System.Windows.Forms.TextBox();
            this.textBoxMeat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateFood = new System.Windows.Forms.Button();
            this.addImageButton = new System.Windows.Forms.Button();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.textBoxSearchMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControlManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPage1);
            this.tabControlManager.Controls.Add(this.tabPage2);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(913, 477);
            this.tabControlManager.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSearchEmployee);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NHÂN VIÊN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(80, 18);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(239, 22);
            this.textBoxSearchEmployee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.cmnd,
            this.hoNV,
            this.tenNV,
            this.gioitinh,
            this.ngaysinh,
            this.sdt,
            this.diachi,
            this.luong,
            this.chucvu,
            this.hinhanh});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(893, 384);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonIngrediant);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.textBoxWater);
            this.tabPage2.Controls.Add(this.textBoxVeget);
            this.tabPage2.Controls.Add(this.textBoxSeaFood);
            this.tabPage2.Controls.Add(this.textBoxMeat);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonUpdateFood);
            this.tabPage2.Controls.Add(this.addImageButton);
            this.tabPage2.Controls.Add(this.pictureBoxFood);
            this.tabPage2.Controls.Add(this.textBoxPrice);
            this.tabPage2.Controls.Add(this.textBoxFood);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.addFoodButton);
            this.tabPage2.Controls.Add(this.textBoxSearchMenu);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewMenu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "THỰC ĐƠN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonIngrediant
            // 
            this.buttonIngrediant.Location = new System.Drawing.Point(482, 19);
            this.buttonIngrediant.Name = "buttonIngrediant";
            this.buttonIngrediant.Size = new System.Drawing.Size(196, 23);
            this.buttonIngrediant.TabIndex = 36;
            this.buttonIngrediant.Text = "NHẬP NGUYÊN LIỆU";
            this.buttonIngrediant.UseVisualStyleBackColor = true;
            this.buttonIngrediant.Click += new System.EventHandler(this.buttonIngrediant_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(517, 391);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(188, 42);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "XÓA";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxWater
            // 
            this.textBoxWater.Location = new System.Drawing.Point(820, 170);
            this.textBoxWater.Name = "textBoxWater";
            this.textBoxWater.Size = new System.Drawing.Size(45, 22);
            this.textBoxWater.TabIndex = 34;
            this.textBoxWater.Text = "0";
            // 
            // textBoxVeget
            // 
            this.textBoxVeget.Location = new System.Drawing.Point(718, 170);
            this.textBoxVeget.Name = "textBoxVeget";
            this.textBoxVeget.Size = new System.Drawing.Size(45, 22);
            this.textBoxVeget.TabIndex = 33;
            this.textBoxVeget.Text = "0";
            // 
            // textBoxSeaFood
            // 
            this.textBoxSeaFood.Location = new System.Drawing.Point(633, 170);
            this.textBoxSeaFood.Name = "textBoxSeaFood";
            this.textBoxSeaFood.Size = new System.Drawing.Size(45, 22);
            this.textBoxSeaFood.TabIndex = 32;
            this.textBoxSeaFood.Text = "0";
            // 
            // textBoxMeat
            // 
            this.textBoxMeat.Location = new System.Drawing.Point(529, 170);
            this.textBoxMeat.Name = "textBoxMeat";
            this.textBoxMeat.Size = new System.Drawing.Size(45, 22);
            this.textBoxMeat.TabIndex = 31;
            this.textBoxMeat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(769, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nước:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rau:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hải sản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Thịt: ";
            // 
            // buttonUpdateFood
            // 
            this.buttonUpdateFood.Location = new System.Drawing.Point(711, 391);
            this.buttonUpdateFood.Name = "buttonUpdateFood";
            this.buttonUpdateFood.Size = new System.Drawing.Size(188, 42);
            this.buttonUpdateFood.TabIndex = 26;
            this.buttonUpdateFood.Text = "CHỈNH SỬA";
            this.buttonUpdateFood.UseVisualStyleBackColor = true;
            this.buttonUpdateFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(633, 334);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(188, 42);
            this.addImageButton.TabIndex = 25;
            this.addImageButton.Text = "THÊM HÌNH ẢNH";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(633, 202);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(188, 126);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 24;
            this.pictureBoxFood.TabStop = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(633, 142);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(188, 22);
            this.textBoxPrice.TabIndex = 23;
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(633, 104);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(188, 22);
            this.textBoxFood.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hình ảnh minh họa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên món ăn:";
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(325, 19);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(151, 23);
            this.addFoodButton.TabIndex = 4;
            this.addFoodButton.Text = "THÊM MÓN ĂN";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // textBoxSearchMenu
            // 
            this.textBoxSearchMenu.Location = new System.Drawing.Point(80, 19);
            this.textBoxSearchMenu.Name = "textBoxSearchMenu";
            this.textBoxSearchMenu.Size = new System.Drawing.Size(239, 22);
            this.textBoxSearchMenu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm:";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(470, 384);
            this.dataGridViewMenu.TabIndex = 1;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(783, 491);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(132, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "LÀM MỚI";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "Căn cước công dân";
            this.cmnd.MinimumWidth = 6;
            this.cmnd.Name = "cmnd";
            this.cmnd.Width = 125;
            // 
            // hoNV
            // 
            this.hoNV.DataPropertyName = "hoNV";
            this.hoNV.HeaderText = "Họ";
            this.hoNV.MinimumWidth = 6;
            this.hoNV.Name = "hoNV";
            this.hoNV.Width = 125;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.Width = 125;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            this.chucvu.Width = 125;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "hinhanh";
            this.hinhanh.HeaderText = "Hình ảnh";
            this.hinhanh.MinimumWidth = 6;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hinhanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hinhanh.Width = 125;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 521);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.tabControlManager);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControlManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textBoxSearchMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxWater;
        private System.Windows.Forms.TextBox textBoxVeget;
        private System.Windows.Forms.TextBox textBoxSeaFood;
        private System.Windows.Forms.TextBox textBoxMeat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdateFood;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonIngrediant;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
    }
}