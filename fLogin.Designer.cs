namespace BarcodeSalesProgram
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.tKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tKullaniciAdi
            // 
            resources.ApplyResources(this.tKullaniciAdi, "tKullaniciAdi");
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Name = "label6";
            // 
            // tSifre
            // 
            resources.ApplyResources(this.tSifre, "tSifre");
            this.tSifre.Name = "tSifre";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Name = "label2";
            // 
            // bGiris
            // 
            this.bGiris.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bGiris.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.bGiris, "bGiris");
            this.bGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bGiris.Image = global::BarcodeSalesProgram.Properties.Resources.enter__1_;
            this.bGiris.Name = "bGiris";
            this.bGiris.UseVisualStyleBackColor = false;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // fLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.tKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.KeyPreview = true;
            this.Name = "fLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGiris;
        private System.Windows.Forms.TextBox tKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tSifre;
        private System.Windows.Forms.Label label2;
    }
}