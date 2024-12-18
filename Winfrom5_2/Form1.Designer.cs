namespace Winfrom5
{
    partial class Winform5_2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyR = new System.Windows.Forms.Button();
            this.onlyG = new System.Windows.Forms.Button();
            this.onlyB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(13, 540);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(131, 45);
            this.loadFileBtn.TabIndex = 1;
            this.loadFileBtn.Text = "Загрузить файл";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(599, 540);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(131, 45);
            this.saveFileBtn.TabIndex = 2;
            this.saveFileBtn.Text = "Сохранить файл";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 513);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 513);
            this.panel1.TabIndex = 4;
            // 
            // onlyR
            // 
            this.onlyR.Location = new System.Drawing.Point(257, 540);
            this.onlyR.Name = "onlyR";
            this.onlyR.Size = new System.Drawing.Size(68, 44);
            this.onlyR.TabIndex = 5;
            this.onlyR.Text = "R";
            this.onlyR.UseVisualStyleBackColor = true;
            this.onlyR.Click += new System.EventHandler(this.onlyR_Click);
            // 
            // onlyG
            // 
            this.onlyG.Location = new System.Drawing.Point(331, 540);
            this.onlyG.Name = "onlyG";
            this.onlyG.Size = new System.Drawing.Size(68, 44);
            this.onlyG.TabIndex = 6;
            this.onlyG.Text = "G";
            this.onlyG.UseVisualStyleBackColor = true;
            this.onlyG.Click += new System.EventHandler(this.onlyG_Click);
            // 
            // onlyB
            // 
            this.onlyB.Location = new System.Drawing.Point(405, 540);
            this.onlyB.Name = "onlyB";
            this.onlyB.Size = new System.Drawing.Size(68, 44);
            this.onlyB.TabIndex = 7;
            this.onlyB.Text = "B";
            this.onlyB.UseVisualStyleBackColor = true;
            this.onlyB.Click += new System.EventHandler(this.onlyB_Click);
            // 
            // Winform5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 597);
            this.Controls.Add(this.onlyB);
            this.Controls.Add(this.onlyG);
            this.Controls.Add(this.onlyR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.loadFileBtn);
            this.Name = "Winform5_2";
            this.Text = "Winform5_2";
            this.Load += new System.EventHandler(this.Winform5_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button onlyR;
        private System.Windows.Forms.Button onlyG;
        private System.Windows.Forms.Button onlyB;
    }
}

