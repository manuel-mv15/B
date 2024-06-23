using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia
{
    internal class Conexcion
    {
        // conexion a base de datos 
        public static MySqlConnection MyConnection()
        {
            string servidor = "localhost";
            string bd = "dbbarberia";
            string usuario = "root";
            string contraseña = "";
            string cadena = $"server={servidor}; database={bd}; Uid={usuario}; pwd={contraseña}";
            MySqlConnection miconexion = new MySqlConnection(cadena);
            return miconexion;
        }

    }
}
