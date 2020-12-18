namespace ProyectoActualizado
{
    partial class FormMovimientosPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimientosPrestamo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActualizaElMovimiento = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMovimiento = new System.Windows.Forms.TextBox();
            this.BtnBuscarEnMovimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualizaElMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.ActualizaElMovimiento);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.txtMovimiento);
            this.panel1.Controls.Add(this.BtnBuscarEnMovimiento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 224);
            this.panel1.TabIndex = 0;
            // 
            // ActualizaElMovimiento
            // 
            this.ActualizaElMovimiento.Image = ((System.Drawing.Image)(resources.GetObject("ActualizaElMovimiento.Image")));
            this.ActualizaElMovimiento.Location = new System.Drawing.Point(508, 190);
            this.ActualizaElMovimiento.Name = "ActualizaElMovimiento";
            this.ActualizaElMovimiento.Size = new System.Drawing.Size(40, 25);
            this.ActualizaElMovimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActualizaElMovimiento.TabIndex = 2;
            this.ActualizaElMovimiento.TabStop = false;
            this.ActualizaElMovimiento.Click += new System.EventHandler(this.ActualizaElMovimiento_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.BorderRadius = 0;
            this.BtnSalir.ButtonText = "Salir";
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Iconimage")));
            this.BtnSalir.Iconimage_right = null;
            this.BtnSalir.Iconimage_right_Selected = null;
            this.BtnSalir.Iconimage_Selected = null;
            this.BtnSalir.IconMarginLeft = 0;
            this.BtnSalir.IconMarginRight = 0;
            this.BtnSalir.IconRightVisible = true;
            this.BtnSalir.IconRightZoom = 0D;
            this.BtnSalir.IconVisible = true;
            this.BtnSalir.IconZoom = 90D;
            this.BtnSalir.IsTab = false;
            this.BtnSalir.Location = new System.Drawing.Point(221, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSalir.selected = false;
            this.BtnSalir.Size = new System.Drawing.Size(79, 29);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Textcolor = System.Drawing.Color.White;
            this.BtnSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtMovimiento
            // 
            this.txtMovimiento.Location = new System.Drawing.Point(396, 190);
            this.txtMovimiento.Multiline = true;
            this.txtMovimiento.Name = "txtMovimiento";
            this.txtMovimiento.Size = new System.Drawing.Size(110, 25);
            this.txtMovimiento.TabIndex = 3;
            // 
            // BtnBuscarEnMovimiento
            // 
            this.BtnBuscarEnMovimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBuscarEnMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBuscarEnMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarEnMovimiento.BorderRadius = 0;
            this.BtnBuscarEnMovimiento.ButtonText = "Buscar_Prestamo";
            this.BtnBuscarEnMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarEnMovimiento.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBuscarEnMovimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBuscarEnMovimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarEnMovimiento.Iconimage")));
            this.BtnBuscarEnMovimiento.Iconimage_right = null;
            this.BtnBuscarEnMovimiento.Iconimage_right_Selected = null;
            this.BtnBuscarEnMovimiento.Iconimage_Selected = null;
            this.BtnBuscarEnMovimiento.IconMarginLeft = 0;
            this.BtnBuscarEnMovimiento.IconMarginRight = 0;
            this.BtnBuscarEnMovimiento.IconRightVisible = true;
            this.BtnBuscarEnMovimiento.IconRightZoom = 0D;
            this.BtnBuscarEnMovimiento.IconVisible = true;
            this.BtnBuscarEnMovimiento.IconZoom = 90D;
            this.BtnBuscarEnMovimiento.IsTab = false;
            this.BtnBuscarEnMovimiento.Location = new System.Drawing.Point(230, 190);
            this.BtnBuscarEnMovimiento.Name = "BtnBuscarEnMovimiento";
            this.BtnBuscarEnMovimiento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBuscarEnMovimiento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnBuscarEnMovimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBuscarEnMovimiento.selected = false;
            this.BtnBuscarEnMovimiento.Size = new System.Drawing.Size(160, 25);
            this.BtnBuscarEnMovimiento.TabIndex = 2;
            this.BtnBuscarEnMovimiento.Text = "Buscar_Prestamo";
            this.BtnBuscarEnMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarEnMovimiento.Textcolor = System.Drawing.Color.White;
            this.BtnBuscarEnMovimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEnMovimiento.Click += new System.EventHandler(this.BtnBuscarEnMovimiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(245, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimientos Prestamos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormMovimientosPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientosPrestamo";
            this.Text = "FormMovimientosPrestamo";
            this.Load += new System.EventHandler(this.FormMovimientosPrestamo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualizaElMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSalir;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBuscarEnMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtMovimiento;
        private System.Windows.Forms.PictureBox ActualizaElMovimiento;
    }
}