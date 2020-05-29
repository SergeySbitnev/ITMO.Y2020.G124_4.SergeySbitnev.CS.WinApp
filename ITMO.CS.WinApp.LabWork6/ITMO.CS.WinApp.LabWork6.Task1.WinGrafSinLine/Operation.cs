using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS.WinApp.LabWork6.Task1.WinGrafSinLine
{
    class Operation
    {
        public static double SummSin (int x, double firstFactor, double secondFactor)
        {
            double res;
            return res = Math.Sin(x * firstFactor) + Math.Sin(x * secondFactor);
        }
    }
}
