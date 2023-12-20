namespace lab2Client
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
            reverseBtn = new Button();
            inputField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            outputLabelWords = new Label();
            outputLabelChars = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // reverseBtn
            // 
            reverseBtn.Location = new Point(675, 102);
            reverseBtn.Margin = new Padding(3, 4, 3, 4);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(116, 27);
            reverseBtn.TabIndex = 0;
            reverseBtn.Text = "Изменить";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // inputField
            // 
            inputField.Location = new Point(62, 102);
            inputField.Margin = new Padding(3, 4, 3, 4);
            inputField.Name = "inputField";
            inputField.Size = new Size(596, 27);
            inputField.TabIndex = 1;
            inputField.Text = "Введите текст ...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(62, 167);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 2;
            label1.Text = "Все буквы прописные:   ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(71, 229);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 3;
            label2.Text = "Все буквы строчные:    ";
            // 
            // outputLabelWords
            // 
            outputLabelWords.AutoSize = true;
            outputLabelWords.BackColor = SystemColors.ControlLightLight;
            outputLabelWords.Location = new Point(246, 167);
            outputLabelWords.Name = "outputLabelWords";
            outputLabelWords.Size = new Size(18, 20);
            outputLabelWords.TabIndex = 4;
            outputLabelWords.Text = "...";
            // 
            // outputLabelChars
            // 
            outputLabelChars.AutoSize = true;
            outputLabelChars.BackColor = SystemColors.ControlLightLight;
            outputLabelChars.Location = new Point(246, 229);
            outputLabelChars.Name = "outputLabelChars";
            outputLabelChars.Size = new Size(18, 20);
            outputLabelChars.TabIndex = 5;
            outputLabelChars.Text = "...";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(682, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(682, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 336);
            Controls.Add(outputLabelChars);
            Controls.Add(outputLabelWords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputField);
            Controls.Add(reverseBtn);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reverseBtn;
        private TextBox inputField;
        private Label label1;
        private Label label2;
        private Label outputLabelWords;
        private Label outputLabelChars;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
