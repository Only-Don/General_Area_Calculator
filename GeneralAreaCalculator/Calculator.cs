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
            SqaureLable.Visible = true;
        }
        public void Graphic()
        {
            comboBox1.Items.Add("正方形");
            comboBox1.Items.Add("圆形");
            comboBox1.Items.Add("长方形");
            comboBox1.Items.Add("三角形");
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("正方形");
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
                    CircleLable.Visible = true;
                    break;
                case 2:
                    RectangleLengthLable.Visible = true;
                    RectangleWidthLable.Visible = true;
                    textBox2.Visible = true;
                    break;
                case 3:
                    TriangleBaseLable.Visible = true;
                    TriangleHeightLable.Visible = true;
                    textBox2.Visible = true;
                    break;

            }
            if(textBox2.Visible)
            {
                radioButton3.Visible = true;
                radioButton4.Visible = true;
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
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int graph = comboBox1.SelectedIndex;
            if(graph <= 1)
            {
                try
                {
                    Unit unit = new Unit(int.Parse(textBox1.Text), radioButton1.Checked);
                    textBox3.Text = $"{unit.centimeterLeft.centimeter}\r\n{unit.inchLeft.inch}";
                }
                catch
                {
                    MessageBox.Show("请输入数字而不是其他类型数据！");
                }
            }
            else
            {
                try
                {
                    Unit unit = new Unit(int.Parse(textBox1.Text), int.Parse(textBox2.Text), radioButton1.Checked, radioButton3.Checked);
                    textBox3.Text = $"{unit.centimeterLeft.centimeter}\r\n{unit.centimeterRight.centimeter}\r\n{unit.inchLeft.inch}\r\n{unit.inchRight.inch}";
                }
                catch
                {
                    MessageBox.Show("请输入数字而不是其他类型数据！");
                }
            }
        }
    }
}
