namespace Chartstudy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btSin = new System.Windows.Forms.Button();
            this.btCos = new System.Windows.Forms.Button();
            this.btTan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(478, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title4.Name = "Title1";
            this.chart1.Titles.Add(title4);
            // 
            // btSin
            // 
            this.btSin.Location = new System.Drawing.Point(12, 268);
            this.btSin.Name = "btSin";
            this.btSin.Size = new System.Drawing.Size(101, 48);
            this.btSin.TabIndex = 1;
            this.btSin.Text = "Sin Curve";
            this.btSin.UseVisualStyleBackColor = true;
            this.btSin.Click += new System.EventHandler(this.btSin_Click);
            // 
            // btCos
            // 
            this.btCos.Location = new System.Drawing.Point(134, 268);
            this.btCos.Name = "btCos";
            this.btCos.Size = new System.Drawing.Size(101, 48);
            this.btCos.TabIndex = 1;
            this.btCos.Text = "Cos Curve";
            this.btCos.UseVisualStyleBackColor = true;
            this.btCos.Click += new System.EventHandler(this.btCos_Click);
            // 
            // btTan
            // 
            this.btTan.Location = new System.Drawing.Point(258, 268);
            this.btTan.Name = "btTan";
            this.btTan.Size = new System.Drawing.Size(115, 48);
            this.btTan.TabIndex = 2;
            this.btTan.Text = "Tan Curve";
            this.btTan.UseVisualStyleBackColor = true;
            this.btTan.Click += new System.EventHandler(this.btTan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 416);
            this.Controls.Add(this.btTan);
            this.Controls.Add(this.btCos);
            this.Controls.Add(this.btSin);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btSin;
        private System.Windows.Forms.Button btCos;
        private System.Windows.Forms.Button btTan;
        private System.Windows.Forms.Timer timer1;
    }
}

