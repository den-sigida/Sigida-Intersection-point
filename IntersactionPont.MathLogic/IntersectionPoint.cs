using IntersactionPont.MathLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IntersactionPont.MathLogic
{
    public class IntersectionPoint
    {
        private Line _firstLine;
        private Line _secondLine;
        public IntersectionPoint(Line firstLine, Line secondLine)
        {
            _firstLine=firstLine;
            _secondLine=secondLine;
        }

        public void Find()
        {
            double 
        }

        public double MemberA(double y2, double y1)
        {
            return y2 - y2;
        }

        public double MemberB(double x1, double x2)
        {
            return x1 - x2;
        }

        public double MemberC(double x1, double x2, double y1, double y2)
        {
            return ((-x1) * y2) + (y1 * x2);
        }
    }
}
