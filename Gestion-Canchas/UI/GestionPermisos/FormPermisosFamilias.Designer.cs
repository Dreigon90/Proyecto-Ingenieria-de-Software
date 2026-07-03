namespace UI.GestionPermisos
{
    partial class FormPermisosFamilias
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
            this.grpFamlias = new System.Windows.Forms.GroupBox();
            this.btnGuardarFamilia = new System.Windows.Forms.Button();
            this.treeConfigFamilia = new System.Windows.Forms.TreeView();
            this.grpFamilias = new System.Windows.Forms.GroupBox();
            this.btnConfigurarFamilia = new System.Windows.Forms.Button();
            this.grpNuevaFamilia = new System.Windows.Forms.GroupBox();
            this.btnGuardarSimple = new System.Windows.Forms.Button();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.grpNuevoPermiso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.btnGuardarPatente = new System.Windows.Forms.Button();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpFamlias.SuspendLayout();
            this.grpFamilias.SuspendLayout();
            this.grpNuevaFamilia.SuspendLayout();
            this.grpPatentes.SuspendLayout();
            this.grpNuevoPermiso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFamlias
            // 
            this.grpFamlias.Controls.Add(this.btnGuardarFamilia);
            this.grpFamlias.Controls.Add(this.treeConfigFamilia);
            this.grpFamlias.Location = new System.Drawing.Point(784, 55);
            this.grpFamlias.Margin = new System.Windows.Forms.Padding(4);
            this.grpFamlias.Name = "grpFamlias";
            this.grpFamlias.Padding = new System.Windows.Forms.Padding(4);
            this.grpFamlias.Size = new System.Drawing.Size(360, 421);
            this.grpFamlias.TabIndex = 11;
            this.grpFamlias.TabStop = false;
            this.grpFamlias.Tag = "ConfigurarFamlias";
            this.grpFamlias.Text = "Configurar Familias";
            // 
            // btnGuardarFamilia
            // 
            this.btnGuardarFamilia.Location = new System.Drawing.Point(8, 382);
            this.btnGuardarFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarFamilia.Name = "btnGuardarFamilia";
            this.btnGuardarFamilia.Size = new System.Drawing.Size(172, 27);
            this.btnGuardarFamilia.TabIndex = 1;
            this.btnGuardarFamilia.Tag = "GuardarFamilia";
            this.btnGuardarFamilia.Text = "Guardar Familia";
            this.btnGuardarFamilia.UseVisualStyleBackColor = true;
            this.btnGuardarFamilia.Click += new System.EventHandler(this.btnGuardarFamilia_Click);
            // 
            // treeConfigFamilia
            // 
            this.treeConfigFamilia.Location = new System.Drawing.Point(8, 23);
            this.treeConfigFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.treeConfigFamilia.Name = "treeConfigFamilia";
            this.treeConfigFamilia.Size = new System.Drawing.Size(343, 351);
            this.treeConfigFamilia.TabIndex = 0;
            // 
            // grpFamilias
            // 
            this.grpFamilias.Controls.Add(this.btnConfigurarFamilia);
            this.grpFamilias.Controls.Add(this.grpNuevaFamilia);
            this.grpFamilias.Controls.Add(this.btnAgregarFamilia);
            this.grpFamilias.Controls.Add(this.cboFamilias);
            this.grpFamilias.Controls.Add(this.label4);
            this.grpFamilias.Location = new System.Drawing.Point(392, 55);
            this.grpFamilias.Margin = new System.Windows.Forms.Padding(4);
            this.grpFamilias.Name = "grpFamilias";
            this.grpFamilias.Padding = new System.Windows.Forms.Padding(4);
            this.grpFamilias.Size = new System.Drawing.Size(361, 374);
            this.grpFamilias.TabIndex = 10;
            this.grpFamilias.TabStop = false;
            this.grpFamilias.Tag = "Roles";
            this.grpFamilias.Text = "Roles";
            // 
            // btnConfigurarFamilia
            // 
            this.btnConfigurarFamilia.Location = new System.Drawing.Point(12, 82);
            this.btnConfigurarFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigurarFamilia.Name = "btnConfigurarFamilia";
            this.btnConfigurarFamilia.Size = new System.Drawing.Size(155, 28);
            this.btnConfigurarFamilia.TabIndex = 4;
            this.btnConfigurarFamilia.Tag = "ConfigurarFamilia";
            this.btnConfigurarFamilia.Text = "Configurar Familia";
            this.btnConfigurarFamilia.UseVisualStyleBackColor = true;
            this.btnConfigurarFamilia.Click += new System.EventHandler(this.btnConfigurarFamilia_Click);
            // 
            // grpNuevaFamilia
            // 
            this.grpNuevaFamilia.Controls.Add(this.btnGuardarSimple);
            this.grpNuevaFamilia.Controls.Add(this.txtNombreFamilia);
            this.grpNuevaFamilia.Controls.Add(this.label5);
            this.grpNuevaFamilia.Location = new System.Drawing.Point(12, 144);
            this.grpNuevaFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.grpNuevaFamilia.Name = "grpNuevaFamilia";
            this.grpNuevaFamilia.Padding = new System.Windows.Forms.Padding(4);
            this.grpNuevaFamilia.Size = new System.Drawing.Size(281, 196);
            this.grpNuevaFamilia.TabIndex = 3;
            this.grpNuevaFamilia.TabStop = false;
            this.grpNuevaFamilia.Tag = "NuevaFamilia";
            this.grpNuevaFamilia.Text = "Nueva Familia";
            // 
            // btnGuardarSimple
            // 
            this.btnGuardarSimple.Location = new System.Drawing.Point(12, 87);
            this.btnGuardarSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarSimple.Name = "btnGuardarSimple";
            this.btnGuardarSimple.Size = new System.Drawing.Size(143, 28);
            this.btnGuardarSimple.TabIndex = 1;
            this.btnGuardarSimple.Tag = "Guardar";
            this.btnGuardarSimple.Text = "Guardar Simple";
            this.btnGuardarSimple.UseVisualStyleBackColor = true;
            this.btnGuardarSimple.Click += new System.EventHandler(this.btnGuardarSimple_Click);
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(8, 50);
            this.txtNombreFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(252, 22);
            this.txtNombreFamilia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Tag = "Nombre";
            this.label5.Text = "Nombre:";
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(175, 82);
            this.btnAgregarFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(159, 28);
            this.btnAgregarFamilia.TabIndex = 2;
            this.btnAgregarFamilia.Tag = "AgregarFamilia";
            this.btnAgregarFamilia.Text = "Agregar Familia >> ";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(12, 50);
            this.cboFamilias.Margin = new System.Windows.Forms.Padding(4);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(322, 24);
            this.cboFamilias.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Tag = "TodosLosRoles";
            this.label4.Text = "Todas los roles:";
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.grpNuevoPermiso);
            this.grpPatentes.Controls.Add(this.btnAgregarPatente);
            this.grpPatentes.Controls.Add(this.cboPatentes);
            this.grpPatentes.Controls.Add(this.label2);
            this.grpPatentes.Location = new System.Drawing.Point(56, 55);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(4);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(4);
            this.grpPatentes.Size = new System.Drawing.Size(315, 374);
            this.grpPatentes.TabIndex = 9;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Tag = "Patentes";
            this.grpPatentes.Text = "Patentes";
            // 
            // grpNuevoPermiso
            // 
            this.grpNuevoPermiso.Controls.Add(this.label1);
            this.grpNuevoPermiso.Controls.Add(this.cboPermisos);
            this.grpNuevoPermiso.Controls.Add(this.btnGuardarPatente);
            this.grpNuevoPermiso.Controls.Add(this.txtNombrePatente);
            this.grpNuevoPermiso.Controls.Add(this.label3);
            this.grpNuevoPermiso.Location = new System.Drawing.Point(12, 144);
            this.grpNuevoPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.grpNuevoPermiso.Name = "grpNuevoPermiso";
            this.grpNuevoPermiso.Padding = new System.Windows.Forms.Padding(4);
            this.grpNuevoPermiso.Size = new System.Drawing.Size(281, 222);
            this.grpNuevoPermiso.TabIndex = 3;
            this.grpNuevoPermiso.TabStop = false;
            this.grpNuevoPermiso.Tag = "NuevaAccion";
            this.grpNuevoPermiso.Text = "Nueva accion";
            this.grpNuevoPermiso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Permiso";
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(13, 51);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(190, 24);
            this.cboPermisos.TabIndex = 9;
            // 
            // btnGuardarPatente
            // 
            this.btnGuardarPatente.Location = new System.Drawing.Point(12, 161);
            this.btnGuardarPatente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPatente.Name = "btnGuardarPatente";
            this.btnGuardarPatente.Size = new System.Drawing.Size(164, 28);
            this.btnGuardarPatente.TabIndex = 1;
            this.btnGuardarPatente.Tag = "GuardarPatente";
            this.btnGuardarPatente.Text = "Guardar Patente";
            this.btnGuardarPatente.UseVisualStyleBackColor = true;
            this.btnGuardarPatente.Click += new System.EventHandler(this.btnGuardarPatente_Click);
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(8, 124);
            this.txtNombrePatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(252, 22);
            this.txtNombrePatente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Tag = "Nombre";
            this.label3.Text = "Nombre:";
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(12, 82);
            this.btnAgregarPatente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(176, 28);
            this.btnAgregarPatente.TabIndex = 2;
            this.btnAgregarPatente.Tag = "AgregarPatente";
            this.btnAgregarPatente.Text = "Agregar Patente >> ";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(12, 50);
            this.cboPatentes.Margin = new System.Windows.Forms.Padding(4);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(280, 24);
            this.cboPatentes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Tag = "TodasLasPatentes";
            this.label2.Text = "Todas las patentes:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(638, 444);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 32);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormPermisosFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 525);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpFamlias);
            this.Controls.Add(this.grpFamilias);
            this.Controls.Add(this.grpPatentes);
            this.Name = "FormPermisosFamilias";
            this.Text = "FormPermisosFamilias";
            this.Load += new System.EventHandler(this.FormPermisosFamilias_Load);
            this.grpFamlias.ResumeLayout(false);
            this.grpFamilias.ResumeLayout(false);
            this.grpFamilias.PerformLayout();
            this.grpNuevaFamilia.ResumeLayout(false);
            this.grpNuevaFamilia.PerformLayout();
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.grpNuevoPermiso.ResumeLayout(false);
            this.grpNuevoPermiso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFamlias;
        private System.Windows.Forms.Button btnGuardarFamilia;
        private System.Windows.Forms.TreeView treeConfigFamilia;
        private System.Windows.Forms.GroupBox grpFamilias;
        private System.Windows.Forms.Button btnConfigurarFamilia;
        private System.Windows.Forms.GroupBox grpNuevaFamilia;
        private System.Windows.Forms.Button btnGuardarSimple;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.GroupBox grpNuevoPermiso;
        private System.Windows.Forms.Button btnGuardarPatente;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPermisos;
    }
}