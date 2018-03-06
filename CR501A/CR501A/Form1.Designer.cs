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
            this.SuspendLayout();
            // 
            // btOn
            // 
            this.btOn.Location = new System.Drawing.Point(630, 115);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(75, 23);
            this.btOn.TabIndex = 0;
            this.btOn.Text = "Led red";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // btOff
            // 
            this.btOff.Location = new System.Drawing.Point(630, 173);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(75, 23);
            this.btOff.TabIndex = 1;
            this.btOff.Text = "Led off";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // btBeep
            // 
            this.btBeep.Location = new System.Drawing.Point(630, 202);
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
            this.cbCom.Location = new System.Drawing.Point(12, 12);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 3;
            // 
            // btCom
            // 
            this.btCom.Location = new System.Drawing.Point(139, 10);
            this.btCom.Name = "btCom";
            this.btCom.Size = new System.Drawing.Size(75, 23);
            this.btCom.TabIndex = 4;
            this.btCom.Text = "Open";
            this.btCom.UseVisualStyleBackColor = true;
            this.btCom.Click += new System.EventHandler(this.btCom_Click);
            // 
            // btLedY
            // 
            this.btLedY.Location = new System.Drawing.Point(630, 144);
            this.btLedY.Name = "btLedY";
            this.btLedY.Size = new System.Drawing.Size(75, 23);
            this.btLedY.TabIndex = 5;
            this.btLedY.Text = "Led yellow";
            this.btLedY.UseVisualStyleBackColor = true;
            this.btLedY.Click += new System.EventHandler(this.btLedY_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(549, 156);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "Đọc";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(204, 144);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(325, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(204, 175);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(325, 20);
            this.tbContent.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 451);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btLedY);
            this.Controls.Add(this.btCom);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.btBeep);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.btOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

