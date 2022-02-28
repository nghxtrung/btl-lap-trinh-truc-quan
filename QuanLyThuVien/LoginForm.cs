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
    public partial class LoginForm : Form
    {
        private DatabaseAccess database = new DatabaseAccess();
        private MainForm mainFrm;

        public LoginForm(MainForm callingMainFrm)
        {
            mainFrm = callingMainFrm;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loadCaptcha();
        }

        private void loadCaptcha()
        {
            Random rand = new Random();
            int lengthCaptcha = rand.Next(6, 8);
            string captcha = "";
            int count = 0;
            do
            {
                int asciiCode = rand.Next(48, 123);
                if ((asciiCode >= 48 && asciiCode <= 57) ||
                    (asciiCode >= 65 && asciiCode <= 90) ||
                    (asciiCode >= 97 && asciiCode <= 122))
                {
                    captcha = captcha + (char)asciiCode;
                    count++;
                    if (count == lengthCaptcha)
                        break;
                }
            } while (true);
            captchaLB.Text = captcha;
        }

        private bool checkCaptcha()
        {
            if (captchaLB.Text != captchaTB.Text)
            {
                MessageBox.Show("Captcha không trùng hợp! Vui lòng nhập lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                captchaTB.Text = "";
                loadCaptcha();
                return false;
            }
            return true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            DataTable loginTable = database.dataReader("select * from TaiKhoan " +
                "where TenDangNhap = '" + userName + "' and MatKhau = '" + password + "'");
            if (checkCaptcha())
            {
                if (loginTable.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainFrm.setAccountName("Xin chào " + loginTable.Rows[0].Field<string>("TenTaiKhoan") + "!");
                    mainFrm.setEnabledLogin(false);
                    mainFrm.setEnabledAllCategory(true);
                    if (loginTable.Rows[0].Field<bool>("Loai"))
                        mainFrm.setEnabledAccountManage(true);
                    else
                        mainFrm.setEnabledAccountManage(false);
                    mainFrm.Username = userName;
                    this.Close();
                }
                else
                    MessageBox.Show("Đăng nhập không thành công! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCB.Checked)
                passwordTB.UseSystemPasswordChar = false;
            else
                passwordTB.UseSystemPasswordChar = true;
        }

        private void captchaLB_Click(object sender, EventArgs e)
        {
            loadCaptcha();
        }
    }
}
