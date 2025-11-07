namespace pryGestioInventarioVidela
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbAgregarProd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbBusquedas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaBusq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoBusq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockBusq = new System.Windows.Forms.TextBox();
            this.txtPrecioBusq = new System.Windows.Forms.TextBox();
            this.txtDescripcionBusq = new System.Windows.Forms.TextBox();
            this.txtNombreBusq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbReportes = new System.Windows.Forms.TabPage();
            this.cbReporte = new System.Windows.Forms.GroupBox();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConex = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tbAgregarProd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.tbBusquedas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbReportes.SuspendLayout();
            this.cbReporte.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAgregarProd
            // 
            this.tbAgregarProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAgregarProd.Controls.Add(this.tabPage1);
            this.tbAgregarProd.Controls.Add(this.tbBusquedas);
            this.tbAgregarProd.Controls.Add(this.tbReportes);
            this.tbAgregarProd.Location = new System.Drawing.Point(23, 19);
            this.tbAgregarProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbAgregarProd.Name = "tbAgregarProd";
            this.tbAgregarProd.SelectedIndex = 0;
            this.tbAgregarProd.Size = new System.Drawing.Size(716, 399);
            this.tbAgregarProd.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.mrcDatos);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(708, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Productos";
            // 
            // mrcDatos
            // 
            this.mrcDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcDatos.Controls.Add(this.cmbCategoria);
            this.mrcDatos.Controls.Add(this.btnAgregar);
            this.mrcDatos.Controls.Add(this.txtStock);
            this.mrcDatos.Controls.Add(this.txtDescripcion);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.txtPrecio);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.lblStock);
            this.mrcDatos.Controls.Add(this.lblDescripcion);
            this.mrcDatos.Controls.Add(this.lblCategoria);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lblPrecio);
            this.mrcDatos.Controls.Add(this.txtCodigo);
            this.mrcDatos.Location = new System.Drawing.Point(20, 19);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(669, 284);
            this.mrcDatos.TabIndex = 2;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Enter += new System.EventHandler(this.mrcDatos_Enter);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(161, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(161, 150);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(94, 24);
            this.txtStock.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(161, 104);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(94, 24);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(37, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 21);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "CATEGORÍA:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(161, 68);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(164, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(161, 231);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(276, 24);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(161, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(37, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(73, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 193);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(37, 234);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(118, 21);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCIÓN:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(37, 105);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(37, 151);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(64, 21);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "STOCK:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(514, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbBusquedas
            // 
            this.tbBusquedas.BackColor = System.Drawing.Color.Gray;
            this.tbBusquedas.Controls.Add(this.groupBox1);
            this.tbBusquedas.Location = new System.Drawing.Point(4, 22);
            this.tbBusquedas.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusquedas.Name = "tbBusquedas";
            this.tbBusquedas.Padding = new System.Windows.Forms.Padding(2);
            this.tbBusquedas.Size = new System.Drawing.Size(708, 373);
            this.tbBusquedas.TabIndex = 1;
            this.tbBusquedas.Text = "Modificación y Bajas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbCategoriaBusq);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtStockBusq);
            this.groupBox1.Controls.Add(this.txtPrecioBusq);
            this.groupBox1.Controls.Add(this.txtDescripcionBusq);
            this.groupBox1.Controls.Add(this.txtNombreBusq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbCategoriaBusq
            // 
            this.cmbCategoriaBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaBusq.FormattingEnabled = true;
            this.cmbCategoriaBusq.Location = new System.Drawing.Point(184, 102);
            this.cmbCategoriaBusq.Name = "cmbCategoriaBusq";
            this.cmbCategoriaBusq.Size = new System.Drawing.Size(128, 29);
            this.cmbCategoriaBusq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "CATEGORÍA:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtCodigoBusq);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(329, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoBusq
            // 
            this.txtCodigoBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBusq.Location = new System.Drawing.Point(136, 17);
            this.txtCodigoBusq.Name = "txtCodigoBusq";
            this.txtCodigoBusq.Size = new System.Drawing.Size(128, 27);
            this.txtCodigoBusq.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "CÓDIGO:";
            // 
            // txtStockBusq
            // 
            this.txtStockBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockBusq.Location = new System.Drawing.Point(184, 270);
            this.txtStockBusq.Name = "txtStockBusq";
            this.txtStockBusq.Size = new System.Drawing.Size(133, 27);
            this.txtStockBusq.TabIndex = 6;
            // 
            // txtPrecioBusq
            // 
            this.txtPrecioBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBusq.Location = new System.Drawing.Point(184, 231);
            this.txtPrecioBusq.Name = "txtPrecioBusq";
            this.txtPrecioBusq.Size = new System.Drawing.Size(133, 27);
            this.txtPrecioBusq.TabIndex = 5;
            // 
            // txtDescripcionBusq
            // 
            this.txtDescripcionBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionBusq.Location = new System.Drawing.Point(184, 187);
            this.txtDescripcionBusq.Name = "txtDescripcionBusq";
            this.txtDescripcionBusq.Size = new System.Drawing.Size(354, 27);
            this.txtDescripcionBusq.TabIndex = 4;
            // 
            // txtNombreBusq
            // 
            this.txtNombreBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBusq.Location = new System.Drawing.Point(184, 145);
            this.txtNombreBusq.Name = "txtNombreBusq";
            this.txtNombreBusq.Size = new System.Drawing.Size(354, 27);
            this.txtNombreBusq.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESCRIPCIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "STOCK:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(544, 261);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 40);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificar.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(427, 261);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 40);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbReportes
            // 
            this.tbReportes.BackColor = System.Drawing.Color.Gray;
            this.tbReportes.Controls.Add(this.cbReporte);
            this.tbReportes.Location = new System.Drawing.Point(4, 22);
            this.tbReportes.Margin = new System.Windows.Forms.Padding(2);
            this.tbReportes.Name = "tbReportes";
            this.tbReportes.Padding = new System.Windows.Forms.Padding(2);
            this.tbReportes.Size = new System.Drawing.Size(708, 373);
            this.tbReportes.TabIndex = 2;
            this.tbReportes.Text = "Reportes";
            // 
            // cbReporte
            // 
            this.cbReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbReporte.Controls.Add(this.chartInventario);
            this.cbReporte.Controls.Add(this.dgvProductos);
            this.cbReporte.Controls.Add(this.cboTipoReporte);
            this.cbReporte.Controls.Add(this.btnGenerar);
            this.cbReporte.Location = new System.Drawing.Point(19, 20);
            this.cbReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cbReporte.Name = "cbReporte";
            this.cbReporte.Padding = new System.Windows.Forms.Padding(2);
            this.cbReporte.Size = new System.Drawing.Size(664, 337);
            this.cbReporte.TabIndex = 4;
            this.cbReporte.TabStop = false;
            this.cbReporte.Text = "Reporte";
            this.cbReporte.Enter += new System.EventHandler(this.cbReporte_Enter);
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Location = new System.Drawing.Point(14, 49);
            this.cboTipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(193, 25);
            this.cboTipoReporte.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerar.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(52, 91);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 49);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConex});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConex
            // 
            this.toolStripStatusLabelConex.Name = "toolStripStatusLabelConex";
            this.toolStripStatusLabelConex.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelConex.Text = "toolStripStatusLabel1";
            // 
            // chartInventario
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInventario.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInventario.Legends.Add(legend1);
            this.chartInventario.Location = new System.Drawing.Point(276, 17);
            this.chartInventario.Margin = new System.Windows.Forms.Padding(2);
            this.chartInventario.Name = "chartInventario";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInventario.Series.Add(series1);
            this.chartInventario.Size = new System.Drawing.Size(369, 299);
            this.chartInventario.TabIndex = 6;
            this.chartInventario.Text = "chart1";
            this.chartInventario.Click += new System.EventHandler(this.chartInventario_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(284, 17);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(361, 299);
            this.dgvProductos.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 458);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbAgregarProd);
            this.Name = "frmPrincipal";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbAgregarProd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.tbBusquedas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbReportes.ResumeLayout(false);
            this.cbReporte.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbAgregarProd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tbBusquedas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategoriaBusq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoBusq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockBusq;
        private System.Windows.Forms.TextBox txtPrecioBusq;
        private System.Windows.Forms.TextBox txtDescripcionBusq;
        private System.Windows.Forms.TextBox txtNombreBusq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabPage tbReportes;
        private System.Windows.Forms.GroupBox cbReporte;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventario;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}

