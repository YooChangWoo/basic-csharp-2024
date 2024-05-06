using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project
{
    public partial class FrmLogin : Form
    {
        private const string Username = "admin";
        private const string Password = "1234";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 입력된 아이디와 비밀번호를 가져옵니다.
            string inputUsername = TxtId.Text;
            string inputPassword = Txtpassword.Text;

            // 입력된 아이디와 비밀번호가 하드코딩된 것과 일치하는지 확인합니다.
            if (inputUsername == Username && inputPassword == Password)
            {
                // 로그인 성공 메시지를 출력합니다.
                MessageBox.Show("로그인 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*// 메인 폼을 띄웁니다.
                FrmMain frmMain = new FrmMain();
                frmMain.Show();*/

                // 현재 폼을 닫습니다.
                this.Close();
            }
            else
            {
                // 아이디 또는 비밀번호가 일치하지 않는 경우 오류 메시지를 출력합니다.
                MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}

