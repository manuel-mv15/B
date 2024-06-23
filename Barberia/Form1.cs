using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Text;

namespace Barberia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Encriptador encriptador = new Encriptador();
            // inicio de secion 
            string Usuario = txt_Usuario.Text;
            string Clave = txt_Clave.Text;

            string consulta = $"SELECT * FROM tbl_usuarios WHERE Usuario = '{Usuario}' and Clave = '{encriptador.Encriptar(Clave)}';";
            // coneccion a la base de datos 
            MySqlConnection conexcion = Conexcion.MyConnection();
            conexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexcion);
                cmd.ExecuteNonQuery();

                int dato = Convert.ToInt32(cmd.ExecuteScalar());
                if (dato > 0)
                {
                    MessageBox.Show("Inicio exitoso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


    }
}
