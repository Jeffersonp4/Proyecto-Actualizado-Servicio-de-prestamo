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
    public partial class FormPrestamo : BotonesPoo
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        protected override void Guardar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            try
            {
                
                cliente.fechaCu = DateTime.Parse(txtFecha.Text);
                cliente.numeroG = long.Parse(txtMonto.Text);
                cliente.idCual = int.Parse(txtId_cliente.Text);
                cliente.numeroP = int.Parse(txtCuota.Text);
                conexbd.Open();

                comando = new SqlCommand("InsertarPrestamo", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_Prestamo", SqlDbType.Int).Value = cliente.id;
                comando.Parameters.Add("@fecha", SqlDbType.Date).Value = cliente.fechaCu;
                comando.Parameters.Add("@MontoPrestamo", SqlDbType.BigInt).Value = cliente.numeroG;
                comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = cliente.idCual;
                comando.Parameters.Add("@cuotas", SqlDbType.Int).Value = cliente.numeroP;
                limpiar();
                comando.ExecuteNonQuery();

                conexbd.Close();
                MessageBox.Show("Prestamo Provisionado Exitosamente!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }

        }

        protected override void Actualizar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;          
            try
            {
                cliente.fechaCu = DateTime.Parse(txtFecha.Text);
                cliente.numeroG = long.Parse(txtMonto.Text);
                cliente.idCual = int.Parse(txtId_cliente.Text);
                cliente.numeroP = int.Parse(txtCuota.Text);
                conexbd.Open();

                comando = new SqlCommand("ActualizarPrestamo", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha", SqlDbType.Date).Value = cliente.fechaCu;
                comando.Parameters.Add("@MontoPrestamo", SqlDbType.BigInt).Value = cliente.numeroG;
                comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = cliente.idCual;
                comando.Parameters.Add("@cuotas", SqlDbType.Int).Value = cliente.numeroP;
                comando.ExecuteNonQuery();
                conexbd.Close();
                limpiar();
                MessageBox.Show("Prestamo Actualizado Exitosamente!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
            }
        }

        protected override void Borrar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            
            try
            {
                //ENCAPSULAMIENTO

                cliente.id = int.Parse(txtId_Prestamo.Text);
                cliente.idCual = int.Parse(txtId_Prestamo.Text);


                conexbd.Open();

                comando = new SqlCommand("EliminarPrestamo", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = cliente.id;
                comando.Parameters.Add("@id_prestamo", SqlDbType.Int).Value = cliente.idCual;
                comando.ExecuteNonQuery();
                conexbd.Close();
                limpiar();
                MessageBox.Show("Prestamo Eliminado!");



            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
            }

        }

        public override DataTable ActualizarGrid()
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            conexbd.Open();

            comando = new SqlCommand("select * from prestamo", conexbd);
            comando.ExecuteNonQuery();
            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();

            return tabla;
        }

        public override DataTable Buscar(Cliente cliente)
        {


            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlDataAdapter adaptar;
            DataTable tabla;
            SqlCommand comando;
            cliente.id = int.Parse(txtBusqueda.Text);
            conexbd.Open();

            comando = new SqlCommand("BuscarPrestamo", conexbd);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id_cliente", SqlDbType.BigInt).Value = cliente.id;
            comando.ExecuteNonQuery();

            adaptar = new SqlDataAdapter(comando);

            tabla = new DataTable();

            adaptar.Fill(tabla);

            conexbd.Close();
            limpiar();



            return tabla;

        }

        public void limpiar()
        {
            txtBusqueda.Text = "";
            txtCuota.Text = "";
            txtFecha.Text = "";
            txtId_cliente.Text = "";
            txtId_Prestamo.Text = "";
            txtMonto.Text = "";
        }

       
    }
}
