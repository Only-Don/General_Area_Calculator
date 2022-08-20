using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Record
{
    public class HistoryRecord
    {
        List<string> records = new List<string>();

        //运算结束时调用
        public void GetRecord(string ouput, double cmLeft, double inLeft, int Gragh)
        {
            if (Gragh == 0)
            {
                records.Add($"[边长：{cmLeft:0.000}cm({inLeft:0.000}inch)]{ouput}");
            }
            if (Gragh == 1)
            {
                records.Add($"[直径：{cmLeft:0.000}cm({inLeft:0.000}inch),{ouput}");
            }
        }

        public void GetRecord(string ouput, double cmLeft, double inLeft, double cmRight, double inRight, int Gragh)
        {
            if (Gragh == 2)
            {
                records.Add($"[长：{cmLeft:0.000}cm({inLeft:0.000}inch),宽：{cmRight:0.000}cm({inRight:0.000}inch)]{ouput}");
            }
            if (Gragh == 3)
            {
                records.Add($"[底：{cmLeft:0.000}cm({inLeft:0.000}inch),高：{cmRight:0.000}cm({inRight:0.000}inch)]{ouput}");
            }
        }

        //保存时调用
        public void SaveRecord()
        {
            FileStream recordFile = new FileStream("records.txt",FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(recordFile);

            foreach (var record in records)
            {
                streamWriter.WriteLine(record);
            }
            streamWriter.Close();
        }

        //点击查看历史记录时调用
        public void ShowRecord(TextBox recordTextBox)
        {
            FileStream recordFile = new FileStream("records.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(recordFile);
            while (streamReader.Peek() >= 0)
            {
                records.Add(streamReader.ReadLine());
            }
            streamReader.Close();

            recordTextBox.Text = string.Join("\r\n", records);
        }

        public void ClearRecord()
        {
            records.Clear();
            File.Delete("records.txt");

        }
    }
}

