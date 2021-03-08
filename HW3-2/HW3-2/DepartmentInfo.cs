using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class DepartmentInfo
    {
        public int SchNo;
        public string mName;
        public int Math;
        public int Eng;
        public int Kor;


        public DepartmentInfo(int n, string name, int math, int eng, int kor)
        {
            SchNo = n;
            mName = name;
            Math = math;
            Eng = eng;
            Kor = kor;
        }

        public String WriteLine()
        {
            return string.Format("{0},{1},{2},{3},{4}", SchNo, mName, Math, Eng, Kor);
        }



    }
}
