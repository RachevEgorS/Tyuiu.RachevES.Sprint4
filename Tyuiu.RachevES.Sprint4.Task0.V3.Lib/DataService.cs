using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RachevES.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int a = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    a = a * i;
                }
            }
            return a;
        }
    }
}
