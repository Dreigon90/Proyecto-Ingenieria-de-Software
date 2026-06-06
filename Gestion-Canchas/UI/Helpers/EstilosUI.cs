using System.Drawing;
using System.Windows.Forms;

namespace UI.Helpers
{
    public static class EstilosUI
    {
        public static void ConfigurarFormulario(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);

            form.StartPosition = FormStartPosition.CenterScreen;

            form.FormBorderStyle = FormBorderStyle.FixedSingle;

            form.MaximizeBox = false;
        }

        public static void ConfigurarTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;

            txt.BackColor = Color.FromArgb(45, 45, 45);

            txt.ForeColor = Color.White;

            txt.Font = new Font("Segoe UI", 11);

            txt.Height = 35;
        }

        public static void ConfigurarBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;

            btn.FlatAppearance.BorderSize = 0;

            btn.BackColor = Color.FromArgb(0, 120, 215);

            btn.ForeColor = Color.White;

            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btn.Height = 40;

            btn.Cursor = Cursors.Hand;
        }

        public static void ConfigurarLabel(Label lbl)
        {
            lbl.ForeColor = Color.White;

            lbl.Font = new Font("Segoe UI", 10);
        }

        public static void ConfigurarTitulo(Label lbl)
        {
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(180, 0, 0, 0);

            lbl.Font = new Font("Segoe UI",14,FontStyle.Bold);

            lbl.AutoSize = false;
            lbl.Size = new Size(300, 50);
            lbl.TextAlign = ContentAlignment.MiddleCenter;

        }
        public static void ConfigurarPanel(Panel panel)
        {
            panel.BackColor = Color.FromArgb(220, 0, 0, 0);
            panel.Width = 400;
            panel.Height = 350;

            panel.BorderStyle = BorderStyle.None;
        }

        public static void ConfigurarMenu(MenuStrip menu)
        {
            menu.BackColor = Color.FromArgb(30, 30, 30);

            menu.ForeColor = Color.White;

            menu.Font = new Font("Segoe UI",10,FontStyle.Bold);

            menu.RenderMode = ToolStripRenderMode.System;
        }
        public static void ConfigurarBotonLogout(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;

            btn.FlatAppearance.BorderSize = 0;

            btn.BackColor = Color.FromArgb(192, 57, 43);

            btn.ForeColor = Color.White;

            btn.Font = new Font("Segoe UI",9,FontStyle.Bold);

            btn.Cursor = Cursors.Hand;

            btn.Width = 120;

            btn.Height = 35;
        }
        public static void ConfigurarTituloBienvenida(Label lbl)
        {
            lbl.ForeColor = Color.White;

            lbl.Font = new Font("Segoe UI",18,FontStyle.Bold);

            lbl.AutoSize = true;
        }
        public static void ConfigurarCheckBox(CheckBox chk)
        {
            chk.ForeColor = Color.White;

            chk.Font = new Font("Segoe UI",10,FontStyle.Bold);

            chk.BackColor = Color.Transparent;

            chk.Cursor = Cursors.Hand;
        }

    }
}
