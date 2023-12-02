using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TkachukSS.Sprint2.Review.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y > 0)
            {
                if (((x * x) + (y * y) <= 4))
                {
                    if (((x * x) + (y * y) >= 1))
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
