using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS.WinApp.LabWork6.Task3.WindowsFormsChart
{
    class Dat
    {
        Random r;
        public Dat()
        {
            r = new Random();
        }

        public Dat(int t)
        {
            r = new Random(t);
        }

        public int random(int t)
        {
            int res = r.Next(t);
            return res;
        }
    }
}
