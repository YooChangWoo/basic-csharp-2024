using System.Drawing.Drawing2D;
using System.Reflection;

namespace project
{
    public partial class FrmMain : Form
    {
        // �� �гο� ǥ�õ� ���ڸ� �����ϴ� ����Ʈ
        private List<int> numList = new List<int>();
        private int num = 1;

        // ���ڿ� ���� ������ ��ȯ�ϴ� �޼���
        private SolidBrush getBrush(int num)
        {
            Color color = Color.Black; // �⺻������ ���������� �ʱ�ȭ
            if (num > 0 && num < 11)
            {
                color = Color.Gold;
            }
            else if (num > 10 && num < 21)
            {
                color = Color.DodgerBlue;
            }
            else if (num > 20 && num < 31)
            {
                color = Color.OrangeRed;
            }
            else if (num > 30 && num < 41)
            {
                color = Color.DimGray;
            }
            else if (num > 40)
            {
                color = Color.ForestGreen;
            }
            return new SolidBrush(color);
        }



        public FrmMain()
        {
            InitializeComponent();
        }

        //private void drawCircle(Graphics g, Rectangle rect, SolidBrush brush)
        //{
        //    g.FillEllipse(brush, rect);
        //}

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            //DrawEllipse(new Pen(System.Drawing.Color.Red), new Rectangle(10, 10, 50, 50));



            //// Panel 2
            //using (Graphics g2 = panel2.CreateGraphics())
            //{
            //    drawCircle(g2, rect, getBrush(2)); // 2�� ���÷� ���� �߰�
            //}

            //numList.Add(2); // ���÷� ���� �߰�
            //label2.Text = numList[1].ToString();
            //label2.BackColor = getBrush(numList[1]).Color;

            //// Panel 3
            //using (Graphics g3 = panel3.CreateGraphics())
            //{
            //    drawCircle(g3, rect, getBrush(3)); // 3�� ���÷� ���� �߰�
            //}

            //numList.Add(3); // ���÷� ���� �߰�
            //label3.Text = numList[2].ToString();
            //label3.BackColor = getBrush(numList[2]).Color;

            //// Panel 4
            //using (Graphics g4 = panel4.CreateGraphics())
            //{
            //    drawCircle(g4, rect, getBrush(4)); // 4�� ���÷� ���� �߰�
            //}

            //numList.Add(4); // ���÷� ���� �߰�
            //label4.Text = numList[3].ToString();
            //label4.BackColor = getBrush(numList[3]).Color;

            //// Panel 5
            //using (Graphics g5 = panel5.CreateGraphics())
            //{
            //    drawCircle(g5, rect, getBrush(5)); // 5�� ���÷� ���� �߰�
            //}

            //numList.Add(5); // ���÷� ���� �߰�
            //label5.Text = numList[4].ToString();
            //label5.BackColor = getBrush(numList[4]).Color;

            //// Panel 6
            //using (Graphics g6 = panel6.CreateGraphics())
            //{
            //    drawCircle(g6, rect, getBrush(6)); // 6�� ���÷� ���� �߰�
            //}

            //numList.Add(6); // ���÷� ���� �߰�
            //label6.Text = numList[5].ToString();
            //label6.BackColor = getBrush(numList[5]).Color;

