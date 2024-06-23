using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia
{
    internal class Encriptador
    {
        public string Encriptar (string clave)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(clave));
        }
        public string desEncriptar(string clave)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(clave));
        }
    }
}
