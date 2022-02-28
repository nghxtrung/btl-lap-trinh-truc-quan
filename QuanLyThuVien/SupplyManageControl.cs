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
using System.IO;

namespace QuanLyThuVien
{
    public partial class SupplyManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;
        private string currentSupplyName;

        public SupplyManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataReader)
        {
            supplyDGV.DataSource = null;
            supplyDGV.Rows.Clear();
            supplyDGV.Columns.Clear();

            supplyDGV.DataSource = dataReader;
            supplyDGV.ClearSelection();

            supplyDGV.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            supplyDGV.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            supplyDGV.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            supplyDGV.Columns["DiaChi"].HeaderText = "Địa chỉ";

            disablePrimaryFuntion(false);
            clearInput();
        }

        private void SupplyManageControl_Load(object sender, EventArgs e)
        {
            loadData(database.dataReader("select * from NhaCungCap"));
        }

        public void setEnabledRemove(bool active)
        {
            supplyRemoveBtn.Enabled = active;
        }

        public bool checkUserAdmin()
        {
            DataTable loginTable = database.dataReader("select Loai from TaiKhoan " +
                "where TenDangNhap = '" + mainFrm.Username + "'");
            if (loginTable.Rows[0].Field<bool>("Loai"))
                return true;
            return false;
        }

        private void disablePrimaryFuntion(bool active)
        {
            supplySaveBtn.Enabled = active;
            supplyCancelBtn.Enabled = active;

            active = active == true ? active = false : active = true;

            supplyRefreshBtn.Enabled = active;
            supplyAddBtn.Enabled = active;
            supplyEditBtn.Enabled = active;
            supplyNameTB.ReadOnly = active;
            supplyPhoneNumberTB.ReadOnly = active;
            supplyAddressTB.ReadOnly = active;
        }

        private void clearInput()
        {
            supplyCodeTB.Text = "";
            supplyNameTB.Text = "";
            supplyPhoneNumberTB.Text = "";
            supplyAddressTB.Text = "";
            supplyDGV.ClearSelection();
        }

        private void supplyRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInput();
            loadData(database.dataReader("select * from NhaCungCap"));
        }

        private void generateSupplyCode()
        {
            DataTable dataReader = database.dataReader("select top(1) MaNCC from NhaCungCap order by MaNCC desc");
            int maxNumber = 1;
            if (dataReader.Rows.Count > 0)
            {
                string maxCode = dataReader.Rows[0].Field<string>("MaNCC");
                maxNumber = int.Parse(maxCode.Substring(4)) + 1;
            }
            supplyCodeTB.Text = "NCC00" + maxNumber.ToString();
        }

        private void supplyAddBtn_Click(object sender, EventArgs e)
        {
            disablePrimaryFuntion(true);
            if (supplyRemoveBtn.Enabled)
                setEnabledRemove(false);
            generateSupplyCode();
        }

        private bool checkSelectDatagridview()
        {
            if (supplyDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void supplyEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disablePrimaryFuntion(true);
                if (supplyRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkTextBoxEmpty(Label label, TextBox textbox)
        {
            if (textbox.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + "!", "Thông báo",
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
        private bool checkTextBoxNameSupply(Label label, TextBox textbox)
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

        private bool checkDuplicateSupplyName(Label label, TextBox textbox)
        {
            foreach (DataGridViewRow row in supplyDGV.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim().ToLower() == textbox.Text.Trim().ToLower() &&
                    textbox.Text.Trim().ToLower() != currentSupplyName.Trim().ToLower())
                {
                    MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " không trùng lặp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void addAndEditSupply(bool active)
        {
            if (checkTextBoxEmpty(supplyNameLB, supplyNameTB) &&
                checkTextBoxNameSupply(supplyNameLB, supplyNameTB) &&
                checkDuplicateSupplyName(supplyNameLB, supplyNameTB) &&
                checkTextBoxEmpty(supplyPhoneNumberLB, supplyPhoneNumberTB) &&
                checkTextBoxPhoneNumber(supplyPhoneNumberLB, supplyPhoneNumberTB) &&
                checkTextBoxEmpty(supplyAddressLB, supplyAddressTB))
            {
                string sql;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sql = "insert NhaCungCap(MaNCC, TenNCC, SoDienThoai, DiaChi) " +
                        "values('" + supplyCodeTB.Text + "',N'" + supplyNameTB.Text + "', '" + supplyPhoneNumberTB.Text +
                        "',N'" + supplyAddressTB.Text + "')";
                        database.updateData(sql);
                        loadData(database.dataReader("select * from NhaCungCap"));
                        if (checkUserAdmin())
                            setEnabledRemove(true);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sql = "update NhaCungCap set TenNCC = N'" + supplyNameTB.Text
                        + "', SoDienThoai ='" + supplyPhoneNumberTB.Text
                        + "', DiaChi = N'"
                            + supplyAddressTB.Text + "' where MaNCC = '" + supplyCodeTB.Text + "'";
                        database.updateData(sql);
                        loadData(database.dataReader("select * from NhaCungCap"));
                        if (checkUserAdmin())
                            setEnabledRemove(true);
                    }   
                }
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from TaiLieu where MaNCC = '" 
                + supplyDGV.CurrentRow.Cells[0].Value.ToString() + "'").Rows.Count > 0)
            {
                MessageBox.Show("Nhà cung cấp đã tồn tài trong tài liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void supplyRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
               MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDeleteLibraryCard = "delete from NhaCungCap where MaNCC = '" + supplyCodeTB.Text + "'";
                database.updateData(sqlDeleteLibraryCard);
                loadData(database.dataReader("select * from NhaCungCap"));
            }
        }

        private void supplySaveBtn_Click(object sender, EventArgs e)
        {
            if (supplyDGV.SelectedCells.Count == 0)
                addAndEditSupply(true);
            else
                addAndEditSupply(false);
        }

        private void supplyCancelBtn_Click(object sender, EventArgs e)
        {
            disablePrimaryFuntion(false);
            if (supplyDGV.SelectedCells.Count == 0)
                clearInput();
            if (checkUserAdmin())
                setEnabledRemove(true);
        }

        private void supplyExitBtn_Click(object sender, EventArgs e)
        {
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void supplyDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                supplyCodeTB.Text = supplyDGV.CurrentRow.Cells[0].Value.ToString();
                currentSupplyName = supplyNameTB.Text = supplyDGV.CurrentRow.Cells[1].Value.ToString();
                supplyPhoneNumberTB.Text = supplyDGV.CurrentRow.Cells[2].Value.ToString();
                supplyAddressTB.Text = supplyDGV.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
