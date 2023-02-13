namespace GepteremProjekt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mentes = new System.Windows.Forms.PictureBox();
            this.bal = new System.Windows.Forms.PictureBox();
            this.jobb = new System.Windows.Forms.PictureBox();
            this.kep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(275, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 253);
            this.panel1.TabIndex = 0;
            // 
            // mentes
            // 
            this.mentes.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mentes.Location = new System.Drawing.Point(104, 236);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(55, 50);
            this.mentes.TabIndex = 4;
            this.mentes.TabStop = false;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // bal
            // 
            this.bal.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.bal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bal.Location = new System.Drawing.Point(12, 111);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(62, 50);
            this.bal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bal.TabIndex = 3;
            this.bal.TabStop = false;
            this.bal.Click += new System.EventHandler(this.bal_Click);
            // 
            // jobb
            // 
            this.jobb.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.jobb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jobb.ImageLocation = "";
            this.jobb.InitialImage = null;
            this.jobb.Location = new System.Drawing.Point(189, 111);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(62, 50);
            this.jobb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jobb.TabIndex = 2;
            this.jobb.TabStop = false;
            this.jobb.Click += new System.EventHandler(this.jobb_Click);
            // 
            // kep
            // 
            this.kep.Location = new System.Drawing.Point(83, 75);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(100, 132);
            this.kep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kep.TabIndex = 1;
            this.kep.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.jobb);
            this.Controls.Add(this.kep);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.PictureBox jobb;
        private System.Windows.Forms.PictureBox bal;
        private System.Windows.Forms.PictureBox mentes;
    }
}

