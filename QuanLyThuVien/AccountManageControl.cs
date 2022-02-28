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
    public partial class AccountManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;
        private string currentUsername;

        public AccountManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataReader)
        {
            accountDGV.DataSource = null;
            accountDGV.Rows.Clear();
            accountDGV.Columns.Clear();

            accountDGV.DataSource = dataReader;
            accountDGV.ClearSelection();

            accountDGV.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            accountDGV.Columns["TenTaiKhoan"].HeaderText = "Tên tài khoản";
            accountDGV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            accountDGV.Columns["GioiTinh"].HeaderText = "Giới tính";
            accountDGV.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            accountDGV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            accountDGV.Columns["MatKhau"].HeaderText = "Mật khẩu";
            accountDGV.Columns["Loai"].HeaderText = "Loại tài khoản";

            disabledPrimaryFunction(false);
            clearInput();
        }

        private void AccountManageControl_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> accountType = new Dictionary<int, string>();
            accountType.Add(1, "Admin");
            accountType.Add(0, "Nhân viên");
            accountTypeCBB.DataSource = new BindingSource(accountType, null);
            accountTypeCBB.DisplayMember = "Value";
            accountTypeCBB.ValueMember = "Key";

            loadData(database.dataReader("exec ThongTinTaiKhoan"));
        }

        private void disabledPrimaryFunction(bool active)
        {
            accountSaveBtn.Enabled = active;
            accountCancelBtn.Enabled = active;
            accountBirthDTP.Enabled = active;
            maleRadioBtn.Enabled = active;
            femaleRadioBtn.Enabled = active;
            accountTypeCBB.Enabled = active;

            active = active == true ? active = false : active = true;

            accountRefreshBtn.Enabled = active;
            accountAddBtn.Enabled = active;
            accountEditBtn.Enabled = active;
            accountRemoveBtn.Enabled = active;
            usernameTB.ReadOnly = active;
            accountNameTB.ReadOnly = active;
            accountPhoneNumberTB.ReadOnly = active;
            accountAddressTB.ReadOnly = active;
            passwordTB.ReadOnly = active;
            accountDGV.Enabled = active;
        }

        private void clearInput()
        {
            usernameTB.Text = "";
            accountNameTB.Text = "";
            accountBirthDTP.Value = DateTime.Now;
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            accountPhoneNumberTB.Text = "";
            accountAddressTB.Text = "";
            passwordTB.Text = "";
            accountTypeCBB.SelectedIndex = -1;
            accountDGV.ClearSelection();
        }

        private void accountRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInput();
            loadData(database.dataReader("exec ThongTinTaiKhoan"));
        }

        private void accountAddBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(true);
            clearInput();
        }

        private bool checkSelectDatagridview()
        {
            if (accountDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void accountEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
                disabledPrimaryFunction(true);
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from TaiKhoan where TenDangNhap = '" 
                + accountDGV.CurrentRow.Cells[0].Value.ToString() 
                + "' and (TenDangNhap in (select TenDangNhap from HoSoMuon) " +
                "or TenDangNhap in (select TenDangNhap from HoSoTra))").Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tài lượt mượn trả!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void accountRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete = "delete from TaiKhoan where TenDangNhap = '" + usernameTB.Text + "'";
                database.updateData(sqlDelete);
                loadData(database.dataReader("exec ThongTinTaiKhoan"));
            }
        }

        private bool checkControlEmpty(string nameControl, Control control)
        {
            if (control.Text.Trim() == "")
            {
                if (control is TextBox)
                    MessageBox.Show("Vui lòng nhập " + nameControl.ToLower() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (control is ComboBox)
                    MessageBox.Show("Vui lòng chọn " + nameControl.ToLower() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        private bool checkTextBoxUserName(Label label, TextBox textbox)
        {
            if (!Regex.Match(textbox.Text, @"^[a-zA-Z][a-zA-Z0-9-_.]{5,30}$").Success)
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " tối thiểu 5 kí tự và đúng định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
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

        private bool checkRadioBtn(Label label, RadioButton firstRadioBtn,
            RadioButton secondRadioBtn, ref int genderValue)
        {
            if (firstRadioBtn.Checked)
                genderValue = 0;
            else if (secondRadioBtn.Checked)
                genderValue = 1;
            else
            {
                MessageBox.Show("Vui lòng chọn " + label.Text.ToLower() + "!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool checkLengthTextBoxPassword(Label label, TextBox textbox)
        {
            if (textbox.Text.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " tối thiếu 8 kí tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            return true;
        }

        private bool checkDuplicateUsername(Label label, TextBox textbox)
        {
            foreach(DataGridViewRow row in accountDGV.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().ToLower() == textbox.Text.Trim().ToLower() &&
                    textbox.Text.Trim().ToLower() != currentUsername.Trim().ToLower())
                {
                    MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " không trùng lặp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void addAndEditAccount(bool active)
        {
            int genderValue = 0;
            if (checkControlEmpty(usernameLB.Text, usernameTB) &&
                checkDuplicateUsername(usernameLB, usernameTB) &&
                checkTextBoxUserName(usernameLB, usernameTB) &&
                checkControlEmpty(accountNameLB.Text, accountNameTB) &&
                checkTextBoxNameAccount(accountNameLB, accountNameTB) &&
                checkRadioBtn(accountGenderLB, maleRadioBtn, femaleRadioBtn, ref genderValue) &&
                checkControlEmpty(accountPhoneNumberLB.Text, accountPhoneNumberTB) &&
                checkTextBoxPhoneNumber(accountPhoneNumberLB, accountPhoneNumberTB) &&
                checkControlEmpty(accountAddressLB.Text, accountAddressTB) &&
                checkControlEmpty(passwordLB.Text, passwordTB) &&
                checkLengthTextBoxPassword(passwordLB, passwordTB) &&
                checkControlEmpty(accountTypeLB.Text, accountTypeCBB))
            {
                string sql;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sql = "insert TaiKhoan(TenDangNhap, TenTaiKhoan, NgaySinh, GioiTinh, " +
                            "SoDienThoai, DiaChi, MatKhau, Loai) values('" + usernameTB.Text 
                            + "', N'" + accountNameTB.Text + "', '" 
                            + accountBirthDTP.Value.ToString("yyyy-MM-dd") + "', " 
                            + genderValue.ToString() + ", '" + accountPhoneNumberTB.Text + "', N'" 
                            + accountAddressTB.Text + "', '" + passwordTB.Text + "', " 
                            + accountTypeCBB.SelectedValue.ToString() + ")";
                        database.updateData(sql);
                        loadData(database.dataReader("exec ThongTinTaiKhoan"));
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sql = "update TaiKhoan set TenDangNhap = '" + usernameTB.Text 
                            + "', TenTaiKhoan = N'" + accountNameTB.Text + "', NgaySinh = '" 
                            + accountBirthDTP.Value.ToString("yyyy-MM-dd") + "', GioiTinh = " 
                            + genderValue.ToString() + ", SoDienThoai = '" + accountPhoneNumberTB.Text 
                            + "', DiaChi = N'" + accountAddressTB.Text + "', MatKhau = '" 
                            + passwordTB.Text + "', Loai = " + accountTypeCBB.SelectedValue.ToString() 
                            + " where TenDangNhap = '" + currentUsername + "'";
                        database.updateData(sql);
                        loadData(database.dataReader("exec ThongTinTaiKhoan"));
                    }
                }
            }
        }

        private void accountSaveBtn_Click(object sender, EventArgs e)
        {
            if (accountDGV.SelectedCells.Count == 0)
                addAndEditAccount(true);
            else
                addAndEditAccount(false);
        }

        private void accountCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (accountDGV.SelectedCells.Count == 0)
                clearInput();
        }

        private void accountExitBtn_Click(object sender, EventArgs e)
        {
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void accountDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentUsername = usernameTB.Text = accountDGV.CurrentRow.Cells[0].Value.ToString();
                accountNameTB.Text = accountDGV.CurrentRow.Cells[1].Value.ToString();
                accountBirthDTP.Value = (DateTime)accountDGV.CurrentRow.Cells[2].Value;
                if (accountDGV.CurrentRow.Cells[3].Value.ToString() == "Nam")
                    maleRadioBtn.Checked = true;
                else if (accountDGV.CurrentRow.Cells[3].Value.ToString() == "Nữ")
                    femaleRadioBtn.Checked = true;
                accountPhoneNumberTB.Text = accountDGV.CurrentRow.Cells[4].Value.ToString();
                accountAddressTB.Text = accountDGV.CurrentRow.Cells[5].Value.ToString();
                passwordTB.Text = accountDGV.CurrentRow.Cells[6].Value.ToString();
                accountTypeCBB.Text = accountDGV.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
