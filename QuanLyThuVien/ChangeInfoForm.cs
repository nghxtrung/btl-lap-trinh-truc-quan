using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    public partial class ChangeInfoForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public ChangeInfoForm(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        private void ChangeInfoForm_Load(object sender, EventArgs e)
        {
            usernameTB.Text = mainFrm.Username;
            DataTable dataAccount = database.dataReader("select * from TaiKhoan where TenDangNhap = '" + mainFrm.Username + "'");
            accountNameTB.Text = dataAccount.Rows[0].Field<string>("TenTaiKhoan");
            accountBirthDTP.Value = dataAccount.Rows[0].Field<DateTime>("NgaySinh");
            if (dataAccount.Rows[0].Field<bool>("GioiTinh"))
                femaleRadioBtn.Checked = true;
            else
                maleRadioBtn.Checked = true;
            accountPhoneNumberTB.Text = dataAccount.Rows[0].Field<string>("SoDienThoai");
            accountAddressTB.Text = dataAccount.Rows[0].Field<string>("DiaChi");
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

        private string removeAllWhiteSpace(string str)
        {
            if (str.Trim() != "")
            {
                str = Regex.Replace(str, @"\s", "");
                return str;
            }
            return str;
        }

        private bool checkTextBoxNameAccount(Label label, TextBox textbox)
        {
            if (!removeAllWhiteSpace(textbox.Text).All(char.IsLetter))
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " đúng định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            return true;
        }

        private bool checkTextBoxPhoneNumber(Label label, TextBox textbox)
        {
            if (!Regex.Match(textbox.Text, @"^(((\+){0,1}(843[2-9]|845[6|8|9]|847[0|6|7|8|9]|848[1-9]|849[1-4|6-9]))|(03[2-9]|05[6|8|9]|07[0|6|7|8|9]|08[1-9]|09[1-4|6-9]))+([0-9]{7})$").Success)
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " đúng định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            return true;
        }

        private void changeInfoBtn_Click(object sender, EventArgs e)
        {
            if (checkTextBoxEmpty(accountNameLB, accountNameTB) &&
                checkTextBoxNameAccount(accountNameLB, accountNameTB) &&
                checkTextBoxEmpty(accountPhoneNumberLB, accountPhoneNumberTB) &&
                checkTextBoxPhoneNumber(accountPhoneNumberLB, accountPhoneNumberTB) &&
                checkTextBoxEmpty(accountAddressLB, accountAddressTB) )
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int genderValue = 0;
                    if (femaleRadioBtn.Checked)
                        genderValue = 1;
                    string sql = "update TaiKhoan set TenTaiKhoan = N'" + accountNameTB.Text + "', NgaySinh = '"
                        + accountBirthDTP.Value.ToString("yyyy-MM-dd") + "', GioiTinh = "
                        + genderValue.ToString() + ", SoDienThoai = '" + accountPhoneNumberTB.Text
                        + "', DiaChi = N'" + accountAddressTB.Text + "' where TenDangNhap = '" + usernameTB.Text + "'";
                    database.updateData(sql);
                    MessageBox.Show("Đổi thông tin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
