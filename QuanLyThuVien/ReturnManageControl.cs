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
    public partial class ReturnManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public ReturnManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataBorrow)
        {
            bookReturnDGV.CurrentCell = null;
            returnDGV.DataSource = null;
            returnDGV.DataSource = dataBorrow;
            returnDGV.ClearSelection();

            returnDGV.Columns["MaHSM"].HeaderText = "Mã mượn";
            returnDGV.Columns["MaBanDoc"].HeaderText = "Mã bạn đọc";
            returnDGV.Columns["NgayMuon"].HeaderText = "Ngày mượn";
            returnDGV.Columns["NgayHenTra"].HeaderText = "Ngày hẹn trả";

            clearInput();
            disabledPrimaryFunction(false);
        }

        private void clearBookBorrow()
        {
            bookReturnDGV.DataSource = null;
            bookReturnDGV.Rows.Clear();
            bookReturnDGV.Columns.Clear();

            DataGridViewTextBoxColumn bookCodeColumn = new DataGridViewTextBoxColumn();
            bookCodeColumn.HeaderText = "Mã tài liệu";
            bookCodeColumn.ReadOnly = true;

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Số lượng mượn";
            quantityColumn.ReadOnly = true;

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
            noteColumn.ReadOnly = true;

            DataGridViewTextBoxColumn quantityReturnColumn = new DataGridViewTextBoxColumn();
            quantityReturnColumn.HeaderText = "Số lượng trả";

            DataGridViewTextBoxColumn fineColumn = new DataGridViewTextBoxColumn();
            fineColumn.HeaderText = "Tiền phạt";
            fineColumn.ReadOnly = true;

            bookReturnDGV.Columns.Add(bookCodeColumn);
            bookReturnDGV.Columns.Add(quantityColumn);
            bookReturnDGV.Columns.Add(conditionColumn);
            bookReturnDGV.Columns.Add(noteColumn);
            bookReturnDGV.Columns.Add(quantityReturnColumn);
            bookReturnDGV.Columns.Add(fineColumn);
        }

        private void loadBookBorrowCode(string borrowCode)
        {
            returnBookCBB.Items.Clear();
            DataTable dataBookCode = database.dataReader("select MaTaiLieu from ChiTietMuon where MaHSM = '" + borrowCode + "' and DaTra = 0");
            foreach (DataRow row in dataBookCode.Rows)
            {
                returnBookCBB.Items.Add(row["MaTaiLieu"].ToString());
            }
            returnBookCBB.SelectedIndex = -1;
        }

        private void loadBookBorrow(string bookCode)
        {
            bookReturnDGV.Rows.Add(1);
            DataTable dataBookBorrow = database.dataReader("exec ThongTinTaiLieuTra '" + returnDGV.CurrentRow.Cells[0].Value.ToString() + "', '" + bookCode + "'");
            bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[0].Value = dataBookBorrow.Rows[0].Field<string>("MaTaiLieu");
            bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[1].Value = dataBookBorrow.Rows[0].Field<int>("SoLuongMuon");
            if (dataBookBorrow.Rows[0].Field<bool>("TinhTrang"))
                bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[2].Value = 1;
            else
                bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[2].Value = 0;
            bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[3].Value = dataBookBorrow.Rows[0].Field<string>("GhiChu");
            bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[4].Value = dataBookBorrow.Rows[0].Field<int>("SoLuongMuon");
            bookReturnDGV.Rows[bookReturnDGV.Rows.Count - 1].Cells[5].Value = caculateOutOfDateFine(dataBookBorrow.Rows[0].Field<string>("MaTaiLieu"));
            bookReturnDGV.CurrentCell = null;
            returnBookCBB.Items.Remove(bookCode);
            addReturnBookBtn.Enabled = false;
        }

        private void ReturnManageControl_Load(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec ThongTinMuonTra"));
        }

        private void disabledPrimaryFunction(bool active)
        {
            comfirmBtn.Enabled = active;
            returnCancelBtn.Enabled = active;
            returnBookCBB.Enabled = active;

            active = active == true ? active = false : active = true;

            returnRefreshBtn.Enabled = active;
            returnBtn.Enabled = active;
            returnDGV.Enabled = active;
            bookReturnDGV.Columns[2].ReadOnly = active;
            bookReturnDGV.Columns[4].ReadOnly = active;
        }

        private void clearInput()
        {
            returnBookCBB.SelectedIndex = -1;
            fineTB.Text = "";
            clearBookBorrow();

            bookCodeTB.Text = "";
            bookNameTB.Text = "";
            categoryTB.Text = "";
            publishYearTB.Text = "";
            publishNameTB.Text = "";
            conditionTB.Text = "";
            quantityTB.Text = "";
            priceTB.Text = "";
            authorListBox.Items.Clear();

            readerCodeTB.Text = "";
            readerNameTB.Text = "";
            readerBirthTB.Text = "";
            readerGenderTB.Text = "";
            readerPhoneNumberTB.Text = "";
        }

        private void returnSearchContentTB_TextChanged(object sender, EventArgs e)
        {
            if (returnBorrowCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + returnSearchContentTB.Text + "'"));
            else if (returnBorrowCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + returnSearchContentTB.Text + "'"));
        }


        private void returnBorrowCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + returnSearchContentTB.Text + "'"));
        }

        private void returnReaderCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + returnSearchContentTB.Text + "'"));
        }

        public void clearInputSearch()
        {
            returnBorrowCodeRadioBtn.Checked = false;
            returnReaderCodeRadioBtn.Checked = false;
            returnSearchContentTB.Text = "";
        }

        private void returnRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInputSearch();
            loadData(database.dataReader("exec ThongTinMuonTra"));
        }

        private bool checkSelectDatagridview()
        {
            if (returnDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin mượn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
                disabledPrimaryFunction(true);
        }

        private string generateReturnCode()
        {
            DataTable dataReturn = database.dataReader("select top(1) MaHST from HoSoTra order by MaHST desc");
            int maxNumber = 1;
            if (dataReturn.Rows.Count > 0)
            {
                string maxCode = dataReturn.Rows[0].Field<string>("MaHST");
                maxNumber = int.Parse(maxCode.Substring(4)) + 1;
            }
            return "HST00" + maxNumber.ToString();
        }

        private bool checkEmptyDGV()
        {
            if (bookReturnDGV.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng tạo thông tin tài liệu!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                foreach (DataGridViewRow row in bookReturnDGV.Rows)
                {
                    if (row.Cells[4].Value == null)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng trả!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void comfirmBtn_Click(object sender, EventArgs e)
        {
            if (checkEmptyDGV() &&
                MessageBox.Show("Bạn có chắc chắn muốn trả?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bookReturnDGV.CurrentCell = null;
                string sql;
                string returnCode = generateReturnCode();
                sql = "insert HoSoTra(MaHST, MaHSM, NgayTra, TenDangNhap) " +
                    "values('" + returnCode + "', '" 
                    + returnDGV.CurrentRow.Cells[0].Value.ToString() 
                    + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + mainFrm.Username + "')";
                database.updateData(sql);
                foreach (DataGridViewRow rowBookReturn in bookReturnDGV.Rows)
                {
                    if (rowBookReturn.Cells[5].Value != null)
                    {
                        sql = "insert ChiTietTra(MaHST, MaTaiLieu, SoLuongTra, TienPhat) " +
                            "values('" + returnCode + "', '" 
                            + rowBookReturn.Cells[0].Value.ToString() 
                            + "', " + rowBookReturn.Cells[4].Value.ToString() + ", " 
                            + rowBookReturn.Cells[5].Value.ToString() + ")";
                        database.updateData(sql);
                    }
                    else
                    {
                        sql = "insert ChiTietTra(MaHST, MaTaiLieu, SoLuongTra) " +
                            "values('" + returnCode + "', '" 
                            + rowBookReturn.Cells[0].Value.ToString()
                            + "', " + rowBookReturn.Cells[4].Value.ToString() + ")";
                        database.updateData(sql);
                    }
                    sql = "update ChiTietMuon set DaTra = 1 where MaHSM = '" 
                        + returnDGV.CurrentRow.Cells[0].Value.ToString() 
                        + "' and MaTaiLieu = '" + rowBookReturn.Cells[0].Value.ToString() + "'";
                    database.updateData(sql);
                    sql = "update TaiLieu set SoLuong = SoLuong + " 
                        + rowBookReturn.Cells[4].Value.ToString() 
                        + ", TinhTrang = 1 where MaTaiLieu = '" 
                        + rowBookReturn.Cells[0].Value.ToString() + "'";
                    database.updateData(sql);
                }
                loadData(database.dataReader("exec ThongTinMuonTra"));
            }
        }

        private void returnCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            loadBookBorrowCode(returnDGV.CurrentRow.Cells[0].Value.ToString());
            clearBookBorrow();
        }

        private void returnExitBtn_Click(object sender, EventArgs e)
        {
            clearInputSearch();
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void getReaderInformation(string readerCode)
        {
            DataTable dataReader = database.dataReader("exec ThongTinBanDocMuonTra '" + readerCode + "'");
            readerCodeTB.Text = readerCode;
            readerNameTB.Text = dataReader.Rows[0].Field<string>("TenBanDoc");
            readerBirthTB.Text = dataReader.Rows[0].Field<DateTime>("NgaySinh").ToString("dd/MM/yyyy");
            readerGenderTB.Text = dataReader.Rows[0].Field<string>("GioiTinh");
            readerPhoneNumberTB.Text = dataReader.Rows[0].Field<string>("SoDienThoai");
        }

        private void returnDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getReaderInformation(returnDGV.CurrentRow.Cells[1].Value.ToString());
                loadBookBorrowCode(returnDGV.CurrentRow.Cells[0].Value.ToString());
                clearBookBorrow();
            }
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

        private void bookReturnDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                getBookInformation(bookReturnDGV.CurrentRow.Cells[0].Value.ToString());
        }

        private string caculateOutOfDateFine(string bookCode)
        {
            int fine = 0;
            int day = (DateTime.Now - ((DateTime)returnDGV.CurrentRow.Cells[3].Value)).Days;
            int price = int.Parse(database.dataReader("select GiaTien from TaiLieu where MaTaiLieu = '"
                    + bookCode + "'").Rows[0].Field<Decimal>("GiaTien").ToString().Split('.')[0]);
            if (day > 0 && day < 30)
                fine += price / 2;
            else if (day >= 30)
                fine += price;
            if (fine == 0)
                return null;
            return fine.ToString();
        }


        private void caculateSumOfFine()
        {
            int fine = 0;
            foreach (DataGridViewRow row in bookReturnDGV.Rows)
            {
                if (row.Cells[5].Value != null)
                    fine += int.Parse(row.Cells[5].Value.ToString());
            }
            if (fine == 0)
                fineTB.Text = "";
            else
                fineTB.Text = fine.ToString();
        }

        private void addReturnBookBtn_Click(object sender, EventArgs e)
        {
            loadBookBorrow(returnBookCBB.Text);
            caculateSumOfFine();
        }

        private void bookReturnDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            returnBookCBB.Items.Add(bookReturnDGV.CurrentRow.Cells[0].Value.ToString());
        }

        private void bookReturnDGV_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (bookReturnDGV.CurrentCell is DataGridViewComboBoxCell)
                bookReturnDGV.EndEdit();
        }

        private void bookReturnDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == bookReturnDGV.Columns[4].Index)
            {
                int value;
                if (e.FormattedValue.ToString().Length > 0)
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out value))
                    {
                        bookReturnDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng đúng định dạng!";
                        e.Cancel = true;
                    }
                    else if (value <= 0)
                    {
                        bookReturnDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng lớn hơn 0!";
                        e.Cancel = true;
                    }
                    else if (value > int.Parse(bookReturnDGV.CurrentRow.Cells[1].Value.ToString()))
                    {
                        bookReturnDGV.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng nhỏ hơn hoặc bằng!";
                        e.Cancel = true;
                    }
                    else
                    {
                        bookReturnDGV.Rows[e.RowIndex].ErrorText = "";
                        e.Cancel = false;
                    }
                }
            }
        }

        private void bookReturnDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fineOutOfDate = int.Parse(caculateOutOfDateFine(bookReturnDGV.CurrentRow.Cells[0].Value.ToString()));
            int quantityBorrow = int.Parse(bookReturnDGV.CurrentRow.Cells[1].Value.ToString());
            int quantityReturn = int.Parse(bookReturnDGV.CurrentRow.Cells[4].Value.ToString());
            int price = int.Parse(database.dataReader("select GiaTien from TaiLieu where MaTaiLieu = '"
                    + bookReturnDGV.CurrentRow.Cells[0].Value.ToString() + "'").Rows[0].Field<Decimal>("GiaTien").ToString().Split('.')[0]);
            if (quantityReturn < quantityBorrow)
                fineOutOfDate += (quantityBorrow - quantityReturn) * price;
            bookReturnDGV.CurrentRow.Cells[5].Value = fineOutOfDate.ToString();
            caculateSumOfFine();
        }

        private void returnBookCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (returnBookCBB.SelectedIndex != -1)
                addReturnBookBtn.Enabled = true;
        }
    }
}
