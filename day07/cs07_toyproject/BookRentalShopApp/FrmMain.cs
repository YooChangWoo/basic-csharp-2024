using Ax.Fw.MetroFramework.Forms;


namespace BookRentalShopApp
{
    public partial class FrmMain : BorderlessForm; // Metro
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 값형식 변수는 null 
            // 값형식 변수에 null값을 넣을 수 있도록 만들어준 기능 nullable
            int? a = null;
            MessageBox.Show(a.ToString());
        }
    }
}
