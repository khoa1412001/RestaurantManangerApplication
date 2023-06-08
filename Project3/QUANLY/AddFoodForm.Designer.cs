
namespace Project3
{
    partial class AddFoodForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMeat = new System.Windows.Forms.TextBox();
            this.textBoxSeaFood = new System.Windows.Forms.TextBox();
            this.textBoxVeget = new System.Windows.Forms.TextBox();
            this.textBoxWater = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình ảnh minh họa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "THÊM MÓN ĂN";
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(175, 60);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(188, 22);
            this.textBoxFood.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(175, 98);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(188, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(175, 158);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(188, 126);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 6;
            this.pictureBoxFood.TabStop = false;
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(175, 308);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(188, 42);
            this.addImageButton.TabIndex = 7;
            this.addImageButton.Text = "THÊM HÌNH ẢNH";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(106, 381);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(188, 42);
            this.addFoodButton.TabIndex = 8;
            this.addFoodButton.Text = "THÊM MÓN ĂN";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(106, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "THOÁT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thịt: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hải sản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rau:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nước:";
            // 
            // textBoxMeat
            // 
            this.textBoxMeat.Location = new System.Drawing.Point(71, 126);
            this.textBoxMeat.Name = "textBoxMeat";
            this.textBoxMeat.Size = new System.Drawing.Size(45, 22);
            this.textBoxMeat.TabIndex = 15;
            this.textBoxMeat.Text = "0";
            // 
            // textBoxSeaFood
            // 
            this.textBoxSeaFood.Location = new System.Drawing.Point(175, 126);
            this.textBoxSeaFood.Name = "textBoxSeaFood";
            this.textBoxSeaFood.Size = new System.Drawing.Size(45, 22);
            this.textBoxSeaFood.TabIndex = 16;
            this.textBoxSeaFood.Text = "0";
            // 
            // textBoxVeget
            // 
            this.textBoxVeget.Location = new System.Drawing.Point(260, 126);
            this.textBoxVeget.Name = "textBoxVeget";
            this.textBoxVeget.Size = new System.Drawing.Size(45, 22);
            this.textBoxVeget.TabIndex = 17;
            this.textBoxVeget.Text = "0";
            // 
            // textBoxWater
            // 
            this.textBoxWater.Location = new System.Drawing.Point(362, 126);
            this.textBoxWater.Name = "textBoxWater";
            this.textBoxWater.Size = new System.Drawing.Size(45, 22);
            this.textBoxWater.TabIndex = 18;
            this.textBoxWater.Text = "0";
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 492);
            this.Controls.Add(this.textBoxWater);
            this.Controls.Add(this.textBoxVeget);
            this.Controls.Add(this.textBoxSeaFood);
            this.Controls.Add(this.textBoxMeat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addFoodButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFoodForm";
            this.Text = "AddFoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMeat;
        private System.Windows.Forms.TextBox textBoxSeaFood;
        private System.Windows.Forms.TextBox textBoxVeget;
        private System.Windows.Forms.TextBox textBoxWater;
    }
}