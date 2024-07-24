namespace BarcodeSalesProgram
{
    partial class fHizliButonUrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHizliButonUrunEkle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lButonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chTumu = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.gridHizliButonEkleUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHizliButonEkleUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lButonID);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.chTumu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridHizliButonEkleUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1299, 665);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 1;
            // 
            // lButonID
            // 
            this.lButonID.AutoSize = true;
            this.lButonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lButonID.ForeColor = System.Drawing.Color.DarkCyan;
            this.lButonID.Location = new System.Drawing.Point(136, 70);
            this.lButonID.Name = "lButonID";
            this.lButonID.Size = new System.Drawing.Size(76, 20);
            this.lButonID.TabIndex = 7;
            this.lButonID.Text = "Buton No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buton Numarası: ";
            // 
            // chTumu
            // 
            this.chTumu.AutoSize = true;
            this.chTumu.BackColor = System.Drawing.SystemColors.Control;
            this.chTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chTumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.chTumu.Location = new System.Drawing.Point(372, 35);
            this.chTumu.Name = "chTumu";
            this.chTumu.Size = new System.Drawing.Size(131, 22);
            this.chTumu.TabIndex = 6;
            this.chTumu.Text = "Tümünü Göster";
            this.chTumu.UseVisualStyleBackColor = false;
            this.chTumu.Click += new System.EventHandler(this.chTumu_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Ara";
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUrunAra.Location = new System.Drawing.Point(16, 32);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(350, 26);
            this.tUrunAra.TabIndex = 4;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // gridHizliButonEkleUrunler
            // 
            this.gridHizliButonEkleUrunler.AllowUserToAddRows = false;
            this.gridHizliButonEkleUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHizliButonEkleUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridHizliButonEkleUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHizliButonEkleUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHizliButonEkleUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHizliButonEkleUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHizliButonEkleUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridHizliButonEkleUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHizliButonEkleUrunler.EnableHeadersVisualStyles = false;
            this.gridHizliButonEkleUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridHizliButonEkleUrunler.Name = "gridHizliButonEkleUrunler";
            this.gridHizliButonEkleUrunler.ReadOnly = true;
            this.gridHizliButonEkleUrunler.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.gridHizliButonEkleUrunler.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridHizliButonEkleUrunler.RowTemplate.Height = 32;
            this.gridHizliButonEkleUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHizliButonEkleUrunler.Size = new System.Drawing.Size(1299, 562);
            this.gridHizliButonEkleUrunler.TabIndex = 2;
            this.gridHizliButonEkleUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHizliButonEkleUrunler_CellDoubleClick);
            // 
            // fHizliButonUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 665);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHizliButonUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Butonlara Ürün Ekle";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHizliButonEkleUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lButonID;
        private System.Windows.Forms.CheckBox chTumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tUrunAra;
        private System.Windows.Forms.DataGridView gridHizliButonEkleUrunler;
    }
}