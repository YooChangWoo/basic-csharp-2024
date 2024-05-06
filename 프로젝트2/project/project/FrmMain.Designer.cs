namespace project
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnLotto = new Button();
            panel1 = new Panel();
            label1 = new Label();
            RtbLottos = new RichTextBox();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLotto
            // 
            BtnLotto.Location = new Point(76, 53);
            BtnLotto.Name = "BtnLotto";
            BtnLotto.Size = new Size(75, 23);
            BtnLotto.TabIndex = 0;
            BtnLotto.Text = "Start";
            BtnLotto.UseVisualStyleBackColor = true;
            BtnLotto.Click += btnLotto_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(76, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 66);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 0;
            label1.Text = "1";
            // 
            // RtbLottos
            // 
            RtbLottos.Location = new Point(688, 22);
            RtbLottos.Name = "RtbLottos";
            RtbLottos.Size = new Size(100, 171);
            RtbLottos.TabIndex = 4;
            RtbLottos.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(186, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 66);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 28);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 0;
            label2.Text = "1";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Location = new Point(297, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(75, 66);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 28);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 0;
            label3.Text = "1";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(413, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(75, 66);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 28);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 0;
            label4.Text = "1";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Location = new Point(529, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 66);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 28);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 0;
            label5.Text = "1";
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Location = new Point(637, 230);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 66);
            panel6.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 28);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 0;
            label6.Text = "1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(RtbLottos);
            Controls.Add(panel1);
            Controls.Add(BtnLotto);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lotto";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLotto;
        private Panel panel1;
        private Label label1;
        private RichTextBox RtbLottos;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
    }
}
