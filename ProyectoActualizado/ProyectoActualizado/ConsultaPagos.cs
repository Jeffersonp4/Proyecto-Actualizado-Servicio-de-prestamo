using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ProyectoActualizado
{
    class ConsultaPagos : IConsultar
    {
        public string fecha { get; set; }
        public int id_prestamo {get; set;}
        public int id_cliente { get; set; }
        public int monto_pagado { get; set; }
        public DataTable ActulizarConsulta()
        {

            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            FormMovimientosPrestamo FmrMovimiento = new FormMovimientosPrestamo();

            conexbd.Open();

            comando = new SqlCommand("select Clientes.id, Clientes.nombre,Clientes.cedula,Clientes.correo,Clientes.telefono,prestamo.id,prestamo.montoPrestamo from Clientes "
                                     +"inner join prestamo  on Clientes.id = prestamo.id_cliente ", conexbd);
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

            comando = new SqlCommand("BuscarMovimiento", conexbd);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = consulta.Id;
            comando.ExecuteNonQuery();

            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();

            return tabla;


        }

        public void insertarTabla(ConsultaPagos consulta)
        {
            FormPagos Fmr = new FormPagos();
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            

           try
            {

                conexbd.Open();

                comando = new SqlCommand("InsertarPago", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = consulta.fecha;
                comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = consulta.id_prestamo;
                comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = consulta.id_cliente;
                comando.Parameters.Add("@MontoPagado", SqlDbType.Int).Value = consulta.monto_pagado;
                comando.ExecuteNonQuery();
             
                comando = new SqlCommand("MontoPago", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = consulta.id_prestamo;
                comando.ExecuteNonQuery();

                conexbd.Close();



            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido un error", error.Message);
            }


        }

        public void Actualizarmovimiento(ConsultaPagos consulta)
        {
            FormPagos Fmr = new FormPagos();
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            conexbd.Open();
            comando = new SqlCommand("cuota", conexbd);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = consulta.id_prestamo;
            comando.ExecuteNonQuery();
            conexbd.Close();
            MessageBox.Show("Pago Guardado!");
        }

        public void limpiar(FormPagos pagos)
        {
            pagos.txtFecha.Text = " ";
            pagos.txtId_cliente.Text = "";
            pagos.txtPrestamo.Text = "";
            pagos.txtMonto.Text = "";
        }
    }
}
