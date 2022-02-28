
namespace QuanLyThuVien
{
    partial class AccountManageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountExitBtn = new FontAwesome.Sharp.IconButton();
            this.accountCancelBtn = new FontAwesome.Sharp.IconButton();
            this.accountSaveBtn = new FontAwesome.Sharp.IconButton();
            this.accountRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.accountEditBtn = new FontAwesome.Sharp.IconButton();
            this.accountAddBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accountAddressTB = new System.Windows.Forms.TextBox();
            this.accountPhoneNumberTB = new System.Windows.Forms.TextBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.accountBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.accountTypeCBB = new System.Windows.Forms.ComboBox();
            this.accountTypeLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.accountAddressLB = new System.Windows.Forms.Label();
            this.accountPhoneNumberLB = new System.Windows.Forms.Label();
            this.accountGenderLB = new System.Windows.Forms.Label();
            this.accountBirthLB = new System.Windows.Forms.Label();
            this.accountNameLB = new System.Windows.Forms.Label();
            this.accountNameTB = new System.Windows.Forms.TextBox();
            this.usernameLB = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.accountDGV = new System.Windows.Forms.DataGridView();
            this.accountRefreshBtn = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // accountExitBtn
            // 
            this.accountExitBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.accountExitBtn.IconColor = System.Drawing.Color.Black;
            this.accountExitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountExitBtn.IconSize = 30;
            this.accountExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountExitBtn.Location = new System.Drawing.Point(559, 196);
            this.accountExitBtn.Name = "accountExitBtn";
            this.accountExitBtn.Size = new System.Drawing.Size(85, 39);
            this.accountExitBtn.TabIndex = 18;
            this.accountExitBtn.Text = "Thoát";
            this.accountExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountExitBtn.UseVisualStyleBackColor = true;
            this.accountExitBtn.Click += new System.EventHandler(this.accountExitBtn_Click);
            // 
            // accountCancelBtn
            // 
            this.accountCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.accountCancelBtn.IconColor = System.Drawing.Color.Black;
            this.accountCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountCancelBtn.IconSize = 30;
            this.accountCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountCancelBtn.Location = new System.Drawing.Point(475, 196);
            this.accountCancelBtn.Name = "accountCancelBtn";
            this.accountCancelBtn.Size = new System.Drawing.Size(78, 39);
            this.accountCancelBtn.TabIndex = 17;
            this.accountCancelBtn.Text = "Huỷ";
            this.accountCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountCancelBtn.UseVisualStyleBackColor = true;
            this.accountCancelBtn.Click += new System.EventHandler(this.accountCancelBtn_Click);
            // 
            // accountSaveBtn
            // 
            this.accountSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.accountSaveBtn.IconColor = System.Drawing.Color.Black;
            this.accountSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountSaveBtn.IconSize = 30;
            this.accountSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountSaveBtn.Location = new System.Drawing.Point(395, 196);
            this.accountSaveBtn.Name = "accountSaveBtn";
            this.accountSaveBtn.Size = new System.Drawing.Size(74, 39);
            this.accountSaveBtn.TabIndex = 16;
            this.accountSaveBtn.Text = "Lưu";
            this.accountSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountSaveBtn.UseVisualStyleBackColor = true;
            this.accountSaveBtn.Click += new System.EventHandler(this.accountSaveBtn_Click);
            // 
            // accountRemoveBtn
            // 
            this.accountRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.accountRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.accountRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountRemoveBtn.IconSize = 30;
            this.accountRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountRemoveBtn.Location = new System.Drawing.Point(311, 196);
            this.accountRemoveBtn.Name = "accountRemoveBtn";
            this.accountRemoveBtn.Size = new System.Drawing.Size(78, 39);
            this.accountRemoveBtn.TabIndex = 15;
            this.accountRemoveBtn.Text = "Xoá";
            this.accountRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountRemoveBtn.UseVisualStyleBackColor = true;
            this.accountRemoveBtn.Click += new System.EventHandler(this.accountRemoveBtn_Click);
            // 
            // accountEditBtn
            // 
            this.accountEditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.accountEditBtn.IconColor = System.Drawing.Color.Black;
            this.accountEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountEditBtn.IconSize = 30;
            this.accountEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountEditBtn.Location = new System.Drawing.Point(232, 196);
            this.accountEditBtn.Name = "accountEditBtn";
            this.accountEditBtn.Size = new System.Drawing.Size(73, 39);
            this.accountEditBtn.TabIndex = 14;
            this.accountEditBtn.Text = "Sửa";
            this.accountEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountEditBtn.UseVisualStyleBackColor = true;
            this.accountEditBtn.Click += new System.EventHandler(this.accountEditBtn_Click);
            // 
            // accountAddBtn
            // 
            this.accountAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.accountAddBtn.IconColor = System.Drawing.Color.Black;
            this.accountAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountAddBtn.IconSize = 30;
            this.accountAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountAddBtn.Location = new System.Drawing.Point(137, 196);
            this.accountAddBtn.Name = "accountAddBtn";
            this.accountAddBtn.Size = new System.Drawing.Size(89, 39);
            this.accountAddBtn.TabIndex = 13;
            this.accountAddBtn.Text = "Thêm";
            this.accountAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountAddBtn.UseVisualStyleBackColor = true;
            this.accountAddBtn.Click += new System.EventHandler(this.accountAddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.passwordTB);
            this.panel3.Controls.Add(this.accountAddressTB);
            this.panel3.Controls.Add(this.accountPhoneNumberTB);
            this.panel3.Controls.Add(this.femaleRadioBtn);
            this.panel3.Controls.Add(this.maleRadioBtn);
            this.panel3.Controls.Add(this.accountBirthDTP);
            this.panel3.Controls.Add(this.accountTypeCBB);
            this.panel3.Controls.Add(this.accountTypeLB);
            this.panel3.Controls.Add(this.passwordLB);
            this.panel3.Controls.Add(this.accountAddressLB);
            this.panel3.Controls.Add(this.accountPhoneNumberLB);
            this.panel3.Controls.Add(this.accountGenderLB);
            this.panel3.Controls.Add(this.accountBirthLB);
            this.panel3.Controls.Add(this.accountNameLB);
            this.panel3.Controls.Add(this.accountNameTB);
            this.panel3.Controls.Add(this.usernameLB);
            this.panel3.Controls.Add(this.usernameTB);
            this.panel3.Location = new System.Drawing.Point(20, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1337, 172);
            this.panel3.TabIndex = 12;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(548, 85);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(249, 22);
            this.passwordTB.TabIndex = 22;
            // 
            // accountAddressTB
            // 
            this.accountAddressTB.Location = new System.Drawing.Point(548, 52);
            this.accountAddressTB.Name = "accountAddressTB";
            this.accountAddressTB.Size = new System.Drawing.Size(249, 22);
            this.accountAddressTB.TabIndex = 21;
            // 
            // accountPhoneNumberTB
            // 
            this.accountPhoneNumberTB.Location = new System.Drawing.Point(548, 19);
            this.accountPhoneNumberTB.Name = "accountPhoneNumberTB";
            this.accountPhoneNumberTB.Size = new System.Drawing.Size(249, 22);
            this.accountPhoneNumberTB.TabIndex = 20;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(270, 119);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(47, 21);
            this.femaleRadioBtn.TabIndex = 19;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Nữ";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(171, 119);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(58, 21);
            this.maleRadioBtn.TabIndex = 18;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Nam";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // accountBirthDTP
            // 
            this.accountBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.accountBirthDTP.Location = new System.Drawing.Point(149, 85);
            this.accountBirthDTP.Name = "accountBirthDTP";
            this.accountBirthDTP.Size = new System.Drawing.Size(249, 22);
            this.accountBirthDTP.TabIndex = 17;
            // 
            // accountTypeCBB
            // 
            this.accountTypeCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeCBB.FormattingEnabled = true;
            this.accountTypeCBB.Location = new System.Drawing.Point(548, 118);
            this.accountTypeCBB.Name = "accountTypeCBB";
            this.accountTypeCBB.Size = new System.Drawing.Size(249, 24);
            this.accountTypeCBB.TabIndex = 16;
            // 
            // accountTypeLB
            // 
            this.accountTypeLB.AutoSize = true;
            this.accountTypeLB.Location = new System.Drawing.Point(429, 121);
            this.accountTypeLB.Name = "accountTypeLB";
            this.accountTypeLB.Size = new System.Drawing.Size(97, 17);
            this.accountTypeLB.TabIndex = 15;
            this.accountTypeLB.Text = "Loại tài khoản";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(465, 88);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(66, 17);
            this.passwordLB.TabIndex = 13;
            this.passwordLB.Text = "Mật khẩu";
            // 
            // accountAddressLB
            // 
            this.accountAddressLB.AutoSize = true;
            this.accountAddressLB.Location = new System.Drawing.Point(481, 55);
            this.accountAddressLB.Name = "accountAddressLB";
            this.accountAddressLB.Size = new System.Drawing.Size(51, 17);
            this.accountAddressLB.TabIndex = 11;
            this.accountAddressLB.Text = "Địa chỉ";
            // 
            // accountPhoneNumberLB
            // 
            this.accountPhoneNumberLB.AutoSize = true;
            this.accountPhoneNumberLB.Location = new System.Drawing.Point(436, 22);
            this.accountPhoneNumberLB.Name = "accountPhoneNumberLB";
            this.accountPhoneNumberLB.Size = new System.Drawing.Size(91, 17);
            this.accountPhoneNumberLB.TabIndex = 9;
            this.accountPhoneNumberLB.Text = "Số điện thoại";
            // 
            // accountGenderLB
            // 
            this.accountGenderLB.AutoSize = true;
            this.accountGenderLB.Location = new System.Drawing.Point(72, 121);
            this.accountGenderLB.Name = "accountGenderLB";
            this.accountGenderLB.Size = new System.Drawing.Size(60, 17);
            this.accountGenderLB.TabIndex = 7;
            this.accountGenderLB.Text = "Giới tính";
            // 
            // accountBirthLB
            // 
            this.accountBirthLB.AutoSize = true;
            this.accountBirthLB.Location = new System.Drawing.Point(60, 88);
            this.accountBirthLB.Name = "accountBirthLB";
            this.accountBirthLB.Size = new System.Drawing.Size(71, 17);
            this.accountBirthLB.TabIndex = 5;
            this.accountBirthLB.Text = "Ngày sinh";
            // 
            // accountNameLB
            // 
            this.accountNameLB.AutoSize = true;
            this.accountNameLB.Location = new System.Drawing.Point(34, 55);
            this.accountNameLB.Name = "accountNameLB";
            this.accountNameLB.Size = new System.Drawing.Size(95, 17);
            this.accountNameLB.TabIndex = 3;
            this.accountNameLB.Text = "Tên tài khoản";
            // 
            // accountNameTB
            // 
            this.accountNameTB.Location = new System.Drawing.Point(149, 52);
            this.accountNameTB.Name = "accountNameTB";
            this.accountNameTB.Size = new System.Drawing.Size(249, 22);
            this.accountNameTB.TabIndex = 2;
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Location = new System.Drawing.Point(24, 22);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(105, 17);
            this.usernameLB.TabIndex = 1;
            this.usernameLB.Text = "Tên đăng nhập";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(149, 19);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(249, 22);
            this.usernameTB.TabIndex = 0;
            // 
            // accountDGV
            // 
            this.accountDGV.AllowUserToAddRows = false;
            this.accountDGV.AllowUserToDeleteRows = false;
            this.accountDGV.AllowUserToResizeColumns = false;
            this.accountDGV.AllowUserToResizeRows = false;
            this.accountDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDGV.Location = new System.Drawing.Point(20, 241);
            this.accountDGV.Name = "accountDGV";
            this.accountDGV.ReadOnly = true;
            this.accountDGV.RowHeadersWidth = 51;
            this.accountDGV.RowTemplate.Height = 24;
            this.accountDGV.Size = new System.Drawing.Size(1337, 359);
            this.accountDGV.TabIndex = 11;
            this.accountDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDGV_CellClick);
            // 
            // accountRefreshBtn
            // 
            this.accountRefreshBtn.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.accountRefreshBtn.IconColor = System.Drawing.Color.Black;
            this.accountRefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountRefreshBtn.IconSize = 30;
            this.accountRefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountRefreshBtn.Location = new System.Drawing.Point(20, 196);
            this.accountRefreshBtn.Name = "accountRefreshBtn";
            this.accountRefreshBtn.Size = new System.Drawing.Size(111, 39);
            this.accountRefreshBtn.TabIndex = 10;
            this.accountRefreshBtn.Text = "Làm mới";
            this.accountRefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountRefreshBtn.UseVisualStyleBackColor = true;
            this.accountRefreshBtn.Click += new System.EventHandler(this.accountRefreshBtn_Click);
            // 
            // AccountManageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.accountExitBtn);
            this.Controls.Add(this.accountCancelBtn);
            this.Controls.Add(this.accountSaveBtn);
            this.Controls.Add(this.accountRemoveBtn);
            this.Controls.Add(this.accountEditBtn);
            this.Controls.Add(this.accountAddBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.accountDGV);
            this.Controls.Add(this.accountRefreshBtn);
            this.Name = "AccountManageControl";
            this.Size = new System.Drawing.Size(1376, 619);
            this.Load += new System.EventHandler(this.AccountManageControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton accountExitBtn;
        private FontAwesome.Sharp.IconButton accountCancelBtn;
        private FontAwesome.Sharp.IconButton accountRemoveBtn;
        private FontAwesome.Sharp.IconButton accountEditBtn;
        private FontAwesome.Sharp.IconButton accountAddBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox accountAddressTB;
        private System.Windows.Forms.TextBox accountPhoneNumberTB;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.DateTimePicker accountBirthDTP;
        private System.Windows.Forms.ComboBox accountTypeCBB;
        private System.Windows.Forms.Label accountTypeLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label accountAddressLB;
        private System.Windows.Forms.Label accountPhoneNumberLB;
        private System.Windows.Forms.Label accountGenderLB;
        private System.Windows.Forms.Label accountBirthLB;
        private System.Windows.Forms.Label accountNameLB;
        private System.Windows.Forms.TextBox accountNameTB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.DataGridView accountDGV;
        private FontAwesome.Sharp.IconButton accountRefreshBtn;
        private FontAwesome.Sharp.IconButton accountSaveBtn;
    }
}
