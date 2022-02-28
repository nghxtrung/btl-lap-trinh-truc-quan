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
    public partial class MainForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private string username;

        private SearchControl searchControl;
        private SupplyManageControl supplyManageControl;
        private ReaderManageControl readerManageControl;
        private BookManageControl bookManageControl;
        private BorrowManageControl borrowManageControl;
        private ReturnManageControl returnManageControl;
        private StatisticControl statisticControl = new StatisticControl();
        private AccountManageControl accountManageControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void hideAllTabPage()
        {
            tabControl.TabPages.Remove(searchTab);
            tabControl.TabPages.Remove(supplyManageTab);
            tabControl.TabPages.Remove(readerManageTab);
            tabControl.TabPages.Remove(bookManageTab);
            tabControl.TabPages.Remove(borrowManageTab);
            tabControl.TabPages.Remove(returnManageTab);
            tabControl.TabPages.Remove(statisticTab);
            tabControl.TabPages.Remove(accountManageTab);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            searchControl = new SearchControl(this);
            supplyManageControl = new SupplyManageControl(this);
            readerManageControl = new ReaderManageControl(this);
            bookManageControl = new BookManageControl(this);
            borrowManageControl = new BorrowManageControl(this);
            returnManageControl = new ReturnManageControl(this);
            accountManageControl = new AccountManageControl(this);

            hideAllTabPage();
            setEnabledAccountManage(false);
            setEnabledAllCategory(false);

            searchControl.Dock = DockStyle.Fill;
            supplyManageControl.Dock = DockStyle.Fill;
            readerManageControl.Dock = DockStyle.Fill;
            bookManageControl.Dock = DockStyle.Fill;
            borrowManageControl.Dock = DockStyle.Fill;
            returnManageControl.Dock = DockStyle.Fill;
            statisticControl.Dock = DockStyle.Fill;
            accountManageControl.Dock = DockStyle.Fill;

            //searchTab.AutoScroll = true;
            //supplyManageTab.AutoScroll = true;
            //readerManageTab.AutoScroll = true;
            //bookManageTab.AutoScroll = true;
            //borrowManageTab.AutoScroll = true;
            //returnManageTab.AutoScroll = true;
            //statisticTab.AutoScroll = true;
            //accountManageTab.AutoScroll = true;

            searchTab.Controls.Add(searchControl);
            supplyManageTab.Controls.Add(supplyManageControl);
            readerManageTab.Controls.Add(readerManageControl);
            bookManageTab.Controls.Add(bookManageControl);
            borrowManageTab.Controls.Add(borrowManageControl);
            returnManageTab.Controls.Add(returnManageControl);
            statisticTab.Controls.Add(statisticControl);
            accountManageTab.Controls.Add(accountManageControl); 
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (tabControl.GetTabRect(tabControl.SelectedIndex).Contains(new Point(e.X, e.Y)))
                {
                    closeTabContextMenu.Show(tabControl, e.X, e.Y);
                }
            }
        }

        private void closeContextMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void showLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginFrm = new LoginForm(this);
            loginFrm.Show();
        }

        private void accountManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(accountManageTab))
            {
                accountManageControl.loadData(database.dataReader("exec ThongTinTaiKhoan"));
                tabControl.TabPages.Add(accountManageTab);
            }
            tabControl.SelectedTab = accountManageTab;
        }

        private void showChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfoForm changeInfoFrm = new ChangeInfoForm(this);
            changeInfoFrm.Show();
        }

        private void showChangePassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassFrm = new ChangePasswordForm(this);
            changePassFrm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                setEnabledLogin(true);
                setEnabledAccountManage(false);
                setEnabledAllCategory(false);
                hideAllTabPage();
                setAccountName("Xin chào!");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(searchTab))
            {
                searchControl.clearInputSearch();
                searchControl.loadData(null);
                tabControl.TabPages.Add(searchTab);
            }
            tabControl.SelectedTab = searchTab;
        }

        private void supplyManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(supplyManageTab))
            {
                supplyManageControl.loadData(database.dataReader("select * from NhaCungCap"));
                if (supplyManageControl.checkUserAdmin())
                    supplyManageControl.setEnabledRemove(true);
                else
                    supplyManageControl.setEnabledRemove(false);
                tabControl.TabPages.Add(supplyManageTab);
            }
            tabControl.SelectedTab = supplyManageTab;
        }

        private void readerManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(readerManageTab))
            {
                readerManageControl.clearInputSearch();
                readerManageControl.loadData(database.dataReader("exec ThongTinBanDoc"));
                if (readerManageControl.checkUserAdmin())
                    readerManageControl.setEnabledRemove(true);
                else
                    readerManageControl.setEnabledRemove(false);
                tabControl.TabPages.Add(readerManageTab);
            }
            tabControl.SelectedTab = readerManageTab;
        }

        private void bookManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(bookManageTab))
            {
                bookManageControl.clearInputSearch();
                bookManageControl.loadData(database.dataReader("exec ThongTinTaiLieu"));
                if (bookManageControl.checkUserAdmin())
                    bookManageControl.setEnabledRemove(true);
                else
                    bookManageControl.setEnabledRemove(false);
                tabControl.TabPages.Add(bookManageTab);
            }
            tabControl.SelectedTab = bookManageTab;
        }

        private void borrowManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(borrowManageTab))
            {
                borrowManageControl.clearInputSearch();
                borrowManageControl.loadData(database.dataReader("exec ThongTinMuonTra"));
                if (borrowManageControl.checkUserAdmin())
                    borrowManageControl.setEnabledRemove(true);
                else
                    borrowManageControl.setEnabledRemove(false);
                tabControl.TabPages.Add(borrowManageTab);
            }
            tabControl.SelectedTab = borrowManageTab;
        }

        private void returnManageBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(returnManageTab))
            {
                returnManageControl.clearInputSearch();
                returnManageControl.loadData(database.dataReader("exec ThongTinMuonTra"));
                tabControl.TabPages.Add(returnManageTab);
            }
            tabControl.SelectedTab = returnManageTab;
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(statisticTab))
            {
                tabControl.TabPages.Add(statisticTab);
                tabControl.SelectedTab = statisticTab;
            }
        }

        public void setEnabledLogin(bool active)
        {
            showLoginBtn.Enabled = active;
        }

        public void setEnabledAccountManage(bool active)
        {
            accountManageBtn.Enabled = active;
        }

        public void setEnabledAllCategory(bool active)
        {
            showChangeInfoBtn.Enabled = active;
            showChangePassBtn.Enabled = active;
            logoutBtn.Enabled = active;
            supplyManageBtn.Enabled = active;
            readerManageBtn.Enabled = active;
            bookManageBtn.Enabled = active;
            borrowManageBtn.Enabled = active;
            returnManageBtn.Enabled = active;
            statisticBtn.Enabled = active;
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public void setAccountName(string name)
        {
            accountNameLB.Text = name;
        }

        public TabControl TabControl()
        {
            return tabControl;
        }
    }
}
