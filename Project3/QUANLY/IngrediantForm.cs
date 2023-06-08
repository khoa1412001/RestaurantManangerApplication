using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class IngrediantForm : Form
    {
        public IngrediantForm()
        {
            InitializeComponent();
        }

        private void IngrediantForm_Load(object sender, EventArgs e)
        {
            Food food = new Food();
            DataTable Ingrediant = food.GetIngrediant();
            labelMeat.Text = "Thịt: " +Ingrediant.Rows[0][0];
            labelSeafood.Text = "Hải sản: " + Ingrediant.Rows[0][1];
            labelVeget.Text = "Rau: " + Ingrediant.Rows[0][2];
            labelWater.Text = "Nước: " + Ingrediant.Rows[0][3];
        }

        private void buttonMakeIngrediant_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            DataTable Ingrediant = food.GetIngrediant();
            int meat = (int)Ingrediant.Rows[0][0] + Convert.ToInt32(textBoxMeat.Text)*1000;
            int saefood = (int)Ingrediant.Rows[0][1] + Convert.ToInt32(textBoxSeaFood.Text)*1000;
            int veget = (int)Ingrediant.Rows[0][2] + Convert.ToInt32(textBoxVeget.Text)*1000;
            int water = (int)Ingrediant.Rows[0][3] + Convert.ToInt32(textBoxWater.Text);
            if(food.UpdateIngrediant(meat,saefood,veget,water))
            {
                MessageBox.Show("Nhập nguyên liệu thành công", "Nhập nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhập nguyên liệu không thành công", "Nhập nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            IngrediantForm_Load(this, new EventArgs());
        }

    }
}
