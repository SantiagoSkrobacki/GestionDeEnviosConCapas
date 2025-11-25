using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEnvios.Controles
{
    public static class ValiacionesUtils
    {

        public  static bool ValidarEntradaUsuario(Form formulario)
        {

            bool validado = true;
            foreach (Control ctrl in formulario.Controls)
            {
                if (ctrl is MiControl miCtrl)
                {
                    validado = miCtrl.Validar();
                }
            }
            return validado;
        }

   



    }
}
