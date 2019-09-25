namespace slideshow1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureB1 = new System.Windows.Forms.PictureBox();
            this.pictureB2 = new System.Windows.Forms.PictureBox();
            this.pictureB3 = new System.Windows.Forms.PictureBox();
            this.pictureB4 = new System.Windows.Forms.PictureBox();
            this.pictureB5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 324);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 318);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureB5);
            this.panel2.Controls.Add(this.pictureB4);
            this.panel2.Controls.Add(this.pictureB3);
            this.panel2.Controls.Add(this.pictureB2);
            this.panel2.Controls.Add(this.pictureB1);
            this.panel2.Location = new System.Drawing.Point(12, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureB1
            // 
            this.pictureB1.Location = new System.Drawing.Point(26, 5);
            this.pictureB1.Name = "pictureB1";
            this.pictureB1.Size = new System.Drawing.Size(129, 92);
            this.pictureB1.TabIndex = 0;
            this.pictureB1.TabStop = false;
            // 
            // pictureB2
            // 
            this.pictureB2.Location = new System.Drawing.Point(170, 5);
            this.pictureB2.Name = "pictureB2";
            this.pictureB2.Size = new System.Drawing.Size(129, 92);
            this.pictureB2.TabIndex = 1;
            this.pictureB2.TabStop = false;
            // 
            // pictureB3
            // 
            this.pictureB3.Location = new System.Drawing.Point(317, 6);
            this.pictureB3.Name = "pictureB3";
            this.pictureB3.Size = new System.Drawing.Size(129, 92);
            this.pictureB3.TabIndex = 2;
            this.pictureB3.TabStop = false;
            // 
            // pictureB4
            // 
            this.pictureB4.Location = new System.Drawing.Point(461, 6);
            this.pictureB4.Name = "pictureB4";
            this.pictureB4.Size = new System.Drawing.Size(129, 92);
            this.pictureB4.TabIndex = 3;
            this.pictureB4.TabStop = false;
            // 
            // pictureB5
            // 
            this.pictureB5.Location = new System.Drawing.Point(607, 5);
            this.pictureB5.Name = "pictureB5";
            this.pictureB5.Size = new System.Drawing.Size(129, 92);
            this.pictureB5.TabIndex = 4;
            this.pictureB5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureB5;
        private System.Windows.Forms.PictureBox pictureB4;
        private System.Windows.Forms.PictureBox pictureB3;
        private System.Windows.Forms.PictureBox pictureB2;
        private System.Windows.Forms.PictureBox pictureB1;
    }
}

