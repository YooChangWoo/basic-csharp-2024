namespace NewBookRentalShopApp
{
    partial class FrmBookRental
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpRetrunDate = new MetroFramework.Controls.MetroDateTime();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtMemNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtRentalIdx = new MetroFramework.Controls.MetroTextBox();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.TxtBookNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtMemberIdx = new MetroFramework.Controls.MetroTextBox();
            this.TxtBookIdx = new MetroFramework.Controls.MetroTextBox();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.Size = new System.Drawing.Size(383, 370);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearchBook);
            this.groupBox1.Controls.Add(this.BtnSearchMember);
            this.groupBox1.Controls.Add(this.TxtBookIdx);
            this.groupBox1.Controls.Add(this.TxtMemberIdx);
            this.groupBox1.Controls.Add(this.TxtBookNames);
            this.groupBox1.Controls.Add(this.DtpRentalDate);
            this.groupBox1.Controls.Add(this.DtpRetrunDate);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TxtMemNames);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.TxtRentalIdx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대출정보 입력항목";
            // 
            // DtpRetrunDate
            // 
            this.DtpRetrunDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRetrunDate.Location = new System.Drawing.Point(102, 153);
            this.DtpRetrunDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRetrunDate.Name = "DtpRetrunDate";
            this.DtpRetrunDate.Size = new System.Drawing.Size(200, 29);
            this.DtpRetrunDate.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(165, 240);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(78, 38);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(84, 240);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 38);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "대출일";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "회원명";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 159);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "반납일";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "책제목";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMemNames
            // 
            // 
            // 
            // 
            this.TxtMemNames.CustomButton.Image = null;
            this.TxtMemNames.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.TxtMemNames.CustomButton.Name = "";
            this.TxtMemNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemNames.CustomButton.TabIndex = 1;
            this.TxtMemNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemNames.CustomButton.UseSelectable = true;
            this.TxtMemNames.CustomButton.Visible = false;
            this.TxtMemNames.Lines = new string[0];
            this.TxtMemNames.Location = new System.Drawing.Point(165, 60);
            this.TxtMemNames.MaxLength = 32767;
            this.TxtMemNames.Name = "TxtMemNames";
            this.TxtMemNames.PasswordChar = '\0';
            this.TxtMemNames.PromptText = "회원명 선택";
            this.TxtMemNames.ReadOnly = true;
            this.TxtMemNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemNames.SelectedText = "";
            this.TxtMemNames.SelectionLength = 0;
            this.TxtMemNames.SelectionStart = 0;
            this.TxtMemNames.ShortcutsEnabled = true;
            this.TxtMemNames.Size = new System.Drawing.Size(101, 23);
            this.TxtMemNames.TabIndex = 6;
            this.TxtMemNames.UseSelectable = true;
            this.TxtMemNames.WaterMark = "회원명 선택";
            this.TxtMemNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "대출순번";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtRentalIdx
            // 
            // 
            // 
            // 
            this.TxtRentalIdx.CustomButton.Image = null;
            this.TxtRentalIdx.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.TxtRentalIdx.CustomButton.Name = "";
            this.TxtRentalIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRentalIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRentalIdx.CustomButton.TabIndex = 1;
            this.TxtRentalIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRentalIdx.CustomButton.UseSelectable = true;
            this.TxtRentalIdx.CustomButton.Visible = false;
            this.TxtRentalIdx.Lines = new string[0];
            this.TxtRentalIdx.Location = new System.Drawing.Point(103, 31);
            this.TxtRentalIdx.MaxLength = 32767;
            this.TxtRentalIdx.Name = "TxtRentalIdx";
            this.TxtRentalIdx.PasswordChar = '\0';
            this.TxtRentalIdx.ReadOnly = true;
            this.TxtRentalIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRentalIdx.SelectedText = "";
            this.TxtRentalIdx.SelectionLength = 0;
            this.TxtRentalIdx.SelectionStart = 0;
            this.TxtRentalIdx.ShortcutsEnabled = true;
            this.TxtRentalIdx.Size = new System.Drawing.Size(199, 23);
            this.TxtRentalIdx.TabIndex = 1;
            this.TxtRentalIdx.UseSelectable = true;
            this.TxtRentalIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRentalIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRentalDate.Location = new System.Drawing.Point(102, 118);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(200, 29);
            this.DtpRentalDate.TabIndex = 8;
            // 
            // TxtBookNames
            // 
            // 
            // 
            // 
            this.TxtBookNames.CustomButton.Image = null;
            this.TxtBookNames.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.TxtBookNames.CustomButton.Name = "";
            this.TxtBookNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookNames.CustomButton.TabIndex = 1;
            this.TxtBookNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookNames.CustomButton.UseSelectable = true;
            this.TxtBookNames.CustomButton.Visible = false;
            this.TxtBookNames.Lines = new string[0];
            this.TxtBookNames.Location = new System.Drawing.Point(165, 89);
            this.TxtBookNames.MaxLength = 32767;
            this.TxtBookNames.Name = "TxtBookNames";
            this.TxtBookNames.PasswordChar = '\0';
            this.TxtBookNames.PromptText = "책제목 선택";
            this.TxtBookNames.ReadOnly = true;
            this.TxtBookNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookNames.SelectedText = "";
            this.TxtBookNames.SelectionLength = 0;
            this.TxtBookNames.SelectionStart = 0;
            this.TxtBookNames.ShortcutsEnabled = true;
            this.TxtBookNames.Size = new System.Drawing.Size(101, 23);
            this.TxtBookNames.TabIndex = 7;
            this.TxtBookNames.UseSelectable = true;
            this.TxtBookNames.WaterMark = "책제목 선택";
            this.TxtBookNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtMemberIdx
            // 
            // 
            // 
            // 
            this.TxtMemberIdx.CustomButton.Image = null;
            this.TxtMemberIdx.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.TxtMemberIdx.CustomButton.Name = "";
            this.TxtMemberIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberIdx.CustomButton.TabIndex = 1;
            this.TxtMemberIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberIdx.CustomButton.UseSelectable = true;
            this.TxtMemberIdx.CustomButton.Visible = false;
            this.TxtMemberIdx.Lines = new string[0];
            this.TxtMemberIdx.Location = new System.Drawing.Point(103, 60);
            this.TxtMemberIdx.MaxLength = 32767;
            this.TxtMemberIdx.Name = "TxtMemberIdx";
            this.TxtMemberIdx.PasswordChar = '\0';
            this.TxtMemberIdx.ReadOnly = true;
            this.TxtMemberIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberIdx.SelectedText = "";
            this.TxtMemberIdx.SelectionLength = 0;
            this.TxtMemberIdx.SelectionStart = 0;
            this.TxtMemberIdx.ShortcutsEnabled = true;
            this.TxtMemberIdx.Size = new System.Drawing.Size(56, 23);
            this.TxtMemberIdx.TabIndex = 2;
            this.TxtMemberIdx.UseSelectable = true;
            this.TxtMemberIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBookIdx
            // 
            // 
            // 
            // 
            this.TxtBookIdx.CustomButton.Image = null;
            this.TxtBookIdx.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.TxtBookIdx.CustomButton.Name = "";
            this.TxtBookIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookIdx.CustomButton.TabIndex = 1;
            this.TxtBookIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookIdx.CustomButton.UseSelectable = true;
            this.TxtBookIdx.CustomButton.Visible = false;
            this.TxtBookIdx.Lines = new string[0];
            this.TxtBookIdx.Location = new System.Drawing.Point(103, 89);
            this.TxtBookIdx.MaxLength = 32767;
            this.TxtBookIdx.Name = "TxtBookIdx";
            this.TxtBookIdx.PasswordChar = '\0';
            this.TxtBookIdx.ReadOnly = true;
            this.TxtBookIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookIdx.SelectedText = "";
            this.TxtBookIdx.SelectionLength = 0;
            this.TxtBookIdx.SelectionStart = 0;
            this.TxtBookIdx.ShortcutsEnabled = true;
            this.TxtBookIdx.Size = new System.Drawing.Size(56, 23);
            this.TxtBookIdx.TabIndex = 3;
            this.TxtBookIdx.UseSelectable = true;
            this.TxtBookIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Image = global::NewBookRentalShopApp.Properties.Resources.search2;
            this.BtnSearchBook.Location = new System.Drawing.Point(272, 89);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(30, 23);
            this.BtnSearchBook.TabIndex = 5;
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = global::NewBookRentalShopApp.Properties.Resources.search2;
            this.BtnSearchMember.Location = new System.Drawing.Point(272, 60);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(30, 23);
            this.BtnSearchMember.TabIndex = 4;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // FrmBookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBookRental";
            this.Text = "대출";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox TxtMemNames;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtRentalIdx;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DtpRetrunDate;
        private MetroFramework.Controls.MetroTextBox TxtBookNames;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.Button BtnSearchMember;
        private MetroFramework.Controls.MetroTextBox TxtBookIdx;
        private MetroFramework.Controls.MetroTextBox TxtMemberIdx;
        private System.Windows.Forms.Button BtnSearchBook;
    }
}