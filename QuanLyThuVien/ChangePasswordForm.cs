using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ChangePasswordForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public ChangePasswordForm(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        private bool checkTextBoxEmpty(Label label, TextBox textbox)
        {
            if (textbox.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool checkPassword(Label label, TextBox textbox)
        {
            DataTable dataAccount = database.dataReader("select MatKhau from TaiKhoan where TenDangNhap = '" + mainFrm.Username + "'");
            if (textbox.Text != dataAccount.Rows[0].Field<string>("MatKhau"))
            {
                MessageBox.Show(label.Text + " không đúng! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool checkFitNewPassword(Label label, TextBox firstTextbox, TextBox secondTextbox)
        {
            if (firstTextbox.Text != secondTextbox.Text)
            {
                MessageBox.Show(label.Text + " không trùng nhau! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (checkTextBoxEmpty(currentPasswordLB, currentPasswordTB) &&
                checkTextBoxEmpty(newPasswordLB, newPasswordTB) &&
                checkTextBoxEmpty(renewPasswordLB, renewPasswordTB) &&
                checkFitNewPassword(newPasswordLB, newPasswordTB, renewPasswordTB) &&
                checkPassword(currentPasswordLB, currentPasswordTB))
            {
                string sql = "update TaiKhoan set MatKhau = '" + renewPasswordTB.Text + "' where TenDangNhap = '" + mainFrm.Username + "'";
                database.updateData(sql);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                currentPasswordTB.UseSystemPasswordChar = false;
                newPasswordTB.UseSystemPasswordChar = false;
                renewPasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                currentPasswordTB.UseSystemPasswordChar = true;
                newPasswordTB.UseSystemPasswordChar = true;
                renewPasswordTB.UseSystemPasswordChar = true;
            }
        }
    }
}
