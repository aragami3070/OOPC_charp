namespace WinFormsApp4
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
            x0Input = new TextBox();
            XkInput = new TextBox();
            xdInput = new TextBox();
            bInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Output = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // x0Input
            // 
            x0Input.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            x0Input.Location = new Point(92, 12);
            x0Input.Name = "x0Input";
            x0Input.Size = new Size(325, 31);
            x0Input.TabIndex = 0;
            // 
            // XkInput
            // 
            XkInput.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            XkInput.Location = new Point(92, 48);
            XkInput.Name = "XkInput";
            XkInput.Size = new Size(325, 31);
            XkInput.TabIndex = 1;
            // 
            // xdInput
            // 
            xdInput.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            xdInput.Location = new Point(92, 83);
            xdInput.Name = "xdInput";
            xdInput.Size = new Size(325, 31);
            xdInput.TabIndex = 2;
            // 
            // bInput
            // 
            bInput.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            bInput.Location = new Point(92, 120);
            bInput.Name = "bInput";
            bInput.Size = new Size(325, 31);
            bInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 4;
            label1.Text = "X0 =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 5;
            label2.Text = "Xk =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 6;
            label3.Text = "Dx =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 123);
            label4.Name = "label4";
            label4.Size = new Size(42, 28);
            label4.TabIndex = 7;
            label4.Text = "B =";
            // 
            // Output
            // 
            Output.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Output.Location = new Point(12, 162);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.ScrollBars = ScrollBars.Both;
            Output.Size = new Size(409, 232);
            Output.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(15, 400);
            button1.Name = "button1";
            button1.Size = new Size(189, 82);
            button1.TabIndex = 9;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(240, 400);
            button2.Name = "button2";
            button2.Size = new Size(177, 82);
            button2.TabIndex = 10;
            button2.Text = "Вычислить с меньшим шагом";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 490);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Output);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bInput);
            Controls.Add(xdInput);
            Controls.Add(XkInput);
            Controls.Add(x0Input);
            Name = "Form1";
            Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Егор Ильич";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox x0Input;
        private TextBox XkInput;
        private TextBox xdInput;
        private TextBox bInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Output;
        private Button button1;
        private Button button2;
    }
}