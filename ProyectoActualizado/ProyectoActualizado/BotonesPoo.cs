using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoActualizado
{
    public partial class BotonesPoo : Form
    {
        public BotonesPoo()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable();

        protected virtual void Guardar(Cliente cliente)
        {

        }
        protected virtual void Actualizar(Cliente cliente)
        {

        }


        protected virtual void Borrar(Cliente cliente)
        {

        }

        public virtual DataTable Buscar(Cliente cliente)
        {
            return tabla;
        }

        public virtual DataTable ActualizarGrid()
        {
            return tabla;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Guardar(cliente);
            FormCliente FmrActualizar = new FormCliente();
            dataGridView.DataSource = ActualizarGrid();

        }

        private void BtnActulizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Actualizar(cliente);
            dataGridView.DataSource = ActualizarGrid();
            

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Borrar(cliente);
            dataGridView.DataSource = ActualizarGrid();

        }

        private void BotonesPoo_Load(object sender, EventArgs e)
        {
           dataGridView.DataSource= ActualizarGrid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                Buscar(cliente);
                dataGridView.DataSource = Buscar(cliente);
            }
            catch(Exception error)
            {
                MessageBox.Show("Cliente no encontrado",error.Message);
            }
            
        }

       

        private void ImagenSalir_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            contenedor.Panel.Visible = true;
            contenedor.Imagen.Visible = true;
            this.Close();
        }

        private void Imagen_Para_Actualizar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ActualizarGrid();
        }
    }
}
