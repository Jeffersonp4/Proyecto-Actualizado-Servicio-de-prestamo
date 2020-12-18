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
    public partial class FormMovimientosPrestamo : Form
    {
        public FormMovimientosPrestamo()
        {
            InitializeComponent();
        }
        Consulta_Movimiento llamar = new Consulta_Movimiento();

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            contenedor.Panel.Visible = true;
            contenedor.Imagen.Visible = true;
            this.Hide();
        }

        private void FormMovimientosPrestamo_Load(object sender, EventArgs e)
        {
           

            dataGridView1.DataSource = llamar.ActulizarConsulta();
        }

        private void BtnBuscarEnMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta_Movimiento consulta = new Consulta_Movimiento();
                consulta.Id = int.Parse(txtMovimiento.Text);

                dataGridView1.DataSource = llamar.BuscarDato(consulta);
            }
            catch(Exception error)
            {
                MessageBox.Show("Cliente no encontrado", error.Message);
            }
        }

        private void ActualizaElMovimiento_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llamar.ActulizarConsulta();
        }
    }
}
