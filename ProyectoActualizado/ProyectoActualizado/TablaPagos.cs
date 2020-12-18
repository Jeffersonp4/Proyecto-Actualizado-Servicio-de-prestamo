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
    public partial class TablaPagos : Form
    {
        Cliente cliente = new Cliente();
        public TablaPagos()
        {
            InitializeComponent();
        }

        private void TablaPagos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  cliente.ActulizarConsulta();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            contenedor.Panel.Visible = true;
            contenedor.Imagen.Visible = true;
            this.Hide();
        }
    }
}
