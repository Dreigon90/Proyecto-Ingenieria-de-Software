using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Traductor
    {
        private Dictionary<string, string> traducciones =
            new Dictionary<string, string>();

        public void Cargar(Dictionary<string, string> diccionario)
        {
            traducciones = diccionario;
        }

        public void TraducirFormulario(Form form)
        {
            TraducirControl(form);

            foreach (Control c in form.Controls)
            {
                Recorrer(c);
            }

            if (form.MainMenuStrip != null)
            {
                foreach (ToolStripMenuItem item in form.MainMenuStrip.Items)
                {
                    TraducirMenu(item);
                }
            }
        }

        private void Recorrer(Control control)
        {
            TraducirControl(control);

            foreach (Control hijo in control.Controls)
            {
                Recorrer(hijo);
            }
        }

        private void TraducirControl(Control control)
        {
            if (control.Tag == null)
                return;

            string clave = control.Tag.ToString();

            if (traducciones.ContainsKey(clave))
            {
                control.Text = traducciones[clave];
            }
        }

        private void TraducirMenu(ToolStripMenuItem item)
        {
            if (item.Tag != null)
            {
                string clave = item.Tag.ToString();

                if (traducciones.ContainsKey(clave))
                {
                    item.Text = traducciones[clave];
                }
            }

            foreach (ToolStripItem hijo in item.DropDownItems)
            {
                if (hijo is ToolStripMenuItem menu)
                    TraducirMenu(menu);
            }
        }
    }
}

