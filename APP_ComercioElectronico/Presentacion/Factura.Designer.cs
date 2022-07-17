namespace Presentacion
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_agregardtg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidaddtg = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.btn_consultar_cliente = new System.Windows.Forms.Button();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.dtg_producto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_categorias = new System.Windows.Forms.ComboBox();
            this.tblCategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBS_ComercioElectronicoDataSet1 = new Presentacion.DBS_ComercioElectronicoDataSet1();
            this.txt_especificaciones = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_consultar_producto = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBS_ComercioElectronicoDataSet = new Presentacion.DBS_ComercioElectronicoDataSet();
            this.tbl_CategoriasTableAdapter = new Presentacion.DBS_ComercioElectronicoDataSetTableAdapters.tbl_CategoriasTableAdapter();
            this.tbl_CategoriasTableAdapter1 = new Presentacion.DBS_ComercioElectronicoDataSet1TableAdapters.tbl_CategoriasTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_producto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBS_ComercioElectronicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBS_ComercioElectronicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de facturación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_agregardtg);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_cantidaddtg);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_nombre_cliente);
            this.panel2.Controls.Add(this.btn_consultar_cliente);
            this.panel2.Controls.Add(this.txt_identificacion);
            this.panel2.Controls.Add(this.dtg_producto);
            this.panel2.Controls.Add(this.btn_facturar);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-2, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 713);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // btn_agregardtg
            // 
            this.btn_agregardtg.BackColor = System.Drawing.SystemColors.Control;
            this.btn_agregardtg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregardtg.Location = new System.Drawing.Point(182, 330);
            this.btn_agregardtg.Name = "btn_agregardtg";
            this.btn_agregardtg.Size = new System.Drawing.Size(98, 32);
            this.btn_agregardtg.TabIndex = 22;
            this.btn_agregardtg.Text = "Agregar";
            this.btn_agregardtg.UseVisualStyleBackColor = false;
            this.btn_agregardtg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cantidad";
            // 
            // txt_cantidaddtg
            // 
            this.txt_cantidaddtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidaddtg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cantidaddtg.Location = new System.Drawing.Point(23, 336);
            this.txt_cantidaddtg.Name = "txt_cantidaddtg";
            this.txt_cantidaddtg.Size = new System.Drawing.Size(153, 26);
            this.txt_cantidaddtg.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.lbl_Subtotal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(388, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 100);
            this.panel4.TabIndex = 21;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.Location = new System.Drawing.Point(79, 10);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(20, 24);
            this.lbl_Subtotal.TabIndex = 1;
            this.lbl_Subtotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Nombre del cliente";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(286, 280);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.ReadOnly = true;
            this.txt_nombre_cliente.Size = new System.Drawing.Size(368, 26);
            this.txt_nombre_cliente.TabIndex = 17;
            // 
            // btn_consultar_cliente
            // 
            this.btn_consultar_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_consultar_cliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_cliente.Location = new System.Drawing.Point(182, 280);
            this.btn_consultar_cliente.Name = "btn_consultar_cliente";
            this.btn_consultar_cliente.Size = new System.Drawing.Size(98, 26);
            this.btn_consultar_cliente.TabIndex = 15;
            this.btn_consultar_cliente.Text = "Consultar";
            this.btn_consultar_cliente.UseVisualStyleBackColor = false;
            this.btn_consultar_cliente.Click += new System.EventHandler(this.btn_consultar_cliente_Click);
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_identificacion.Location = new System.Drawing.Point(23, 280);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(153, 26);
            this.txt_identificacion.TabIndex = 16;
            // 
            // dtg_producto
            // 
            this.dtg_producto.AllowUserToAddRows = false;
            this.dtg_producto.AllowUserToDeleteRows = false;
            this.dtg_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2});
            this.dtg_producto.Location = new System.Drawing.Point(23, 368);
            this.dtg_producto.Name = "dtg_producto";
            this.dtg_producto.Size = new System.Drawing.Size(631, 150);
            this.dtg_producto.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio_Unidad";
            this.Column2.Name = "Column2";
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_facturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.Location = new System.Drawing.Point(186, 524);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(143, 66);
            this.btn_facturar.TabIndex = 9;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(27, 524);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(141, 66);
            this.btn_nuevo.TabIndex = 7;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbx_categorias);
            this.panel3.Controls.Add(this.txt_especificaciones);
            this.panel3.Controls.Add(this.txt_fecha);
            this.panel3.Controls.Add(this.txt_codigo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_cantidad);
            this.panel3.Controls.Add(this.btn_consultar_producto);
            this.panel3.Controls.Add(this.txt_precio);
            this.panel3.Controls.Add(this.txt_nombre_producto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel3.Size = new System.Drawing.Size(670, 593);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(650, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Información del producto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Especificaciones";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Categoría";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cantidad";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Identificación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre del producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Código ";
            // 
            // cbx_categorias
            // 
            this.cbx_categorias.DataSource = this.tblCategoriasBindingSource1;
            this.cbx_categorias.DisplayMember = "Descripcion";
            this.cbx_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categorias.FormattingEnabled = true;
            this.cbx_categorias.Location = new System.Drawing.Point(12, 143);
            this.cbx_categorias.Name = "cbx_categorias";
            this.cbx_categorias.Size = new System.Drawing.Size(263, 28);
            this.cbx_categorias.TabIndex = 9;
            this.cbx_categorias.ValueMember = "PKCodigo";
            // 
            // tblCategoriasBindingSource1
            // 
            this.tblCategoriasBindingSource1.DataMember = "tbl_Categorias";
            this.tblCategoriasBindingSource1.DataSource = this.dBS_ComercioElectronicoDataSet1;
            // 
            // dBS_ComercioElectronicoDataSet1
            // 
            this.dBS_ComercioElectronicoDataSet1.DataSetName = "DBS_ComercioElectronicoDataSet1";
            this.dBS_ComercioElectronicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_especificaciones
            // 
            this.txt_especificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_especificaciones.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_especificaciones.Location = new System.Drawing.Point(12, 196);
            this.txt_especificaciones.Name = "txt_especificaciones";
            this.txt_especificaciones.ReadOnly = true;
            this.txt_especificaciones.Size = new System.Drawing.Size(638, 26);
            this.txt_especificaciones.TabIndex = 10;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_fecha.Location = new System.Drawing.Point(282, 143);
            this.txt_fecha.Multiline = true;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(369, 28);
            this.txt_fecha.TabIndex = 8;
            this.txt_fecha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_codigo.Location = new System.Drawing.Point(12, 53);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(160, 26);
            this.txt_codigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Información del cliente";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AccessibleName = "";
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cantidad.Location = new System.Drawing.Point(282, 98);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(369, 26);
            this.txt_cantidad.TabIndex = 5;
            // 
            // btn_consultar_producto
            // 
            this.btn_consultar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_consultar_producto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_producto.Location = new System.Drawing.Point(178, 53);
            this.btn_consultar_producto.Name = "btn_consultar_producto";
            this.btn_consultar_producto.Size = new System.Drawing.Size(98, 26);
            this.btn_consultar_producto.TabIndex = 2;
            this.btn_consultar_producto.Text = "Consultar";
            this.btn_consultar_producto.UseVisualStyleBackColor = false;
            this.btn_consultar_producto.Click += new System.EventHandler(this.btn_consultar_producto_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_precio.Location = new System.Drawing.Point(12, 98);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.ReadOnly = true;
            this.txt_precio.Size = new System.Drawing.Size(264, 26);
            this.txt_precio.TabIndex = 3;
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nombre_producto.Location = new System.Drawing.Point(282, 53);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.ReadOnly = true;
            this.txt_nombre_producto.Size = new System.Drawing.Size(369, 26);
            this.txt_nombre_producto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 577);
            this.label2.TabIndex = 0;
            this.label2.Text = "Información del producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tblCategoriasBindingSource
            // 
            this.tblCategoriasBindingSource.DataMember = "tbl_Categorias";
            this.tblCategoriasBindingSource.DataSource = this.dBS_ComercioElectronicoDataSet;
            // 
            // dBS_ComercioElectronicoDataSet
            // 
            this.dBS_ComercioElectronicoDataSet.DataSetName = "DBS_ComercioElectronicoDataSet";
            this.dBS_ComercioElectronicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CategoriasTableAdapter
            // 
            this.tbl_CategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CategoriasTableAdapter1
            // 
            this.tbl_CategoriasTableAdapter1.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Factura";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_producto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBS_ComercioElectronicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBS_ComercioElectronicoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_consultar_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ComboBox cbx_categorias;
        private System.Windows.Forms.TextBox txt_fecha;
        private DBS_ComercioElectronicoDataSet dBS_ComercioElectronicoDataSet;
        private System.Windows.Forms.BindingSource tblCategoriasBindingSource;
        private DBS_ComercioElectronicoDataSetTableAdapters.tbl_CategoriasTableAdapter tbl_CategoriasTableAdapter;
        private System.Windows.Forms.TextBox txt_especificaciones;
        private DBS_ComercioElectronicoDataSet1 dBS_ComercioElectronicoDataSet1;
        private System.Windows.Forms.BindingSource tblCategoriasBindingSource1;
        private DBS_ComercioElectronicoDataSet1TableAdapters.tbl_CategoriasTableAdapter tbl_CategoriasTableAdapter1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtg_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Button btn_consultar_cliente;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Button btn_agregardtg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cantidaddtg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

