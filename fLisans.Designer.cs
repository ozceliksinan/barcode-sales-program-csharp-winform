namespace BarcodeSalesProgram
{
    partial class fLisans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLisans));
            this.bTamam = new System.Windows.Forms.Button();
            this.tLisansNo = new System.Windows.Forms.TextBox();
            this.lKontrolNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTamam
            // 
            this.bTamam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bTamam.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.bTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bTamam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bTamam.Image = global::BarcodeSalesProgram.Properties.Resources.enter__1_;
            this.bTamam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bTamam.Location = new System.Drawing.Point(29, 119);
            this.bTamam.Margin = new System.Windows.Forms.Padding(1);
            this.bTamam.Name = "bTamam";
            this.bTamam.Size = new System.Drawing.Size(116, 58);
            this.bTamam.TabIndex = 19;
            this.bTamam.Text = "Tamam";
            this.bTamam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bTamam.UseVisualStyleBackColor = false;
            this.bTamam.Click += new System.EventHandler(this.bTamam_Click);
            // 
            // tLisansNo
            // 
            this.tLisansNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tLisansNo.Location = new System.Drawing.Point(29, 79);
            this.tLisansNo.Name = "tLisansNo";
            this.tLisansNo.Size = new System.Drawing.Size(202, 26);
            this.tLisansNo.TabIndex = 18;
            // 
            // lKontrolNo
            // 
            this.lKontrolNo.AutoSize = true;
            this.lKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKontrolNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKontrolNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lKontrolNo.Location = new System.Drawing.Point(25, 56);
            this.lKontrolNo.Name = "lKontrolNo";
            this.lKontrolNo.Size = new System.Drawing.Size(83, 20);
            this.lKontrolNo.TabIndex = 21;
            this.lKontrolNo.Text = "Kontrol No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "LİSANS İŞLEMLERİ";
            // 
            // fLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 200);
            this.Controls.Add(this.bTamam);
            this.Controls.Add(this.tLisansNo);
            this.Controls.Add(this.lKontrolNo);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans İşlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTamam;
        private System.Windows.Forms.TextBox tLisansNo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lKontrolNo;
    }
}