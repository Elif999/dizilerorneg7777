namespace WinFormsApp47
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 19);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 7;
            label3.Text = "öğrenci sayısını belirleyin :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "ortalama";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 45);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "isim";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(174, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 244);
            listBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(310, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 297);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(42, 197);
            button6.Name = "button6";
            button6.Size = new Size(97, 23);
            button6.TabIndex = 8;
            button6.Text = "taktir listesi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(42, 157);
            button5.Name = "button5";
            button5.Size = new Size(97, 23);
            button5.TabIndex = 7;
            button5.Text = "teşekkür listesi";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 118);
            button4.Name = "button4";
            button4.Size = new Size(97, 23);
            button4.TabIndex = 6;
            button4.Text = "geçen listesi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 78);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 5;
            button3.Text = "kalan listesi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 35);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 4;
            button2.Text = "tümünü listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
           // Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}