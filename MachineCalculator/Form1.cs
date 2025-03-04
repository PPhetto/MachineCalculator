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
        int nnn;
        double lengthValue;

        public Form1()
        {
            InitializeComponent();


            textBox3.TextChanged += (s, e) => CalculateTotal();
            textBox4.TextChanged += (s, e) => CalculateTotal();
            textBox5.TextChanged += (s, e) => CalculateTotal();
            textBox6.TextChanged += (s, e) => CalculateTotal();
            textBox7.TextChanged += (s, e) => CalculateTotal();
            textBox8.TextChanged += (s, e) => CalculateTotal();
            textBox9.TextChanged += (s, e) => CalculateTotal();
            comboBox1.SelectedIndexChanged += (s, e) => CalculateTotal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderDialog.SelectedPath;

                string[] files = Directory.GetFiles(folderDialog.SelectedPath, "*.m008");

                foreach (string file in files)
                {
                    textBox1.Text += file + Environment.NewLine;

                    fileHistory.Add(file);

                    UpdateComboBox();

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    string content = File.ReadAllText(file, Encoding.GetEncoding(932)); //encode JiS

                    string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None); // save text from file per line
                    foreach (string line in lines)
                    {
                        if (line.Contains("#"))
                        {
                            listBox1.Items.Add(line);
                        }
                    }

                    button1.Visible = false;
                    button4.Visible = true;
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lengths = new List<string>();
            int count = 0;
            string Dvalue = "";

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
                        string pos = parts[0].Replace("mm", "").Trim();
                        string length = parts[1].Replace("mm", "").Trim();

                        //MessageBox.Show(length);

                        lengths.Add(length);
                    }
                }
                if (line.Contains("ロボット位置"))
                {
                    string[] parts = line.Split(new char[] { '】' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length > 0)
                    {
                        string nemuric = parts[1].Replace("mm", "".Trim());
                        Dvalue = nemuric;
                    }
                }
            }

            double value = double.Parse(lengths[0]);
            double valueCal = (1.0 / 1600.0);
            lengthValue = value;
            textBox8.Text = valueCal.ToString();

            if (Dvalue.StartsWith("0"))
            {
                textBox6.Text = "0";
            }
            else
            {
                textBox6.Text = "3";
            }

            // P1, P2
            List<string> data = listBox1.Items.Cast<string>().ToList();
            Dictionary<int, List<string>> sections = new Dictionary<int, List<string>>();

            listBox2.Items.Clear();

            int StartSection = -1;
            int EndSection = -1;

            foreach (string line in data)
            {
                Match match = Regex.Match(line, @"■\s*(\d+)\s*/\s*(\d+)"); // find ■ ? / ?

                if (match.Success)
                {
                    StartSection = int.Parse(match.Groups[1].Value); // add value
                    EndSection = int.Parse(match.Groups[2].Value); // add value
                    nnn = EndSection;

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
                count++;
                //MessageBox.Show($"เวลารวมของส่วนที่ {sectionNumber} / {EndSection}: {totalTime:F2} วินาที");
                listBox2.Items.Add($"P{count} = {totalTime:F2}");
            }
            //double P;
            //double A = double.Parse(textBox3.Text);
            //double B = double.Parse(textBox4.Text);
            //double C = double.Parse(textBox5.Text);
            //double D = double.Parse(textBox6.Text);
            //double E = double.Parse(textBox7.Text);
            //double F = double.Parse(textBox8.Text);
            //double G = double.Parse(textBox9.Text);
            //double totalP = 0;

            //string Nfile = comboBox1.Text;

            //foreach (var item in listBox2.Items)
            //{
            //    string itemText = item.ToString();
            //    int indexOfEqualSign = itemText.IndexOf("=");

            //    if (indexOfEqualSign >= 0)
            //    {
            //        string valueAfterEqualSign = itemText.Substring(indexOfEqualSign + 1).Trim();

            //        double parsedValue = Convert.ToDouble(valueAfterEqualSign);
            //        P = parsedValue * A + B;
            //        totalP += P;
            //    }
            //}
            //double calculatedValue = totalP + C * nnn + D + E * nnn + lengthValue * F + G;
            //textBox10.Text = calculatedValue.ToString("F2");
        }

        private void CalculateTotal()
        {
            try
            {
                double P;
                double A = double.TryParse(textBox3.Text, out double aVal) ? aVal : 0;
                double B = double.TryParse(textBox4.Text, out double bVal) ? bVal : 0;
                double C = double.TryParse(textBox5.Text, out double cVal) ? cVal : 0;
                double D = double.TryParse(textBox6.Text, out double dVal) ? dVal : 0;
                double E = double.TryParse(textBox7.Text, out double eVal) ? eVal : 0;
                double F = double.TryParse(textBox8.Text, out double fVal) ? fVal : 0;
                double G = double.TryParse(textBox9.Text, out double gVal) ? gVal : 0;
                double totalP = 0;

                foreach (var item in listBox2.Items)
                {
                    string itemText = item.ToString();
                    int indexOfEqualSign = itemText.IndexOf("=");

                    if (indexOfEqualSign >= 0)
                    {
                        string valueAfterEqualSign = itemText.Substring(indexOfEqualSign + 1).Trim();

                        if (double.TryParse(valueAfterEqualSign, out double parsedValue))
                        {
                            P = parsedValue * A + B;
                            totalP += P;
                        }
                    }
                }

                double calculatedValue = totalP + C * nnn + D + E * nnn + lengthValue * F + G;
                textBox10.Text = calculatedValue.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

            //double P;
            //double A = double.Parse(textBox3.Text);
            //double B = double.Parse(textBox4.Text);
            //double C = double.Parse(textBox5.Text);
            //double D = double.Parse(textBox6.Text);
            //double E = double.Parse(textBox7.Text);
            //double F = double.Parse(textBox8.Text);
            //double G = double.Parse(textBox9.Text);
            //double totalP = 0;

            //string Nfile = comboBox1.Text;

            //foreach (var item in listBox2.Items)
            //{
            //    string itemText = item.ToString();
            //    int indexOfEqualSign = itemText.IndexOf("=");

            //    if (indexOfEqualSign >= 0)
            //    {
            //        string valueAfterEqualSign = itemText.Substring(indexOfEqualSign + 1).Trim();

            //        MessageBox.Show(valueAfterEqualSign);
            //        double parsedValue = Convert.ToDouble(valueAfterEqualSign);
            //        P = parsedValue * A + B;
            //        totalP += P;
            //    }
            //}

            //MessageBox.Show("final" + totalP.ToString());
            //string fileNameWithoutExtension = Nfile.Split('.')[0];
            //if (fileNameWithoutExtension.StartsWith("0"))
            //{
            //    string modifiedFileName = fileNameWithoutExtension.Substring(1);
            //    listBox4.Items.Add(modifiedFileName + " = " + totalP.ToString("F2"));
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double P;
            double A = double.Parse(textBox3.Text);
            double B = double.Parse(textBox4.Text);
            double C = double.Parse(textBox5.Text);
            double D = double.Parse(textBox6.Text);
            double E = double.Parse(textBox7.Text);
            double F = double.Parse(textBox8.Text);
            double G = double.Parse(textBox9.Text);

            int comboBoxCount = comboBox1.Items.Count;
            int currentIndex = 0;

            listBox4.Items.Clear();

            while (currentIndex < comboBoxCount)
            {
                comboBox1.SelectedIndex = currentIndex;

                string Nfile = comboBox1.Text;
                double totalP = 0;

                foreach (var item in listBox2.Items)
                {
                    string itemText = item.ToString();
                    int indexOfEqualSign = itemText.IndexOf("=");

                    if (indexOfEqualSign >= 0)
                    {
                        string valueAfterEqualSign = itemText.Substring(indexOfEqualSign + 1).Trim();
                        double parsedValue = Convert.ToDouble(valueAfterEqualSign);
                        P = parsedValue * A + B;
                        totalP += P;
                    }
                }
                double calculatedValue = totalP + C * nnn + D + E * nnn + lengthValue * F + G;
                string fileNameWithoutExtension = Nfile.Split('.')[0];
                if (fileNameWithoutExtension.StartsWith("0"))
                {
                    string modifiedFileName = fileNameWithoutExtension.Substring(1);
                    listBox4.Items.Add(modifiedFileName + " = " + calculatedValue.ToString("F2") + " [" + nnn + "] ");
                }

                currentIndex++;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string items = string.Join(Environment.NewLine, listBox1.Items.Cast<object>());
            MessageBox.Show(items);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string mathValue = "math";
            string valueToAdd = "";

            foreach (var item in listBox3.Items)
            {
                string itemText = item.ToString();
                int indexOfEqualSign = itemText.IndexOf("=");

                if (indexOfEqualSign >= 0)
                {
                    string leftSide = itemText.Substring(0, indexOfEqualSign).Trim();
                    string rightSide = itemText.Substring(indexOfEqualSign + 1).Trim();

                    if (leftSide.Equals(mathValue))
                    {
                        valueToAdd = rightSide;
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(valueToAdd))
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    string itemText = listBox3.Items[i].ToString();
                    int indexOfEqualSign = itemText.IndexOf("=");

                    if (indexOfEqualSign >= 0)
                    {
                        string leftSide = itemText.Substring(0, indexOfEqualSign).Trim();
                        if (leftSide.Equals(mathValue))
                        {
                            listBox3.Items[i] = itemText + " " + valueToAdd;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ไม่พบค่า 'math' ในรายการ.");
            }
        }
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                textBox2.Text = openFileDialog.FileName;

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                string content = File.ReadAllText(openFileDialog.FileName, Encoding.GetEncoding(932)); //encode JiS

                listBox3.Items.Clear();

                string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None); //save text form file per lines
                foreach (string line in lines)
                {
                    string lineWithoutSpaces = line.Replace(" ", "");
                    listBox3.Items.Add(lineWithoutSpaces); //add line
                }
            }
            button5.Visible = false;
            button8.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in listBox3.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("ไฟล์ CSV ถูกสร้างเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการสร้างไฟล์: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> mapping = new Dictionary<string, string>();

            foreach (string item in listBox4.Items)
            {
                string[] parts = item.Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    if (value.Contains("."))
                    {
                        value = value.Split('.')[0];
                    }

                    mapping[key] = value;
                }
            }

            List<string> updatedItems = new List<string>();

            foreach (string item in listBox3.Items)
            {
                string[] parts = item.Split(',');
                string newItem = item;

                if (parts.Length > 1)
                {
                    string key = parts[1].Trim();

                    if (mapping.ContainsKey(key))
                    {
                        string valueToAdd = mapping[key];

                        if (!newItem.EndsWith("," + valueToAdd))
                        {
                            newItem += "," + valueToAdd;
                        }
                    }
                }

                updatedItems.Add(newItem);
            }

            listBox3.Items.Clear();
            listBox3.Items.AddRange(updatedItems.ToArray());

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fileHistory.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox4.Items.Clear();

            button1.Visible = true;
            button4.Visible = false;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            listBox3.Items.Clear();
            button8.Visible = false;
            button5.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<double> valuesList = new List<double>();
            double sumVar = 0;

            foreach (var item in listBox3.Items)
            {
                string line = item.ToString();
                string[] values = line.Split(',');

                if (values.Length > 6)
                {
                    double selectedValue = Convert.ToDouble(values[6]);
                    valuesList.Add(selectedValue);
                    sumVar += selectedValue;
                }
            }

            MessageBox.Show(sumVar.ToString());

            foreach (var VarCal in valuesList)
            {
                double x_ = VarCal - sumVar;
                MessageBox.Show(x_.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
