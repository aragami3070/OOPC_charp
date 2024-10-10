namespace WinFormsApp3
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
            groupBox1 = new GroupBox();
            check3 = new RadioButton();
            check2 = new RadioButton();
            check1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            output = new TextBox();
            startBtn = new Button();
            clearBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(check3);
            groupBox1.Controls.Add(check2);
            groupBox1.Controls.Add(check1);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(281, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(107, 122);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "f(x)";
            // 
            // check3
            // 
            check3.AutoSize = true;
            check3.Location = new Point(16, 73);
            check3.Name = "check3";
            check3.Size = new Size(63, 32);
            check3.TabIndex = 2;
            check3.TabStop = true;
            check3.Text = "e^x";
            check3.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            check2.AutoSize = true;
            check2.Location = new Point(16, 48);
            check2.Name = "check2";
            check2.Size = new Size(64, 32);
            check2.TabIndex = 1;
            check2.TabStop = true;
            check2.Text = "x^2";
            check2.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.Checked = true;
            check1.Location = new Point(17, 23);
            check1.Name = "check1";
            check1.Size = new Size(76, 32);
            check1.TabIndex = 0;
            check1.TabStop = true;
            check1.Text = "sh(x)";
            check1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 28);
            label1.TabIndex = 1;
            label1.Text = "X =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 2;
            label2.Text = "P =";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(82, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(82, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 31);
            textBox2.TabIndex = 5;
            // 
            // output
            // 
            output.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(12, 137);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Both;
            output.Size = new Size(376, 219);
            output.TabIndex = 7;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            startBtn.Location = new Point(12, 380);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(149, 49);
            startBtn.TabIndex = 8;
            startBtn.Text = "Вычислить";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(240, 380);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(148, 49);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Очистить";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(clearBtn);
            Controls.Add(startBtn);
            Controls.Add(output);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Лаб. раб. N1. Ст. гр. 251 Смирнов Егор Ильич";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton check3;
        private RadioButton check2;
        private RadioButton check1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox output;
        private Button startBtn;
        private Button clearBtn;
    }
}