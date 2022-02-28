using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace QuanLyThuVien
{
    public partial class StatisticControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();

        public StatisticControl()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            sumOfBookQuantityTB.Text = (database.dataReader("select sum(SoLuong) as SoLuongTL " +
                "from TaiLieu").Rows[0].Field<int>("SoLuongTL")).ToString();
            sumOfBookPriceTB.Text = database.dataReader("select sum(GiaTien) as TongTien from " +
                "TaiLieu").Rows[0].Field<Decimal>("TongTien").ToString().Split('.')[0];
            sumOfBorrowBookQuantityTB.Text = (database.dataReader("select sum(SoLuongMuon) as SoLuongMuon from " +
                "ChiTietMuon where DaTra = 0").Rows[0].Field<int>("SoLuongMuon")).ToString();
            sumOfFine.Text = database.dataReader("select sum(TienPhat) as TongTienPhat from " +
                "ChiTietTra").Rows[0].Field<Decimal>("TongTienPhat").ToString().Split('.')[0];
        }

        private void StatisticControl_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public string reportDayStart()
        {
            return reportDayStartDTP.Value.ToString("yyyy-MM-dd");
        }

        public string reportDayEnd()
        {
            return reportDayEndDTP.Value.ToString("yyyy-MM-dd");
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            if (outOfDateRadioBtn.Checked)
                reportDGV.DataSource = database.dataReader("exec ThongTinQuaHan '" + reportDayStart() + "', '" + reportDayEnd() + "'");
            else if (doneRadioBtn.Checked)
                reportDGV.DataSource = database.dataReader("exec ThongTinDaTra '" + reportDayStart() + "', '" + reportDayEnd() + "'");
        }

        private void reportExportBtn_Click(object sender, EventArgs e)
        {
            if (outOfDateRadioBtn.Checked)
            {
                DataTable dataOutOfDate = database.dataReader("exec ThongTinQuaHan '" + reportDayStart() + "', '" + reportDayEnd() + "'");
                if (dataOutOfDate.Rows.Count > 0)
                {
                    Excel.Application excelApplication = new Excel.Application();
                    Excel.Workbook excelWorkbook = excelApplication.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets[1];

                    Excel.Range header = (Excel.Range)excelWorksheet.Cells[1, 2];
                    excelWorksheet.get_Range("B1:G1").Merge(true);
                    header.Font.Size = 13;
                    header.Font.Bold = true;
                    header.Font.Color = Color.Red;
                    header.Value = "Danh sách mượn quá hạn từ ngày "
                        + reportDayStartDTP.Value.ToString("dd/MM/yyyy") + " đến ngày "
                        + reportDayEndDTP.Value.ToString("dd/MM/yyyy");

                    excelWorksheet.get_Range("A3:I3").Font.Bold = true;
                    excelWorksheet.get_Range("A3:I3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    excelWorksheet.get_Range("A3").Value = "Mã mượn";
                    excelWorksheet.get_Range("A3").ColumnWidth = 10;
                    excelWorksheet.get_Range("B3").Value = "Mã bạn đọc";
                    excelWorksheet.get_Range("B3").ColumnWidth = 13;
                    excelWorksheet.get_Range("C3").Value = "Tên bạn đọc";
                    excelWorksheet.get_Range("C3").ColumnWidth = 20;
                    excelWorksheet.get_Range("D3").Value = "Số điện thoại";
                    excelWorksheet.get_Range("D3").ColumnWidth = 15;
                    excelWorksheet.get_Range("E3").Value = "Mã Tài liệu";
                    excelWorksheet.get_Range("E3").ColumnWidth = 12;
                    excelWorksheet.get_Range("F3").Value = "Tên tài liệu";
                    excelWorksheet.get_Range("F3").ColumnWidth = 15;
                    excelWorksheet.get_Range("G3").Value = "Số lượng mượn";
                    excelWorksheet.get_Range("G3").ColumnWidth = 16;
                    excelWorksheet.get_Range("H3").Value = "Ngày mượn";
                    excelWorksheet.get_Range("H3").ColumnWidth = 14;
                    excelWorksheet.get_Range("I3").Value = "Ngày hẹn trả";
                    excelWorksheet.get_Range("I3").ColumnWidth = 14;

                    for (int i = 0; i < dataOutOfDate.Rows.Count; i++)
                    {
                        excelWorksheet.get_Range("A" + (i + 4).ToString() + ":I" + (i + 4).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        excelWorksheet.get_Range("A" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("MaHSM");
                        excelWorksheet.get_Range("B" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("MaBanDoc"); ;
                        excelWorksheet.get_Range("C" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("TenBanDoc");
                        excelWorksheet.get_Range("D" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("SoDienThoai");
                        excelWorksheet.get_Range("E" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("MaTaiLieu");
                        excelWorksheet.get_Range("F" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<string>("TenTaiLieu");
                        excelWorksheet.get_Range("G" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<int>("SoLuongMuon");
                        excelWorksheet.get_Range("H" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<DateTime>("NgayMuon").ToString("dd/MM/yyyy");
                        excelWorksheet.get_Range("I" + (i + 4).ToString()).Value = dataOutOfDate.Rows[i].Field<DateTime>("NgayHenTra").ToString("dd/MM/yyyy");
                    }
                    excelWorksheet.Name = "DanhSachMuonQuaHan";
                    excelWorkbook.Activate();
                    SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls";
                    saveDlg.FilterIndex = 1;
                    saveDlg.AddExtension = true;
                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        excelWorkbook.SaveAs(saveDlg.FileName.ToString());
                        Process.Start(saveDlg.FileName.ToString());
                    }
                    excelApplication.Quit();
                }
                else
                    MessageBox.Show("Không tồn tại danh sách mượn quá hạn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (doneRadioBtn.Checked)
            {
                DataTable dataDone = database.dataReader("exec ThongTinDaTra '" + reportDayStart() + "', '" + reportDayEnd() + "'");
                if (dataDone.Rows.Count > 0)
                {
                    Excel.Application excelApplication = new Excel.Application();
                    Excel.Workbook excelWorkbook = excelApplication.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets[1];

                    Excel.Range header = (Excel.Range)excelWorksheet.Cells[1, 2];
                    excelWorksheet.get_Range("B1:G1").Merge(true);
                    header.Font.Size = 13;
                    header.Font.Bold = true;
                    header.Font.Color = Color.Red;
                    header.Value = "Danh sách đã trả từ ngày "
                        + reportDayStartDTP.Value.ToString("dd/MM/yyyy") + " đến ngày "
                        + reportDayEndDTP.Value.ToString("dd/MM/yyyy");

                    excelWorksheet.get_Range("A3:L3").Font.Bold = true;
                    excelWorksheet.get_Range("A3:L3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    excelWorksheet.get_Range("A3").Value = "Mã trả";
                    excelWorksheet.get_Range("A3").ColumnWidth = 10;
                    excelWorksheet.get_Range("B3").Value = "Mã bạn đọc";
                    excelWorksheet.get_Range("B3").ColumnWidth = 13;
                    excelWorksheet.get_Range("C3").Value = "Tên bạn đọc";
                    excelWorksheet.get_Range("C3").ColumnWidth = 20;
                    excelWorksheet.get_Range("D3").Value = "Số điện thoại";
                    excelWorksheet.get_Range("D3").ColumnWidth = 15;
                    excelWorksheet.get_Range("E3").Value = "Mã Tài liệu";
                    excelWorksheet.get_Range("E3").ColumnWidth = 12;
                    excelWorksheet.get_Range("F3").Value = "Tên tài liệu";
                    excelWorksheet.get_Range("F3").ColumnWidth = 15;
                    excelWorksheet.get_Range("G3").Value = "Số lượng mượn";
                    excelWorksheet.get_Range("G3").ColumnWidth = 16;
                    excelWorksheet.get_Range("H3").Value = "Số lượng trả";
                    excelWorksheet.get_Range("H3").ColumnWidth = 16;
                    excelWorksheet.get_Range("I3").Value = "Tiền phạt";
                    excelWorksheet.get_Range("I3").ColumnWidth = 14;
                    excelWorksheet.get_Range("J3").Value = "Ngày mượn";
                    excelWorksheet.get_Range("J3").ColumnWidth = 14;
                    excelWorksheet.get_Range("K3").Value = "Ngày hẹn trả";
                    excelWorksheet.get_Range("K3").ColumnWidth = 14;
                    excelWorksheet.get_Range("L3").Value = "Ngày trả";
                    excelWorksheet.get_Range("L3").ColumnWidth = 14;

                    for (int i = 0; i < dataDone.Rows.Count; i++)
                    {
                        excelWorksheet.get_Range("A" + (i + 4).ToString() + ":L" + (i + 4).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        excelWorksheet.get_Range("A" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("MaHST");
                        excelWorksheet.get_Range("B" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("MaBanDoc"); ;
                        excelWorksheet.get_Range("C" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("TenBanDoc");
                        excelWorksheet.get_Range("D" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("SoDienThoai");
                        excelWorksheet.get_Range("E" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("MaTaiLieu");
                        excelWorksheet.get_Range("F" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<string>("TenTaiLieu");
                        excelWorksheet.get_Range("G" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<int>("SoLuongMuon");
                        excelWorksheet.get_Range("H" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<int>("SoLuongTra");
                        excelWorksheet.get_Range("I" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<decimal?>("TienPhat");
                        excelWorksheet.get_Range("J" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<DateTime>("NgayMuon").ToString("dd/MM/yyyy");
                        excelWorksheet.get_Range("K" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<DateTime>("NgayHenTra").ToString("dd/MM/yyyy");
                        excelWorksheet.get_Range("L" + (i + 4).ToString()).Value = dataDone.Rows[i].Field<DateTime>("NgayTra").ToString("dd/MM/yyyy");
                    }
                    excelWorksheet.Name = "DanhSachDaTra";
                    excelWorkbook.Activate();
                    SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls";
                    saveDlg.FilterIndex = 1;
                    saveDlg.AddExtension = true;
                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        excelWorkbook.SaveAs(saveDlg.FileName.ToString());
                        Process.Start(saveDlg.FileName.ToString());
                    }
                    excelApplication.Quit();
                }
                else
                    MessageBox.Show("Không tồn tại danh sách mượn quá hạn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
