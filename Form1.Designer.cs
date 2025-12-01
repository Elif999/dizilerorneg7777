namespace WinFormsApp47
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "dizi oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "dizi satır sayısı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "dizi sütun sayısı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 96);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 6;
            label3.Text = "Rastgele en düşük sayı";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 138);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 8;
            label4.Text = "rastgele en yüksek sayı";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(263, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(263, 172);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "dizi listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mantık1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(389, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 408);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 402);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private ListBox listBox1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
