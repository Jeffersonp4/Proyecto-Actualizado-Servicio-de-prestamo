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
    public partial class FormCliente : BotonesPoo
    {
        public FormCliente()
        {
            InitializeComponent();
        }

       

        protected override void Guardar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            //ENCAPSULAMIENTO

            cliente.cedula = long.Parse(txtCedula.Text);
            cliente.nombre = txtNombre.Text;
            cliente.correo = txtCorreo.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = long.Parse(txtTelefono.Text);


            try
            {

                conexbd.Open();

                comando = new SqlCommand("InsertarCliente", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = cliente.id;
                comando.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cliente.cedula;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.correo;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.BigInt).Value = cliente.telefono;
                comando.ExecuteNonQuery();
                conexbd.Close();
                MessageBox.Show("Cliente Guardado!");
                Limpiar();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido un error", error.Message);

            }
        }

        protected override void Actualizar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            //ENCAPSULAMIENTO

            cliente.cedula = long.Parse(txtCedula.Text);
            cliente.nombre = txtNombre.Text;
            cliente.correo = txtCorreo.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = long.Parse(txtTelefono.Text);


            try
            {

                conexbd.Open();
                comando = new SqlCommand("ActualizarCliente", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cliente.cedula;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.correo;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.BigInt).Value = cliente.telefono;
                comando.ExecuteNonQuery();
                conexbd.Close();
                MessageBox.Show("Cliente actualizado!");
                Limpiar();


            }

            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido un error", error.Message);
            }
        }

        protected override void Borrar(Cliente cliente)
        {
            SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand comando;
            try
            {
                //ENCAPSULAMIENTO

                cliente.cedula = long.Parse(txtCedula.Text);


                conexbd.Open();

                comando = new SqlCommand("EliminarCliente", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(@"cedula", SqlDbType.BigInt).Value = cliente.cedula;
                comando.ExecuteNonQuery();
                conexbd.Close();
                MessageBox.Show("Cliente Eliminado!");
                Limpiar();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error", error.Message);
            }
        }
        public override DataTable Buscar(Cliente cliente)
        {
            
            
                SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                SqlDataAdapter adaptar;
                DataTable tabla;
                SqlCommand comando;
                cliente.cedula = long.Parse(textBuscar.Text);
                conexbd.Open();

                comando = new SqlCommand("BuscarCliente", conexbd);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cliente.cedula;
                comando.ExecuteNonQuery();

                adaptar = new SqlDataAdapter(comando);

                tabla = new DataTable();

                adaptar.Fill(tabla);

                conexbd.Close();
            
            

                return tabla;

        }

        public override DataTable ActualizarGrid()
        {
                SqlConnection conexbd = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                SqlDataAdapter adaptar;
                DataTable tabla;
                SqlCommand comando;

                conexbd.Open();

                comando = new SqlCommand("select * from Clientes", conexbd);
                comando.ExecuteNonQuery();
                adaptar = new SqlDataAdapter(comando);

                tabla = new DataTable();

                adaptar.Fill(tabla);

                conexbd.Close();

                return tabla;
            
        }


        public void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            textBuscar.Text = "";
        }

       
    }
}
