namespace UI
{
    partial class Auditoria
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvUsuarioHistorial = new System.Windows.Forms.DataGridView();
            this.btnEstadoAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(54, 21);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(706, 231);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // dgvUsuarioHistorial
            // 
            this.dgvUsuarioHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioHistorial.Location = new System.Drawing.Point(52, 36);
            this.dgvUsuarioHistorial.Name = "dgvUsuarioHistorial";
            this.dgvUsuarioHistorial.RowHeadersWidth = 51;
            this.dgvUsuarioHistorial.RowTemplate.Height = 24;
            this.dgvUsuarioHistorial.Size = new System.Drawing.Size(706, 293);
            this.dgvUsuarioHistorial.TabIndex = 6;
            // 
            // btnEstadoAnterior
            // 
            this.btnEstadoAnterior.Location = new System.Drawing.Point(74, 239);
            this.btnEstadoAnterior.Name = "btnEstadoAnterior";
            this.btnEstadoAnterior.Size = new System.Drawing.Size(257, 69);
            this.btnEstadoAnterior.TabIndex = 8;
            this.btnEstadoAnterior.Tag = "btnVolverEstado";
            this.btnEstadoAnterior.Text = "Volver a estado anterior";
            this.btnEstadoAnterior.UseVisualStyleBackColor = true;
            this.btnEstadoAnterior.Click += new System.EventHandler(this.btnEstadoAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(388, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 296);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios del sistema";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUsuarioHistorial);
            this.groupBox2.Location = new System.Drawing.Point(388, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 355);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de cambios";
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEstadoAnterior);
            this.Name = "Auditoria";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarioHistorial;
        private System.Windows.Forms.Button btnEstadoAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}