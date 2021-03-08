namespace Ex14
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputStart = new System.Windows.Forms.TextBox();
            this.inputStop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "3의 배수의 합";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputStart
            // 
            this.inputStart.Location = new System.Drawing.Point(67, 108);
            this.inputStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputStart.Name = "inputStart";
            this.inputStart.Size = new System.Drawing.Size(114, 25);
            this.inputStart.TabIndex = 1;
            this.inputStart.Text = "1";
            this.inputStart.TextChanged += new System.EventHandler(this.inputStart_TextChanged);
            // 
            // inputStop
            // 
            this.inputStop.Location = new System.Drawing.Point(393, 108);
            this.inputStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputStop.Name = "inputStop";
            this.inputStop.Size = new System.Drawing.Size(114, 25);
            this.inputStop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "시작할 정수를 입력하세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "종료할 정수를 입력하세요.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(94, 402);
            this.result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(401, 25);
            this.result.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "답은 다음과 같습니다.";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 556);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputStop);
            this.Controls.Add(this.inputStart);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputStart;
        private System.Windows.Forms.TextBox inputStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
    }
}

