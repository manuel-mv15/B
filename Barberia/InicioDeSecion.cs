using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Barberia
{
    public partial class InicioDeSecion : Form
    {
        public InicioDeSecion()
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
                    consulta = consulta = $"SELECT Tipo_Usuario FROM tbl_usuarios WHERE Usuario = '{txt_Usuario.Text}'";
                    if("Super Usuario"== BuscarDato(consulta))
                    {
                        MessageBox.Show("Hola " + BuscarDato(consulta));
                    }
                    else if ("Administrador" == BuscarDato(consulta))
                    {

                    }
                    else if("Usuario Común" == BuscarDato(consulta))
                    {

                    }
                         


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            
        }
        public string BuscarDato(string consulta)
        {
            MySqlConnection conexion = Conexcion.MyConnection();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }



    }
}
