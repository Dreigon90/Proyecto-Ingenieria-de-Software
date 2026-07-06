namespace UI
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosYFamiliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesYUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionUsuarios,
            this.canchasToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosYFamiliasToolStripMenuItem,
            this.rolesYUsuariosToolStripMenuItem,
            this.modificarUsuariosToolStripMenuItem});
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Size = new System.Drawing.Size(146, 24);
            this.menuGestionUsuarios.Tag = "menuGestionUsuarios";
            this.menuGestionUsuarios.Text = "Gestionar Usuarios";
            // 
            // permisosYFamiliasToolStripMenuItem
            // 
            this.permisosYFamiliasToolStripMenuItem.AccessibleName = "GestionarPermisosYFamilias";
            this.permisosYFamiliasToolStripMenuItem.Name = "permisosYFamiliasToolStripMenuItem";
            this.permisosYFamiliasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.permisosYFamiliasToolStripMenuItem.Text = "Permisos y Familias";
            this.permisosYFamiliasToolStripMenuItem.Click += new System.EventHandler(this.permisosYFamiliasToolStripMenuItem_Click);
            // 
            // rolesYUsuariosToolStripMenuItem
            // 
            this.rolesYUsuariosToolStripMenuItem.AccessibleName = "GestionarUsuariosYRoles";
            this.rolesYUsuariosToolStripMenuItem.Name = "rolesYUsuariosToolStripMenuItem";
            this.rolesYUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rolesYUsuariosToolStripMenuItem.Text = "Usuarios y Roles";
            this.rolesYUsuariosToolStripMenuItem.Click += new System.EventHandler(this.rolesYUsuariosToolStripMenuItem_Click);
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.AccessibleName = "ModificarUsuarios";
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            this.modificarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuariosToolStripMenuItem_Click);
            // 
            // canchasToolStripMenuItem
            // 
            this.canchasToolStripMenuItem.Name = "canchasToolStripMenuItem";
            this.canchasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.canchasToolStripMenuItem.Tag = "canchasToolStripMenuItem";
            this.canchasToolStripMenuItem.Text = "Canchas";
            this.canchasToolStripMenuItem.Click += new System.EventHandler(this.canchasToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reservasToolStripMenuItem.Tag = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.bitacoraToolStripMenuItem.Tag = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.auditoriaToolStripMenuItem.Tag = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem canchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosYFamiliasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesYUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
    }
}