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
    public partial class AuthorForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private BookManageControl bookManageCtrl;
        private string currentAuthorName;

        public AuthorForm(BookManageControl callingBookManageCtrl)
        {
            bookManageCtrl = callingBookManageCtrl;
            InitializeComponent();
        }

        private void loadData()
        {
            authorDGV.DataSource = null;
            authorDGV.Rows.Clear();
            authorDGV.Columns.Clear();

            authorDGV.DataSource = database.dataReader("select * from TacGia");
            authorDGV.ClearSelection();

            authorDGV.Columns[0].HeaderText = "Mã tác giả";
            authorDGV.Columns[0].ReadOnly = true;
            authorDGV.Columns[1].HeaderText = "Tên tác giả";
            authorDGV.Columns[1].ReadOnly = true;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Chọn";
            authorDGV.Columns.Add(checkboxColumn);

            authorCodeTB.Text = "";
            authorNameTB.Text = "";
            authorNameTB.ReadOnly = true;

            authorSaveBtn.Enabled = false;
            authorCancelBtn.Enabled = false;
        }

        private void loadDataCheckbox()
        {
            foreach (string item in bookManageCtrl.AuthorCodeList())
            {
                foreach (DataGridViewRow row in authorDGV.Rows)
                {
                    if (item.Equals(row.Cells[0].Value))
                        row.Cells[2].Value = true;
                }
            }
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataCheckbox();
        }

        public void setEnabledRemove(bool active)
        {
            authorRemoveBtn.Enabled = active;
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

        private string removeAllWhiteSpace(string str)
        {
            if (str.Trim() != "")
            {
                str = Regex.Replace(str, @"\s", "");
                return str;
            }
            return str;
        }

        private void generateAuthorCode()
        {
            DataTable dataAuthor = database.dataReader("select top(1) MaTacGia from TacGia order by MaTacGia desc");
            int maxNumber = 1;
            if (dataAuthor.Rows.Count > 0)
            {
                string maxCode = dataAuthor.Rows[0].Field<string>("MaTacGia");
                maxNumber = int.Parse(maxCode.Substring(3)) + 1;
            }
            authorCodeTB.Text = "TG00" + maxNumber.ToString();
        }

        private void disabledPrimaryFunction(bool active)
        {
            authorSaveBtn.Enabled = active;
            authorCancelBtn.Enabled = active;

            active = active == true ? active = false : active = true;

            authorAddBtn.Enabled = active;
            authorEditBtn.Enabled = active;
            authorNameTB.ReadOnly = active;
            authorDGV.Enabled = active;
        }

        private void authorAddBtn_Click(object sender, EventArgs e)
        {
            generateAuthorCode();
            disabledPrimaryFunction(true);
            authorNameTB.Text = "";
            authorDGV.ClearSelection();
            if (authorRemoveBtn.Enabled)
                setEnabledRemove(false);
        }

        private bool checkDuplicateAuthorName(Label label, TextBox textbox)
        {
            foreach (DataGridViewRow row in authorDGV.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim().ToLower() == textbox.Text.Trim().ToLower() &&
                    textbox.Text.Trim().ToLower() != currentAuthorName.Trim().ToLower())
                {
                    MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " không trùng lặp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void addAndEditAuthor(bool active)
        {
            if (checkTextBox(authorNameLB, authorNameTB) &&
                checkDuplicateAuthorName(authorNameLB, authorNameTB))
            {
                string sql;
                bool checkUpdateDB = false;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "insert TacGia (MaTacGia, TenTacGia) values ('" + authorCodeTB.Text
                            + "', N'" + authorNameTB.Text + "')";
                        database.updateData(sql);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "update TacGia set TenTacGia = N'" + authorNameTB.Text
                           + "' where MaTacGia = '" + authorCodeTB.Text + "'";
                        database.updateData(sql);
                        bookManageCtrl.reloadAuthor();
                        bookManageCtrl.loadAuthorData();
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

        private bool checkSelectDatagridview()
        {
            if (authorDGV.SelectedCells.Count == 0) 
            {
                MessageBox.Show("Vui lòng chọn tác giả!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void authorEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (authorRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from Viet where MaTacGia = '" + authorCodeTB.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Tác giả đã tồn tại trong tài liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void authorRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete = "delete from TacGia where MaTacGia = '" + authorCodeTB.Text + "'";
                database.updateData(sqlDelete);
                loadData();
            }
        }

        private void authorSaveBtn_Click(object sender, EventArgs e)
        {
            if (authorDGV.SelectedCells.Count == 0)
                addAndEditAuthor(true);
            else
                addAndEditAuthor(false);
        }

        private void authorCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (authorDGV.SelectedCells.Count == 0)
                loadData();
            if (bookManageCtrl.checkUserAdmin())
                setEnabledRemove(true);
        }

        private void authorSelectedBtn_Click(object sender, EventArgs e)
        {
            bookManageCtrl.AuthorListBox().Items.Clear();
            bookManageCtrl.AuthorCodeList().Clear();
            foreach (DataGridViewRow row in authorDGV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    bookManageCtrl.AuthorCodeList().Add(row.Cells[0].Value.ToString());
                    bookManageCtrl.AuthorListBox().Items.Add(row.Cells[1].Value);
                }
            }
            this.Close();
        }

        private void authorDGV_Sorted(object sender, EventArgs e)
        {
            loadDataCheckbox();
        }

        private void authorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                authorCodeTB.Text = authorDGV.CurrentRow.Cells[0].Value.ToString();
                currentAuthorName = authorNameTB.Text = authorDGV.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
