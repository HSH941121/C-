using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentForm
{
    class Departmentinfo
    {
        public string mName;
        public int NoProf;
        public int NoAssitant;
        public int NoStudent;
        public string mBuliding;

        public Departmentinfo(string n, int p, int a, int s, string b)
        {
            mName = n;
            NoProf = p;
            NoAssitant = a;
            NoStudent = s;
            mBuliding = b;
        }

        public string WriteLine()
        {
            //return mName + " " + NoProf.ToString() + " " + NoAssitant.ToString() + " " + NoStudent.ToString() + " " + mBuliding;
            return string.Format("{0} {1} {2} {3} {4}", mName, NoProf, NoAssitant, NoStudent, mBuliding);
        }
    }
}
