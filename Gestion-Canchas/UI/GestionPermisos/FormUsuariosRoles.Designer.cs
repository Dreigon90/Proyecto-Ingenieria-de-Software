namespace UI.GestionPermisos
{
    partial class FormUsuariosRoles
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigurarUsuario = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.treeConfigFamilia = new System.Windows.Forms.TreeView();
            this.grpPermisos.SuspendLayout();
            this.grpRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(782, 469);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 32);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(14, 339);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(223, 32);
            this.btnGuardarCambios.TabIndex = 17;
            this.btnGuardarCambios.Tag = "GuardarCambios";
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.btnAgregarFamilia);
            this.grpPermisos.Controls.Add(this.cboFamilias);
            this.grpPermisos.Controls.Add(this.label3);
            this.grpPermisos.Controls.Add(this.btnAgregarPermiso);
            this.grpPermisos.Controls.Add(this.cboPermisos);
            this.grpPermisos.Controls.Add(this.label1);
            this.grpPermisos.Controls.Add(this.btnConfigurarUsuario);
            this.grpPermisos.Controls.Add(this.cboUsuarios);
            this.grpPermisos.Controls.Add(this.label2);
            this.grpPermisos.Location = new System.Drawing.Point(49, 59);
            this.grpPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPermisos.Size = new System.Drawing.Size(341, 306);
            this.grpPermisos.TabIndex = 16;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Tag = "PermisosDeUsuarios";
            this.grpPermisos.Text = "Permisos de usuarios";
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(15, 270);
            this.btnAgregarFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(153, 28);
            this.btnAgregarFamilia.TabIndex = 13;
            this.btnAgregarFamilia.Tag = "Agregar";
            this.btnAgregarFamilia.Text = "Agregar Familia >>";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(15, 239);
            this.cboFamilias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(311, 24);
            this.cboFamilias.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 11;
            this.label3.Tag = "AgregarFamilias/Roles";
            this.label3.Text = "Agregar Familias/Roles: ";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(15, 186);
            this.btnAgregarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(153, 28);
            this.btnAgregarPermiso.TabIndex = 10;
            this.btnAgregarPermiso.Tag = "AgregarPermiso";
            this.btnAgregarPermiso.Text = "Agregar Permiso >>";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(15, 156);
            this.cboPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(311, 24);
            this.cboPermisos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 8;
            this.label1.Tag = "AgregarPermisosAcciones";
            this.label1.Text = "Agregar Permisos/Acciones";
            // 
            // btnConfigurarUsuario
            // 
            this.btnConfigurarUsuario.Location = new System.Drawing.Point(15, 78);
            this.btnConfigurarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfigurarUsuario.Name = "btnConfigurarUsuario";
            this.btnConfigurarUsuario.Size = new System.Drawing.Size(153, 28);
            this.btnConfigurarUsuario.TabIndex = 7;
            this.btnConfigurarUsuario.Tag = "ConfigurarUsuario";
            this.btnConfigurarUsuario.Text = "Configurar Usuario";
            this.btnConfigurarUsuario.UseVisualStyleBackColor = true;
            this.btnConfigurarUsuario.Click += new System.EventHandler(this.btnConfigurarUsuario_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(15, 48);
            this.cboUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(311, 24);
            this.cboUsuarios.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 5;
            this.label2.Tag = "TodosLosUsuarios";
            this.label2.Text = "Todos los usuarios:";
            // 
            // grpRoles
            // 
            this.grpRoles.Controls.Add(this.treeConfigFamilia);
            this.grpRoles.Controls.Add(this.btnGuardarCambios);
            this.grpRoles.Location = new System.Drawing.Point(516, 59);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Size = new System.Drawing.Size(408, 389);
            this.grpRoles.TabIndex = 19;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Roles";
            // 
            // treeConfigFamilia
            // 
            this.treeConfigFamilia.Location = new System.Drawing.Point(14, 29);
            this.treeConfigFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeConfigFamilia.Name = "treeConfigFamilia";
            this.treeConfigFamilia.Size = new System.Drawing.Size(367, 306);
            this.treeConfigFamilia.TabIndex = 12;
            // 
            // FormUsuariosRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 563);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.grpRoles);
            this.Name = "FormUsuariosRoles";
            this.Text = "FormRolesUsuarios";
            this.Load += new System.EventHandler(this.FormUsuariosRoles_Load);
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurarUsuario;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpRoles;
        private System.Windows.Forms.TreeView treeConfigFamilia;
    }
}