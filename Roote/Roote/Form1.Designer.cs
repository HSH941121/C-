namespace Roote
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
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Roots1 = new System.Windows.Forms.TextBox();
            this.tb_Roots2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(11, 41);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(100, 21);
            this.tb_A.TabIndex = 0;
            this.tb_A.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(145, 41);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(100, 21);
            this.tb_B.TabIndex = 0;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(283, 41);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(100, 21);
            this.tb_C.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find Roots";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Roots1
            // 
            this.tb_Roots1.Location = new System.Drawing.Point(33, 42);
            this.tb_Roots1.Name = "tb_Roots1";
            this.tb_Roots1.Size = new System.Drawing.Size(100, 21);
            this.tb_Roots1.TabIndex = 0;
            this.tb_Roots1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_Roots2
            // 
            this.tb_Roots2.Location = new System.Drawing.Point(246, 40);
            this.tb_Roots2.Name = "tb_Roots2";
            this.tb_Roots2.Size = new System.Drawing.Size(100, 21);
            this.tb_Roots2.TabIndex = 0;
            this.tb_Roots2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_B);
            this.groupBox1.Controls.Add(this.tb_A);
            this.groupBox1.Controls.Add(this.tb_C);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이차방정식의 계수들";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Roots2);
            this.groupBox2.Controls.Add(this.tb_Roots1);
            this.groupBox2.Location = new System.Drawing.Point(18, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이차방정식의 두근";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Roots1;
        private System.Windows.Forms.TextBox tb_Roots2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

