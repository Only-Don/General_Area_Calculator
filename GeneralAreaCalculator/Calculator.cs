﻿using Record;
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
        HistoryRecord record = new HistoryRecord();
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
                    Unit unit = new Unit(double.Parse(textBox1.Text), radioButton1.Checked);
                    Area area = new Area(unit.centimeterLeft.centimeter, unit.inchLeft.inch, graph);
                    textBox3.Text = $"您选择的是{comboBox1.SelectedItem}\r\n该图形的面积为{area.cmArea:0.000}平方厘米（等价于{area.inArea:0.000}平方英寸）";

                    record.GetRecord(textBox3.Text, unit.centimeterLeft.centimeter, unit.inchLeft.inch, graph);
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
                    Unit unit = new Unit(double.Parse(textBox1.Text), double.Parse(textBox2.Text), radioButton1.Checked, radioButton3.Checked);
                    Area area = new Area(unit.centimeterLeft.centimeter, unit.inchLeft.inch, unit.centimeterRight.centimeter, unit.inchRight.inch, graph);
                    textBox3.Text = $"您选择的是{comboBox1.SelectedItem}\r\n该图形的面积为{area.cmArea:0.000}平方厘米（等价于{area.inArea:0.000}平方英寸）";

                    record.GetRecord(textBox3.Text, unit.centimeterLeft.centimeter, unit.inchLeft.inch, unit.centimeterRight.centimeter, unit.inchRight.inch, graph);
                }
                catch
                {
                    MessageBox.Show("请输入数字而不是其他类型数据！");
                }
            }
        }

        private void LoadHistory_Click(object sender, EventArgs e)
        {
            record.ShowRecord(this.textBox3);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            record.ClearRecord(this.textBox3);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            record.SaveRecord();
        }
    }
}
