namespace ex18_winControlApp
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
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TrbDummy = new TrackBar();
            PrgDummy = new ProgressBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddChild = new Button();
            BtnAddRoot = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            groupBox5 = new GroupBox();
            PicNomal = new PictureBox();
            BtnLoad = new Button();
            DlgOpenImage = new OpenFileDialog();
            GrbEdiTor = new GroupBox();
            BtnFileSave = new Button();
            BtnFileLoad = new Button();
            RtxEditor = new RichTextBox();
            groupbox7 = new GroupBox();
            PrgProcess = new ProgressBar();
            BtnStop = new Button();
            BtnThread = new Button();
            BtnNothread = new Button();
            TxtLog = new TextBox();
            BgwProgress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNomal).BeginInit();
            GrbEdiTor.SuspendLayout();
            groupbox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(23, 60);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(361, 21);
            TxtSampleText.TabIndex = 3;
            TxtSampleText.Text = "Hello, C#!";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 8.999999F, FontStyle.Italic);
            ChkItalic.Location = new Point(322, 33);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            ChkBold.Location = new Point(266, 33);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(68, 31);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(192, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕", 8.999999F);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Location = new Point(9, 118);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(415, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(2, 17);
            TrbDummy.Margin = new Padding(2);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(383, 45);
            TrbDummy.TabIndex = 1;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(5, 68);
            PrgDummy.Margin = new Padding(2);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(376, 22);
            PrgDummy.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(9, 224);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(415, 56);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(324, 20);
            BtnQuestion.Margin = new Padding(2);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(73, 32);
            BtnQuestion.TabIndex = 3;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(199, 20);
            BtnMsgBox.Margin = new Padding(2);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(106, 32);
            BtnMsgBox.TabIndex = 2;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(107, 20);
            BtnModaless.Margin = new Padding(2);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(73, 32);
            BtnModaless.TabIndex = 1;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(14, 20);
            BtnModal.Margin = new Padding(2);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(73, 32);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(9, 290);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(418, 245);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(115, 201);
            BtnAddChild.Margin = new Padding(2);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(103, 40);
            BtnAddChild.TabIndex = 3;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(5, 201);
            BtnAddRoot.Margin = new Padding(2);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(106, 40);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(215, 26);
            LsvDummy.Margin = new Padding(2);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(192, 171);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(5, 26);
            TrvDummy.Margin = new Padding(2);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(207, 171);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PicNomal);
            groupBox5.Location = new Point(442, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(401, 244);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽처박스";
            // 
            // PicNomal
            // 
            PicNomal.BackColor = SystemColors.ButtonShadow;
            PicNomal.Location = new Point(11, 24);
            PicNomal.Name = "PicNomal";
            PicNomal.Size = new Size(374, 205);
            PicNomal.TabIndex = 0;
            PicNomal.TabStop = false;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(768, 263);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // GrbEdiTor
            // 
            GrbEdiTor.BackColor = SystemColors.ButtonFace;
            GrbEdiTor.Controls.Add(BtnFileSave);
            GrbEdiTor.Controls.Add(BtnFileLoad);
            GrbEdiTor.Controls.Add(RtxEditor);
            GrbEdiTor.ForeColor = SystemColors.ControlText;
            GrbEdiTor.Location = new Point(849, 22);
            GrbEdiTor.Name = "GrbEdiTor";
            GrbEdiTor.Size = new Size(400, 513);
            GrbEdiTor.TabIndex = 1;
            GrbEdiTor.TabStop = false;
            GrbEdiTor.Text = "텍스트에디터";
            // 
            // BtnFileSave
            // 
            BtnFileSave.Location = new Point(307, 471);
            BtnFileSave.Name = "BtnFileSave";
            BtnFileSave.Size = new Size(75, 39);
            BtnFileSave.TabIndex = 5;
            BtnFileSave.Text = "파일세이브";
            BtnFileSave.UseVisualStyleBackColor = true;
            BtnFileSave.Click += BtnFileSave_Click;
            // 
            // BtnFileLoad
            // 
            BtnFileLoad.Location = new Point(208, 471);
            BtnFileLoad.Name = "BtnFileLoad";
            BtnFileLoad.Size = new Size(75, 39);
            BtnFileLoad.TabIndex = 4;
            BtnFileLoad.Text = "파일로드";
            BtnFileLoad.UseVisualStyleBackColor = true;
            BtnFileLoad.Click += BtnFileLoad_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.BorderStyle = BorderStyle.None;
            RtxEditor.Location = new Point(3, 19);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(391, 446);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // groupbox7
            // 
            groupbox7.Controls.Add(PrgProcess);
            groupbox7.Controls.Add(BtnStop);
            groupbox7.Controls.Add(BtnThread);
            groupbox7.Controls.Add(BtnNothread);
            groupbox7.Controls.Add(TxtLog);
            groupbox7.Location = new Point(442, 290);
            groupbox7.Name = "groupbox7";
            groupbox7.Size = new Size(401, 245);
            groupbox7.TabIndex = 1;
            groupbox7.TabStop = false;
            groupbox7.Text = "스레드,백그라운드워커";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(11, 181);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(374, 23);
            PrgProcess.TabIndex = 4;
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Location = new Point(310, 210);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 3;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(229, 211);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(75, 23);
            BtnThread.TabIndex = 2;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnNothread
            // 
            BtnNothread.Location = new Point(148, 211);
            BtnNothread.Name = "BtnNothread";
            BtnNothread.Size = new Size(75, 23);
            BtnNothread.TabIndex = 1;
            BtnNothread.Text = "노스레드";
            BtnNothread.UseVisualStyleBackColor = true;
            BtnNothread.Click += BtnNothread_Click;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(11, 26);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(374, 149);
            TxtLog.TabIndex = 0;
            // 
            // BgwProgress
            // 
            BgwProgress.DoWork += BgwProgress_DoWork;
            BgwProgress.ProgressChanged += BgwProgress_ProgressChanged;
            BgwProgress.RunWorkerCompleted += BgwProgress_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1261, 553);
            Controls.Add(groupbox7);
            Controls.Add(GrbEdiTor);
            Controls.Add(BtnLoad);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Name = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNomal).EndInit();
            GrbEdiTor.ResumeLayout(false);
            groupbox7.ResumeLayout(false);
            groupbox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CboFonts;
        private Label label1;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private GroupBox groupBox2;
        private TrackBar TrbDummy;
        private ProgressBar PrgDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnAddChild;
        private Button BtnAddRoot;
        private GroupBox groupBox5;
        private Button BtnLoad;
        private PictureBox PicNomal;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEdiTor;
        private RichTextBox RtxEditor;
        private Button BtnFileSave;
        private Button BtnFileLoad;
        private GroupBox groupbox7;
        private ProgressBar PrgProcess;
        private Button BtnStop;
        private Button BtnThread;
        private Button BtnNothread;
        private TextBox TxtLog;
        private System.ComponentModel.BackgroundWorker BgwProgress;
    }
}
