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
    public partial class CategoryForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private BookManageControl bookManageCtrl;
        private string currentCategoryName;

        public CategoryForm(BookManageControl callingBookManageCtrl)
        {
            bookManageCtrl = callingBookManageCtrl;
            InitializeComponent();
        }

        private void loadData()
        {
            categoryDGV.DataSource = null;
            categoryDGV.Rows.Clear();
            categoryDGV.Columns.Clear();

            categoryDGV.DataSource = database.dataReader("select * from TheLoai");
            categoryDGV.ClearSelection();

            categoryDGV.Columns[0].HeaderText = "Mã thể loại";
            categoryDGV.Columns[1].HeaderText = "Tên thể loại";

            categoryCodeTB.Text = "";
            categoryNameTB.Text = "";

            categorySaveBtn.Enabled = false;
            categoryCancelBtn.Enabled = false;
        }

        private void loadCategorySelection()
        {
            if (bookManageCtrl.CategoryCombobox().SelectedIndex != -1)
            {
                DataTable dataCategory = database.dataReader("select * from TheLoai where MaTheLoai = '"
                + bookManageCtrl.CategoryCombobox().SelectedValue.ToString() + "'");
                categoryCodeTB.Text = dataCategory.Rows[0].Field<string>("MaTheLoai");
                categoryNameTB.Text = dataCategory.Rows[0].Field<string>("TenTheLoai");
            }        
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            loadData();
            loadCategorySelection();
        }

        public void setEnabledRemove(bool active)
        {
            categoryRemoveBtn.Enabled = active;
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
        private void generateCategoryCode()
        {
            DataTable dataAuthor = database.dataReader("select top(1) MaTheLoai from TheLoai order by MaTheLoai desc");
            int maxNumber = 1;
            if (dataAuthor.Rows.Count > 0)
            {
                string maxCode = dataAuthor.Rows[0].Field<string>("MaTheloai");
                maxNumber = int.Parse(maxCode.Substring(3)) + 1;
            }
            categoryCodeTB.Text = "TL00" + maxNumber.ToString();
        }
        private void disabledPrimaryFunction(bool active)
        {
            categorySaveBtn.Enabled = active;
            categoryCancelBtn.Enabled = active;

            active = active == true ? active = false : active = true;

            categoryAddBtn.Enabled = active;
            categoryEditBtn.Enabled = active;
            categoryNameTB.ReadOnly = active;
            categoryDGV.Enabled = active;
        }

        private void categoryAddBtn_Click(object sender, EventArgs e)
        {
            generateCategoryCode();
            disabledPrimaryFunction(true);
            categoryNameTB.Text = "";
            categoryDGV.ClearSelection();
            if (categoryRemoveBtn.Enabled)
                setEnabledRemove(false);
        }

        private bool checkSelectDatagridview()
        {
            if (categoryDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void categoryEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (categoryRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkDuplicateCategoryName(Label label, TextBox textbox)
        {
            foreach (DataGridViewRow row in categoryDGV.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim().ToLower() == textbox.Text.Trim().ToLower() &&
                    textbox.Text.Trim().ToLower() != currentCategoryName.Trim().ToLower())
                {
                    MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() + " không trùng lặp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void addAndEditCategory(bool active)
        {
            if (checkTextBox(categoryNameLB, categoryNameTB) &&
                checkDuplicateCategoryName(categoryNameLB, categoryNameTB))
            {
                string sql;
                bool checkUpdateDB = false;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "insert TheLoai (MaTheLoai, TenTheLoai) values ('" + categoryCodeTB.Text + "', N'" + categoryNameTB.Text + "')";
                        database.updateData(sql);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "update TheLoai set TenTheLoai = N'" + categoryNameTB.Text + "' where MaTheLoai = '" + categoryCodeTB.Text + "'";
                        database.updateData(sql);
                        bookManageCtrl.reloadCategory(categoryNameTB.Text);
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
            if (database.dataReader("select * from TaiLieu where MaTheLoai = '" + categoryCodeTB.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Thể loại đã tồn tại trong tài liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void categoryRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete = "delete from TheLoai where MaTheLoai = '" + categoryCodeTB.Text + "'";
                database.updateData(sqlDelete);
                loadData();
            }
        }

        private void categorySaveBtn_Click(object sender, EventArgs e)
        {
            if (categoryDGV.SelectedCells.Count == 0)
                addAndEditCategory(true);
            else
                addAndEditCategory(false);
        }

        private void categoryCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (categoryDGV.SelectedCells.Count == 0)
                loadData();
            if (bookManageCtrl.checkUserAdmin())
                setEnabledRemove(true);
        }

        private void categoryDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                categoryCodeTB.Text = categoryDGV.CurrentRow.Cells[0].Value.ToString();
                currentCategoryName = categoryNameTB.Text = categoryDGV.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
