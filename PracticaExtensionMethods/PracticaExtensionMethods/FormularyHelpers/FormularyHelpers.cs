using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace PracticeExtensionMethods.FormularioHelpers
{
    public static class FormularyHelpers
    {
        public static void ClearForm(Control control)
        {
            foreach (var ctrl in control.Controls)
            {
                if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                //else if(ctrl is Label)
                //{
                //    ((Label)ctrl) = "";
                //}
            }
        }
    }
}
