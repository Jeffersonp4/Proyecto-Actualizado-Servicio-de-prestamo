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
    public partial class FormPagos : Form
    {
        ConsultaPagos llamar = new ConsultaPagos();

        public FormPagos()
        {
            InitializeComponent();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llamar.ActulizarConsulta();
        }

        private void BtnCuota_Click(object sender, EventArgs e)
        {
            ConsultaPagos consulta = new ConsultaPagos();
            consulta.fecha = txtFecha.Text;
            consulta.id_cliente = int.Parse(txtId_cliente.Text);
            consulta.id_prestamo = int.Parse(txtPrestamo.Text);
            consulta.monto_pagado = int.Parse(txtMonto.Text);

            llamar.insertarTabla(consulta);
            llamar.Actualizarmovimiento(consulta);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            contenedor.Panel.Visible = true;
            contenedor.Imagen.Visible = true;
            this.Hide();
        }
    }
}
