
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.bg = new System.Windows.Forms.Panel();
            this.res = new System.Windows.Forms.Label();
            this.gboll = new System.Windows.Forms.PictureBox();
            this.gplatform = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.looslab = new System.Windows.Forms.Label();
            this.bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gplatform)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.SystemColors.Control;
            this.bg.Controls.Add(this.looslab);
            this.bg.Controls.Add(this.res);
            this.bg.Controls.Add(this.gboll);
            this.bg.Controls.Add(this.gplatform);
            this.bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1255, 707);
            this.bg.TabIndex = 0;
            this.bg.Paint += new System.Windows.Forms.PaintEventHandler(this.bg_Paint);
            // 
            // res
            // 
            this.res.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res.Location = new System.Drawing.Point(1038, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(162, 67);
            this.res.TabIndex = 2;
            this.res.Text = "Score:";
            this.res.Click += new System.EventHandler(this.label1_Click);
            // 
            // gboll
            // 
            this.gboll.BackColor = System.Drawing.Color.DarkMagenta;
            this.gboll.Location = new System.Drawing.Point(188, 149);
            this.gboll.Name = "gboll";
            this.gboll.Size = new System.Drawing.Size(33, 30);
            this.gboll.TabIndex = 1;
            this.gboll.TabStop = false;
            // 
            // gplatform
            // 
            this.gplatform.BackColor = System.Drawing.Color.Navy;
            this.gplatform.Location = new System.Drawing.Point(173, 398);
            this.gplatform.Name = "gplatform";
            this.gplatform.Size = new System.Drawing.Size(228, 24);
            this.gplatform.TabIndex = 0;
            this.gplatform.TabStop = false;
            this.gplatform.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // looslab
            // 
            this.looslab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.looslab.AutoSize = true;
            this.looslab.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.looslab.Location = new System.Drawing.Point(445, 207);
            this.looslab.Name = "looslab";
            this.looslab.Size = new System.Drawing.Size(255, 67);
            this.looslab.TabIndex = 3;
            this.looslab.Text = "You loose!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 707);
            this.Controls.Add(this.bg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.bg.ResumeLayout(false);
            this.bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gplatform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.PictureBox gplatform;
        private System.Windows.Forms.PictureBox gboll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label looslab;
    }
}

