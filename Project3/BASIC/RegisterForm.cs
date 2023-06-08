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
    public partial class RegisterForm : Form
    {
        private string Manv;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxEmployee.Image = Image.FromFile(opf.FileName);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                MyDB db = new MyDB();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM account WHERE username = @user", db.GetConnection);

                command.Parameters.Add("@user", SqlDbType.VarChar).Value = textBoxUsermane.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "ĐĂNG KÝ TÀI KHOẢN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command2 = new SqlCommand("INSERT INTO account (username, password,chucvu,manv)" + "VALUES (@user2,@pass2,@chucvu,@manv)", db.GetConnection);

                    if (AddNewEmployee())
                    {
                        command2.Parameters.Add("@user2", SqlDbType.VarChar).Value = textBoxUsermane.Text;
                        command2.Parameters.Add("@pass2", SqlDbType.VarChar).Value = textBoxPassword.Text;
                        if (managerButton.Checked)
                            command2.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = "1";
                        else
                            command2.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = "0";
                        command2.Parameters.Add("@manv", SqlDbType.VarChar).Value = Manv;



                        db.openConnection();

                        if ((command2.ExecuteNonQuery() == 1))
                        {
                            db.closeConnection();
                        }
                        else
                        {
                            db.closeConnection();
                        }
                        MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG!!", "ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ĐĂNG KÝ KHÔNG THÀNH CÔNG!!", "ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không giống nhau!!", "ĐĂNG KÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddNewEmployee()
        {
            Nhanvien nhanvien = new Nhanvien();
            Manv = CreateEmployeeID();
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
            if ((this_year - born_year) < 16 )
            {
                MessageBox.Show("Độ tuổi của nhân viên phải lớn hơn 16 tuổi!!", "THÊM THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verif())
                {
                    pictureBoxEmployee.Image.Save(hinhanh, pictureBoxEmployee.Image.RawFormat);
                    if (nhanvien.InsertNewEmployee(Manv,cmnd, hoNV, tenNV, ngaysinh, gioitinh, sdt, diachi,chucvu, hinhanh))
                    {
                        //MessageBox.Show("Thêm thông tin nhân viên thành công", "THÊM THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("LỖI", "THÊM THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống !!!", "THÊM THÔNG TIN NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return false;
        }

        private string CreateEmployeeID()
        {
            MyDB db = new MyDB();
            string EmployeeID = "";
            if(employeeButton.Checked)
            {
                EmployeeID += "NV";
            }
            else
            {
                EmployeeID += "QL";
            }

            for(int i = 1; i < 200;i++)
            {
                string tempEmployeeID = EmployeeID + i.ToString();
                SqlCommand command2 = new SqlCommand("SELECT * FROM thongtinnv WHERE manv = @manv", db.GetConnection);
                command2.Parameters.Add("@manv", SqlDbType.Char).Value = tempEmployeeID;
                SqlDataAdapter adapter = new SqlDataAdapter(command2);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count > 0)
                {
                    continue;
                }
                else
                {
                    EmployeeID = tempEmployeeID;
                    break;
                }
            }

            return EmployeeID;
        }

        bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxIdentification.Text.Trim() == "")
                || (pictureBoxEmployee.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
