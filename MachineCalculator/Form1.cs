using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace MachineCalculator
{
    public partial class Form1 : Form
    {
        private List<string> fileHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a file"; //browse name
            openFileDialog.Filter = "All files (*.*)|*.*"; //read all files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName; //show path file

                fileHistory.Add(openFileDialog.FileName); //save to list history

                UpdateComboBox();

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                string content = File.ReadAllText(openFileDialog.FileName, Encoding.GetEncoding(932)); //encode JiS

                listBox1.Items.Clear();

                string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None); //save text form file per lines
                foreach (string line in lines)
                {
                    if (line.Contains("#"))
                    {
                        listBox1.Items.Add(line); //add line
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lengths = new List<string>();

            string selectedFileName = comboBox1.SelectedItem.ToString();

            string selectedFilePath = fileHistory.Find(filePath => System.IO.Path.GetFileName(filePath) == selectedFileName); //find filename in filehistory == selectfilename just show filepath

            textBox1.Text = selectedFilePath;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string content = File.ReadAllText(selectedFilePath, Encoding.GetEncoding(932)); //encode JiS

            listBox1.Items.Clear();

            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None); //save text form file per lines
            foreach (string line in lines)
            {
                if (line.Contains("#"))
                {
                    listBox1.Items.Add(line); //add line
                }

                if (line.Contains("材料先端位置"))
                {
                    string[] parts = line.Split(new char[] { ']', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    //MessageBox.Show(parts.Length.ToString());

                    if (parts.Length == 2)
                    {
                        // ตรวจสอบว่า parts[1] และ parts[2] สามารถใช้ได้หรือไม่
                        string pos = parts[0].Replace("mm", "").Trim();
                        string length = parts[1].Replace("mm", "").Trim();

                        //MessageBox.Show(length);

                        lengths.Add(length);
                    }
                }
            }

            double value = double.Parse(lengths[0]);
            double valueCal = value / 1600;
            textBox8.Text = valueCal.ToString("F2");

            // P1, P2
            List<string> data = listBox1.Items.Cast<string>().ToList();
            Dictionary<int, List<string>> sections = new Dictionary<int, List<string>>();

            textBox10.Clear();

            int StartSection = -1;
            int EndSection = -1;

            foreach (string line in data)
            {
                Match match = Regex.Match(line, @"■\s*(\d+)\s*/\s*(\d+)"); // find ■ ? / ?

                if (match.Success)
                {
                    StartSection = int.Parse(match.Groups[1].Value); // add value
                    EndSection = int.Parse(match.Groups[2].Value); // add value

                    if (!sections.ContainsKey(StartSection))
                    {
                        sections[StartSection] = new List<string>(); // add startsection to section list
                    }
                    continue;
                }

                if (StartSection != -1)
                {
                    sections[StartSection].Add(line);
                }
            }
            //***
            foreach (var section in sections)
            {
                int sectionNumber = section.Key;
                double totalTime = 0;
                double[] previousValues = new double[4];
                int getText = 1;
                string allresult = "";

                //MessageBox.Show($"กำลังคำนวณส่วนที่ {sectionNumber} / {EndSection}");

                foreach (string item in section.Value)
                {
                    string noSpacesItem = item.Replace(" ", "");
                    string result = noSpacesItem.Replace("#", "");

                    if (result.StartsWith(getText.ToString()))
                    {
                        allresult += result + Environment.NewLine;

                        string[] values = result.Split(',');

                        if (values.Length >= 10)
                        {
                            double x1 = double.Parse(values[1]);
                            double y1 = double.Parse(values[2]);
                            double z1 = double.Parse(values[3]);
                            double speed = double.Parse(values[8]);

                            if (getText > 1)
                            {
                                double x2 = previousValues[0];
                                double y2 = previousValues[1];
                                double z2 = previousValues[2];

                                double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
                                double time = distance / speed;
                                totalTime += time;
                            }

                            previousValues[0] = x1;
                            previousValues[1] = y1;
                            previousValues[2] = z1;
                            previousValues[3] = speed;
                        }
                        else
                        {
                            MessageBox.Show("ข้อมูลไม่ครบถ้วน");
                        }

                        getText++;
                    }
                }

                // เพิ่มผลลัพธ์ของเวลาไปที่ TextBox ตามหมายเลขส่วน
                string resultText = totalTime.ToString("F2");

                // ตรวจสอบว่า sectionNumber ตรงกับ TextBox ใด
                if (sectionNumber == 1)
                {
                    textBox2.Text = resultText; // เพิ่มไปที่ TextBox2
                }
                else if (sectionNumber == 2)
                {
                    textBox10.Text = resultText; // เพิ่มไปที่ TextBox10
                }
                // เพิ่มเงื่อนไขสำหรับส่วนที่มากขึ้นได้เช่นเดียวกัน
                // else if (sectionNumber == 4) { textBox4.Text = resultText; }
                // else if (sectionNumber == 5) { textBox5.Text = resultText; }

                //MessageBox.Show(resultText); // แสดงข้อความผลลัพธ์
            }
            //***
        }

        private void UpdateComboBox()
        {
            comboBox1.Items.Clear();

            foreach (string filePath in fileHistory)
            {
                comboBox1.Items.Add(System.IO.Path.GetFileName(filePath)); //add filename to combobox1
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1; //choose last choice
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                int num1 = int.Parse(textBox2.Text);
                int num2 = int.Parse(textBox3.Text);

                int sum = num1 + num2;

                count++;

                string outputValue = $"{count}. {sum}";

                listBox2.Items.Add(outputValue);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string items = string.Join(Environment.NewLine, listBox1.Items.Cast<object>());
            MessageBox.Show(items);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
