
namespace QuanLyThuVien
{
    partial class LoginForm
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
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.userNameLB = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLB = new System.Windows.Forms.Label();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPasswordCB = new System.Windows.Forms.CheckBox();
            this.captchaLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.captchaTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(146, 21);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(246, 27);
            this.userNameTB.TabIndex = 7;
            // 
            // userNameLB
            // 
            this.userNameLB.AutoSize = true;
            this.userNameLB.Location = new System.Drawing.Point(19, 24);
            this.userNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(119, 20);
            this.userNameLB.TabIndex = 6;
            this.userNameLB.Text = "Tên đăng nhập";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(146, 56);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(246, 27);
            this.passwordTB.TabIndex = 10;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(61, 59);
            this.passwordLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(77, 20);
            this.passwordLB.TabIndex = 9;
            this.passwordLB.Text = "Mật khẩu";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.loginBtn.IconColor = System.Drawing.Color.Black;
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.IconSize = 30;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(264, 201);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(128, 38);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.captchaTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.captchaLB);
            this.panel1.Controls.Add(this.showPasswordCB);
            this.panel1.Controls.Add(this.userNameTB);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.userNameLB);
            this.panel1.Controls.Add(this.passwordLB);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 262);
            this.panel1.TabIndex = 12;
            // 
            // showPasswordCB
            // 
            this.showPasswordCB.AutoSize = true;
            this.showPasswordCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCB.Location = new System.Drawing.Point(230, 170);
            this.showPasswordCB.Name = "showPasswordCB";
            this.showPasswordCB.Size = new System.Drawing.Size(162, 24);
            this.showPasswordCB.TabIndex = 11;
            this.showPasswordCB.Text = "Hiển thị mật khẩu";
            this.showPasswordCB.UseVisualStyleBackColor = true;
            this.showPasswordCB.CheckedChanged += new System.EventHandler(this.showPasswordCB_CheckedChanged);
            // 
            // captchaLB
            // 
            this.captchaLB.AutoSize = true;
            this.captchaLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captchaLB.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaLB.Location = new System.Drawing.Point(159, 97);
            this.captchaLB.Name = "captchaLB";
            this.captchaLB.Size = new System.Drawing.Size(109, 27);
            this.captchaLB.TabIndex = 12;
            this.captchaLB.Text = "captcha";
            this.captchaLB.Click += new System.EventHandler(this.captchaLB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Captcha";
            // 
            // captchaTB
            // 
            this.captchaTB.Location = new System.Drawing.Point(146, 137);
            this.captchaTB.Name = "captchaTB";
            this.captchaTB.Size = new System.Drawing.Size(246, 27);
            this.captchaTB.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 262);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLB;
        private FontAwesome.Sharp.IconButton loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showPasswordCB;
        private System.Windows.Forms.TextBox captchaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label captchaLB;
    }
}