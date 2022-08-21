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
        public void GetRecord(string output)
        {
                records.Add($"{output}");
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

            records.Clear();
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
            File.Delete("records.txt");
            recordTextBox.Text = string.Join("\r\n", records);
        }

        public void ClearRecord(TextBox recordTextBox)
        {
            records.Clear();
            File.Delete("records.txt");
            recordTextBox.Text = "";
        }
    }
}

