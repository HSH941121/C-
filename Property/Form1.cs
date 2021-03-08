using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;
using Accord.Math;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Distributions.Fitting;

namespace Property
{
    
    public partial class Form1 : Form
    {
        DataTable mDT;
        NaiveBayes<NormalDistribution> nb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mDT = new DataTable("MaleROFemale");

            mDT.Columns.Add("Height", "Weight", "FootSize", "Sex");

            mDT.Rows.Add("175", "78", "270", "0");
            mDT.Rows.Add("153", "50", "220", "1");

            dataGridView1.DataSource = mDT;
        }

        private void btLearn_Click(object sender, EventArgs e)
        {
            mDT = (DataTable)dataGridView1.DataSource;

            double[][] inputs = mDT.ToJagged<double>("Height", "Weight", "FootSize");
            int[] output = mDT.ToArray<int>("Sex");

            var learner = new NaiveBayesLearning<NormalDistribution, NormalOptions>();
            learner.Options.InnerOption.Regularization = 1e-5;

            nb = learner.Learn(inputs, output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nb == null) return;

            double height = double.Parse(tbHeight.Text);
            double weight = double.Parse(tbWeight.Text);
            double foot = double.Parse(tbFootSize.Text);

            double[] input = { height, weight, foot };
            double[] result = nb.Probabilities(input);

            tbMale.Text = result[0].ToString("0.00");
            tbFemale.Text = result[1].ToString("0.00");

            if(result[0]> result[1])
            {
                tbResult.Text = "남자";
            }
            else
            {
                tbResult.Text = "여자";
            }
        }
    }
}
