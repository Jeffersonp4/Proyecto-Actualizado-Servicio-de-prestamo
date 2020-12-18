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
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente FmrCliente = new FormCliente();
            FmrCliente.MdiParent = this;
            Imagen.Visible = false;
            Panel.Visible = false;
            FmrCliente.Show();
        }

        private void solicitarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamo FmrPrestamo = new FormPrestamo();
            FmrPrestamo.MdiParent = this;
            Imagen.Visible = false;
            Panel.Visible = false;
            FmrPrestamo.Show();
        }

        private void movimientosPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovimientosPrestamo FmrMovimiento = new FormMovimientosPrestamo();
            FmrMovimiento.MdiParent = this;
            Imagen.Visible = false;
            Panel.Visible = false;
            FmrMovimiento.Show();
        }

        private void pagarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagos FmrPagos = new FormPagos();
            FmrPagos.MdiParent = this;
            Imagen.Visible = false;
            Panel.Visible = false;
            FmrPagos.Show();

        }

        private void pagosEfectuadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaPagos tabla = new TablaPagos();
            tabla.MdiParent = this;
            Imagen.Visible = false;
            Panel.Visible = false;
            tabla.Show();
        }
    }
}
