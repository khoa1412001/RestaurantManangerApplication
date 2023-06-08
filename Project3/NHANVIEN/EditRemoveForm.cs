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

namespace Project3.NHANVIEN
{
    public partial class EditRemoveForm : Form
    {
        public string manv;
        public EditRemoveForm()
        {
            InitializeComponent();
        }
        private bool verif()
        {
            if ((textBoxIdentification.Text.Trim() == "")
                || (textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == ""))
            { return false; }

            else return true;
        }
        Nhanvien nhanvien = new Nhanvien();
        private void editButton_Click(object sender, EventArgs e)
        {
            string cmnd = textBoxIdentification.Text;
            string hoNV = textBoxFirstName.Text;
            string tenNV = textBoxLastName.Text;
            DateTime ngaysinh = dateTimePickNgaySinh.Value;
            string sdt = textBoxPhone.Text;
            string diachi = textBoxAddress.Text;

            string gioitinh = "Nam";
            if (femaleRadioButton.Checked)
            {
                gioitinh = "Nữ";
            }

            string chucvu = "1";
            if (employeeButton.Checked)
            {
                chucvu = "0";
            }

            MemoryStream hinhanh = new MemoryStream();
            int born_year = dateTimePickNgaySinh.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 16)
            {
                MessageBox.Show("Độ tuổi của nhân viên phải lớn hơn 16 tuổi!!", "CHỈNH SỬA THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verif())
                {
                    pictureBoxEmployee.Image.Save(hinhanh, pictureBoxEmployee.Image.RawFormat);
                    if (nhanvien.UpdateEmployee(manv,cmnd,hoNV,tenNV,ngaysinh,gioitinh,sdt,diachi,chucvu,hinhanh))
                    {
                        MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công", "CHỈNH SỬA THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                    else
                    {
                        MessageBox.Show("LỖI", "CHỈNH SỬA THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống !!!", "CHỈNH SỬA THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc là muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nhanvien.DeleteEmployee(manv))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxIdentification.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePickNgaySinh.Value = DateTime.Now;
                        pictureBoxEmployee.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên này", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập mã nhân viên hợp lệ", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
                pictureBoxEmployee.Image = Image.FromFile(opf.FileName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
