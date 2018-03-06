namespace CR501A
{
    partial class Form1
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
            this.btOn = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.btBeep = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.btCom = new System.Windows.Forms.Button();
            this.btLedY = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOn
            // 
            this.btOn.Location = new System.Drawing.Point(3, 3);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(75, 23);
            this.btOn.TabIndex = 0;
            this.btOn.Text = "Led red";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // btOff
            // 
            this.btOff.Location = new System.Drawing.Point(165, 3);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(75, 23);
            this.btOff.TabIndex = 1;
            this.btOff.Text = "Led off";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // btBeep
            // 
            this.btBeep.Location = new System.Drawing.Point(246, 3);
            this.btBeep.Name = "btBeep";
            this.btBeep.Size = new System.Drawing.Size(75, 23);
            this.btBeep.TabIndex = 2;
            this.btBeep.Text = "Beep";
            this.btBeep.UseVisualStyleBackColor = true;
            this.btBeep.Click += new System.EventHandler(this.btBeep_Click);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(71, 6);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 3;
            // 
            // btCom
            // 
            this.btCom.Location = new System.Drawing.Point(198, 3);
            this.btCom.Name = "btCom";
            this.btCom.Size = new System.Drawing.Size(75, 23);
            this.btCom.TabIndex = 4;
            this.btCom.Text = "Open";
            this.btCom.UseVisualStyleBackColor = true;
            this.btCom.Click += new System.EventHandler(this.btCom_Click);
            // 
            // btLedY
            // 
            this.btLedY.Location = new System.Drawing.Point(84, 3);
            this.btLedY.Name = "btLedY";
            this.btLedY.Size = new System.Drawing.Size(75, 23);
            this.btLedY.TabIndex = 5;
            this.btLedY.Text = "Led yellow";
            this.btLedY.UseVisualStyleBackColor = true;
            this.btLedY.Click += new System.EventHandler(this.btLedY_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(385, 16);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(54, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(325, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(54, 29);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(325, 20);
            this.tbContent.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Com port";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCom);
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 31);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btRead);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbContent);
            this.panel2.Location = new System.Drawing.Point(12, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 61);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serial";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btOn);
            this.panel3.Controls.Add(this.btLedY);
            this.panel3.Controls.Add(this.btOff);
            this.panel3.Controls.Add(this.btBeep);
            this.panel3.Location = new System.Drawing.Point(12, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 31);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CR501A.Properties.Resources.cropped_combros_logo_512x512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(117, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 83);
            this.panel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "COMBROS TECHNOLOGY CO., LTD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 264);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CR501A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOn;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Button btBeep;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Button btCom;
        private System.Windows.Forms.Button btLedY;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}

