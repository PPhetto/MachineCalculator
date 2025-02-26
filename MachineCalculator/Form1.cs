using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
    }
}
