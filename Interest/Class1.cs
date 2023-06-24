using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    public class SimpleInterest
    {
        public int CalculateInterest(int P, int R, int T)
        {
            int SIvalue = (P * R * T) / 100;
            return SIvalue;
        }
    }
    public class CompoundInterest
    {
        public double CalculateInterest(double P, double R, double T)
        {
            double CIvalue = P * (Math.Pow((1 + R / 100.0), T));
            return CIvalue;
        }
    }
}
