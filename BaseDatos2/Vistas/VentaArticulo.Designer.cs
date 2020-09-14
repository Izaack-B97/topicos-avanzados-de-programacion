namespace BaseDatos2.Vistas
{
    partial class VentaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaArticulo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botAgregarVenta = new System.Windows.Forms.ToolStripButton();
            this.botAgregarArticulo = new System.Windows.Forms.ToolStripButton();
            this.botGenerarXML = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            this.botInsertarActualizar = new System.Windows.Forms.ToolStripButton();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this._IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this._IDArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.txtIDArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botAgregarVenta,
            this.botAgregarArticulo,
            this.botGenerarXML,
            this.botCerrar,
            this.botInsertarActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // botAgregarVenta
            // 
            this.botAgregarVenta.Image = ((System.Drawing.Image)(resources.GetObject("botAgregarVenta.Image")));
            this.botAgregarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botAgregarVenta.Name = "botAgregarVenta";
            this.botAgregarVenta.Size = new System.Drawing.Size(101, 22);
            this.botAgregarVenta.Text = "Agregar Venta";
            this.botAgregarVenta.Click += new System.EventHandler(this.botAgregarVenta_Click);
            // 
            // botAgregarArticulo
            // 
            this.botAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("botAgregarArticulo.Image")));
            this.botAgregarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botAgregarArticulo.Name = "botAgregarArticulo";
            this.botAgregarArticulo.Size = new System.Drawing.Size(114, 22);
            this.botAgregarArticulo.Text = "Agregar Articulo";
            this.botAgregarArticulo.Click += new System.EventHandler(this.botAgregarArticulo_Click);
            // 
            // botGenerarXML
            // 
            this.botGenerarXML.Image = ((System.Drawing.Image)(resources.GetObject("botGenerarXML.Image")));
            this.botGenerarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botGenerarXML.Name = "botGenerarXML";
            this.botGenerarXML.Size = new System.Drawing.Size(95, 22);
            this.botGenerarXML.Text = "Generar XML";
            this.botGenerarXML.Click += new System.EventHandler(this.botGenerarXML_Click);
            // 
            // botCerrar
            // 
            this.botCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.botCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botCerrar.Image")));
            this.botCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCerrar.Name = "botCerrar";
            this.botCerrar.Size = new System.Drawing.Size(59, 22);
            this.botCerrar.Text = "Cerrar";
            this.botCerrar.Click += new System.EventHandler(this.botCerrar_Click);
            // 
            // botInsertarActualizar
            // 
            this.botInsertarActualizar.Image = ((System.Drawing.Image)(resources.GetObject("botInsertarActualizar.Image")));
            this.botInsertarActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botInsertarActualizar.Name = "botInsertarActualizar";
            this.botInsertarActualizar.Size = new System.Drawing.Size(121, 22);
            this.botInsertarActualizar.Text = "Insertar Actualizar";
            this.botInsertarActualizar.Click += new System.EventHandler(this.botInsertarActualizar_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IDVenta,
            this._Fecha});
            this.dgvVenta.Location = new System.Drawing.Point(16, 28);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.Size = new System.Drawing.Size(549, 89);
            this.dgvVenta.TabIndex = 1;
            this.dgvVenta.SelectionChanged += new System.EventHandler(this.dgvVenta_SelectionChanged);
            // 
            // _IDVenta
            // 
            this._IDVenta.HeaderText = "IDVenta";
            this._IDVenta.Name = "_IDVenta";
            this._IDVenta.ReadOnly = true;
            // 
            // _Fecha
            // 
            this._Fecha.HeaderText = "Fecha";
            this._Fecha.Name = "_Fecha";
            this._Fecha.ReadOnly = true;
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IDArticulo,
            this._NombreArticulo,
            this._Cantidad,
            this._Precio});
            this.dgvArticulo.Location = new System.Drawing.Point(16, 216);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.Size = new System.Drawing.Size(549, 150);
            this.dgvArticulo.TabIndex = 2;
            // 
            // _IDArticulo
            // 
            this._IDArticulo.HeaderText = "IDArticulo";
            this._IDArticulo.Name = "_IDArticulo";
            this._IDArticulo.ReadOnly = true;
            // 
            // _NombreArticulo
            // 
            this._NombreArticulo.HeaderText = "Nombre Artículo";
            this._NombreArticulo.Name = "_NombreArticulo";
            this._NombreArticulo.ReadOnly = true;
            // 
            // _Cantidad
            // 
            this._Cantidad.HeaderText = "Cantidad";
            this._Cantidad.Name = "_Cantidad";
            this._Cantidad.ReadOnly = true;
            // 
            // _Precio
            // 
            this._Precio.HeaderText = "Precio";
            this._Precio.Name = "_Precio";
            this._Precio.ReadOnly = true;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(106, 187);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.ReadOnly = true;
            this.txtNombreArticulo.Size = new System.Drawing.Size(205, 20);
            this.txtNombreArticulo.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(374, 187);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(497, 187);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(68, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Artículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(16, 372);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(549, 161);
            this.txtXML.TabIndex = 9;
            // 
            // txtIDArticulo
            // 
            this.txtIDArticulo.Location = new System.Drawing.Point(106, 139);
            this.txtIDArticulo.Name = "txtIDArticulo";
            this.txtIDArticulo.Size = new System.Drawing.Size(57, 20);
            this.txtIDArticulo.TabIndex = 10;
            this.txtIDArticulo.Text = "0";
            this.txtIDArticulo.TextChanged += new System.EventHandler(this.txtIDArticulo_TextChanged);
            this.txtIDArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDArticulo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "IDArticulo:";
            // 
            // VentaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDArticulo);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VentaArticulo";
            this.Text = "VentaArticulo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botAgregarVenta;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.ToolStripButton botAgregarArticulo;
        private System.Windows.Forms.ToolStripButton botGenerarXML;
        private System.Windows.Forms.ToolStripButton botCerrar;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Precio;
        private System.Windows.Forms.ToolStripButton botInsertarActualizar;
        private System.Windows.Forms.TextBox txtIDArticulo;
        private System.Windows.Forms.Label label4;
    }
}