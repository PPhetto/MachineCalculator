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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox2 = new ListBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            button5 = new Button();
            textBox10 = new TextBox();
            listBox3 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "File Path";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(61, 59);
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
            textBox1.Location = new Point(175, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(696, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(61, 144);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(394, 384);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(480, 484);
            button2.Name = "button2";
            button2.Size = new Size(187, 44);
            button2.TabIndex = 7;
            button2.Text = "Calculator";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(696, 38);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "File History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 119);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 9;
            label3.Text = "File Data Preview";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(502, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 27);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(502, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(69, 27);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(480, 303);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(379, 164);
            listBox2.TabIndex = 14;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(599, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 27);
            textBox4.TabIndex = 15;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(695, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(68, 27);
            textBox5.TabIndex = 16;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(792, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(67, 27);
            textBox6.TabIndex = 17;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(502, 229);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(69, 27);
            textBox7.TabIndex = 18;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(599, 229);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(68, 27);
            textBox8.TabIndex = 19;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(696, 231);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(67, 27);
            textBox9.TabIndex = 20;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(778, 230);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 21;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(679, 484);
            button4.Name = "button4";
            button4.Size = new Size(180, 44);
            button4.TabIndex = 22;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 273);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 23;
            label6.Text = "Result Preview";
            // 
            // button5
            // 
            button5.Location = new Point(346, 115);
            button5.Name = "button5";
            button5.Size = new Size(109, 29);
            button5.TabIndex = 24;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(696, 144);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(163, 27);
            textBox10.TabIndex = 25;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(98, 229);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(285, 204);
            listBox3.TabIndex = 26;
            listBox3.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 191);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 27;
            label7.Text = "A :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(476, 233);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 28;
            label8.Text = "E :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(572, 191);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 29;
            label9.Text = "B :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(573, 233);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 30;
            label10.Text = "F :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(668, 191);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 31;
            label11.Text = "C :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(669, 235);
            label12.Name = "label12";
            label12.Size = new Size(26, 20);
            label12.TabIndex = 32;
            label12.Text = "G :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(763, 191);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 33;
            label13.Text = "D :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(668, 148);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 34;
            label14.Text = "P2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(474, 151);
            label15.Name = "label15";
            label15.Size = new Size(25, 20);
            label15.TabIndex = 35;
            label15.Text = "P1";
            // 
            // button6
            // 
            button6.Location = new Point(246, 115);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 38;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 567);
            Controls.Add(button6);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox3);
            Controls.Add(textBox10);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(listBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider1;
        private ListBox listBox1;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox2;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Label label6;
        private TextBox textBox10;
        private Button button5;
        private ListBox listBox3;
        private Label label8;
        private Label label7;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button6;
    }
}
