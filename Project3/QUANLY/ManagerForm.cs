using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            SqlCommand command = new SqlCommand("SELECT * FROM thongtinnv");
            dataGridViewEmployee.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployee.RowTemplate.Height = 80;
            dataGridViewEmployee.DataSource = nhanvien.getNhanvien(command);
            picCol = (DataGridViewImageColumn)dataGridViewEmployee.Columns[12];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployee.AllowUserToAddRows = false;
            //
            Food food = new Food();
            dataGridViewMenu.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dataGridViewMenu.RowTemplate.Height = 80;
            DataTable TableFood = food.getAllFood();
            TableFood.Columns.Add("Số lượng", typeof(int));
            FillColumns(TableFood);
            dataGridViewMenu.DataSource = TableFood;
            picCol1 = (DataGridViewImageColumn)dataGridViewMenu.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployee.AllowUserToAddRows = false;
        }

        private void dataGridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NHANVIEN.EditRemoveForm fr = new NHANVIEN.EditRemoveForm();
            fr.textBoxIdentification.Text = dataGridViewEmployee.CurrentRow.Cells[1].Value.ToString();
            fr.textBoxFirstName.Text = dataGridViewEmployee.CurrentRow.Cells[2].Value.ToString();
            fr.textBoxLastName.Text = dataGridViewEmployee.CurrentRow.Cells[3].Value.ToString();
            fr.dateTimePickNgaySinh.Value = (DateTime)dataGridViewEmployee.CurrentRow.Cells[5].Value;
            if (dataGridViewEmployee.CurrentRow.Cells[4].Value.ToString() == "Female") fr.femaleRadioButton.Checked = true;
            else fr.maleRadioButton.Checked = true;
            fr.textBoxPhone.Text = dataGridViewEmployee.CurrentRow.Cells[6].Value.ToString();
            fr.textBoxAddress.Text = dataGridViewEmployee.CurrentRow.Cells[7].Value.ToString();
            fr.manv = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewEmployee.CurrentRow.Cells[12].Value;
            MemoryStream picture = new MemoryStream(pic);
            fr.pictureBoxEmployee.Image = Image.FromStream(picture);
            fr.Show();
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodForm = new AddFoodForm();
            addFoodForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            SqlCommand command = new SqlCommand("SELECT * FROM thongtinnv");
            dataGridViewEmployee.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployee.RowTemplate.Height = 80;
            dataGridViewEmployee.DataSource = nhanvien.getNhanvien(command);
            picCol = (DataGridViewImageColumn)dataGridViewEmployee.Columns[12];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployee.AllowUserToAddRows = false;
            //
            Food food = new Food();
            dataGridViewMenu.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dataGridViewMenu.RowTemplate.Height = 80;
            DataTable TableFood = food.getAllFood();
            TableFood.Columns.Add("Số lượng", typeof(int));
            FillColumns(TableFood);
            dataGridViewMenu.DataSource = TableFood;
            picCol1 = (DataGridViewImageColumn)dataGridViewMenu.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployee.AllowUserToAddRows = false;
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Food food = new Food();
            textBoxFood.Text = dataGridViewMenu.CurrentRow.Cells[0].Value.ToString();
            textBoxPrice.Text = dataGridViewMenu.CurrentRow.Cells[1].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewMenu.CurrentRow.Cells[2].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxFood.Image = Image.FromStream(picture);
            //
            DataTable foodCost = food.getFoodCost(textBoxFood.Text.Trim());
            textBoxMeat.Text = foodCost.Rows[0][1].ToString();
            textBoxSeaFood.Text = foodCost.Rows[0][2].ToString();
            textBoxVeget.Text = foodCost.Rows[0][3].ToString();
            textBoxWater.Text = foodCost.Rows[0][4].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa món ăn này trong thực đơn ?", "Chỉnh sửa thực đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Food food = new Food();
                string foodName = textBoxFood.Text;
                int price = Convert.ToInt32(textBoxPrice.Text);
                MemoryStream hinhanh = new MemoryStream();
                pictureBoxFood.Image.Save(hinhanh, pictureBoxFood.Image.RawFormat);
                int meat = Convert.ToInt32(textBoxMeat.Text);
                int seafood = Convert.ToInt32(textBoxSeaFood.Text);
                int veget = Convert.ToInt32(textBoxVeget.Text);
                int water = Convert.ToInt32(textBoxWater.Text);
                if ((food.updateFood(foodName, price, hinhanh, dataGridViewMenu.CurrentRow.Cells[0].Value.ToString()) && (food.updateFoodCost(dataGridViewMenu.CurrentRow.Cells[0].Value.ToString(),meat,seafood,veget,water,foodName))))
                {
                    MessageBox.Show("Chỉnh sửa món ăn thành công", "Chỉnh sửa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa món ăn không thành công", "Chỉnh sửa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa món ăn này khỏi thực đơn ?", "Xóa món ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBoxFood.Text.Trim() == "")
                {
                }
                else
                {
                    Food food = new Food();
                    food.DeleteFood(textBoxFood.Text.Trim());
                    textBoxFood.Text = "";
                    textBoxPrice.Text = "";
                    pictureBoxFood.Image = null;
                    textBoxMeat.Text = "";
                    textBoxSeaFood.Text = "";
                    textBoxVeget.Text = "";
                    textBoxWater.Text = "";
                }
                buttonRefresh_Click(this,new EventArgs());              
            }
        }

        private void buttonIngrediant_Click(object sender, EventArgs e)
        {
            IngrediantForm ingredianForm = new IngrediantForm();
            ingredianForm.Show();
        }
        private void FillColumns(DataTable table)
        {
            Food food = new Food();
            if(table.Rows.Count > 0)
            {
                for(int i =0; i < table.Rows.Count;i++)
                {
                    table.Rows[i][3] = food.GetNumberOfPlate(table.Rows[i][0].ToString().Trim());
                }
            }
        }
    }
}
