using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        // 각 화면을 초기화
        FrmLoginUser frmLoginUser = null;  // 객체를 메서드로 생성
        FrmBookDivision frmBookDivision = null;
        FrmBookInfo frmBookInfo = null;
        FrmMember frmMember = null;  // FrmMember : 클래스, frmMember : 객채변수
        FrmBookRental frmBookRental = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;
            frm.ShowDialog();

            LblLoginId.Text = Helper.Common.LoginId;  // 메인창에 로그인된 아이디 표시
        }

        private void MunLoginUsers_Click(object sender, EventArgs e)
        {
            // 이미 창이 열려있으면 새로 생성할 필요가 없기때문에
            // 이러한 작업을 안하면 메뉴클릭시마다 새폼이 열림
            frmLoginUser = ShowActiveFrom(frmLoginUser, typeof(FrmLoginUser)) as FrmLoginUser;
        }

        // 책 장르관리 메뉴 클릭 이벤트 핸들러
        private void MnuBookDivision_Click(object sender, EventArgs e)
        {
            frmBookDivision = ShowActiveFrom(frmBookDivision, typeof(FrmBookDivision)) as FrmBookDivision;
        }
        private void MunBookInfo_Click(object sender, EventArgs e)
        {
            // 객체변수, 객체변수, 클래스, 클래스
            frmBookInfo = ShowActiveFrom(frmBookInfo, typeof(FrmBookInfo)) as FrmBookInfo;

        }
        private void MnuMembers_Click(object sender, EventArgs e)
        {
            frmMember = ShowActiveFrom(frmMember, typeof(FrmMember)) as FrmMember;
        }

        private void MnuBookRental_Click(object sender, EventArgs e)
        {
            frmBookRental = ShowActiveFrom(frmBookRental, typeof(FrmBookRental)) as FrmBookRental;
        }
        Form ShowActiveFrom(Form form, Type type)
        {
            if (form == null)  // 화면이 한번도 안열였으면
            {
                form = Activator.CreateInstance(type) as Form;  // 타입은 클래스 타입
                form.MdiParent = this;  // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = Activator.CreateInstance(type) as Form;  // 타입은 클래스 타입
                    form.MdiParent = this;  // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else   // 창을 그냥 최소화, 열려있으면
                {
                    form.Activate();  // 화면에 열려있는 창을 활성화
                }
            }
            return form;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;  // 종료 안되는 부분
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void MnuAboutasf_Click(object sender, EventArgs e)
        {
            FrmAboutasf popup = new FrmAboutasf();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Show();
        }
    }
}
