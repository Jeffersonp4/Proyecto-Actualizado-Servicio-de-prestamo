using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoActualizado
{
   public class Consulta_Movimiento:IConsultar
   {
        public int Id { get; set; }
        


        public DataTable ActulizarConsulta()
        {
           
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            FormMovimientosPrestamo FmrMovimiento = new FormMovimientosPrestamo();

            conexbd.Open();

            comando = new SqlCommand("select * from MovimientoPrestamo", conexbd);
            comando.ExecuteNonQuery();
            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();

            return tabla;
        }

        public DataTable BuscarDato(Consulta_Movimiento consulta)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            FormMovimientosPrestamo FmrMovimiento = new FormMovimientosPrestamo();
            
            conexbd.Open();

            comando = new SqlCommand("BuscarMovimiento",conexbd);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = consulta.Id;
            comando.ExecuteNonQuery();

            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();



            return tabla;

           
        }
    }
}
