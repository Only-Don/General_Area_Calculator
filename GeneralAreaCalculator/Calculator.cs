using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralAreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphic();
            Unit();
            SqaureLable.Visible = true;
        }
        public void Graphic()
        {
            comboBox1.Items.Add("正方形");
            comboBox1.Items.Add("长方形");
            comboBox1.Items.Add("三角形");
            comboBox1.Items.Add("圆形");
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("正方形");
        }
        public void Unit()
        {
            comboBox2.Items.Add("厘米");
            comboBox2.Items.Add("英寸");
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("厘米");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            clearAll();
            switch(index)
            {
                case 0:
                    SqaureLable.Visible = true;
                    break;
                case 1:
                    RectangleLengthLable.Visible = true;
                    RectangleWidthLable.Visible = true;
                    textBox2.Visible = true;
                    break;
                case 2:
                    TriangleBaseLable.Visible = true;
                    TriangleHeightLable.Visible = true;
                    textBox2.Visible = true;
                    break;
                case 3:
                    CircleLable.Visible = true;
                    break;

            }
        }

        public void clearAll()
        {
            textBox2.Visible = false;
            SqaureLable.Visible = false;
            RectangleLengthLable.Visible = false;
            RectangleWidthLable.Visible = false;
            CircleLable.Visible = false;
            TriangleBaseLable.Visible = false;
            TriangleHeightLable.Visible = false;
        }
    }
}
