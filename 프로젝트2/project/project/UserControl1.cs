using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class UserControl1 : UserControl
    {
        // 생성자에서 받아서 사용할 전역변수
        private int num = 0;

        private Label label1;

        public UserControl1()
        {
            InitializeComponent();
            InitializeLabel();
        }

        // 생성자
        public UserControl1(int _num)
        {
            InitializeComponent();
            // 번호를 가져와서 전역변수로 저장
            num = _num;
            InitializeLabel();
            setCircle();
        }

        private void InitializeLabel()
        {
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(10, 10); // 위치 조정
            this.Controls.Add(label1);
        }

        private void setCircle()
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(Brushes.Black, rect);
            g.Dispose();

            label1.Text = num.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            setCircle();
        }
    }
}
