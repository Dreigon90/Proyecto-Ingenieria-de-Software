using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public class Traductor
    {
        private readonly IdiomaBLL idiomaBLL = new IdiomaBLL();

        public void TraducirFormulario(Form formulario, Idioma idioma)
        {
            List<Traduccion> traducciones = idiomaBLL.ObtenerTraducciones(idioma.Id);

            Dictionary<string, string> dic = new Dictionary<string, string>();

            foreach (var t in traducciones)
                dic[t.Clave] = t.Texto;

            TraducirControl(formulario, dic);

            foreach (Control c in formulario.Controls)
                Recorrer(c, dic);

            if (formulario.MainMenuStrip != null)
            {
                foreach (ToolStripMenuItem item in formulario.MainMenuStrip.Items)
                {
                    TraducirMenu(item, dic);
                }
            }
            foreach (Control c in formulario.Controls)
            {
                if (c is ToolStrip ts)
                {
                    TraducirToolStrip(ts, dic);
                }
            }
        }

        private void Recorrer(Control control, Dictionary<string, string> dic)
        {
            TraducirControl(control, dic);

            foreach (Control hijo in control.Controls)
            {
                Recorrer(hijo, dic);
            }
        }

        private void TraducirControl(Control control, Dictionary<string, string> dic)
        {
            if (control.Tag == null)
                return;

            string clave = control.Tag.ToString();

            if (dic.ContainsKey(clave))
                control.Text = dic[clave];
        }

        private void TraducirMenu(ToolStripMenuItem menu, Dictionary<string, string> dic)
        {
            if (menu.Tag != null)
            {
                string clave = menu.Tag.ToString();

                if (dic.ContainsKey(clave))
                    menu.Text = dic[clave];
            }

            foreach (ToolStripItem item in menu.DropDownItems)
            {
                if (item is ToolStripMenuItem hijo)
                    TraducirMenu(hijo, dic);
            }
        }
        private static void TraducirToolStrip(ToolStrip toolStrip, Dictionary<string, string> traducciones)
        {
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item.Tag != null)
                {
                    string clave = item.Tag.ToString();

                    if (traducciones.ContainsKey(clave))
                        item.Text = traducciones[clave];
                }
            }
        }
    }
}
