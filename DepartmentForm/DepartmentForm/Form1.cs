using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DepartmentForm
{
    public partial class Form1 : Form
    {
        List<Departmentinfo> mDepart;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog aDia = new OpenFileDialog();

            if(aDia.ShowDialog() == DialogResult.OK)
            {
                string filename = aDia.FileName;

                StreamReader sr = new StreamReader(filename,Encoding.Default);
                string line;
                int index = 0;
                char[] splitword = new char[3] {' ',',','\t'};

                while((line = sr.ReadLine())!= null)
                {
                    if(index == 0) {index++;continue;}

                    string[] result = line.Split(splitword, StringSplitOptions.RemoveEmptyEntries);
                    //ainfo:기본적으로string
                    Departmentinfo ainfo = new Departmentinfo(
                        result[0],
                        int.Parse(result[1]),
                        int.Parse(result[2]),
                        int.Parse(result[3]),
                        result[4]);
                    mDepart.Add(ainfo);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mDepart = new List<Departmentinfo>();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mDepart.Count != 0)
            {
                DataTable ds = new DataTable("충남대 학과");

                ds.Columns.Add("학과이름");
                ds.Columns.Add("교수수");
                ds.Columns.Add("조교수");
                ds.Columns.Add("학생수");
                ds.Columns.Add("건물");

                //ds.Rows.Add("간호학과", 10, 3, 100, "E10");
                for (int i = 0; i < mDepart.Count;i++)
                {
                    ds.Rows.Add(mDepart[i].mName,
                                mDepart[i].NoProf,
                                mDepart[i].NoAssitant,
                                mDepart[i].NoStudent,
                                mDepart[i].mBuliding);
                }

                dataGridView1.DataSource = ds;
                
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog aDia = new SaveFileDialog();

            if(aDia.ShowDialog() == DialogResult.OK)
            {
                string filename = aDia.FileName;

                StreamWriter sw = new StreamWriter(filename);

                sw.WriteLine("학과이름 교수수 조교수수 학생수 거주건물명");
                for(int i = 0; i < mDepart.Count; i++)
                {
                   sw.WriteLine(mDepart[i].WriteLine());
                }
                sw.Close();
            }
        }
    }
}
