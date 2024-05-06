using System.Drawing.Drawing2D;
using System.Reflection;

namespace project
{
    public partial class FrmMain : Form
    {
        // 각 패널에 표시될 숫자를 저장하는 리스트
        private List<int> numList = new List<int>();
        private int num = 1;

        // 숫자에 따른 색상을 반환하는 메서드
        private SolidBrush getBrush(int num)
        {
            Color color = Color.Black; // 기본적으로 검은색으로 초기화
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
            //    drawCircle(g2, rect, getBrush(2)); // 2는 예시로 숫자 추가
            //}

            //numList.Add(2); // 예시로 숫자 추가
            //label2.Text = numList[1].ToString();
            //label2.BackColor = getBrush(numList[1]).Color;

            //// Panel 3
            //using (Graphics g3 = panel3.CreateGraphics())
            //{
            //    drawCircle(g3, rect, getBrush(3)); // 3은 예시로 숫자 추가
            //}

            //numList.Add(3); // 예시로 숫자 추가
            //label3.Text = numList[2].ToString();
            //label3.BackColor = getBrush(numList[2]).Color;

            //// Panel 4
            //using (Graphics g4 = panel4.CreateGraphics())
            //{
            //    drawCircle(g4, rect, getBrush(4)); // 4는 예시로 숫자 추가
            //}

            //numList.Add(4); // 예시로 숫자 추가
            //label4.Text = numList[3].ToString();
            //label4.BackColor = getBrush(numList[3]).Color;

            //// Panel 5
            //using (Graphics g5 = panel5.CreateGraphics())
            //{
            //    drawCircle(g5, rect, getBrush(5)); // 5는 예시로 숫자 추가
            //}

            //numList.Add(5); // 예시로 숫자 추가
            //label5.Text = numList[4].ToString();
            //label5.BackColor = getBrush(numList[4]).Color;

            //// Panel 6
            //using (Graphics g6 = panel6.CreateGraphics())
            //{
            //    drawCircle(g6, rect, getBrush(6)); // 6은 예시로 숫자 추가
            //}

            //numList.Add(6); // 예시로 숫자 추가
            //label6.Text = numList[5].ToString();
            //label6.BackColor = getBrush(numList[5]).Color;

            // 나머지 패널에 대한 작업도 추가하시면 됩니다.
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

            

            // 1부터 45까지의 숫자를 패널 개수만큼 생성하여 할당합니다.
            for (int i = 0; i < numList.Count; i++)
            {
                int randomNumber;

                // 중복되지 않는 난수를 생성합니다.
                do
                {
                    // 1부터 45까지의 난수 생성
                    randomNumber = random.Next(1, 46);
                } while (numList.Contains(randomNumber)); // 생성된 숫자가 이미 리스트에 있으면 다시 생성합니다.

                numList[i] = randomNumber; // 생성된 난수를 리스트에 할당합니다.

                // 숫자를 표시할 라벨을 찾습니다.
                Label label = Controls.Find("label" + (i + 1), true)[0] as Label;

                // 라벨에 숫자를 표시합니다.
                label.Text = randomNumber.ToString();

                // 숫자에 따라 색상을 지정합니다.
                label.BackColor = getBrush(randomNumber).Color;
                result = (Brush)properties[randomNumber].GetValue(null, null);
                return result;
            }
        }*/

        private void btnLotto_Click(object sender, EventArgs e)
        {

            String temp = "Gray";
            
            Random random = new Random();

            // 1부터 45까지의 숫자를 패널 개수만큼 생성하여 할당합니다.
            for (int i = 0; i < numList.Count; i++)
            {
                int randomNumber;

                // 중복되지 않는 난수를 생성합니다.
                do
                {
                    // 1부터 45까지의 난수 생성
                    randomNumber = random.Next(1, 46);
                } while (numList.Contains(randomNumber)); // 생성된 숫자가 이미 리스트에 있으면 다시 생성합니다.

                numList[i] = randomNumber; // 생성된 난수를 리스트에 할당합니다.

                // 숫자를 표시할 라벨을 찾습니다.
                Label label = new Label();

                // 라벨에 숫자를 표시합니다.
                label = Controls.Find("label" + (i + 1), true)[0] as Label;

                // 라벨의 숫자를 panel 가운데에 정렬합니다.
                label.Text = randomNumber.ToString();
                label.AutoSize = false; // 라벨의 크기 자동 조정을 비활성화합니다.
                label.TextAlign = ContentAlignment.MiddleCenter; // 가운데 정렬로 설정합니다.
                label.Dock = DockStyle.Fill; // 라벨을 패널에 가득 채우도록 설정합니다.


                // 숫자에 따라 색상을 지정합니다.
                label.BackColor = getBrush(randomNumber).Color;
            }



            // 리치텍스트 박스에 표시
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

            // 숫자를 원의 중앙에 위치하도록 계산합니다.
            float x = rect.X + rect.Width / 2;
            float y = rect.Y + rect.Height / 2;

            // 숫자를 그립니다.
            g.DrawString(number.ToString(), this.Font, Brushes.White, x, y, stringFormat);
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
        }
    }
}
