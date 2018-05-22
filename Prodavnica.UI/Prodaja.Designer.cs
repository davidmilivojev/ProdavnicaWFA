namespace Prodavnica.UI
{
    partial class Prodaja
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodajPiceBtn = new System.Windows.Forms.Button();
            this.kolicinaLbl = new System.Windows.Forms.Label();
            this.listaPicaLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.prodajaCbx = new System.Windows.Forms.ComboBox();
            this.prodajaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // prodajPiceBtn
            // 
            this.prodajPiceBtn.Location = new System.Drawing.Point(577, 92);
            this.prodajPiceBtn.Name = "prodajPiceBtn";
            this.prodajPiceBtn.Size = new System.Drawing.Size(75, 23);
            this.prodajPiceBtn.TabIndex = 12;
            this.prodajPiceBtn.Text = "Dodaj";
            this.prodajPiceBtn.UseVisualStyleBackColor = true;
            this.prodajPiceBtn.Click += new System.EventHandler(this.prodajPiceBtn_Click);
            // 
            // kolicinaLbl
            // 
            this.kolicinaLbl.AutoSize = true;
            this.kolicinaLbl.Location = new System.Drawing.Point(364, 69);
            this.kolicinaLbl.Name = "kolicinaLbl";
            this.kolicinaLbl.Size = new System.Drawing.Size(57, 17);
            this.kolicinaLbl.TabIndex = 11;
            this.kolicinaLbl.Text = "Kolicina";
            // 
            // listaPicaLbl
            // 
            this.listaPicaLbl.AutoSize = true;
            this.listaPicaLbl.Location = new System.Drawing.Point(90, 69);
            this.listaPicaLbl.Name = "listaPicaLbl";
            this.listaPicaLbl.Size = new System.Drawing.Size(35, 17);
            this.listaPicaLbl.TabIndex = 10;
            this.listaPicaLbl.Text = "Pica";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(367, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // prodajaCbx
            // 
            this.prodajaCbx.FormattingEnabled = true;
            this.prodajaCbx.Location = new System.Drawing.Point(90, 92);
            this.prodajaCbx.Name = "prodajaCbx";
            this.prodajaCbx.Size = new System.Drawing.Size(202, 24);
            this.prodajaCbx.TabIndex = 8;
            // 
            // prodajaBtn
            // 
            this.prodajaBtn.Location = new System.Drawing.Point(577, 387);
            this.prodajaBtn.Name = "prodajaBtn";
            this.prodajaBtn.Size = new System.Drawing.Size(133, 32);
            this.prodajaBtn.TabIndex = 14;
            this.prodajaBtn.Text = "Prodaj";
            this.prodajaBtn.UseVisualStyleBackColor = true;
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodajaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prodajPiceBtn);
            this.Controls.Add(this.kolicinaLbl);
            this.Controls.Add(this.listaPicaLbl);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.prodajaCbx);
            this.Name = "Prodaja";
            this.Text = "Prodaja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button prodajPiceBtn;
        private System.Windows.Forms.Label kolicinaLbl;
        private System.Windows.Forms.Label listaPicaLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox prodajaCbx;
        private System.Windows.Forms.Button prodajaBtn;
    }
}