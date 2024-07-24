namespace BarcodeSalesProgram
{
    partial class fYedek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fYedek));
            this.tDosya = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bYedekSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tDosya
            // 
            this.tDosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDosya.Location = new System.Drawing.Point(25, 43);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(527, 26);
            this.tDosya.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(21, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Barkodlu Satış Sistemi için en son aldığınız yedeği seçiniz.";
            this.label6.UseWaitCursor = true;
            // 
            // bYukle
            // 
            this.bYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.bYukle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.bYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bYukle.ForeColor = System.Drawing.Color.White;
            this.bYukle.Image = global::BarcodeSalesProgram.Properties.Resources.restore4854;
            this.bYukle.Location = new System.Drawing.Point(224, 85);
            this.bYukle.Name = "bYukle";
            this.bYukle.Padding = new System.Windows.Forms.Padding(3);
            this.bYukle.Size = new System.Drawing.Size(181, 71);
            this.bYukle.TabIndex = 18;
            this.bYukle.Text = "Yükle";
            this.bYukle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bYukle.UseVisualStyleBackColor = false;
            this.bYukle.Click += new System.EventHandler(this.bYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dikkat: Bu işlemi yaptığınızda yükleyeceğiniz\r\nson yedek bilgileri yüklenip eskil" +
    "er silinecektir.";
            // 
            // bYedekSec
            // 
            this.bYedekSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.bYedekSec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.bYedekSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYedekSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bYedekSec.ForeColor = System.Drawing.Color.White;
            this.bYedekSec.Image = global::BarcodeSalesProgram.Properties.Resources.backup4854;
            this.bYedekSec.Location = new System.Drawing.Point(25, 85);
            this.bYedekSec.Name = "bYedekSec";
            this.bYedekSec.Padding = new System.Windows.Forms.Padding(3);
            this.bYedekSec.Size = new System.Drawing.Size(181, 71);
            this.bYedekSec.TabIndex = 20;
            this.bYedekSec.Text = "Yedek Seç";
            this.bYedekSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bYedekSec.UseVisualStyleBackColor = false;
            this.bYedekSec.Click += new System.EventHandler(this.bYedekSec_Click);
            // 
            // fYedek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 221);
            this.Controls.Add(this.tDosya);
            this.Controls.Add(this.bYedekSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bYukle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fYedek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekten Geri Yükleme (Recovery)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bYedekSec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bYukle;
        private System.Windows.Forms.Label label1;
    }
}