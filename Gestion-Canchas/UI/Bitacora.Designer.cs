namespace UI
{
    partial class Bitacora
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
            this.chkDesde = new System.Windows.Forms.CheckBox();
            this.chkHasta = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDesde
            // 
            this.chkDesde.AutoSize = true;
            this.chkDesde.Location = new System.Drawing.Point(12, 149);
            this.chkDesde.Name = "chkDesde";
            this.chkDesde.Size = new System.Drawing.Size(112, 20);
            this.chkDesde.TabIndex = 11;
            this.chkDesde.Tag = "chkDesde";
            this.chkDesde.Text = "Fecha desde:";
            this.chkDesde.UseVisualStyleBackColor = true;
            this.chkDesde.CheckedChanged += new System.EventHandler(this.chkDesde_CheckedChanged);
            // 
            // chkHasta
            // 
            this.chkHasta.AutoSize = true;
            this.chkHasta.Location = new System.Drawing.Point(12, 191);
            this.chkHasta.Name = "chkHasta";
            this.chkHasta.Size = new System.Drawing.Size(106, 20);
            this.chkHasta.TabIndex = 12;
            this.chkHasta.Tag = "chkHasta";
            this.chkHasta.Text = "Fecha hasta:";
            this.chkHasta.UseVisualStyleBackColor = true;
            this.chkHasta.CheckedChanged += new System.EventHandler(this.chkHasta_CheckedChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(163, 149);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(285, 22);
            this.dtpDesde.TabIndex = 13;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(163, 191);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(285, 22);
            this.dtpHasta.TabIndex = 14;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(163, 247);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(109, 49);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Tag = "btnFiltrar";
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1075, 519);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 28);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Tag = "btnVolver";
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 426);
            this.dataGridView1.TabIndex = 17;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.chkHasta);
            this.Controls.Add(this.chkDesde);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDesde;
        private System.Windows.Forms.CheckBox chkHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}