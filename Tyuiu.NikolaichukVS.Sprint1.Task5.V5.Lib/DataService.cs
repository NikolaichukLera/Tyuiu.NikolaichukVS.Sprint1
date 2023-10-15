using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaichukVS.Sprint1.Task5.V5.Lib
{
    public class DataService 
    {
        public int SecondsToHours(int k)
        {
            int res = (k / 60) / 60;
            return res;
        }
    }
}
