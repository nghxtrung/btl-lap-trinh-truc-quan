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
    public partial class PublishForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private BookManageControl bookManageCtrl;
        private string currentPublishName;

        public PublishForm(BookManageControl callingBookManageCtrl)
        {
            bookManageCtrl = callingBookManageCtrl;
            InitializeComponent();
        }

        private void loadData()
        {
            publishDGV.DataSource = null;
            publishDGV.Rows.Clear();
            publishDGV.Columns.Clear();

            publishDGV.DataSource = database.dataReader("select * from NhaXuatBan");
            publishDGV.ClearSelection();

            publishDGV.Columns[0].HeaderText = "Mã nhà xuất bản";
            publishDGV.Columns[1].HeaderText = "Tên nhà xuất bản";

            publishCodeTB.Text = "";
            publishNameTB.Text = "";

            publishSaveBtn.Enabled = false;
            publishCancelBtn.Enabled = false;
        }

        private void PublishForm_Load(object sender, EventArgs e)
        {
            loadData();
            loadPublishSelection();
        }

        private void loadPublishSelection()
        {
            if (bookManageCtrl.PublishCombobox().SelectedIndex != -1)
            {
                DataTable dataPublish = database.dataReader("select * from NhaXuatBan where MaNXB = '"
                + bookManageCtrl.PublishCombobox().SelectedValue.ToString() + "'");
                publishCodeTB.Text = dataPublish.Rows[0].Field<string>("MaNXB");
                publishNameTB.Text = dataPublish.Rows[0].Field<string>("TenNXB");
            }
        }

        public void setEnabledRemove(bool active)
        {
            publishRemoveBtn.Enabled = active;
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
        private bool checkTextBox(Label label, TextBox textbox)
        {
            if (textbox.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + "!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            if (!removeAllWhiteSpace(textbox.Text).All(char.IsLetter))
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " đúng định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox.Focus();
                return false;
            }
            return true;
        }
        private void generatePublishCode()
        {
            DataTable dataAuthor = database.dataReader("select top(1) MaNXB from NhaXuatBan order by MaNXB desc");
            int maxNumber = 1;
            if (dataAuthor.Rows.Count > 0)
            {
                string maxCode = dataAuthor.Rows[0].Field<string>("MaNXB");
                maxNumber = int.Parse(maxCode.Substring(4)) + 1;
            }
            publishCodeTB.Text = "NXB00" + maxNumber.ToString();
        }
        private void disabledPrimaryFunction(bool active)
        {
            publishSaveBtn.Enabled = active;
            publishCancelBtn.Enabled = active;

            active = active == true ? active = false : active = true;

            publishAddBtn.Enabled = active;
            publishEditBtn.Enabled = active;
            publishNameTB.ReadOnly = active;
            publishDGV.Enabled = active;
        }

        private void publishAddBtn_Click(object sender, EventArgs e)
        {
            generatePublishCode();
            disabledPrimaryFunction(true);
            publishNameTB.Text = "";
            publishDGV.ClearSelection();
            if (publishRemoveBtn.Enabled)
                setEnabledRemove(false);
        }

        private bool checkSelectDatagridview()
        {
            if (publishDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void publishEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (publishRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkDuplicatePublishName(Label label, TextBox textbox)
        {
            foreach (DataGridViewRow row in publishDGV.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim().ToLower() == textbox.Text.Trim().ToLower() &&
                    textbox.Text.Trim().ToLower() != currentPublishName.Trim().ToLower())
                {
                    MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " không trùng lặp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void addAndEditPublish(bool active)
        {
            if (checkTextBox(publishNameLB, publishNameTB) &&
                checkDuplicatePublishName(publishNameLB, publishNameTB))
            {
                string sql;
                bool checkUpdateDB = false;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "insert NhaXuatBan (MaNXB, TenNXB) values ('" + publishCodeTB.Text + "', N'" + publishNameTB.Text + "')";
                        database.updateData(sql);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "update NhaXuatBan set TenNXB = N'" + publishNameTB.Text + "' where MaNXB = '" + publishCodeTB.Text + "'";
                        database.updateData(sql);
                        bookManageCtrl.reloadPublish(publishNameTB.Text);
                    }
                }
                if (checkUpdateDB)
                {
                    loadData();
                    disabledPrimaryFunction(false);
                    if (bookManageCtrl.checkUserAdmin())
                        setEnabledRemove(true);
                }
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from TaiLieu where MaNXB = '" + publishCodeTB.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Nhà xuất bản đã tồn tại trong tài liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void publishRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete = "delete from NhaXuatBan where MaNXB = '" + publishCodeTB.Text + "'";
                database.updateData(sqlDelete);
                loadData();
            }
        }

        private void publishSaveBtn_Click(object sender, EventArgs e)
        {
            if (publishDGV.SelectedCells.Count == 0)
                addAndEditPublish(true);
            else
                addAndEditPublish(false);
        }

        private void publishCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (publishDGV.SelectedCells.Count == 0)
                loadData();
            if (bookManageCtrl.checkUserAdmin())
                setEnabledRemove(true);
        }

        private void publishDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                publishCodeTB.Text = publishDGV.CurrentRow.Cells[0].Value.ToString();
                currentPublishName = publishNameTB.Text = publishDGV.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
