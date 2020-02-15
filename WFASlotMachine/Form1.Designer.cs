namespace WFASlotMachine
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
            this.btnKoluCek = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbResim3 = new System.Windows.Forms.PictureBox();
            this.pbResim2 = new System.Windows.Forms.PictureBox();
            this.pbResim1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKoluCek
            // 
            this.btnKoluCek.Enabled = false;
            this.btnKoluCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoluCek.Location = new System.Drawing.Point(622, 40);
            this.btnKoluCek.Name = "btnKoluCek";
            this.btnKoluCek.Size = new System.Drawing.Size(150, 150);
            this.btnKoluCek.TabIndex = 1;
            this.btnKoluCek.Text = "Kolu Çek";
            this.btnKoluCek.UseVisualStyleBackColor = true;
            this.btnKoluCek.Click += new System.EventHandler(this.btnKoluCek_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jeton Yatırma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Bir Jetonla Çalışır.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Jeton yatır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbResim3
            // 
            this.pbResim3.Location = new System.Drawing.Point(431, 40);
            this.pbResim3.Name = "pbResim3";
            this.pbResim3.Size = new System.Drawing.Size(150, 150);
            this.pbResim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim3.TabIndex = 0;
            this.pbResim3.TabStop = false;
            // 
            // pbResim2
            // 
            this.pbResim2.Location = new System.Drawing.Point(225, 40);
            this.pbResim2.Name = "pbResim2";
            this.pbResim2.Size = new System.Drawing.Size(150, 150);
            this.pbResim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim2.TabIndex = 0;
            this.pbResim2.TabStop = false;
            // 
            // pbResim1
            // 
            this.pbResim1.Location = new System.Drawing.Point(22, 40);
            this.pbResim1.Name = "pbResim1";
            this.pbResim1.Size = new System.Drawing.Size(150, 150);
            this.pbResim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim1.TabIndex = 0;
            this.pbResim1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKoluCek);
            this.Controls.Add(this.pbResim3);
            this.Controls.Add(this.pbResim2);
            this.Controls.Add(this.pbResim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim1;
        private System.Windows.Forms.PictureBox pbResim2;
        private System.Windows.Forms.PictureBox pbResim3;
        private System.Windows.Forms.Button btnKoluCek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

