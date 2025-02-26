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
        int count = 0;
        //real
        int C = 4;
        int D = 3;
        int G = 2;
        int F = 1 / 1600;

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
            }
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

        private void button5_Click(object sender, EventArgs e)
        {

            List<string> data = listBox1.Items.Cast<string>().ToList();
            Dictionary<int, List<string>> sections = new Dictionary<int, List<string>>();

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

                MessageBox.Show($"กำลังคำนวณส่วนที่ {sectionNumber} / {EndSection}");

                foreach (string item in section.Value)
                {
                    string noSpacesItem = item.Replace(" ", "");
                    string result = noSpacesItem.Replace("#", "");

                    if (result.StartsWith(getText.ToString()))
                    {
                        listBox3.Items.Add(result);
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

                MessageBox.Show($"เวลารวมของส่วนที่ {sectionNumber} / {EndSection}: {totalTime:F2} วินาที");
            }
            //***
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> data = listBox1.Items.Cast<string>().ToList();
            Dictionary<int, List<string>> sections = new Dictionary<int, List<string>>();

            int StartSection = -1; //start
            int EndSection = -1; //end

            foreach (string line in data)
            {
                Match match = Regex.Match(line, @"■\s*(\d+)\s*/\s*(\d+)"); // find ■ ? / ?

                if (match.Success)
                {
                    StartSection = int.Parse(match.Groups[1].Value); // add value to parameter (\d+)
                    EndSection = int.Parse(match.Groups[2].Value); // add value to parameter (\d+)

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
        }
    }
}
