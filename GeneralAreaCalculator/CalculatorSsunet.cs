//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Record;

//namespace GeneralAreaCalculator
//{
//    public partial class Form1 : Form
//    {
//        HistoryRecord record = new HistoryRecord();
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Load_Click(object sender, EventArgs e)
//        {
//            record.ShowRecord(this.textBox3);
//        }

//        private void Save_Click(object sender, EventArgs e)
//        {
//            record.SaveRecord();
//        }

//        private void calculate_Click(object sender, EventArgs e)
//        {
//            string output = "";//此处取输出结果


//            record.GetRecord(output, this.comboBox1.Text, this.comboBox2.Text);
//        }
//    }
//}