            // ������ �гο� ���� �۾��� �߰��Ͻø� �˴ϴ�.
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);
            numList.Add(6);

        }
        /*public Brush CreateLotto()
        {
            Brush result = Brushes.Transparent;
            Random random = new Random();
            Type brushesType = typeof(Brushes);
            PropertyInfo[] properties = brushesType.GetProperties();

            

            // 1���� 45������ ���ڸ� �г� ������ŭ �����Ͽ� �Ҵ��մϴ�.
            for (int i = 0; i < numList.Count; i++)
            {
                int randomNumber;

                // �ߺ����� �ʴ� ������ �����մϴ�.
                do
                {
                    // 1���� 45������ ���� ����
                    randomNumber = random.Next(1, 46);
                } while (numList.Contains(randomNumber)); // ������ ���ڰ� �̹� ����Ʈ�� ������ �ٽ� �����մϴ�.

                numList[i] = randomNumber; // ������ ������ ����Ʈ�� �Ҵ��մϴ�.

                // ���ڸ� ǥ���� ���� ã���ϴ�.
                Label label = Controls.Find("label" + (i + 1), true)[0] as Label;

                // �󺧿� ���ڸ� ǥ���մϴ�.
                label.Text = randomNumber.ToString();

                // ���ڿ� ���� ������ �����մϴ�.
                label.BackColor = getBrush(randomNumber).Color;
                result = (Brush)properties[randomNumber].GetValue(null, null);
                return result;
            }
        }*/

        private void btnLotto_Click(object sender, EventArgs e)
        {

            String temp = "Gray";
            
            Random random = new Random();

            // 1���� 45������ ���ڸ� �г� ������ŭ �����Ͽ� �Ҵ��մϴ�.
            for (int i = 0; i < numList.Count; i++)
            {
                int randomNumber;

                // �ߺ����� �ʴ� ������ �����մϴ�.
                do
                {
                    // 1���� 45������ ���� ����
                    randomNumber = random.Next(1, 46);
                } while (numList.Contains(randomNumber)); // ������ ���ڰ� �̹� ����Ʈ�� ������ �ٽ� �����մϴ�.

                numList[i] = randomNumber; // ������ ������ ����Ʈ�� �Ҵ��մϴ�.

                // ���ڸ� ǥ���� ���� ã���ϴ�.
                Label label = new Label();

                // �󺧿� ���ڸ� ǥ���մϴ�.
                label = Controls.Find("label" + (i + 1), true)[0] as Label;

                // ���� ���ڸ� panel ����� �����մϴ�.
                label.Text = randomNumber.ToString();
                label.AutoSize = false; // ���� ũ�� �ڵ� ������ ��Ȱ��ȭ�մϴ�.
                label.TextAlign = ContentAlignment.MiddleCenter; // ��� ���ķ� �����մϴ�.
                label.Dock = DockStyle.Fill; // ���� �гο� ���� ä�쵵�� �����մϴ�.


                // ���ڿ� ���� ������ �����մϴ�.
                label.BackColor = getBrush(randomNumber).Color;
            }



            // ��ġ�ؽ�Ʈ �ڽ��� ǥ��
            RtbLottos.Text = "";
            for (int i = 0; i < numList.Count; i++)
            {
                RtbLottos.Text += numList[i] + "\n";
            }

            // Panel 1
            Graphics g = panel1.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[0]), rect);
            g.Dispose();
            // Panel 2
            g = panel2.CreateGraphics();
            rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[1]), rect);
            g.Dispose();
            // Panel 3
            g = panel3.CreateGraphics();
            rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[2]), rect);
            g.Dispose();
            // Panel 4
            g = panel4.CreateGraphics();
            rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[3]), rect);
            g.Dispose();
            // Panel 5
            g = panel5.CreateGraphics();
            rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[4]), rect);
            g.Dispose();
            // Panel 6
            g = panel6.CreateGraphics();
            rect = new Rectangle(0, 0, 50, 50);
            g.FillEllipse(getBrush(numList[5]), rect);
            g.Dispose();
        }
        void DrawNumberCircle(Graphics g, Brush brush, Rectangle rect, int number)
        {
            g.FillEllipse(brush, rect);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // ���ڸ� ���� �߾ӿ� ��ġ�ϵ��� ����մϴ�.
            float x = rect.X + rect.Width / 2;
            float y = rect.Y + rect.Height / 2;

            // ���ڸ� �׸��ϴ�.
            g.DrawString(number.ToString(), this.Font, Brushes.White, x, y, stringFormat);
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
        }
    }
}
