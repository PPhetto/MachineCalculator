namespace MachineCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            listBox2 = new ListBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            calculateToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            button11 = new Button();
            textBox12 = new TextBox();
            label19 = new Label();
            button5 = new Button();
            button10 = new Button();
            dataGridView1 = new DataGridView();
            textBox11 = new TextBox();
            label17 = new Label();
            button9 = new Button();
            button8 = new Button();
            label18 = new Label();
            label15 = new Label();
            label14 = new Label();
            listBox4 = new ListBox();
            button7 = new Button();
            button6 = new Button();
            listBox3 = new ListBox();
            textBox2 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            textBox10 = new TextBox();
            label16 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "File Path";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(61, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(175, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(696, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(61, 184);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(394, 384);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(696, 480);
            button2.Name = "button2";
            button2.Size = new Size(178, 44);
            button2.TabIndex = 7;
            button2.Text = "Calculate by 1";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(696, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "File select";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 159);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 9;
            label3.Text = "File Data Preview";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(687, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(69, 27);
            textBox3.TabIndex = 11;
            textBox3.Text = "1";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(480, 184);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(160, 384);
            listBox2.TabIndex = 14;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(802, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 27);
            textBox4.TabIndex = 15;
            textBox4.Text = "0";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(687, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(68, 27);
            textBox5.TabIndex = 16;
            textBox5.Text = "4";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(803, 230);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(67, 27);
            textBox6.TabIndex = 17;
            textBox6.Text = "0";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(687, 278);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(69, 27);
            textBox7.TabIndex = 18;
            textBox7.Text = "5";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(802, 278);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(68, 27);
            textBox8.TabIndex = 19;
            textBox8.Text = "0";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(687, 328);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(69, 27);
            textBox9.TabIndex = 20;
            textBox9.Text = "2";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(696, 480);
            button3.Name = "button3";
            button3.Size = new Size(178, 44);
            button3.TabIndex = 21;
            button3.Text = "Use Result";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 159);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 23;
            label6.Text = "ロボット動作点データ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 188);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 27;
            label7.Text = "A :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 282);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 28;
            label8.Text = "E :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(775, 189);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 29;
            label9.Text = "B :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(776, 282);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 30;
            label10.Text = "F :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(660, 233);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 31;
            label11.Text = "C :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(660, 332);
            label12.Name = "label12";
            label12.Size = new Size(26, 20);
            label12.TabIndex = 32;
            label12.Text = "G :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(775, 234);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 33;
            label13.Text = "D :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(408, 39);
            label4.Name = "label4";
            label4.Size = new Size(112, 31);
            label4.TabIndex = 34;
            label4.Text = "Calculate";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculateToolStripMenuItem, exportCSVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(926, 28);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculateToolStripMenuItem
            // 
            calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            calculateToolStripMenuItem.Size = new Size(84, 24);
            calculateToolStripMenuItem.Text = "Calculate";
            calculateToolStripMenuItem.Click += calculateToolStripMenuItem_Click;
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.Size = new Size(55, 24);
            exportCSVToolStripMenuItem.Text = "分散";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(listBox4);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 573);
            panel1.TabIndex = 36;
            panel1.Visible = false;
            // 
            // textBox14
            // 
            textBox14.Enabled = false;
            textBox14.Location = new Point(461, 518);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 27);
            textBox14.TabIndex = 23;
            textBox14.Visible = false;
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Location = new Point(149, 518);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 22;
            textBox13.Visible = false;
            // 
            // button11
            // 
            button11.Enabled = false;
            button11.Location = new Point(49, 518);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 21;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Visible = false;
            button11.Click += button11_Click;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(461, 485);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(190, 27);
            textBox12.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(380, 488);
            label19.Name = "label19";
            label19.Size = new Size(84, 20);
            label19.TabIndex = 19;
            label19.Text = "標準偏差 : ";
            // 
            // button5
            // 
            button5.Location = new Point(61, 67);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 1;
            button5.Text = "Browse";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Location = new Point(614, 119);
            button10.Name = "button10";
            button10.Size = new Size(59, 29);
            button10.TabIndex = 18;
            button10.Text = "Table";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(614, 306);
            dataGridView1.TabIndex = 17;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(149, 485);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(190, 27);
            textBox11.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(91, 488);
            label17.Name = "label17";
            label17.Size = new Size(52, 20);
            label17.TabIndex = 15;
            label17.Text = "分散 : ";
            // 
            // button9
            // 
            button9.Location = new Point(784, 72);
            button9.Name = "button9";
            button9.Size = new Size(106, 27);
            button9.TabIndex = 14;
            button9.Text = "Calculate";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(61, 66);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 13;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(175, 46);
            label18.Name = "label18";
            label18.Size = new Size(64, 20);
            label18.TabIndex = 12;
            label18.Text = "File Path";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(712, 126);
            label15.Name = "label15";
            label15.Size = new Size(104, 20);
            label15.TabIndex = 9;
            label15.Text = "Result Preview";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(61, 126);
            label14.Name = "label14";
            label14.Size = new Size(120, 20);
            label14.TabIndex = 8;
            label14.Text = ".CSV File Preview";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.HorizontalScrollbar = true;
            listBox4.Location = new Point(712, 153);
            listBox4.Name = "listBox4";
            listBox4.ScrollAlwaysVisible = true;
            listBox4.Size = new Size(147, 304);
            listBox4.TabIndex = 7;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(721, 477);
            button7.Name = "button7";
            button7.Size = new Size(129, 43);
            button7.TabIndex = 6;
            button7.Text = "Export File";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(661, 71);
            button6.Name = "button6";
            button6.Size = new Size(107, 29);
            button6.TabIndex = 5;
            button6.Text = "Insert to CSV";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.HorizontalScrollbar = true;
            listBox3.Location = new Point(61, 153);
            listBox3.Name = "listBox3";
            listBox3.ScrollAlwaysVisible = true;
            listBox3.Size = new Size(612, 304);
            listBox3.TabIndex = 3;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(175, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(465, 25);
            textBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 2);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 0;
            label5.Text = "分散";
            // 
            // button4
            // 
            button4.Location = new Point(61, 99);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 37;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click_1;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(683, 419);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(203, 27);
            textBox10.TabIndex = 38;
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(683, 396);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 39;
            label16.Text = "Result";
            label16.Click += label16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(926, 605);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(listBox2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox10);
            Controls.Add(label16);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private ListBox listBox2;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button3;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculateToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private Panel panel1;
        private Button button7;
        private Button button6;
        private ListBox listBox3;
        private TextBox textBox2;
        private Button button5;
        private Label label5;
        private ListBox listBox4;
        private Label label15;
        private Label label14;
        private Button button4;
        private TextBox textBox10;
        private Label label16;
        private Label label18;
        private Button button8;
        private Button button9;
        private TextBox textBox11;
        private Label label17;
        private Button button10;
        private DataGridView dataGridView1;
        private TextBox textBox12;
        private Label label19;
        private Button button11;
        private TextBox textBox13;
        private TextBox textBox14;
    }
}
