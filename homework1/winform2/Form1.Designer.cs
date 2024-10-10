namespace WinFormsApp2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Output = new TextBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 0;
            label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 77);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 1;
            label2.Text = "Введите значение Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 118);
            label3.Name = "label3";
            label3.Size = new Size(203, 28);
            label3.TabIndex = 2;
            label3.Text = "Введите значение Z:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 175);
            label4.Name = "label4";
            label4.Size = new Size(345, 28);
            label4.TabIndex = 6;
            label4.Text = "Результат выполнения программы:";
            // 
            // Output
            // 
            Output.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Output.Location = new Point(34, 206);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.ScrollBars = ScrollBars.Both;
            Output.Size = new Size(422, 180);
            Output.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(354, 392);
            button1.Name = "button1";
            button1.Size = new Size(167, 47);
            button1.TabIndex = 8;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(244, 34);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(212, 31);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(244, 77);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(212, 31);
            maskedTextBox2.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(244, 118);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(212, 31);
            maskedTextBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(Output);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(549, 489);
            MinimumSize = new Size(549, 489);
            Name = "Form1";
            Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Егор Ильич";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Output;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
    }
}