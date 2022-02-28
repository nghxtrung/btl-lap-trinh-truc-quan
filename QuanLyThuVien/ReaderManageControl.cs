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
using System.Drawing.Imaging;

namespace QuanLyThuVien
{
    public partial class ReaderManageControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public ReaderManageControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataReader)
        {
            readerDGV.DataSource = null;
            readerDGV.Rows.Clear();
            readerDGV.Columns.Clear();

            readerDGV.DataSource = dataReader;
            readerDGV.ClearSelection();

            readerDGV.Columns["MaBanDoc"].HeaderText = "Mã bạn đọc";
            readerDGV.Columns["TenBanDoc"].HeaderText = "Tên bạn đọc";
            readerDGV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            readerDGV.Columns["GioiTinh"].HeaderText = "Giới tính";
            readerDGV.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            readerDGV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            readerDGV.Columns["NgayLap"].HeaderText = "NgayLap";
            readerDGV.Columns["NgayHetHan"].HeaderText = "NgayHetHan";

            readerDGV.Columns["HinhAnh"].DefaultCellStyle.Padding = new Padding(50, 0, 50, 0);
            readerDGV.Columns["HinhAnh"].DefaultCellStyle.NullValue = null;
            ((DataGridViewImageColumn)readerDGV.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            disabledPrimaryFunction(false);
            clearInput();
        }

        private void ReaderManageControl_Load(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec ThongTinBanDoc"));
        }

        public void setEnabledRemove(bool active)
        {
            readerRemoveBtn.Enabled = active;
        }

        public bool checkUserAdmin()
        {
            DataTable loginTable = database.dataReader("select Loai from TaiKhoan " +
                "where TenDangNhap = '" + mainFrm.Username + "'");
            if (loginTable.Rows[0].Field<bool>("Loai"))
                return true;
            return false;
        }

        private void disabledPrimaryFunction(bool active)
        {
            readerSelectPictureBtn.Enabled = active;
            readerRemovePictureBtn.Enabled = active;
            readerSaveBtn.Enabled = active;
            readerCancelBtn.Enabled = active;
            readerBirthDTP.Enabled = active;
            maleRadioBtn.Enabled = active;
            femaleRadioBtn.Enabled = active;
            dayStartDTP.Enabled = active;
            dayEndDTP.Enabled = active;

            active = active == true ? active = false : active = true;

            readerRefreshBtn.Enabled = active;
            readerAddBtn.Enabled = active;
            readerEditBtn.Enabled = active;
            readerNameTB.ReadOnly = active;
            readerPhoneNumberTB.ReadOnly = active;
            readerAddressTB.ReadOnly = active;
            readerDGV.Enabled = active;
        }

        private void clearInput()
        {
            readerPictureBox.Image = null;
            readerCodeTB.Text = "";
            readerNameTB.Text = "";
            readerBirthDTP.Value = DateTime.Now;
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            readerPhoneNumberTB.Text = "";
            readerAddressTB.Text = "";
            dayStartDTP.Value = DateTime.Now;
            dayEndDTP.Value = DateTime.Now;
            readerDGV.ClearSelection();
        }

        private void readerSelectPictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "JPEG Images|*.jpg|PNG Images|*.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                readerPictureBox.Image = new Bitmap(Image.FromFile(openDlg.FileName), new Size(500, 500));
            }
        }

        private void readerRemovePictureBtn_Click(object sender, EventArgs e)
        {
            readerPictureBox.Image = null;
        }

        private void readerRefreshBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm mới thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInputSearch();
            loadData(database.dataReader("exec ThongTinBanDoc"));
        }

        private string generateCode(string tableName, string summaryTableName)
        {
            DataTable dataReader = database.dataReader("select top(1) MaBanDoc from " + tableName + " order by MaBanDoc desc");
            int maxNumber = 1;
            if (dataReader.Rows.Count > 0)
            {
                string maxCode = dataReader.Rows[0].Field<string>("MaBanDoc");
                maxNumber = int.Parse(maxCode.Substring(3)) + 1;
            }
            return summaryTableName + "00" + maxNumber.ToString();
        }

        private void readerAddBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(true);
            clearInput();
            if (readerRemoveBtn.Enabled)
                setEnabledRemove(false);
            readerCodeTB.Text = generateCode("BanDoc", "BD");
        }

        private bool checkSelectDatagridview()
        {
            if (readerDGV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bạn đọc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void readerEditBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview())
            {
                disabledPrimaryFunction(true);
                if (readerRemoveBtn.Enabled)
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

        private bool checkTextBoxNameReader(Label label, TextBox textbox)
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

        private bool checkBirthday(Label label, DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Vui lòng chọn " + label.Text.ToLower() + " nhỏ hơn ngày hôm nay!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return true;
        }

        private void addAndEditReader(bool active)
        {
            int genderValue = 0;
            if (checkTextBoxEmpty(readerNameLB, readerNameTB) &&
                checkTextBoxNameReader(readerNameLB, readerNameTB) &&
                checkBirthday(readerBirthLB, readerBirthDTP) &&
                checkRadioBtn(readerGenderLB, maleRadioBtn, femaleRadioBtn, ref genderValue) &&
                checkTextBoxEmpty(readerPhoneNumberLB, readerPhoneNumberTB) &&
                checkTextBoxPhoneNumber(readerPhoneNumberLB, readerPhoneNumberTB) &&
                checkTextBoxEmpty(readerAddressLB, readerAddressTB) &&
                checkDateTime(dayStartLB, dayEndLB, dayStartDTP, dayEndDTP))
            {
                string sql;
                if (active)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (readerPictureBox.Image == null)
                        {
                            sql = "insert BanDoc(MaBanDoc, TenBanDoc, NgaySinh, GioiTinh, SoDienThoai, DiaChi) " +
                                "values('" + readerCodeTB.Text + "', N'" + readerNameTB.Text + "', '"
                                + readerBirthDTP.Value.ToString("yyyy-MM-dd") + "', " + genderValue + ", '"
                                + readerPhoneNumberTB.Text + "', N'" + readerAddressTB.Text + "')";
                            database.updateData(sql);
                        }
                        else
                        {
                            MemoryStream stream = new MemoryStream();
                            readerPictureBox.Image.Save(stream, ImageFormat.Jpeg);
                            byte[] imageArray = stream.ToArray();
                            sql = "insert BanDoc(MaBanDoc, TenBanDoc, NgaySinh, GioiTinh, SoDienThoai, DiaChi, HinhAnh) " +
                                "values('" + readerCodeTB.Text + "', N'" + readerNameTB.Text + "', '"
                                + readerBirthDTP.Value.ToString("yyyy-MM-dd") + "', " + genderValue + ", '"
                                + readerPhoneNumberTB.Text + "', N'" + readerAddressTB.Text + "', @imageArray)";
                            database.updateDataWithImage(sql, "@imageArray", imageArray);
                        }
                        sql = "insert TheThuVien(MaThe, MaBanDoc, NgayLap, NgayHetHan) " +
                            "values('" + generateCode("TheThuVien", "TTV") + "', '" + readerCodeTB.Text
                            + "', '" + dayStartDTP.Value.ToString("yyyy-MM-dd") + "', '"
                            + dayEndDTP.Value.ToString("yyyy-MM-dd") + "')";
                        database.updateData(sql);
                        loadData(database.dataReader("exec ThongTinBanDoc"));
                        if (checkUserAdmin())
                            setEnabledRemove(true);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (readerPictureBox.Image == null)
                        {
                            sql = "update BanDoc set TenBanDoc = N'" + readerNameTB.Text
                                + "', NgaySinh = '" + readerBirthDTP.Value.ToString("yyyy-MM-dd")
                                + "', GioiTinh = " + genderValue + ", SoDienThoai = '"
                                + readerPhoneNumberTB.Text + "', DiaChi = N'"
                                + readerAddressTB.Text + "', HinhAnh = null where MaBanDoc = '" + readerCodeTB.Text + "'";
                            database.updateData(sql);
                        }
                        else
                        {
                            MemoryStream stream = new MemoryStream();
                            readerPictureBox.Image.Save(stream, ImageFormat.Jpeg);
                            byte[] imageArray = stream.ToArray();
                            sql = "update BanDoc set TenBanDoc = N'" + readerNameTB.Text
                                + "', NgaySinh = '" + readerBirthDTP.Value.ToString("yyyy-MM-dd")
                                + "', GioiTinh = " + genderValue + ", SoDienThoai = '"
                                + readerPhoneNumberTB.Text + "', DiaChi = N'"
                                + readerAddressTB.Text + "', HinhAnh = @imageArray where MaBanDoc = '" + readerCodeTB.Text + "'";
                            database.updateDataWithImage(sql, "@imageArray", imageArray);
                        }
                        sql = "update TheThuVien set NgayLap = '" + dayStartDTP.Value.ToString("yyyy-MM-dd")
                            + "', NgayHetHan = '" + dayEndDTP.Value.ToString("yyyy-MM-dd")
                            + "' where MaBanDoc = '" + readerCodeTB.Text + "'";
                        database.updateData(sql);
                        loadData(database.dataReader("exec ThongTinBanDoc"));
                        if (checkUserAdmin())
                            setEnabledRemove(true);
                    }
                }
            }
        }

        private bool checkRemove()
        {
            if (database.dataReader("select * from HoSoMuon where MaBanDoc = '"
                + readerDGV.CurrentRow.Cells[0].Value.ToString() + "'").Rows.Count > 0)
            {
                MessageBox.Show("Tài liệu đang đã tồn tại lượt mượn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void readerRemoveBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectDatagridview() &&
                checkRemove() &&
                MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlDeleteLibraryCard = "delete from TheThuVien where MaBanDoc = '" + readerCodeTB.Text + "'";
                string sqlDeleteReader = "delete from BanDoc where MaBanDoc = '" + readerCodeTB.Text + "'";
                database.updateData(sqlDeleteLibraryCard);
                database.updateData(sqlDeleteReader);
                loadData(database.dataReader("exec ThongTinBanDoc"));
            }
        }

        private void readerSaveBtn_Click(object sender, EventArgs e)
        {
            if (readerDGV.SelectedCells.Count == 0)
                addAndEditReader(true);
            else
                addAndEditReader(false);
        }

        private void readerCancelBtn_Click(object sender, EventArgs e)
        {
            disabledPrimaryFunction(false);
            if (readerDGV.SelectedCells.Count == 0)
                clearInput();
            if (checkUserAdmin())
                setEnabledRemove(true);
        }

        public void clearInputSearch()
        {
            readerCodeRadioBtn.Checked = false;
            readerNameRadioBtn.Checked = false;
            searchReaderContentTB.Text = "";
        }

        private void readerExitBtn_Click(object sender, EventArgs e)
        {
            clearInputSearch();
            mainFrm.TabControl().TabPages.Remove(mainFrm.TabControl().SelectedTab);
        }

        private void readerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                readerCodeTB.Text = readerDGV.CurrentRow.Cells[0].Value.ToString();
                readerNameTB.Text = readerDGV.CurrentRow.Cells[1].Value.ToString();
                readerBirthDTP.Value = (DateTime)readerDGV.CurrentRow.Cells[2].Value;
                if (readerDGV.CurrentRow.Cells[3].Value.ToString() == "Nam")
                    maleRadioBtn.Checked = true;
                else if (readerDGV.CurrentRow.Cells[3].Value.ToString() == "Nữ")
                    femaleRadioBtn.Checked = true;
                readerPhoneNumberTB.Text = readerDGV.CurrentRow.Cells[4].Value.ToString();
                readerAddressTB.Text = readerDGV.CurrentRow.Cells[5].Value.ToString();
                dayStartDTP.Value = (DateTime)readerDGV.CurrentRow.Cells[6].Value;
                dayEndDTP.Value = (DateTime)readerDGV.CurrentRow.Cells[7].Value;
                if (readerDGV.CurrentRow.Cells[8].Value == DBNull.Value)
                    readerPictureBox.Image = null;
                else
                {
                    byte[] imageArray = (byte[])readerDGV.CurrentRow.Cells[8].Value;
                    MemoryStream stream = new MemoryStream(imageArray);
                    readerPictureBox.Image = new Bitmap(Image.FromStream(stream), new Size(500, 500));
                    stream.Close();
                    stream.Dispose();
                }
            }
        }

        private void searchReaderContentTB_TextChanged(object sender, EventArgs e)
        {
            if (readerCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMaBanDoc '" + searchReaderContentTB.Text + "'"));
            else if (readerNameRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTenBanDoc N'" + searchReaderContentTB.Text + "'"));
        }

        private void readerCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMaBanDoc '" + searchReaderContentTB.Text + "'"));
        }

        private void readerNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTenBanDoc N'" + searchReaderContentTB.Text + "'"));
        }
    }
}
