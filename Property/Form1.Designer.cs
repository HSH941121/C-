namespace Property
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btLearn = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbFootSize = new System.Windows.Forms.TextBox();
            this.Q = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMale = new System.Windows.Forms.TextBox();
            this.tbFemale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(670, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // btLearn
            // 
            this.btLearn.Location = new System.Drawing.Point(12, 209);
            this.btLearn.Name = "btLearn";
            this.btLearn.Size = new System.Drawing.Size(670, 23);
            this.btLearn.TabIndex = 1;
            this.btLearn.Text = "Learn!!";
            this.btLearn.UseVisualStyleBackColor = true;
            this.btLearn.Click += new System.EventHandler(this.btLearn_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(12, 271);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 21);
            this.tbHeight.TabIndex = 2;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(132, 271);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 21);
            this.tbWeight.TabIndex = 2;
            // 
            // tbFootSize
            // 
            this.tbFootSize.Location = new System.Drawing.Point(260, 271);
            this.tbFootSize.Name = "tbFootSize";
            this.tbFootSize.Size = new System.Drawing.Size(100, 21);
            this.tbFootSize.TabIndex = 2;
            // 
            // Q
            // 
            this.Q.Location = new System.Drawing.Point(387, 269);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(75, 23);
            this.Q.TabIndex = 3;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(489, 269);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(150, 21);
            this.tbResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "FootSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Male OR Female";
            // 
            // tbMale
            // 
            this.tbMale.Location = new System.Drawing.Point(413, 318);
            this.tbMale.Name = "tbMale";
            this.tbMale.Size = new System.Drawing.Size(100, 21);
            this.tbMale.TabIndex = 5;
            // 
            // tbFemale
            // 
            this.tbFemale.Location = new System.Drawing.Point(519, 318);
            this.tbFemale.Name = "tbFemale";
            this.tbFemale.Size = new System.Drawing.Size(100, 21);
            this.tbFemale.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Male Prob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Female Prob";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 362);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFemale);
            this.Controls.Add(this.tbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbFootSize);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.btLearn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btLearn;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbFootSize;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMale;
        private System.Windows.Forms.TextBox tbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

