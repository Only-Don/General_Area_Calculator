using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAreaCalculator
{
    internal class Area
    {
        public double cmArea { get; set; }
        public double inArea { get; set; }
        public Area(double cmLeft, double inLeft, int Gragh)
        {
            if (Gragh == 0)
            {
                cmArea = cmLeft * cmLeft;
                inArea = inLeft * inLeft;
            }
            else if (Gragh == 1)
            {
                cmArea = cmLeft * cmLeft * 3.1415926 / 4;
                inArea = inLeft * inLeft * 3.1415926 / 4;
            }
        }
        public Area(double cmLeft, double inLeft, double cmRight, double inRight, int Gragh)
        {
            if (Gragh == 2)
            {
                cmArea = cmLeft * cmRight;
                inArea = inLeft * inRight;
            }
            else if (Gragh == 3)
            {
                cmArea = cmLeft * cmRight * 0.5;
                inArea = inLeft * inRight * 0.5;
            }
        }
    }
}
