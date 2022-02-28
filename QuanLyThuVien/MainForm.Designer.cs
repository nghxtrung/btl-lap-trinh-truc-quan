
namespace QuanLyThuVien
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statisticBtn = new FontAwesome.Sharp.IconButton();
            this.returnManageBtn = new FontAwesome.Sharp.IconButton();
            this.borrowManageBtn = new FontAwesome.Sharp.IconButton();
            this.bookManageBtn = new FontAwesome.Sharp.IconButton();
            this.readerManageBtn = new FontAwesome.Sharp.IconButton();
            this.supplyManageBtn = new FontAwesome.Sharp.IconButton();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.showChangePassBtn = new FontAwesome.Sharp.IconButton();
            this.accountManageBtn = new FontAwesome.Sharp.IconButton();
            this.showChangeInfoBtn = new FontAwesome.Sharp.IconButton();
            this.showLoginBtn = new FontAwesome.Sharp.IconButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.supplyManageTab = new System.Windows.Forms.TabPage();
            this.readerManageTab = new System.Windows.Forms.TabPage();
            this.bookManageTab = new System.Windows.Forms.TabPage();
            this.borrowManageTab = new System.Windows.Forms.TabPage();
            this.returnManageTab = new System.Windows.Forms.TabPage();
            this.statisticTab = new System.Windows.Forms.TabPage();
            this.accountManageTab = new System.Windows.Forms.TabPage();
            this.closeTabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountNameLB = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.closeTabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statisticBtn);
            this.groupBox2.Controls.Add(this.returnManageBtn);
            this.groupBox2.Controls.Add(this.borrowManageBtn);
            this.groupBox2.Controls.Add(this.bookManageBtn);
            this.groupBox2.Controls.Add(this.readerManageBtn);
            this.groupBox2.Controls.Add(this.supplyManageBtn);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Location = new System.Drawing.Point(465, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // statisticBtn
            // 
            this.statisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.statisticBtn.IconColor = System.Drawing.Color.Black;
            this.statisticBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statisticBtn.Location = new System.Drawing.Point(720, 30);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Size = new System.Drawing.Size(112, 115);
            this.statisticBtn.TabIndex = 9;
            this.statisticBtn.Text = "Báo cáo thống kê";
            this.statisticBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statisticBtn.UseVisualStyleBackColor = true;
            this.statisticBtn.Click += new System.EventHandler(this.statisticBtn_Click);
            // 
            // returnManageBtn
            // 
            this.returnManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnManageBtn.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.returnManageBtn.IconColor = System.Drawing.Color.Black;
            this.returnManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.returnManageBtn.Location = new System.Drawing.Point(602, 30);
            this.returnManageBtn.Name = "returnManageBtn";
            this.returnManageBtn.Size = new System.Drawing.Size(112, 115);
            this.returnManageBtn.TabIndex = 9;
            this.returnManageBtn.Text = "Quản lý trả sách";
            this.returnManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnManageBtn.UseVisualStyleBackColor = true;
            this.returnManageBtn.Click += new System.EventHandler(this.returnManageBtn_Click);
            // 
            // borrowManageBtn
            // 
            this.borrowManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowManageBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.borrowManageBtn.IconColor = System.Drawing.Color.Black;
            this.borrowManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.borrowManageBtn.Location = new System.Drawing.Point(484, 30);
            this.borrowManageBtn.Name = "borrowManageBtn";
            this.borrowManageBtn.Size = new System.Drawing.Size(112, 115);
            this.borrowManageBtn.TabIndex = 9;
            this.borrowManageBtn.Text = "Quản lý mượn sách";
            this.borrowManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrowManageBtn.UseVisualStyleBackColor = true;
            this.borrowManageBtn.Click += new System.EventHandler(this.borrowManageBtn_Click);
            // 
            // bookManageBtn
            // 
            this.bookManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookManageBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.bookManageBtn.IconColor = System.Drawing.Color.Black;
            this.bookManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookManageBtn.Location = new System.Drawing.Point(366, 30);
            this.bookManageBtn.Name = "bookManageBtn";
            this.bookManageBtn.Size = new System.Drawing.Size(112, 115);
            this.bookManageBtn.TabIndex = 9;
            this.bookManageBtn.Text = "Quản lý tài liệu";
            this.bookManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookManageBtn.UseVisualStyleBackColor = true;
            this.bookManageBtn.Click += new System.EventHandler(this.bookManageBtn_Click);
            // 
            // readerManageBtn
            // 
            this.readerManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readerManageBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.readerManageBtn.IconColor = System.Drawing.Color.Black;
            this.readerManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.readerManageBtn.Location = new System.Drawing.Point(248, 30);
            this.readerManageBtn.Name = "readerManageBtn";
            this.readerManageBtn.Size = new System.Drawing.Size(112, 115);
            this.readerManageBtn.TabIndex = 8;
            this.readerManageBtn.Text = "Quản lý bạn đọc";
            this.readerManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.readerManageBtn.UseVisualStyleBackColor = true;
            this.readerManageBtn.Click += new System.EventHandler(this.readerManageBtn_Click);
            // 
            // supplyManageBtn
            // 
            this.supplyManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyManageBtn.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.supplyManageBtn.IconColor = System.Drawing.Color.Black;
            this.supplyManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.supplyManageBtn.Location = new System.Drawing.Point(130, 30);
            this.supplyManageBtn.Name = "supplyManageBtn";
            this.supplyManageBtn.Size = new System.Drawing.Size(112, 115);
            this.supplyManageBtn.TabIndex = 7;
            this.supplyManageBtn.Text = "Quản lý nhà cung cấp";
            this.supplyManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplyManageBtn.UseVisualStyleBackColor = true;
            this.supplyManageBtn.Click += new System.EventHandler(this.supplyManageBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.Location = new System.Drawing.Point(12, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 115);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutBtn);
            this.groupBox1.Controls.Add(this.showChangePassBtn);
            this.groupBox1.Controls.Add(this.accountManageBtn);
            this.groupBox1.Controls.Add(this.showChangeInfoBtn);
            this.groupBox1.Controls.Add(this.showLoginBtn);
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ thống";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.Black;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 30;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(247, 108);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(183, 35);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // showChangePassBtn
            // 
            this.showChangePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChangePassBtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.showChangePassBtn.IconColor = System.Drawing.Color.Black;
            this.showChangePassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showChangePassBtn.IconSize = 30;
            this.showChangePassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showChangePassBtn.Location = new System.Drawing.Point(247, 67);
            this.showChangePassBtn.Name = "showChangePassBtn";
            this.showChangePassBtn.Size = new System.Drawing.Size(183, 35);
            this.showChangePassBtn.TabIndex = 9;
            this.showChangePassBtn.Text = "Đổi mật khẩu";
            this.showChangePassBtn.UseVisualStyleBackColor = true;
            this.showChangePassBtn.Click += new System.EventHandler(this.showChangePassBtn_Click);
            // 
            // accountManageBtn
            // 
            this.accountManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManageBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.accountManageBtn.IconColor = System.Drawing.Color.Black;
            this.accountManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountManageBtn.Location = new System.Drawing.Point(129, 28);
            this.accountManageBtn.Name = "accountManageBtn";
            this.accountManageBtn.Size = new System.Drawing.Size(112, 115);
            this.accountManageBtn.TabIndex = 8;
            this.accountManageBtn.Text = "Quản lý tài khoản";
            this.accountManageBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountManageBtn.UseVisualStyleBackColor = true;
            this.accountManageBtn.Click += new System.EventHandler(this.accountManageBtn_Click);
            // 
            // showChangeInfoBtn
            // 
            this.showChangeInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChangeInfoBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.showChangeInfoBtn.IconColor = System.Drawing.Color.Black;
            this.showChangeInfoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showChangeInfoBtn.IconSize = 30;
            this.showChangeInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showChangeInfoBtn.Location = new System.Drawing.Point(247, 28);
            this.showChangeInfoBtn.Name = "showChangeInfoBtn";
            this.showChangeInfoBtn.Size = new System.Drawing.Size(183, 33);
            this.showChangeInfoBtn.TabIndex = 8;
            this.showChangeInfoBtn.Text = "Đổi thông tin";
            this.showChangeInfoBtn.UseVisualStyleBackColor = true;
            this.showChangeInfoBtn.Click += new System.EventHandler(this.showChangeInfoBtn_Click);
            // 
            // showLoginBtn
            // 
            this.showLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLoginBtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.showLoginBtn.IconColor = System.Drawing.Color.Black;
            this.showLoginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showLoginBtn.Location = new System.Drawing.Point(11, 28);
            this.showLoginBtn.Name = "showLoginBtn";
            this.showLoginBtn.Size = new System.Drawing.Size(112, 115);
            this.showLoginBtn.TabIndex = 7;
            this.showLoginBtn.Text = "Đăng nhập";
            this.showLoginBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showLoginBtn.UseVisualStyleBackColor = true;
            this.showLoginBtn.Click += new System.EventHandler(this.showLoginBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 202);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Controls.Add(this.supplyManageTab);
            this.tabControl.Controls.Add(this.readerManageTab);
            this.tabControl.Controls.Add(this.bookManageTab);
            this.tabControl.Controls.Add(this.borrowManageTab);
            this.tabControl.Controls.Add(this.returnManageTab);
            this.tabControl.Controls.Add(this.statisticTab);
            this.tabControl.Controls.Add(this.accountManageTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(295, 202);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1384, 652);
            this.tabControl.TabIndex = 3;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // searchTab
            // 
            this.searchTab.BackColor = System.Drawing.Color.White;
            this.searchTab.Location = new System.Drawing.Point(4, 29);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(1376, 619);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Tìm kiếm";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // supplyManageTab
            // 
            this.supplyManageTab.Location = new System.Drawing.Point(4, 29);
            this.supplyManageTab.Name = "supplyManageTab";
            this.supplyManageTab.Size = new System.Drawing.Size(1376, 619);
            this.supplyManageTab.TabIndex = 1;
            this.supplyManageTab.Text = "Quản lý nhà cung cấp";
            this.supplyManageTab.UseVisualStyleBackColor = true;
            // 
            // readerManageTab
            // 
            this.readerManageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readerManageTab.Location = new System.Drawing.Point(4, 29);
            this.readerManageTab.Name = "readerManageTab";
            this.readerManageTab.Size = new System.Drawing.Size(1376, 619);
            this.readerManageTab.TabIndex = 2;
            this.readerManageTab.Text = "Quản lý bạn đọc";
            this.readerManageTab.UseVisualStyleBackColor = true;
            // 
            // bookManageTab
            // 
            this.bookManageTab.Location = new System.Drawing.Point(4, 29);
            this.bookManageTab.Name = "bookManageTab";
            this.bookManageTab.Size = new System.Drawing.Size(1376, 619);
            this.bookManageTab.TabIndex = 3;
            this.bookManageTab.Text = "Quản lý tài liệu";
            this.bookManageTab.UseVisualStyleBackColor = true;
            // 
            // borrowManageTab
            // 
            this.borrowManageTab.Location = new System.Drawing.Point(4, 29);
            this.borrowManageTab.Name = "borrowManageTab";
            this.borrowManageTab.Size = new System.Drawing.Size(1376, 619);
            this.borrowManageTab.TabIndex = 4;
            this.borrowManageTab.Text = "Quản lý mượn sách";
            this.borrowManageTab.UseVisualStyleBackColor = true;
            // 
            // returnManageTab
            // 
            this.returnManageTab.Location = new System.Drawing.Point(4, 29);
            this.returnManageTab.Name = "returnManageTab";
            this.returnManageTab.Size = new System.Drawing.Size(1376, 619);
            this.returnManageTab.TabIndex = 5;
            this.returnManageTab.Text = "Quản lý trả sách";
            this.returnManageTab.UseVisualStyleBackColor = true;
            // 
            // statisticTab
            // 
            this.statisticTab.Location = new System.Drawing.Point(4, 29);
            this.statisticTab.Name = "statisticTab";
            this.statisticTab.Size = new System.Drawing.Size(1376, 619);
            this.statisticTab.TabIndex = 6;
            this.statisticTab.Text = "Báo cáo thống kê";
            this.statisticTab.UseVisualStyleBackColor = true;
            // 
            // accountManageTab
            // 
            this.accountManageTab.Location = new System.Drawing.Point(4, 29);
            this.accountManageTab.Name = "accountManageTab";
            this.accountManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountManageTab.Size = new System.Drawing.Size(1376, 619);
            this.accountManageTab.TabIndex = 7;
            this.accountManageTab.Text = "Quản lý tài khoản";
            this.accountManageTab.UseVisualStyleBackColor = true;
            // 
            // closeTabContextMenu
            // 
            this.closeTabContextMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTabContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.closeTabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeContextMenuItem});
            this.closeTabContextMenu.Name = "contextMenuStrip1";
            this.closeTabContextMenu.Size = new System.Drawing.Size(111, 26);
            this.closeTabContextMenu.Text = "Đóng";
            // 
            // closeContextMenuItem
            // 
            this.closeContextMenuItem.Name = "closeContextMenuItem";
            this.closeContextMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeContextMenuItem.Text = "Đóng";
            this.closeContextMenuItem.Click += new System.EventHandler(this.closeContextMenuItem_Click);
            // 
            // accountNameLB
            // 
            this.accountNameLB.AutoSize = true;
            this.accountNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLB.Location = new System.Drawing.Point(23, 9);
            this.accountNameLB.Name = "accountNameLB";
            this.accountNameLB.Size = new System.Drawing.Size(104, 25);
            this.accountNameLB.TabIndex = 4;
            this.accountNameLB.Text = "Xin chào!";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1691, 867);
            this.Controls.Add(this.accountNameLB);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.closeTabContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton showLoginBtn;
        private FontAwesome.Sharp.IconButton statisticBtn;
        private FontAwesome.Sharp.IconButton returnManageBtn;
        private FontAwesome.Sharp.IconButton borrowManageBtn;
        private FontAwesome.Sharp.IconButton bookManageBtn;
        private FontAwesome.Sharp.IconButton readerManageBtn;
        private FontAwesome.Sharp.IconButton supplyManageBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton showChangePassBtn;
        private FontAwesome.Sharp.IconButton showChangeInfoBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage supplyManageTab;
        private System.Windows.Forms.TabPage readerManageTab;
        private System.Windows.Forms.TabPage bookManageTab;
        private System.Windows.Forms.TabPage borrowManageTab;
        private System.Windows.Forms.TabPage returnManageTab;
        private System.Windows.Forms.TabPage statisticTab;
        private System.Windows.Forms.ContextMenuStrip closeTabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeContextMenuItem;
        private FontAwesome.Sharp.IconButton accountManageBtn;
        private System.Windows.Forms.TabPage accountManageTab;
        private System.Windows.Forms.Label accountNameLB;
        private System.Windows.Forms.TabPage searchTab;
    }
}

