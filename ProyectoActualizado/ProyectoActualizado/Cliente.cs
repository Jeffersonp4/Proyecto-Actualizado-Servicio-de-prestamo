using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoActualizado
{
    public class Cliente
    {
        public int id { get; set; }
        public int idNu { get; set; }
        public long cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public long telefono { get; set; }
        public long numeroG { get; set; }
        public int numeroP { get; set; }
        public DateTime fechaCu { get; set; }
        public int idCual { get; set; }


        public DataTable ActulizarConsulta()
        {

            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            FormMovimientosPrestamo FmrMovimiento = new FormMovimientosPrestamo();

            conexbd.Open();

            comando = new SqlCommand("select * from Pagos", conexbd);
            comando.ExecuteNonQuery();
            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();

            return tabla;
        }


    }


}
