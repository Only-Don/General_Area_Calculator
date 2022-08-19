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

        public HistoryRecord()
        {
            FileStream recordFile = new FileStream("records.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(recordFile);
            while (streamReader.Peek() >= 0)
            {
                records.Add(streamReader.ReadLine());
            }
        }

        //运算结束时调用
        public void GetRecord(string ouput, string graphicsType,string unitType)
        {
            records.Add($"{graphicsType} {unitType} {ouput}");
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
            recordTextBox.Text = string.Join("\r\n", records);
        }

    }
}

