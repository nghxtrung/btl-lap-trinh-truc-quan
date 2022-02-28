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
    public partial class SearchControl : UserControl
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public SearchControl(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        public void loadData(DataTable dataBook)
        {
            searchDGV.DataSource = null;
            searchDGV.Rows.Clear();
            searchDGV.Columns.Clear();

            searchDGV.DataSource = dataBook;
            searchDGV.ClearSelection();
        }


        private void searchContentTB_TextChanged(object sender, EventArgs e)
        {
            if (bookCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMaTaiLieu '" + searchContentTB.Text + "'"));
            else if (bookNameRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTenTaiLieu N'" + searchContentTB.Text + "'"));
            else if (authorRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTacGia N'" + searchContentTB.Text + "'"));
            else if (categoryRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemTheLoai N'" + searchContentTB.Text + "'"));
            else if (borrowCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + searchContentTB.Text + "'"));
            else if (readerCodeRadioBtn.Checked)
                loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + searchContentTB.Text + "'"));
        }

        public void clearInputSearch()
        {
            bookCodeRadioBtn.Checked = false;
            bookNameRadioBtn.Checked = false;
            authorRadioBtn.Checked = false;
            categoryRadioBtn.Checked = false;
            borrowCodeRadioBtn.Checked = false;
            readerCodeRadioBtn.Checked = false;
            searchContentTB.Text = "";
        }

        private void bookCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMaTaiLieu '" + searchContentTB.Text + "'"));
        }

        private void bookNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTenTaiLieu N'" + searchContentTB.Text + "'"));
        }

        private void authorRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTacGia N'" + searchContentTB.Text + "'"));
        }

        private void categoryRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemTheLoai N'" + searchContentTB.Text + "'"));
        }

        private void borrowCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaMuonTra '" + searchContentTB.Text + "'"));
        }

        private void readerCodeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            loadData(database.dataReader("exec TimKiemMTMaBanDoc '" + searchContentTB.Text + "'"));
        }
    }
}
