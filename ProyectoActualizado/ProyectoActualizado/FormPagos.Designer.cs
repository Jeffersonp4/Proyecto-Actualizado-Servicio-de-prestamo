namespace ProyectoActualizado
{
    partial class FormPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagos));
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtId_cliente = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idClie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCuota = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Pago_total = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(533, 216);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(109, 20);
            this.txtPrestamo.TabIndex = 35;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(246, 215);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(116, 20);
            this.txtFecha.TabIndex = 33;
            // 
            // txtId_cliente
            // 
            this.txtId_cliente.Location = new System.Drawing.Point(246, 176);
            this.txtId_cliente.Name = "txtId_cliente";
            this.txtId_cliente.Size = new System.Drawing.Size(116, 20);
            this.txtId_cliente.TabIndex = 32;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(168, 210);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(72, 25);
            this.fecha.TabIndex = 31;
            this.fecha.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Id_Prestamo";
            // 
            // idClie
            // 
            this.idClie.AutoSize = true;
            this.idClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClie.Location = new System.Drawing.Point(132, 171);
            this.idClie.Name = "idClie";
            this.idClie.Size = new System.Drawing.Size(108, 25);
            this.idClie.TabIndex = 28;
            this.idClie.Text = "Id_Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 274);
            this.dataGridView1.TabIndex = 37;
            // 
            // BtnCuota
            // 
            this.BtnCuota.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCuota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCuota.BorderRadius = 0;
            this.BtnCuota.ButtonText = "Pagar_Cuota";
            this.BtnCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCuota.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCuota.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCuota.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCuota.Iconimage")));
            this.BtnCuota.Iconimage_right = null;
            this.BtnCuota.Iconimage_right_Selected = null;
            this.BtnCuota.Iconimage_Selected = null;
            this.BtnCuota.IconMarginLeft = 0;
            this.BtnCuota.IconMarginRight = 0;
            this.BtnCuota.IconRightVisible = true;
            this.BtnCuota.IconRightZoom = 0D;
            this.BtnCuota.IconVisible = true;
            this.BtnCuota.IconZoom = 90D;
            this.BtnCuota.IsTab = false;
            this.BtnCuota.Location = new System.Drawing.Point(648, 280);
            this.BtnCuota.Name = "BtnCuota";
            this.BtnCuota.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCuota.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnCuota.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCuota.selected = false;
            this.BtnCuota.Size = new System.Drawing.Size(126, 28);
            this.BtnCuota.TabIndex = 38;
            this.BtnCuota.Text = "Pagar_Cuota";
            this.BtnCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCuota.Textcolor = System.Drawing.Color.White;
            this.BtnCuota.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuota.Click += new System.EventHandler(this.BtnCuota_Click);
            // 
            // Btn_Pago_total
            // 
            this.Btn_Pago_total.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Pago_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Pago_total.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Pago_total.BorderRadius = 0;
            this.Btn_Pago_total.ButtonText = "Pago_Total";
            this.Btn_Pago_total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Pago_total.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Pago_total.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Pago_total.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Pago_total.Iconimage")));
            this.Btn_Pago_total.Iconimage_right = null;
            this.Btn_Pago_total.Iconimage_right_Selected = null;
            this.Btn_Pago_total.Iconimage_Selected = null;
            this.Btn_Pago_total.IconMarginLeft = 0;
            this.Btn_Pago_total.IconMarginRight = 0;
            this.Btn_Pago_total.IconRightVisible = true;
            this.Btn_Pago_total.IconRightZoom = 0D;
            this.Btn_Pago_total.IconVisible = true;
            this.Btn_Pago_total.IconZoom = 90D;
            this.Btn_Pago_total.IsTab = false;
            this.Btn_Pago_total.Location = new System.Drawing.Point(5, 281);
            this.Btn_Pago_total.Name = "Btn_Pago_total";
            this.Btn_Pago_total.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Pago_total.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Pago_total.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Pago_total.selected = false;
            this.Btn_Pago_total.Size = new System.Drawing.Size(126, 27);
            this.Btn_Pago_total.TabIndex = 41;
            this.Btn_Pago_total.Text = "Pago_Total";
            this.Btn_Pago_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pago_total.Textcolor = System.Drawing.Color.White;
            this.Btn_Pago_total.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Monto_Pagar $";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(533, 177);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(109, 20);
            this.txtMonto.TabIndex = 34;
            // 
            // cerrar
            // 
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(-4, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 25);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 42;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 601);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.Btn_Pago_total);
            this.Controls.Add(this.BtnCuota);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtId_cliente);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idClie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idClie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCuota;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Pago_total;
        public System.Windows.Forms.TextBox txtPrestamo;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtId_cliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.PictureBox cerrar;
    }
}