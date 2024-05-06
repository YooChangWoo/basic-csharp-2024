namespace project
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            TxtId = new TextBox();
            Txtpassword = new TextBox();
            BtnLogin = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "비밀번호 :";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(117, 26);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 2;
            // 
            // Txtpassword
            // 
            Txtpassword.Location = new Point(117, 60);
            Txtpassword.Name = "Txtpassword";
            Txtpassword.PasswordChar = '●';
            Txtpassword.Size = new Size(100, 23);
            Txtpassword.TabIndex = 3;
            Txtpassword.KeyPress += Txtpassword_KeyPress;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(50, 105);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "로그인";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += btnLogin_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(142, 105);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 149);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(Txtpassword);
            Controls.Add(TxtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtId;
        private TextBox Txtpassword;
        private Button BtnLogin;
        private Button BtnCancel;
    }
}