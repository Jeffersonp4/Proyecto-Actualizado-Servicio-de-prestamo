namespace ProyectoActualizado
{
    partial class FormPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamo));
            this.prestamoCliente = new System.Windows.Forms.Label();
            this.ImagenPrestamo = new System.Windows.Forms.PictureBox();
            this.LlueveDinero = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtId_Prestamo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idClie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.txtId_cliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Para_Actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlueveDinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen_Para_Actualizar
            // 
            this.Imagen_Para_Actualizar.Location = new System.Drawing.Point(586, 49);
            this.Imagen_Para_Actualizar.Size = new System.Drawing.Size(30, 31);
            // 
            // prestamoCliente
            // 
            this.prestamoCliente.AutoSize = true;
            this.prestamoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestamoCliente.Location = new System.Drawing.Point(61, 49);
            this.prestamoCliente.Name = "prestamoCliente";
            this.prestamoCliente.Size = new System.Drawing.Size(130, 31);
            this.prestamoCliente.TabIndex = 11;
            this.prestamoCliente.Text = "Pretamos";
            // 
            // ImagenPrestamo
            // 
            this.ImagenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPrestamo.Image")));
            this.ImagenPrestamo.Location = new System.Drawing.Point(5, 39);
            this.ImagenPrestamo.Name = "ImagenPrestamo";
            this.ImagenPrestamo.Size = new System.Drawing.Size(50, 50);
            this.ImagenPrestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPrestamo.TabIndex = 12;
            this.ImagenPrestamo.TabStop = false;
            // 
            // LlueveDinero
            // 
            this.LlueveDinero.Image = ((System.Drawing.Image)(resources.GetObject("LlueveDinero.Image")));
            this.LlueveDinero.Location = new System.Drawing.Point(252, 12);
            this.LlueveDinero.Name = "LlueveDinero";
            this.LlueveDinero.Size = new System.Drawing.Size(274, 114);
            this.LlueveDinero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LlueveDinero.TabIndex = 28;
            this.LlueveDinero.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(622, 49);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 31);
            this.txtBusqueda.TabIndex = 29;
            // 
            // txtId_Prestamo
            // 
            this.txtId_Prestamo.Location = new System.Drawing.Point(12, 456);
            this.txtId_Prestamo.Name = "txtId_Prestamo";
            this.txtId_Prestamo.Size = new System.Drawing.Size(119, 20);
            this.txtId_Prestamo.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id_Prestamo";
            // 
            // idClie
            // 
            this.idClie.AutoSize = true;
            this.idClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClie.Location = new System.Drawing.Point(168, 147);
            this.idClie.Name = "idClie";
            this.idClie.Size = new System.Drawing.Size(108, 25);
            this.idClie.TabIndex = 20;
            this.idClie.Text = "Id_Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Monto $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cuota_Mes";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(189, 190);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(72, 25);
            this.fecha.TabIndex = 23;
            this.fecha.Text = "Fecha";
            // 
            // txtId_cliente
            // 
            this.txtId_cliente.Location = new System.Drawing.Point(282, 154);
            this.txtId_cliente.Name = "txtId_cliente";
            this.txtId_cliente.Size = new System.Drawing.Size(116, 20);
            this.txtId_cliente.TabIndex = 24;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(282, 195);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(116, 20);
            this.txtFecha.TabIndex = 25;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(528, 152);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 26;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(528, 194);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 20);
            this.txtCuota.TabIndex = 27;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId_Prestamo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.LlueveDinero);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtId_cliente);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idClie);
            this.Controls.Add(this.ImagenPrestamo);
            this.Controls.Add(this.prestamoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.Controls.SetChildIndex(this.prestamoCliente, 0);
            this.Controls.SetChildIndex(this.ImagenPrestamo, 0);
            this.Controls.SetChildIndex(this.idClie, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.fecha, 0);
            this.Controls.SetChildIndex(this.txtId_cliente, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.txtCuota, 0);
            this.Controls.SetChildIndex(this.LlueveDinero, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.txtId_Prestamo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Imagen_Para_Actualizar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Para_Actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlueveDinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prestamoCliente;
        private System.Windows.Forms.PictureBox ImagenPrestamo;
        private System.Windows.Forms.PictureBox LlueveDinero;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtId_Prestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idClie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.TextBox txtId_cliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCuota;
    }
}