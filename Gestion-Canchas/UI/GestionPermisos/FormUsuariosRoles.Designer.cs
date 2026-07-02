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
            this.button_GuardarCambios = new System.Windows.Forms.Button();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.button_AgregarRol = new System.Windows.Forms.Button();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AgregarAccion = new System.Windows.Forms.Button();
            this.comboBox_Acciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ConfigurarUsuario = new System.Windows.Forms.Button();
            this.comboBox_Usuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grpPatentes.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // button_GuardarCambios
            // 
            this.button_GuardarCambios.Location = new System.Drawing.Point(14, 339);
            this.button_GuardarCambios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_GuardarCambios.Name = "button_GuardarCambios";
            this.button_GuardarCambios.Size = new System.Drawing.Size(223, 32);
            this.button_GuardarCambios.TabIndex = 17;
            this.button_GuardarCambios.Tag = "GuardarCambios";
            this.button_GuardarCambios.Text = "Guardar cambios";
            this.button_GuardarCambios.UseVisualStyleBackColor = true;
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.button_AgregarRol);
            this.grpPatentes.Controls.Add(this.comboBox_Roles);
            this.grpPatentes.Controls.Add(this.label3);
            this.grpPatentes.Controls.Add(this.button_AgregarAccion);
            this.grpPatentes.Controls.Add(this.comboBox_Acciones);
            this.grpPatentes.Controls.Add(this.label1);
            this.grpPatentes.Controls.Add(this.button_ConfigurarUsuario);
            this.grpPatentes.Controls.Add(this.comboBox_Usuarios);
            this.grpPatentes.Controls.Add(this.label2);
            this.grpPatentes.Location = new System.Drawing.Point(49, 59);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPatentes.Size = new System.Drawing.Size(341, 306);
            this.grpPatentes.TabIndex = 16;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Tag = "PermisosDeUsuarios";
            this.grpPatentes.Text = "Permisos de usuarios";
            // 
            // button_AgregarRol
            // 
            this.button_AgregarRol.Location = new System.Drawing.Point(15, 270);
            this.button_AgregarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AgregarRol.Name = "button_AgregarRol";
            this.button_AgregarRol.Size = new System.Drawing.Size(100, 28);
            this.button_AgregarRol.TabIndex = 13;
            this.button_AgregarRol.Tag = "Agregar";
            this.button_AgregarRol.Text = "Agregar >>";
            this.button_AgregarRol.UseVisualStyleBackColor = true;
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(15, 239);
            this.comboBox_Roles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(311, 24);
            this.comboBox_Roles.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 11;
            this.label3.Tag = "AgregarRolesFamilias";
            this.label3.Text = "Agregar roles/familias: ";
            // 
            // button_AgregarAccion
            // 
            this.button_AgregarAccion.Location = new System.Drawing.Point(15, 186);
            this.button_AgregarAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AgregarAccion.Name = "button_AgregarAccion";
            this.button_AgregarAccion.Size = new System.Drawing.Size(100, 28);
            this.button_AgregarAccion.TabIndex = 10;
            this.button_AgregarAccion.Tag = "Agregar";
            this.button_AgregarAccion.Text = "Agregar >>";
            this.button_AgregarAccion.UseVisualStyleBackColor = true;
            // 
            // comboBox_Acciones
            // 
            this.comboBox_Acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Acciones.FormattingEnabled = true;
            this.comboBox_Acciones.Location = new System.Drawing.Point(15, 156);
            this.comboBox_Acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Acciones.Name = "comboBox_Acciones";
            this.comboBox_Acciones.Size = new System.Drawing.Size(311, 24);
            this.comboBox_Acciones.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 8;
            this.label1.Tag = "AgregarAccionesPatentes";
            this.label1.Text = "Agregar acciones/patentes: ";
            // 
            // button_ConfigurarUsuario
            // 
            this.button_ConfigurarUsuario.Location = new System.Drawing.Point(15, 78);
            this.button_ConfigurarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ConfigurarUsuario.Name = "button_ConfigurarUsuario";
            this.button_ConfigurarUsuario.Size = new System.Drawing.Size(100, 28);
            this.button_ConfigurarUsuario.TabIndex = 7;
            this.button_ConfigurarUsuario.Tag = "Configurar";
            this.button_ConfigurarUsuario.Text = "Configurar";
            this.button_ConfigurarUsuario.UseVisualStyleBackColor = true;
            // 
            // comboBox_Usuarios
            // 
            this.comboBox_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Usuarios.FormattingEnabled = true;
            this.comboBox_Usuarios.Location = new System.Drawing.Point(15, 48);
            this.comboBox_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Usuarios.Name = "comboBox_Usuarios";
            this.comboBox_Usuarios.Size = new System.Drawing.Size(311, 24);
            this.comboBox_Usuarios.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.button_GuardarCambios);
            this.groupBox1.Location = new System.Drawing.Point(516, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 389);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 29);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(367, 306);
            this.treeView1.TabIndex = 12;
            // 
            // FormRolesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 563);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpPatentes);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRolesUsuarios";
            this.Text = "FormRolesUsuarios";
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button_GuardarCambios;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button button_AgregarRol;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AgregarAccion;
        private System.Windows.Forms.ComboBox comboBox_Acciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ConfigurarUsuario;
        private System.Windows.Forms.ComboBox comboBox_Usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}