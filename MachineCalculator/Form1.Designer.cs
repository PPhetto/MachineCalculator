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
            label4 = new Label();
            label5 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "File Path";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(61, 54);
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
            textBox1.Location = new Point(175, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(696, 56);
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
            label2.Location = new Point(696, 33);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "File History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 121);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 9;
            label3.Text = "File Data Preview";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(480, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(480, 214);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "A";
            textBox3.Size = new Size(91, 27);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 121);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 12;
            label4.Text = "Robot operation point";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 191);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 13;
            label5.Text = "Parameter";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(480, 325);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(379, 144);
            listBox2.TabIndex = 14;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(577, 214);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "B";
            textBox4.Size = new Size(90, 27);
            textBox4.TabIndex = 15;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(673, 214);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "C";
            textBox5.Size = new Size(90, 27);
            textBox5.TabIndex = 16;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(769, 214);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "D";
            textBox6.Size = new Size(90, 27);
            textBox6.TabIndex = 17;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(480, 256);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "E";
            textBox7.Size = new Size(91, 27);
            textBox7.TabIndex = 18;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(577, 256);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "F";
            textBox8.Size = new Size(90, 27);
            textBox8.TabIndex = 19;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(673, 258);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "G";
            textBox9.Size = new Size(90, 27);
            textBox9.TabIndex = 20;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(769, 256);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 21;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 302);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 23;
            label6.Text = "Result Preview";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 567);
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
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label5;
        private Label label4;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}
