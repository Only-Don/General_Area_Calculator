using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAreaCalculator
{
    class Unit
    {
        public Centimeter centimeterLeft { get; set; }
        public Centimeter centimeterRight { get; set; }
        public Inch inchLeft { get; set; }
        public Inch inchRight { get; set; }
        public Unit(double dataLeft, double dataRight, bool judgeLeft, bool judgeRight)
        {
            centimeterLeft = new Centimeter(dataLeft, judgeLeft);
            inchLeft = new Inch(dataLeft, judgeLeft);
            centimeterRight = new Centimeter(dataRight, judgeRight);
            inchRight = new Inch(dataRight, judgeRight);
        }
        public Unit(double data, bool judge)
        {
            centimeterLeft = new Centimeter(data, judge);
            inchLeft = new Inch(data, judge);
            centimeterRight = null;
            inchRight = null;
        }
    }
    class Centimeter
    {
        public double centimeter { get; set; }
        public Centimeter(double data, bool judge)
        {
            if (judge)
                centimeter = data;
            else
                centimeter = data * 2.54;
        }
    }
    class Inch
    {
        public double inch { get; set; }
        public Inch(double data, bool judge)
        {
            if (!judge)
                inch = data;
            else
                inch = data / 2.54;
        }
    }
}
