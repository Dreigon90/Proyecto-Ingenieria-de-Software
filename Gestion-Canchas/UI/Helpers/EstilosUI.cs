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
    }
}
