
namespace QuanLyThuVien
{
    partial class ChangePasswordForm
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
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.changePassBtn = new FontAwesome.Sharp.IconButton();
            this.renewPasswordTB = new System.Windows.Forms.TextBox();
            this.renewPasswordLB = new System.Windows.Forms.Label();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.newPasswordLB = new System.Windows.Forms.Label();
            this.currentPasswordTB = new System.Windows.Forms.TextBox();
            this.currentPasswordLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showPassword);
            this.panel1.Controls.Add(this.changePassBtn);
            this.panel1.Controls.Add(this.renewPasswordTB);
            this.panel1.Controls.Add(this.renewPasswordLB);
            this.panel1.Controls.Add(this.newPasswordTB);
            this.panel1.Controls.Add(this.newPasswordLB);
            this.panel1.Controls.Add(this.currentPasswordTB);
            this.panel1.Controls.Add(this.currentPasswordLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 212);
            this.panel1.TabIndex = 0;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(287, 125);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(162, 24);
            this.showPassword.TabIndex = 9;
            this.showPassword.Text = "Hiển thị mật khẩu";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // changePassBtn
            // 
            this.changePassBtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.changePassBtn.IconColor = System.Drawing.Color.Black;
            this.changePassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changePassBtn.IconSize = 30;
            this.changePassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePassBtn.Location = new System.Drawing.Point(305, 155);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(144, 38);
            this.changePassBtn.TabIndex = 8;
            this.changePassBtn.Text = "Đổi mật khẩu";
            this.changePassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // renewPasswordTB
            // 
            this.renewPasswordTB.Location = new System.Drawing.Point(203, 92);
            this.renewPasswordTB.Name = "renewPasswordTB";
            this.renewPasswordTB.Size = new System.Drawing.Size(246, 27);
            this.renewPasswordTB.TabIndex = 7;
            this.renewPasswordTB.UseSystemPasswordChar = true;
            // 
            // renewPasswordLB
            // 
            this.renewPasswordLB.AutoSize = true;
            this.renewPasswordLB.Location = new System.Drawing.Point(22, 95);
            this.renewPasswordLB.Name = "renewPasswordLB";
            this.renewPasswordLB.Size = new System.Drawing.Size(175, 20);
            this.renewPasswordLB.TabIndex = 6;
            this.renewPasswordLB.Text = "Nhập lại mật khẩu mới";
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Location = new System.Drawing.Point(203, 59);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(246, 27);
            this.newPasswordTB.TabIndex = 5;
            this.newPasswordTB.UseSystemPasswordChar = true;
            // 
            // newPasswordLB
            // 
            this.newPasswordLB.AutoSize = true;
            this.newPasswordLB.Location = new System.Drawing.Point(88, 62);
            this.newPasswordLB.Name = "newPasswordLB";
            this.newPasswordLB.Size = new System.Drawing.Size(109, 20);
            this.newPasswordLB.TabIndex = 4;
            this.newPasswordLB.Text = "Mật khẩu mới";
            // 
            // currentPasswordTB
            // 
            this.currentPasswordTB.Location = new System.Drawing.Point(203, 26);
            this.currentPasswordTB.Name = "currentPasswordTB";
            this.currentPasswordTB.Size = new System.Drawing.Size(246, 27);
            this.currentPasswordTB.TabIndex = 3;
            this.currentPasswordTB.UseSystemPasswordChar = true;
            // 
            // currentPasswordLB
            // 
            this.currentPasswordLB.AutoSize = true;
            this.currentPasswordLB.Location = new System.Drawing.Point(61, 29);
            this.currentPasswordLB.Name = "currentPasswordLB";
            this.currentPasswordLB.Size = new System.Drawing.Size(136, 20);
            this.currentPasswordLB.TabIndex = 2;
            this.currentPasswordLB.Text = "Mật khẩu hiện tại";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 212);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton changePassBtn;
        private System.Windows.Forms.TextBox renewPasswordTB;
        private System.Windows.Forms.Label renewPasswordLB;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.Label newPasswordLB;
        private System.Windows.Forms.TextBox currentPasswordTB;
        private System.Windows.Forms.Label currentPasswordLB;
        private System.Windows.Forms.CheckBox showPassword;
    }
}