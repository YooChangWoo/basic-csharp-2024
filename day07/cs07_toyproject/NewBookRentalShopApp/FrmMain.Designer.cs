namespace NewBookRentalShopApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutasf = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MunLoginUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBookDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.MunBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBookRental = new System.Windows.Forms.ToolStripMenuItem();
            this.LblLoginId = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.toolStripMenuItem1,
            this.MnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(125, 22);
            this.MnuExit.Text = "끝내기(&X)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MunLoginUsers,
            this.MnuBookDivision,
            this.MunBookInfo,
            this.MnuMembers,
            this.MnuBookRental});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "관리(&M)";
            // 
            // MnuAbout
            // 
            this.MnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAboutasf});
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(72, 20);
            this.MnuAbout.Text = "도움말(&H)";
            // 
            // MnuAboutasf
            // 
            this.MnuAboutasf.Name = "MnuAboutasf";
            this.MnuAboutasf.Size = new System.Drawing.Size(180, 22);
            this.MnuAboutasf.Text = "이 프로그램은...(&A)";
            this.MnuAboutasf.Click += new System.EventHandler(this.MnuAboutasf_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblLoginId});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "로그인아이디";
            // 
            // MunLoginUsers
            // 
            this.MunLoginUsers.Image = ((System.Drawing.Image)(resources.GetObject("MunLoginUsers.Image")));
            this.MunLoginUsers.Name = "MunLoginUsers";
            this.MunLoginUsers.Size = new System.Drawing.Size(174, 22);
            this.MunLoginUsers.Text = "로그인사용자 관리";
            this.MunLoginUsers.Click += new System.EventHandler(this.MunLoginUsers_Click);
            // 
            // MnuBookDivision
            // 
            this.MnuBookDivision.Image = ((System.Drawing.Image)(resources.GetObject("MnuBookDivision.Image")));
            this.MnuBookDivision.Name = "MnuBookDivision";
            this.MnuBookDivision.Size = new System.Drawing.Size(174, 22);
            this.MnuBookDivision.Text = "책장르 관리";
            this.MnuBookDivision.Click += new System.EventHandler(this.MnuBookDivision_Click);
            // 
            // MunBookInfo
            // 
            this.MunBookInfo.Image = ((System.Drawing.Image)(resources.GetObject("MunBookInfo.Image")));
            this.MunBookInfo.Name = "MunBookInfo";
            this.MunBookInfo.Size = new System.Drawing.Size(174, 22);
            this.MunBookInfo.Text = "책정보관리";
            this.MunBookInfo.Click += new System.EventHandler(this.MunBookInfo_Click);
            // 
            // MnuMembers
            // 
            this.MnuMembers.Image = ((System.Drawing.Image)(resources.GetObject("MnuMembers.Image")));
            this.MnuMembers.Name = "MnuMembers";
            this.MnuMembers.Size = new System.Drawing.Size(174, 22);
            this.MnuMembers.Text = "도서회원 관리";
            this.MnuMembers.Click += new System.EventHandler(this.MnuMembers_Click);
            // 
            // MnuBookRental
            // 
            this.MnuBookRental.Image = ((System.Drawing.Image)(resources.GetObject("MnuBookRental.Image")));
            this.MnuBookRental.Name = "MnuBookRental";
            this.MnuBookRental.Size = new System.Drawing.Size(174, 22);
            this.MnuBookRental.Text = "대출 관리";
            this.MnuBookRental.Click += new System.EventHandler(this.MnuBookRental_Click);
            // 
            // LblLoginId
            // 
            this.LblLoginId.Name = "LblLoginId";
            this.LblLoginId.Size = new System.Drawing.Size(12, 17);
            this.LblLoginId.Text = "-";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "책 대여점 v1.2";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MunLoginUsers;
        private System.Windows.Forms.ToolStripMenuItem MnuBookDivision;
        private System.Windows.Forms.ToolStripMenuItem MunBookInfo;
        private System.Windows.Forms.ToolStripMenuItem MnuMembers;
        private System.Windows.Forms.ToolStripMenuItem MnuBookRental;
        private System.Windows.Forms.ToolStripMenuItem MnuAboutasf;
        private System.Windows.Forms.ToolStripStatusLabel LblLoginId;
    }
}

