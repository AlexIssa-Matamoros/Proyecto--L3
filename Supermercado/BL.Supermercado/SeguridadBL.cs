using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class SeguridadBL
    {
        public bool Autorizar(string Usuario, string Contraseña)
        {
            if (Usuario == "hola" && Contraseña == "5678")
            {
                return true;
            }
            else
            {
                if (Usuario == "admin" && Contraseña == "1234")
                {
                    return true;
                }
            }
            return false;
        }
    }
}

