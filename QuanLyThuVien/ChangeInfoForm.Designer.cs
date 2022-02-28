
namespace QuanLyThuVien
{
    partial class ChangeInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.accountPhoneNumberTB = new System.Windows.Forms.TextBox();
            this.accountPhoneNumberLB = new System.Windows.Forms.Label();
            this.changeInfoBtn = new FontAwesome.Sharp.IconButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.accountGenderLB = new System.Windows.Forms.Label();
            this.accountAddressTB = new System.Windows.Forms.TextBox();
            this.accountNameLB = new System.Windows.Forms.Label();
            this.accountAddressLB = new System.Windows.Forms.Label();
            this.accountNameTB = new System.Windows.Forms.TextBox();
            this.accountBirthLB = new System.Windows.Forms.Label();
            this.accountBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Controls.Add(this.accountPhoneNumberTB);
            this.panel1.Controls.Add(this.accountPhoneNumberLB);
            this.panel1.Controls.Add(this.changeInfoBtn);
            this.panel1.Controls.Add(this.maleRadioBtn);
            this.panel1.Controls.Add(this.femaleRadioBtn);
            this.panel1.Controls.Add(this.accountGenderLB);
            this.panel1.Controls.Add(this.accountAddressTB);
            this.panel1.Controls.Add(this.accountNameLB);
            this.panel1.Controls.Add(this.accountAddressLB);
            this.panel1.Controls.Add(this.accountNameTB);
            this.panel1.Controls.Add(this.accountBirthLB);
            this.panel1.Controls.Add(this.accountBirthDTP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 305);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên đăng nhập";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(149, 27);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            this.usernameTB.Size = new System.Drawing.Size(254, 27);
            this.usernameTB.TabIndex = 37;
            // 
            // accountPhoneNumberTB
            // 
            this.accountPhoneNumberTB.Location = new System.Drawing.Point(149, 164);
            this.accountPhoneNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.accountPhoneNumberTB.Name = "accountPhoneNumberTB";
            this.accountPhoneNumberTB.Size = new System.Drawing.Size(254, 27);
            this.accountPhoneNumberTB.TabIndex = 35;
            this.accountPhoneNumberTB.TabStop = false;
            // 
            // accountPhoneNumberLB
            // 
            this.accountPhoneNumberLB.AutoSize = true;
            this.accountPhoneNumberLB.Location = new System.Drawing.Point(35, 167);
            this.accountPhoneNumberLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountPhoneNumberLB.Name = "accountPhoneNumberLB";
            this.accountPhoneNumberLB.Size = new System.Drawing.Size(106, 20);
            this.accountPhoneNumberLB.TabIndex = 34;
            this.accountPhoneNumberLB.Text = "Số điện thoại";
            // 
            // changeInfoBtn
            // 
            this.changeInfoBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.changeInfoBtn.IconColor = System.Drawing.Color.Black;
            this.changeInfoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeInfoBtn.IconSize = 30;
            this.changeInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeInfoBtn.Location = new System.Drawing.Point(267, 234);
            this.changeInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeInfoBtn.Name = "changeInfoBtn";
            this.changeInfoBtn.Size = new System.Drawing.Size(136, 40);
            this.changeInfoBtn.TabIndex = 32;
            this.changeInfoBtn.Text = "Đổi thông tin";
            this.changeInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeInfoBtn.UseVisualStyleBackColor = true;
            this.changeInfoBtn.Click += new System.EventHandler(this.changeInfoBtn_Click);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(184, 132);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(65, 24);
            this.maleRadioBtn.TabIndex = 30;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Nam";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(290, 132);
            this.femaleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(51, 24);
            this.femaleRadioBtn.TabIndex = 31;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Nữ";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // accountGenderLB
            // 
            this.accountGenderLB.AutoSize = true;
            this.accountGenderLB.Location = new System.Drawing.Point(70, 132);
            this.accountGenderLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountGenderLB.Name = "accountGenderLB";
            this.accountGenderLB.Size = new System.Drawing.Size(71, 20);
            this.accountGenderLB.TabIndex = 29;
            this.accountGenderLB.Text = "Giới tính";
            // 
            // accountAddressTB
            // 
            this.accountAddressTB.Location = new System.Drawing.Point(149, 199);
            this.accountAddressTB.Margin = new System.Windows.Forms.Padding(4);
            this.accountAddressTB.Name = "accountAddressTB";
            this.accountAddressTB.Size = new System.Drawing.Size(254, 27);
            this.accountAddressTB.TabIndex = 28;
            this.accountAddressTB.TabStop = false;
            // 
            // accountNameLB
            // 
            this.accountNameLB.AutoSize = true;
            this.accountNameLB.Location = new System.Drawing.Point(32, 65);
            this.accountNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNameLB.Name = "accountNameLB";
            this.accountNameLB.Size = new System.Drawing.Size(109, 20);
            this.accountNameLB.TabIndex = 23;
            this.accountNameLB.Text = "Tên tài khoản";
            // 
            // accountAddressLB
            // 
            this.accountAddressLB.AutoSize = true;
            this.accountAddressLB.Location = new System.Drawing.Point(80, 202);
            this.accountAddressLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountAddressLB.Name = "accountAddressLB";
            this.accountAddressLB.Size = new System.Drawing.Size(61, 20);
            this.accountAddressLB.TabIndex = 27;
            this.accountAddressLB.Text = "Địa chỉ";
            // 
            // accountNameTB
            // 
            this.accountNameTB.Location = new System.Drawing.Point(149, 62);
            this.accountNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.accountNameTB.Name = "accountNameTB";
            this.accountNameTB.Size = new System.Drawing.Size(254, 27);
            this.accountNameTB.TabIndex = 24;
            this.accountNameTB.TabStop = false;
            // 
            // accountBirthLB
            // 
            this.accountBirthLB.AutoSize = true;
            this.accountBirthLB.Location = new System.Drawing.Point(58, 97);
            this.accountBirthLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountBirthLB.Name = "accountBirthLB";
            this.accountBirthLB.Size = new System.Drawing.Size(83, 20);
            this.accountBirthLB.TabIndex = 26;
            this.accountBirthLB.Text = "Ngày sinh";
            // 
            // accountBirthDTP
            // 
            this.accountBirthDTP.CustomFormat = "dd/MM/yyyy";
            this.accountBirthDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.accountBirthDTP.Location = new System.Drawing.Point(149, 97);
            this.accountBirthDTP.Margin = new System.Windows.Forms.Padding(4);
            this.accountBirthDTP.Name = "accountBirthDTP";
            this.accountBirthDTP.Size = new System.Drawing.Size(254, 27);
            this.accountBirthDTP.TabIndex = 25;
            // 
            // ChangeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 305);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChangeInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi thông tin";
            this.Load += new System.EventHandler(this.ChangeInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton changeInfoBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.Label accountGenderLB;
        private System.Windows.Forms.Label accountNameLB;
        private System.Windows.Forms.TextBox accountNameTB;
        private System.Windows.Forms.Label accountBirthLB;
        private System.Windows.Forms.DateTimePicker accountBirthDTP;
        private System.Windows.Forms.TextBox accountPhoneNumberTB;
        private System.Windows.Forms.Label accountPhoneNumberLB;
        private System.Windows.Forms.TextBox accountAddressTB;
        private System.Windows.Forms.Label accountAddressLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTB;
    }
}