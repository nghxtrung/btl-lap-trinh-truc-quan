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
    public partial class BorrowManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;
        private Dictionary<string, int> bookBorrowInfomation = new Dictionary<string, int>();
        private DateTime returnDay;

        public BorrowManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataBorrow)
        {
            bookBorrowDGV.CurrentCell = null;
            bookBorrowInfomation.Clear();
            borrowDGV.DataSource = null;
            borrowDGV.DataSource = dataBorrow;
            borrowDGV.ClearSelection();

            borrowDGV.Columns["MaHSM"].HeaderText = "Mã mượn";
            borrowDGV.Columns["MaBanDoc"].HeaderText = "Mã bạn đọc";
            borrowDGV.Columns["NgayMuon"].HeaderText = "Ngày mượn";
            borrowDGV.Columns["NgayHenTra"].HeaderText = "Ngày hẹn trả";

            loadBookBorrow();
            disabledPrimaryFunction(false);
            clearInput();
        }

        private void loadReaderCode()
        {
            borrowReaderCodeCBB.Items.Clear();
            DataTable dataReaderCode = database.dataReader("select MaBanDoc from BanDoc");
            foreach (DataRow row in dataReaderCode.Rows)
            {
                string readerCode = row["MaBanDoc"].ToString();
                borrowReaderCodeCBB.Items.Add(readerCode);
            }
            borrowReaderCodeCBB.SelectedIndex = -1;
        }

        public void loadBookBorrow()
        {
            bookBorrowDGV.DataSource = null;
            bookBorrowDGV.Rows.Clear();
            bookBorrowDGV.Columns.Clear();

            DataTable dataBookCode = database.dataReader("select MaTaiLieu from TaiLieu");
            quantityBookBorrowNUD.Maximum = dataBookCode.Rows.Count;
            
            DataGridViewComboBoxColumn bookCodeColumn = new DataGridViewComboBoxColumn();
            bookCodeColumn.DataSource = dataBookCode;
            bookCodeColumn.DisplayMember = "MaTaiLieu";
            bookCodeColumn.ValueMember = "MaTaiLieu";
            bookCodeColumn.HeaderText = "Mã Tài Liệu";

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Số lượng mượn";

            DataGridViewComboBoxColumn conditionColumn = new DataGridViewComboBoxColumn();
            Dictionary<int, string> condition = new Dictionary<int, string>();
            condition.Add(1, "Mới");
            condition.Add(0, "Cũ");
            conditionColumn.DataSource = new BindingSource(condition, null);
            conditionColumn.DisplayMember = "Value";
            conditionColumn.ValueMember = "Key";
            conditionColumn.HeaderText = "Tình trạng";

            DataGridViewTextBoxColumn noteColumn = new DataGridViewTextBoxColumn();
            noteColumn.HeaderText = "Ghi chú";

            bookBorrowDGV.Columns.Add(bookCodeColumn);
            bookBorrowDGV.Columns.Add(quantityColumn);
            bookBorrowDGV.Columns.Add(conditionColumn);
            bookBorrowDGV.Columns.Add(noteColumn);
        }

        public void setEnabledRemove(bool active)
        {
            borrowRemoveBtn.Enabled = active;
        }

        public bool checkUserAdmin()
        {
            DataTable loginTable = database.dataReader("select Loai from TaiKhoan " +
                "where TenDangNhap = '" + mainFrm.Username + "'");
            if (loginTable.Rows[0].Field<bool>("Loai"))
                return true;
            return false;
        }

        private void BorrowManageControl_Load(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec ThongTinMuonTra"));
        }

        private bool checkEmptyDGV()
        {
            if (bookBorrowDGV.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng tạo thông tin tài liệu!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                foreach (DataGridViewRow row in bookBorrowDGV.Rows)
                {
                    if (row.Cells[0].Value == null ||
                        row.Cells[1].Value == null ||
                        row.Cells[2].Value == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài liệu!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bookBorrowDGV_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (bookBorrowDGV.CurrentCell is DataGridViewComboBoxCell)
                bookBorrowDGV.EndEdit();
        }

        private bool checkDuplicateBookCode(int rowIndex)
        {
            if (bookBorrowDGV.Rows[rowIndex].Cells[0].Value != null)
            {
                string currentCellValue = bookBorrowDGV.Rows[rowIndex].Cells[0].Value.ToString();
                for (int i = 0; i < bookBorrowDGV.Rows.Count; i++)
                {
                    if (bookBorrowDGV.Rows[i].Cells[0].Value != null && i != rowIndex)
                    {
                        string cellValue = bookBorrowDGV.Rows[i].Cells[0].Value.ToString();
                        if (currentCellValue == cellValue)
                        {
                            bookBorrowDGV.Rows[rowIndex].ErrorText = "Vui lòng không chọn trùng!";
                            return false;
                        }
                    }
                }
            }
            foreach (DataGridViewRow row in bookBorrowDGV.Rows)
            {
                row.ErrorText = "";
            }
            return true;
        }

        private bool checkSumQuantity(int rowIndex, string quantity)
        {
            if (quantity.Length > 0)
            {
                int currentCellValue = int.Parse(quantity);
                for (int i = 0; i < bookBorrowDGV.Rows.Count; i++)
                {
                    if (bookBorrowDGV.Rows[i].Cells[1].Value != null && i != rowIndex)
                    {
                        int cellValue = int.Parse(bookBorrowDGV.Rows[i].Cells[1].Value.ToString());
                        currentCellValue += cellValue;
                    }
                }
                if (currentCellValue > 10)
                {
                    bookBorrowDGV.Rows[rowIndex].ErrorText = "Vui lòng nhập tổng số lượng nhỏ hơn hoặc bằng 10!";
                    return false;
                }
            }
            foreach (DataGridViewRow row in bookBorrowDGV.Rows)
            {
                row.ErrorText = "";
            }
            return true;
        }

        private bool checkQuantity(string quantity)
        {
            DataGridViewComboBoxCell bookCodeCell = (DataGridViewComboBoxCell)bookBorrowDGV.CurrentRow.Cells[0];
            if (bookCodeCell.Value != null && quantity.Length > 0)
            {
                string bookCode = bookCodeCell.Value.ToString();
                DataTable dataBook = database.dataReader("select SoLuong from TaiLieu where MaTaiLieu = '" + bookCode + "'");
                if (borrowDGV.SelectedCells.Count == 0)
                {
                    if (int.Parse(quantity) >= dataBook.Rows[0].Field<int>("SoLuong"))
                    {
                        bookBorrowDGV.CurrentRow.ErrorText = "Vui lòng nhập số lượng nhỏ hơn!";
                        return false;
                    }
                }
                else if (bookBorrowInfomation.Count > 0)
                {
                    if (bookBorrowInfomation.ContainsKey(bookCode))
                    {
                        if (int.Parse(quantity) >= (dataBook.Rows[0].Field<int>("SoLuong") + bookBorrowInfomation[bookCode]))
                        {
                            bookBorrowDGV.CurrentRow.ErrorText = "Vui lòng nhập số lượng nhỏ hơn!";
                            return false;
                        }
                    }
                    else
                    {
                        
                        if (int.Parse(quantity) >= dataBook.Rows[0].Field<int>("SoLuong"))
                        {
                            bookBorrowDGV.CurrentRow.ErrorText = "Vui lòng nhập số lượng nhỏ hơn!";
                            return false;
                        }
                    }
                }
            }           
            return true;
        }

        private void getBookInformation(string bookCode)
        {
            DataTable dataBook = database.dataReader("exec ThongTinTaiLieuMuonTra '" + bookCode + "'");
            bookCodeTB.Text = bookCode;
            bookNameTB.Text = dataBook.Rows[0].Field<string>("TenTaiLieu");
            categoryTB.Text = dataBook.Rows[0].Field<string>("TenTheLoai");
            publishYearTB.Text = dataBook.Rows[0].Field<int>("NamXuatBan").ToString();
            publishNameTB.Text = dataBook.Rows[0].Field<string>("TenNXB");
            conditionTB.Text = dataBook.Rows[0].Field<string>("TinhTrang");
            quantityTB.Text = dataBook.Rows[0].Field<int>("SoLuong").ToString();
            priceTB.Text = dataBook.Rows[0].Field<Decimal>("GiaTien").ToString().Split('.')[0];
            DataTable dataAuthor = database.dataReader("exec ThongTinTacGiaTaiLieu '" + bookCode + "'");
            authorListBox.Items.Clear();
            foreach (DataRow authorRow in dataAuthor.Rows)
            {
                authorListBox.Items.Add(authorRow["TenTacGia"].ToString());
            }
        }

        private void bookBorrowDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell bookCodeCell = (DataGridViewComboBoxCell)bookBorrowDGV.CurrentRow.Cells[0];
            DataGridViewTextBoxCell quantityCell = (DataGridViewTextBoxCell)bookBorrowDGV.CurrentRow.Cells[1];
            if (bookCodeCell.Value != null && bookCodeCell.Selected
                && checkDuplicateBookCode(bookBorrowDGV.CurrentCell.RowIndex))
            {
                getBookInformation(bookCodeCell.Value.ToString());
                if (quantityCell.Value != null)
                {
                    checkQuantity(quantityCell.Value.ToString());
                    checkSumQuantity(bookBorrowDGV.CurrentCell.RowIndex, quantityCell.Value.ToString());
                }
            }
        }


        private void bookBorrowDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && bookBorrowDGV.CurrentRow.Cells[0].Value != null)
                getBookInformation(bookBorrowDGV.CurrentRow.Cells[0].Value.ToString());
        }

        private void bookBorrowDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == bookBorrowDGV.Columns[1].Index)
            {
                int value;
                if (e.FormattedValue.ToString().Length > 0 &&
                    !int.TryParse(e.FormattedValue.ToString(), out value))
                {
                    bookBorrowDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng đúng định dạng!";
                    e.Cancel = true;
                }
                else if (e.FormattedValue.ToString().Length > 0 &&
                    int.Parse(e.FormattedValue.ToString()) <= 0)
                {
                    bookBorrowDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng lớn hơn 0!";
                    e.Cancel = true;
                }
                else if (!checkQuantity(e.FormattedValue.ToString()))
                {
                    bookBorrowDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng nhỏ hơn!";
                    e.Cancel = true;
                }
                else if (!checkSumQuantity(e.RowIndex, e.FormattedValue.ToString()))
                    e.Cancel = true;
                else
                {
                    bookBorrowDGV.Rows[e.RowIndex].ErrorText = "";
                    e.Cancel = false;
                }
            }
            if (e.ColumnIndex == bookBorrowDGV.Columns[0].Index)
            {
                if (!checkDuplicateBookCode(e.RowIndex))
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
        }


        private void bookBorrowDGV_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (bookBorrowDGV.Rows.Count == 0)
            {
                clearBookInformation();
                quantityBookBorrowNUD.Maximum = database.dataReader("select MaTaiLieu from TaiLieu").Rows.Count;
                quantityBookBorrowNUD.Value = 1;
            }
            else
            {
                quantityBookBorrowNUD.Enabled = true;
                borrowBookAddBtn.Enabled = true;
                if (quantityBookBorrowNUD.Maximum < database.dataReader("select MaTaiLieu from TaiLieu").Rows.Count)
                    quantityBookBorrowNUD.Maximum += 1;
                quantityBookBorrowNUD.Value = 1;
            }
        }

        private void borrowBookAddBtn_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(Math.Round(quantityBookBorrowNUD.Value));
            if (bookBorrowDGV.Rows.Count < database.dataReader("select MaTaiLieu from TaiLieu").Rows.Count)
            {
                bookBorrowDGV.Rows.Add(quantity);
                quantityBookBorrowNUD.Value = 1;
            }
            quantityBookBorrowNUD.Maximum -= quantity;
        }


        private void quantityBookBorrowNUD_ValueChanged(object sender, EventArgs e)
        {
            if (quantityBookBorrowNUD.Value == 0)
            {
                if (bookBorrowDGV.Rows.Count == database.dataReader("select MaTaiLieu from TaiLieu").Rows.Count)
                {
                    quantityBookBorrowNUD.Enabled = false;
                    borrowBookAddBtn.Enabled = false;
                }
                else
                {
                    quantityBookBorrowNUD.Enabled = true;
                    borrowBookAddBtn.Enabled = true;
                    quantityBookBorrowNUD.Value = 1;
                }
            }
        }

        private void quantityBookBorrowNUD_KeyUp(object sender, KeyEventArgs e)
        {
            if (quantityBookBorrowNUD.Value > quantityBookBorrowNUD.Maximum)
                quantityBookBorrowNUD.Value = quantityBookBorrowNUD.Maximum;
        }

        private void quantityBookBorrowNUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void borrowReaderCodeCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataReader = database.dataReader("exec ThongTinBanDocMuonTra '" + borrowReaderCodeCBB.Text + "'");
            readerCodeTB.Text = borrowReaderCodeCBB.Text;
            readerNameTB.Text = dataReader.Rows[0].Field<string>("TenBanDoc");
            readerBirthTB.Text = dataReader.Rows[0].Field<DateTime>("NgaySinh").ToString("dd/MM/yyyy");
            readerGenderTB.Text = dataReader.Rows[0].Field<string>("GioiTinh");
            readerPhoneNumberTB.Text = dataReader.Rows[0].Field<string>("SoDienThoai");
        }

        private void disabledPrimaryFunction(bool active)
        {
            borrowSaveBtn.Enabled = active;
            borrowCancelBtn.Enabled = active;
            borrowReaderCodeCBB.Enabled = active;
            borrowDayDTP.Enabled = active;
            returnDayDTP.Enabled = active;
            quantityBookBorrowNUD.Enabled = active;
            borrowBookAddBtn.Enabled = active;
            bookBorrowDGV.AllowUserToDeleteRows = active;

            active = active == true ? active = false : active = true;

            borrowRefreshBtn.Enabled = active;
            borrowAddBtn.Enabled = active;
            borrowEditBtn.Enabled = active;
            borrowExtendBtn.Enabled = active;
            bookBorrowDGV.ReadOnly = active;
            borrowDGV.Enabled = active;
        }

        private void clearInput()
        {
            borrowCodeTB.Text = "";
            loadReaderCode();
            borrowDayDTP.Value = DateTime.Now;
            returnDayDTP.Value = DateTime.Now;
            quantityBookBorrowNUD.Value = 1;

            clearBookInformation();
            readerCodeTB.Text = "";
            readerNameTB.Text = "";
            readerBirthTB.Text = "";
            readerGenderTB.Text = "";
            readerPhoneNumberTB.Text = "";
        }

        private void clearBookInformation()
        {
            bookCodeTB.Text = "";
            bookNameTB.Text = "";
            categoryTB.Text = "";
            publishYearTB.Text = "";
            publishNameTB.Text = "";
            conditionTB.Text = "";
            quantityTB.Text = "";
            priceTB.Text = "";
            authorListBox.Items.Clear();
        }

        public void clearInputSearch()
        {
            borrowBorrowCodeRadioBtn.Checked = false;
            borrowReaderCodeRadioBtn.Checked = false;
            searchBorrowContentTB.Text = "";
        }

        private void searchBorrowContentTB_TextChanged(object sender, EventArgs e)
        {
            if (borrowBorrowCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + searchBorrowContentTB.Text + "'"));
            else if (borrowReaderCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + searchBorrowContentTB.Text + "'"));
        }

        private void borrowBorrowCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + searchBorrowContentTB.Text + "'"));
        }

        private void borrowReaderCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + searchBorrowContentTB.Text + "'"));
        }

        private void borrowRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInputSearch();
            loadData(database.dataReader("exec ThongTinMuonTra"));
        }

        private void generateBorrowCode()
        {
            DataTable dataBorrow = database.dataReader("select top(1) MaHSM from HoSoMuon order by MaHSM desc");
            int maxNumber = 1;
            if (dataBorrow.Rows.Count > 0)
            {
                string maxCode = dataBorrow.Rows[0].Field<string>("MaHSM");
                maxNumber = int.Parse(maxCode.Substring(4)) + 1;
            }
            borrowCodeTB.Text = "HSM00" + maxNumber.ToString();
        }

        private void borrowAddBtn_Click(object sender, EventArgs e)
        {
            loadBookBorrow();
            borrowDGV.ClearSelection();
            disabledPrimaryFunction(true);
            clearInput();
            generateBorrowCode();
            if (borrowRemoveBtn.Enabled)
                setEnabledRemove(false);
        }

        private bool checkSelectDatagridview()
        {
            if (borrowDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin mượn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void borrowEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (borrowRemoveBtn.Enabled)
                    setEnabledRemove(false);
            }
        }

        private bool checkComboBoxEmpty(Label label, ComboBox combobox)
        {
            if (combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn " + label.Text.ToLower() + "!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combobox.Focus();
                return false;
            }
            return true;
        }

        private bool checkDateTime(Label firstLabel, Label secondLabel,
            DateTimePicker startDay, DateTimePicker endDay)
        {
            if (endDay.Value <= startDay.Value)
            {
                MessageBox.Show("Vui lòng chọn " + secondLabel.Text.ToLower() + " lớn hơn "
                    + firstLabel.Text.ToLower() + "!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((endDay.Value - startDay.Value).Days >= 30)
            {
                MessageBox.Show("Thời gian mượn không quá 30 ngày!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void addAndEditBorrow(bool active)
        {
            if (checkComboBoxEmpty(borrowReaderCodeLB, borrowReaderCodeCBB) &&
                checkDateTime(borrowDateLB, returnDayLB, borrowDayDTP, returnDayDTP) &&
                checkEmptyDGV())
            {
                bookBorrowDGV.CurrentCell = null;
                string sql;
                bool checkUpdateDB = false;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        sql = "insert HoSoMuon(MaHSM, MaBanDoc, NgayMuon, NgayHenTra, TenDangNhap, DaGiaHan) " +
                        "values('" + borrowCodeTB.Text + "', '" + borrowReaderCodeCBB.Text + "', '"
                        + borrowDayDTP.Value.ToString("yyyy-MM-dd") + "', '"
                        + returnDayDTP.Value.ToString("yyyy-MM-dd") + "', '" + mainFrm.Username + "', 0)";
                        database.updateData(sql);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        checkUpdateDB = true;
                        int DaGiaHan = !borrowDayDTP.Enabled ? DaGiaHan = 1 : DaGiaHan = 0;
                        sql = "update HoSoMuon set MaBanDoc = '" + borrowReaderCodeCBB.Text
                        + "', NgayMuon = '" + borrowDayDTP.Value.ToString("yyyy-MM-dd")
                        + "', NgayHenTra = '" + returnDayDTP.Value.ToString("yyyy-MM-dd").ToString()
                        + "', DaGiaHan = " + DaGiaHan.ToString() + " where MaHSM = '" + borrowCodeTB.Text + "'";
                        database.updateData(sql);
                        foreach (string bookCode in bookBorrowInfomation.Keys)
                        {
                            sql = "delete from ChiTietMuon where MaHSM = '" + borrowCodeTB.Text + "' and MaTaiLieu = '" + bookCode + "'";
                            database.updateData(sql);
                        }
                    }
                }
                if (checkUpdateDB)
                {
                    foreach (DataGridViewRow rowBookBorrow in bookBorrowDGV.Rows)
                    {
                        DataGridViewComboBoxCell bookCodeCell = (DataGridViewComboBoxCell)rowBookBorrow.Cells[0];
                        if (rowBookBorrow.Cells[3].Value != null)
                        {
                            sql = "insert ChiTietMuon(MaHSM, MaTaiLieu, SoLuongMuon, GhiChu, DaTra) " +
                                "values('" + borrowCodeTB.Text + "', '" + bookCodeCell.Value.ToString()
                                + "', " + rowBookBorrow.Cells[1].Value.ToString() + ", N'"
                                + rowBookBorrow.Cells[3].Value.ToString() + "', 0)";
                            database.updateData(sql);
                        }
                        else
                        {
                            sql = "insert ChiTietMuon(MaHSM, MaTaiLieu, SoLuongMuon, DaTra) " +
                                "values('" + borrowCodeTB.Text + "', '" + bookCodeCell.Value.ToString()
                                + "', " + rowBookBorrow.Cells[1].Value.ToString() + ", 0)";
                            database.updateData(sql);
                        }
                        DataGridViewComboBoxCell conditionCell = (DataGridViewComboBoxCell)rowBookBorrow.Cells[2];
                        sql = "update TaiLieu set TinhTrang = " + conditionCell.Value.ToString()
                            + " where MaTaiLieu = '" + bookCodeCell.Value.ToString() + "'";
                        database.updateData(sql);
                    }
                    loadData(database.dataReader("exec ThongTinMuonTra"));
                    if (checkUserAdmin())
                        setEnabledRemove(true);
                }
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from HoSoMuon where MaHSM = '" 
                + borrowDGV.CurrentRow.Cells[0].Value.ToString() 
                + "' and MaHSM not in (select MaHSM from HoSoTra)").Rows.Count == 0)
            {
                MessageBox.Show("Hồ sơ mượn đang đã tồn tại lượt trả!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void borrowRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDelete;
                foreach (string bookCode in bookBorrowInfomation.Keys)
                {
                   sqlDelete = "delete from ChiTietMuon where MaHSM = '" + borrowCodeTB.Text + "' and MaTaiLieu = '" + bookCode + "'";
                    database.updateData(sqlDelete);
                }
                sqlDelete = "delete from HoSoMuon where MaHSM = '" + borrowCodeTB.Text + "'";
                database.updateData(sqlDelete);
                loadData(database.dataReader("exec ThongTinMuonTra"));
            }
        }

        private void borrowSaveBtn_Click(object sender, EventArgs e)
        {
            if (borrowDGV.SelectedCells.Count == 0)
                addAndEditBorrow(true);
            else if (!borrowDayDTP.Enabled)
            {
                if (checkExtendTime() && MessageBox.Show("Bạn có chắc chắn muốn gia hạn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    addAndEditBorrow(false);
            }
            else
                addAndEditBorrow(false);
        }

        private bool checkExtend()
        {
            if (database.dataReader("select DaGiaHan from HoSoMuon where MaHSM = '"
                + borrowDGV.CurrentRow.Cells[0].Value.ToString() + "'").Rows[0].Field<bool>("DaGiaHan"))
            {
                MessageBox.Show("Hồ sơ mượn đã gia hạn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool checkExtendTime()
        {
            if ((returnDayDTP.Value - returnDay).Days > 15)
            {
                MessageBox.Show("Gia hạn không quá 15 ngày!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void borrowExtendBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() && checkExtend())
            {
                disabledPrimaryFunction(true);
                borrowReaderCodeCBB.Enabled = false;
                borrowDayDTP.Enabled = false;
                quantityBookBorrowNUD.Enabled = false;
                borrowBookAddBtn.Enabled = false;
                bookBorrowDGV.ReadOnly = true;
                returnDay = returnDayDTP.Value;
            }
        }

        private void borrowCancelBtn_Click(object sender, EventArgs e)
        {
            loadBookBorrow();
            loadDataBookBorrow();
            disabledPrimaryFunction(false);
            if (borrowDGV.SelectedCells.Count == 0)
                clearInput();
            if (checkUserAdmin())
                setEnabledRemove(true);
        }

        private void borrowExitBtn_Click(object sender, EventArgs e)
        {
            clearInputSearch();
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void loadDataBookBorrow()
        {
            bookBorrowInfomation.Clear();
            DataTable dataBorrow = database.dataReader("exec ThongTinTaiLieuMuon '" + borrowCodeTB.Text + "'");
            if (dataBorrow.Rows.Count > 0)
                bookBorrowDGV.Rows.Add(dataBorrow.Rows.Count);
            foreach (DataGridViewRow rowBookBorrow in bookBorrowDGV.Rows)
            {
                rowBookBorrow.Cells[0].Value = dataBorrow.Rows[rowBookBorrow.Index].Field<string>("MaTaiLieu");
                rowBookBorrow.Cells[1].Value = dataBorrow.Rows[rowBookBorrow.Index].Field<int>("SoLuongMuon");
                if (dataBorrow.Rows[rowBookBorrow.Index].Field<bool>("TinhTrang"))
                    rowBookBorrow.Cells[2].Value = 1;
                else
                    rowBookBorrow.Cells[2].Value = 0;
                rowBookBorrow.Cells[3].Value = dataBorrow.Rows[rowBookBorrow.Index].Field<string>("GhiChu");
                bookBorrowInfomation.Add(dataBorrow.Rows[rowBookBorrow.Index].Field<string>("MaTaiLieu"),
                    dataBorrow.Rows[rowBookBorrow.Index].Field<int>("SoLuongMuon"));
            }
            quantityBookBorrowNUD.Maximum = quantityBookBorrowNUD.Maximum - dataBorrow.Rows.Count;
        }

        private void borrowDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                borrowCodeTB.Text = borrowDGV.CurrentRow.Cells[0].Value.ToString();
                borrowReaderCodeCBB.Text = borrowDGV.CurrentRow.Cells[1].Value.ToString();
                borrowDayDTP.Value = (DateTime)borrowDGV.CurrentRow.Cells[2].Value;
                returnDayDTP.Value = (DateTime)borrowDGV.CurrentRow.Cells[3].Value;
                loadBookBorrow();
                loadDataBookBorrow();
            }
        }
    }
}
