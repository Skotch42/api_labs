namespace GrpcClient
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
            textBox5 = new TextBox();
            reverseBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(360, 27);
            textBox5.TabIndex = 0;
            textBox5.Text = "Введите текст ...";
            // 
            // reverseBtn
            // 
            reverseBtn.Location = new Point(406, 97);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(117, 27);
            reverseBtn.TabIndex = 1;
            reverseBtn.Text = "Изменить";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(595, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(595, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(40, 156);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 6;
            label1.Text = "Все буквы прописные:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(53, 214);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 7;
            label2.Text = "Все буквы строчные:";
            label2.Click += this.label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "...";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(423, 27);
            textBox4.TabIndex = 9;
            textBox4.Text = "...";
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 343);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reverseBtn);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Button reverseBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
