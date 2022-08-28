using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralAreaCalculator
{
    public partial class ShapeButton : Button
    {
        public ShapeButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        bool flag;
        [Description(" 获取或设置按钮椭圆效果。"), DefaultValue(false)]
        public bool Circle
        {
            set
            {
                flag = value;
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(this.ClientRectangle);//圆形
                this.Region = new Region(gp);
                FlatAppearance.BorderSize = 0;//去掉边框
                FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Invalidate();
            }
            get { return flag; }
        }
    }
}
