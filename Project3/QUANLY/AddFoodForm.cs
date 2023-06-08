using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class AddFoodForm : Form
    {
        Food food = new Food();
        public AddFoodForm()
        {
            InitializeComponent();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxFood.Image = Image.FromFile(opf.FileName);
            }
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            string Food = textBoxFood.Text;
            int Price = Convert.ToInt32(textBoxPrice.Text);
            MemoryStream hinhanh = new MemoryStream();
            int meat = Convert.ToInt32(textBoxMeat.Text);
            int seafood = Convert.ToInt32(textBoxSeaFood.Text);
            int veget = Convert.ToInt32(textBoxVeget.Text);
            int water = Convert.ToInt32(textBoxWater.Text);
            if (verif())
            {
                pictureBoxFood.Image.Save(hinhanh, pictureBoxFood.Image.RawFormat);
                if((food.InsertNewFood(Food,Price,hinhanh))&&(food.InsertNewFoodCost(Food,meat,seafood,veget,water)))
                {
                    MessageBox.Show("Thêm món ăn thành công", "THÊM MÓN ĂN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại", "THÊM MÓN ĂN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không đủ dữ liệu", "THÊM MÓN ĂN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool verif()
        {
            if ((textBoxFood.Text.Trim() == "")
                || (textBoxPrice.Text.Trim() == "")
                || (pictureBoxFood.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
