namespace TimerEx
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelClock = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNewyork = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStop = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(28, 88);
            this.labelClock.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(38, 12);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "label1";
            // 
            // timerNow
            // 
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "서울 기준 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "뉴욕 기준 시간";
            // 
            // labelNewyork
            // 
            this.labelNewyork.AutoSize = true;
            this.labelNewyork.Location = new System.Drawing.Point(185, 88);
            this.labelNewyork.Name = "labelNewyork";
            this.labelNewyork.Size = new System.Drawing.Size(38, 12);
            this.labelNewyork.TabIndex = 3;
            this.labelNewyork.Text = "label3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(27, 210);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(53, 12);
            this.labelStop.TabIndex = 5;
            this.labelStop.Text = "공부시작";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(29, 255);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(136, 255);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(75, 23);
            this.btPause.TabIndex = 6;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(251, 255);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 404);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelNewyork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNewyork;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btStop;
    }
}

