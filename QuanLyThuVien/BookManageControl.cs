using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLyThuVien
{
    public partial class BookManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private List<string> authorCodeList = new List<string>(100);
        private MainForm mainFrm;

        public BookManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataBook)
        {
            authorCodeList.Clear();
            authorListBox.Items.Clear();
            bookDGV.DataSource = null;
            bookDGV.Rows.Clear();
            bookDGV.Columns.Clear();

            bookDGV.DataSource = dataBook;
            bookDGV.ClearSelection();

            DataGridViewComboBoxColumn authorNameColumn = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn authorCodeColumn = new DataGridViewComboBoxColumn();
            authorNameColumn.HeaderText = "Tên tác giả";
            authorCodeColumn.HeaderText = "Mã tác giả";
            authorNameColumn.Name = "TenTacGia";
            authorCodeColumn.Name = "MaTacGia";
            authorNameColumn.DisplayIndex = 2;
            authorCodeColumn.Visible = false;
            bookDGV.Columns.Add(authorNameColumn);
            bookDGV.Columns.Add(authorCodeColumn);

            bookDGV.Columns["MaTaiLieu"].HeaderText = "Mã tài liệu";
            bookDGV.Columns["MaTaiLieu"].ReadOnly = true;
            bookDGV.Columns["TenTaiLieu"].HeaderText = "Tên tài liệu";
            bookDGV.Columns["TenTaiLieu"].ReadOnly = true;
            bookDGV.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
            bookDGV.Columns["NamXuatBan"].ReadOnly = true;
            bookDGV.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
            bookDGV.Columns["TenTheLoai"].ReadOnly = true;
            bookDGV.Columns["TenNXB"].HeaderText = "Tên nhà xuất bản";
            bookDGV.Columns["TenNXB"].ReadOnly = true;
            bookDGV.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            bookDGV.Columns["TenNCC"].ReadOnly = true;
            bookDGV.Columns["TinhTrang"].HeaderText = "Tình trạng";
            bookDGV.Columns["TinhTrang"].ReadOnly = true;
            bookDGV.Columns["SoLuong"].HeaderText = "Số lượng";
            bookDGV.Columns["SoLuong"].ReadOnly = true;
            bookDGV.Columns["GiaTien"].HeaderText = "Giá";
            bookDGV.Columns["GiaTien"].ReadOnly = true;

            bookDGV.Columns["HinhAnh"].DefaultCellStyle.Padding = new Padding(50, 0, 50, 0);
            bookDGV.Columns["HinhAnh"].DefaultCellStyle.NullValue = null;
            ((DataGridViewImageColumn)bookDGV.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            disabledPrimaryFunction(false);
            clearInput();
            loadAuthorData();
        }

        public void loadAuthorData()
        {
            ((DataGridViewComboBoxColumn)bookDGV.Columns["TenTacGia"]).Items.Clear();
            ((DataGridViewComboBoxColumn)bookDGV.Columns["MaTacGia"]).Items.Clear();
            foreach (DataGridViewRow bookRow in bookDGV.Rows)
            {
                string bookCode = bookRow.Cells["MaTaiLieu"].Value.ToString();
                DataTable dataAuthor = database.dataReader("exec ThongTinTacGia '" + bookCode + "'");
                DataGridViewComboBoxCell authorNameCell = new DataGridViewComboBoxCell();
                DataGridViewComboBoxCell authorCodeCell = new DataGridViewComboBoxCell();
                foreach (DataRow authorRow in dataAuthor.Rows)
                {
                    authorNameCell.Items.Add(authorRow["TenTacGia"].ToString());
                    authorCodeCell.Items.Add(authorRow["MaTacGia"].ToString());
                }
                authorNameCell.Value = authorNameCell.Items[0];
                authorCodeCell.Value = authorCodeCell.Items[0];
                bookDGV.Rows[bookDGV.Rows.IndexOf(bookRow)].Cells["TenTacGia"] = authorNameCell;
                bookDGV.Rows[bookDGV.Rows.IndexOf(bookRow)].Cells["MaTacGia"] = authorCodeCell;
            }
        }

        private void BookManageControl_Load(object sender, EventArgs e)
        {
            categoryCBB.DataSource = database.dataReader("select * from TheLoai");
            categoryCBB.DisplayMember = "TenTheLoai";
            categoryCBB.ValueMember = "MaTheLoai";

            publishNameCBB.DataSource = database.dataReader("select * from NhaXuatBan");
            publishNameCBB.DisplayMember = "TenNXB";
            publishNameCBB.ValueMember = "MaNXB";

            supplyCBB.DataSource = database.dataReader("select MaNCC, TenNCC from NhaCungCap");
            supplyCBB.DisplayMember = "TenNCC";
            supplyCBB.ValueMember = "MaNCC";

            Dictionary<int, string> condition = new Dictionary<int, string>();
            condition.Add(1, "Mới");
            condition.Add(0, "Cũ");
            conditionCBB.DataSource = new BindingSource(condition, null);
            conditionCBB.DisplayMember = "Value";
            conditionCBB.ValueMember = "Key";

            loadData(database.dataReader("exec ThongTinTaiLieu"));
        }

        public void setEnabledRemove(bool active)
        {
            bookRemoveBtn.Enabled = active;
        }

        public bool checkUserAdmin()
        {
            DataTable loginTable = database.dataReader("select Loai from TaiKhoan " +
                "where TenDangNhap = '" + mainFrm.Username + "'");
            if (loginTable.Rows[0].Field<bool>("Loai"))
                return true;
            return false;
        }

        private void searchBookContentTB_TextChanged(object sender, EventArgs e)
        {
            if (bookCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMaTaiLieu '" + searchBookContentTB.Text + "'"));
            else if (bookNameRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTenTaiLieu N'" + searchBookContentTB.Text + "'"));
            else if (authorRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTacGia N'" + searchBookContentTB.Text + "'"));
            else if (categoryRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTheLoai N'" + searchBookContentTB.Text + "'"));
        }

        private void bookCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMaTaiLieu '" + searchBookContentTB.Text + "'"));
        }

        private void bookNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTenTaiLieu N'" + searchBookContentTB.Text + "'"));
        }

        private void authorRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTacGia N'" + searchBookContentTB.Text + "'"));
        }

        private void categoryRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTheLoai N'" + searchBookContentTB.Text + "'"));
        }

        private void bookSelectPictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "JPEG Images|*.jpg|PNG Images|*.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                bookPictureBox.Image = new Bitmap(Image.FromFile(openDlg.FileName), new Size(500, 500));
            }
        }

        private void bookRemovePictureBtn_Click(object sender, EventArgs e)
        {
            bookPictureBox.Image = null;
        }

        private void bookRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInputSearch();
            loadData(database.dataReader("exec ThongTinTaiLieu"));
            loadAuthorData();
            supplyCBB.DataSource = database.dataReader("select MaNCC, TenNCC from NhaCungCap");
            supplyCBB.DisplayMember = "TenNCC";
            supplyCBB.ValueMember = "MaNCC";
            supplyCBB.SelectedIndex = -1;
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

        private bool checkListBoxEmpty(Label label, ListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm " + label.Text.ToLower() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool checkControlNumber(Label label, TextBox textBox, int value)
        {
            if (!int.TryParse(textBox.Text, out value))
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() 
                    + " đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool checkYear(Label label, TextBox textBox)
        {
            if (int.Parse(textBox.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Vui lòng nhập " + label.Text.ToLower() 
                    + " nhỏ hơn hoặc bằng năm " + DateTime.Now.Year.ToString() 
                    + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void generateBookCode()
        {
            DataTable dataBook = database.dataReader("select top(1) MaTaiLieu from TaiLieu order by MaTaiLieu desc");
            int maxNumber = 1;
            if (dataBook.Rows.Count > 0)
            {
                string maxCode = dataBook.Rows[0].Field<string>("MaTaiLieu");
                maxNumber = int.Parse(maxCode.Substring(3)) + 1;
            }
            bookCodeTB.Text = "TL00" + maxNumber.ToString();
        }

        private void disabledPrimaryFunction(bool active)
        {
            bookSelectPictureBtn.Enabled = active;
            bookRemovePictureBtn.Enabled = active;
            bookSaveBtn.Enabled = active;
            bookCancelBtn.Enabled = active;
            authorLB.Enabled = active;
            categoryLB.Enabled = active;
            categoryCBB.Enabled = active;
            publishNameLB.Enabled = active;
            publishNameCBB.Enabled = active;
            supplyCBB.Enabled = active;
            conditionCBB.Enabled = active;

            active = active == true ? active = false : active = true;

            bookRefreshBtn.Enabled = active;
            bookAddBtn.Enabled = active;
            bookEditBtn.Enabled = active;
            bookNameTB.ReadOnly = active;
            publishYearTB.ReadOnly = active;
            bookQuantityTB.ReadOnly = active;
            bookPriceTB.ReadOnly = active;
            bookDGV.Enabled = active;
        }

        private void clearInput()
        {
            bookPictureBox.Image = null;
            bookCodeTB.Text = "";
            bookNameTB.Text = "";
            authorCodeList.Clear();
            authorListBox.Items.Clear();
            categoryCBB.SelectedIndex = -1;
            publishYearTB.Text = "";
            publishNameCBB.SelectedIndex = -1;
            supplyCBB.SelectedIndex = -1;
            conditionCBB.SelectedIndex = -1;
            bookQuantityTB.Text = "";
            bookPriceTB.Text = "";
            bookDGV.ClearSelection();
        }

        public void reloadAuthor()
        {
            authorListBox.Items.Clear();
            DataTable dataAuthor = database.dataReader("exec ThongTinTacGia '" + bookCodeTB.Text + "'");
            foreach (DataRow row in dataAuthor.Rows)
            {
                authorListBox.Items.Add(row.Field<string>("TenTacGia"));
            }
        }

        private void bookAddBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(true);
            clearInput();
            generateBookCode();
            if (bookRemoveBtn.Enabled)
                setEnabledRemove(false);
        }

        private bool checkSelectDatagridview()
        {
            if (bookDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void bookEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (bookRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from ChiTietMuon where MaTaiLieu = '"
                + bookDGV.CurrentRow.Cells[0].Value.ToString() + "'").Rows.Count > 0)
            {
                MessageBox.Show("Bạn đọc đang đã tồn tại lượt mượn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void bookRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDeleteAuthor = "delete from Viet where MaTaiLieu = '" + bookCodeTB.Text + "'";
                string sqlDeleteBook = "delete from TaiLieu where MaTaiLieu = '" + bookCodeTB.Text + "'";
                database.updateData(sqlDeleteAuthor);
                database.updateData(sqlDeleteBook);
                loadData(database.dataReader("exec ThongTinTaiLieu"));
            }
        }

        private void addAndEditBook(bool active)
        {
            int publishYearNumber = 0;
            int bookQuantityNumber = 0;
            int bookPriceNumber = 0;
            if (checkControlEmpty(bookNameLB.Text, bookNameTB) &&
                checkListBoxEmpty(authorLB, authorListBox) &&
                checkControlEmpty(categoryLB.Text, categoryCBB) &&
                checkControlEmpty(publishYearLB.Text, publishYearTB) &&
                checkControlNumber(publishYearLB, publishYearTB, publishYearNumber) &&
                checkYear(publishYearLB, publishYearTB) &&
                checkControlEmpty(publishNameLB.Text, publishNameCBB) &&
                checkControlEmpty(supplyLB.Text, supplyCBB) &&
                checkControlEmpty(conditionLB.Text, conditionCBB) &&
                checkControlEmpty(bookQuantityLB.Text, bookQuantityTB) &&
                checkControlNumber(bookQuantityLB, bookQuantityTB, bookQuantityNumber) &&
                checkControlEmpty(bookPriceLB.Text, bookPriceTB) &&
                checkControlNumber(bookPriceLB, bookPriceTB, bookPriceNumber))
            {
                string sql;
                bool checkUpdateDB = false;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        if (bookPictureBox.Image == null)
                        {
                            sql = "insert TaiLieu(MaTaiLieu, TenTaiLieu, MaTheLoai, NamXuatBan, MaNXB, MaNCC, TinhTrang, SoLuong, GiaTien) " +
                                "values('" + bookCodeTB.Text + "', N'" + bookNameTB.Text + "', '" +
                                categoryCBB.SelectedValue.ToString() + "', " + publishYearTB.Text + ", '" +
                                publishNameCBB.SelectedValue.ToString() + "', '" +
                                supplyCBB.SelectedValue.ToString() + "', " +
                                conditionCBB.SelectedValue + ", " +
                                bookQuantityTB.Text + ", " + bookPriceTB.Text + ")";
                            database.updateData(sql);
                        }
                        else
                        {
                            MemoryStream stream = new MemoryStream();
                            bookPictureBox.Image.Save(stream, ImageFormat.Jpeg);
                            byte[] imageArray = stream.ToArray();
                            sql = "insert TaiLieu(MaTaiLieu, TenTaiLieu, MaTheLoai, NamXuatBan, MaNXB, MaNCC, TinhTrang, SoLuong, GiaTien, HinhAnh) " +
                                "values('" + bookCodeTB.Text + "', N'" + bookNameTB.Text + "', '" +
                                categoryCBB.SelectedValue.ToString() + "', " + publishYearTB.Text + ", '" +
                                publishNameCBB.SelectedValue.ToString() + "', '" +
                                supplyCBB.SelectedValue.ToString() + "', " +
                                conditionCBB.SelectedValue + ", " +
                                bookQuantityTB.Text + ", " + bookPriceTB.Text + ", @imageArray)";
                            database.updateDataWithImage(sql, "@imageArray", imageArray);
                            stream.Close();
                            stream.Dispose();
                        }
                        foreach (string authorCode in authorCodeList)
                        {
                            sql = "insert Viet(MaTaiLieu, MaTacGia) values('" + bookCodeTB.Text + "','" + authorCode + "')";
                            database.updateData(sql);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        if (bookPictureBox.Image == null)
                        {
                            sql = "update TaiLieu set TenTaiLieu = N'" + bookNameTB.Text +
                                "', MaTheLoai = '" + categoryCBB.SelectedValue.ToString() +
                                "', NamXuatBan = " + publishYearTB.Text + ", MaNXB = '" +
                                publishNameCBB.SelectedValue.ToString() + "', MaNCC = '" +
                                supplyCBB.SelectedValue.ToString() + "', TinhTrang = " +
                                conditionCBB.SelectedValue.ToString() + ", SoLuong = " +
                                bookQuantityTB.Text + ", GiaTien = " + bookPriceTB.Text +
                                ", HinhAnh = null where MaTaiLieu = '" + bookCodeTB.Text + "'";
                            database.updateData(sql);
                        }
                        else
                        {
                            MemoryStream stream = new MemoryStream();
                            bookPictureBox.Image.Save(stream, ImageFormat.Jpeg);
                            byte[] imageArray = stream.ToArray();
                            sql = "update TaiLieu set TenTaiLieu = N'" + bookNameTB.Text +
                                "', MaTheLoai = '" + categoryCBB.SelectedValue.ToString() +
                                "', NamXuatBan = " + publishYearTB.Text + ", MaNXB = '" +
                                publishNameCBB.SelectedValue.ToString() + "', MaNCC = '" +
                                supplyCBB.SelectedValue.ToString() + "', TinhTrang = " +
                                conditionCBB.SelectedValue.ToString() + ", SoLuong = " +
                                bookQuantityTB.Text + ", GiaTien = " + bookPriceTB.Text +
                                ", HinhAnh = @imageArray where MaTaiLieu = '" + bookCodeTB.Text + "'";
                            database.updateDataWithImage(sql, "@imageArray", imageArray);
                            stream.Close();
                            stream.Dispose();
                        }
                        string sqlDelete = "delete from Viet where MaTaiLieu = '" + bookCodeTB.Text + "'";
                        database.updateData(sqlDelete);
                        foreach (string authorCode in authorCodeList)
                        {
                            sql = "insert Viet(MaTaiLieu, MaTacGia) values('" + bookCodeTB.Text + "','" + authorCode + "')";
                            database.updateData(sql);
                        }
                    }
                }
                if (checkUpdateDB)
                {
                    loadData(database.dataReader("exec ThongTinTaiLieu"));
                    authorListBox.Items.Clear();
                    authorCodeList.Clear();
                    if (checkUserAdmin())
                        setEnabledRemove(true);
                }
            }
        }

        private void bookSaveBtn_Click(object sender, EventArgs e)
        {
            if (bookDGV.SelectedCells.Count == 0)
                addAndEditBook(true);
            else
                addAndEditBook(false);
        }

        private void bookCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (bookDGV.SelectedCells.Count == 0)
                clearInput();
            if (checkUserAdmin())
                setEnabledRemove(true);
        }

        public void clearInputSearch()
        {
            bookCodeRadioBtn.Checked = false;
            bookNameRadioBtn.Checked = false;
            authorRadioBtn.Checked = false;
            categoryRadioBtn.Checked = false;
            searchBookContentTB.Text = "";
        }

        private void bookExitBtn_Click(object sender, EventArgs e)
        {
            clearInputSearch();
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void authorLB_Click(object sender, EventArgs e)
        {
            AuthorForm authorFrm = new AuthorForm(this);
            if (checkUserAdmin())
                authorFrm.setEnabledRemove(true);
            else
                authorFrm.setEnabledRemove(false);
            authorFrm.Show();
        }

        public List<string> AuthorCodeList()
        {
            return authorCodeList;
        }

        public ListBox AuthorListBox()
        {
            return authorListBox;
        }

        private void bookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                bookCodeTB.Text = bookDGV.CurrentRow.Cells[0].Value.ToString();
                bookNameTB.Text = bookDGV.CurrentRow.Cells[1].Value.ToString();
                categoryCBB.Text = bookDGV.CurrentRow.Cells[2].Value.ToString();
                publishYearTB.Text = bookDGV.CurrentRow.Cells[3].Value.ToString();
                publishNameCBB.Text = bookDGV.CurrentRow.Cells[4].Value.ToString();
                supplyCBB.Text = bookDGV.CurrentRow.Cells[5].Value.ToString();
                conditionCBB.Text = bookDGV.CurrentRow.Cells[6].Value.ToString();
                bookQuantityTB.Text = bookDGV.CurrentRow.Cells[7].Value.ToString();
                bookPriceTB.Text = bookDGV.CurrentRow.Cells[8].Value.ToString().Split('.')[0];
                if (bookDGV.CurrentRow.Cells[9].Value == DBNull.Value)
                    bookPictureBox.Image = null;
                else
                {
                    byte[] imageArray = (byte[])bookDGV.CurrentRow.Cells[9].Value;
                    MemoryStream stream = new MemoryStream(imageArray);
                    bookPictureBox.Image = new Bitmap(Image.FromStream(stream), new Size(500, 500));
                    stream.Close();
                    stream.Dispose();
                }
                authorListBox.Items.Clear();
                authorCodeList.Clear();
                DataGridViewComboBoxCell authorNameCell = bookDGV.CurrentRow.Cells["TenTacGia"] as DataGridViewComboBoxCell;
                foreach (var item in authorNameCell.Items)
                {
                    authorListBox.Items.Add(item);
                }
                DataGridViewComboBoxCell authorCodeCell = bookDGV.CurrentRow.Cells["MaTacGia"] as DataGridViewComboBoxCell;
                foreach (var item in authorCodeCell.Items)
                {
                    authorCodeList.Add(item.ToString());
                }
            }
        }

        private void bookDGV_Sorted(object sender, EventArgs e)
        {
            loadAuthorData();
        }

        public ComboBox CategoryCombobox()
        {
            return categoryCBB;
        }

        public ComboBox PublishCombobox()
        {
            return publishNameCBB;
        }

        public void reloadCategory(string categoryName)
        {
            categoryCBB.DataSource = database.dataReader("select * from TheLoai");
            categoryCBB.DisplayMember = "TenTheLoai";
            categoryCBB.ValueMember = "MaTheLoai";
            categoryCBB.Text = categoryName;
            bookDGV.CurrentRow.Cells[2].Value = categoryName;
        }

        public void reloadPublish(string publishName)
        {
            publishNameCBB.DataSource = database.dataReader("select * from NhaXuatBan");
            publishNameCBB.DisplayMember = "TenNXB";
            publishNameCBB.ValueMember = "MaNXB";
            bookDGV.CurrentRow.Cells[4].Value = publishName;
        }

        private void categoryLB_Click(object sender, EventArgs e)
        {
            CategoryForm categoryFrm = new CategoryForm(this);
            if (checkUserAdmin())
                categoryFrm.setEnabledRemove(true);
            else
                categoryFrm.setEnabledRemove(false);
            categoryFrm.Show();
        }

        private void publishNameLB_Click(object sender, EventArgs e)
        {
            PublishForm publishFrm = new PublishForm(this);
            if (checkUserAdmin())
                publishFrm.setEnabledRemove(true);
            else
                publishFrm.setEnabledRemove(false);
            publishFrm.Show();
        }
    }
}
