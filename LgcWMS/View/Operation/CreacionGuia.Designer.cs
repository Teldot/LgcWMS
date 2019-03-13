namespace LgcWMS.View.Operation
{
    partial class CreacionGuia
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsecClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.dgvDespachos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPesoRealVol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPesoLiq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbGuia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrintGuia = new System.Windows.Forms.Button();
            this.cbPrinterLabel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPrinterGuia = new System.Windows.Forms.ComboBox();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPlanilla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGuiaData = new System.Windows.Forms.GroupBox();
            this.Imp_Etqueta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONSECUTIVO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESPACHO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSECUTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REDENCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PREMIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREMIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMITENTE_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMITENTE_DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGEN_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Declarado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUIA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespachos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbGuiaData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo:";
            // 
            // cbConsecClient
            // 
            this.cbConsecClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsecClient.FormattingEnabled = true;
            this.cbConsecClient.Location = new System.Drawing.Point(114, 19);
            this.cbConsecClient.Name = "cbConsecClient";
            this.cbConsecClient.Size = new System.Drawing.Size(168, 21);
            this.cbConsecClient.TabIndex = 1;
            this.cbConsecClient.SelectedIndexChanged += new System.EventHandler(this.cbConsecutivo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Proveedor:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(114, 46);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(168, 21);
            this.cbProveedor.TabIndex = 5;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // dgvDespachos
            // 
            this.dgvDespachos.AllowUserToAddRows = false;
            this.dgvDespachos.AllowUserToDeleteRows = false;
            this.dgvDespachos.AllowUserToOrderColumns = true;
            this.dgvDespachos.AllowUserToResizeRows = false;
            this.dgvDespachos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespachos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDespachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespachos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imp_Etqueta,
            this.CONSECUTIVO_CLIENTE,
            this.DESPACHO_ID,
            this.CONSECUTIVO,
            this.FECHA_REDENCION,
            this.CODIGO_PREMIO,
            this.PREMIO,
            this.Remitente,
            this.REMITENTE_VAL,
            this.REMITENTE_DIRECCION,
            this.Origen,
            this.ORIGEN_VAL,
            this.Nombre_destinatario,
            this.Direccion_Destinatario,
            this.Telefono_Destinatario,
            this.Destino_Id,
            this.DESTINO_VAL,
            this.Unidades,
            this.Valor_Declarado,
            this.GUIA_ID,
            this.GUIA});
            this.dgvDespachos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDespachos.Location = new System.Drawing.Point(29, 108);
            this.dgvDespachos.MultiSelect = false;
            this.dgvDespachos.Name = "dgvDespachos";
            this.dgvDespachos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespachos.Size = new System.Drawing.Size(789, 391);
            this.dgvDespachos.TabIndex = 6;
            this.dgvDespachos.SelectionChanged += new System.EventHandler(this.dgvDespachos_SelectionChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de envio";
            // 
            // dtFechaEnvio
            // 
            this.dtFechaEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEnvio.Location = new System.Drawing.Point(130, 45);
            this.dtFechaEnvio.Name = "dtFechaEnvio";
            this.dtFechaEnvio.Size = new System.Drawing.Size(123, 20);
            this.dtFechaEnvio.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso (KG)";
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPeso.Location = new System.Drawing.Point(130, 71);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(123, 20);
            this.tbPeso.TabIndex = 2;
            this.tbPeso.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso Vol.  real (KG)";
            // 
            // tbPesoRealVol
            // 
            this.tbPesoRealVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesoRealVol.Location = new System.Drawing.Point(151, 97);
            this.tbPesoRealVol.Name = "tbPesoRealVol";
            this.tbPesoRealVol.Size = new System.Drawing.Size(102, 20);
            this.tbPesoRealVol.TabIndex = 3;
            this.tbPesoRealVol.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPesoRealVol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Peso liquidado (kG)";
            // 
            // tbPesoLiq
            // 
            this.tbPesoLiq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesoLiq.Location = new System.Drawing.Point(130, 123);
            this.tbPesoLiq.Name = "tbPesoLiq";
            this.tbPesoLiq.ReadOnly = true;
            this.tbPesoLiq.Size = new System.Drawing.Size(123, 20);
            this.tbPesoLiq.TabIndex = 15;
            this.tbPesoLiq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbObservaciones.Location = new System.Drawing.Point(130, 149);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservaciones.Size = new System.Drawing.Size(123, 102);
            this.tbObservaciones.TabIndex = 4;
            // 
            // tbGuia
            // 
            this.tbGuia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGuia.Location = new System.Drawing.Point(130, 19);
            this.tbGuia.Name = "tbGuia";
            this.tbGuia.Size = new System.Drawing.Size(123, 20);
            this.tbGuia.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "No Guia";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(176, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(55, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 0);
            this.button3.TabIndex = 21;
            this.button3.Text = "Imprimir label";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPrintGuia
            // 
            this.btnPrintGuia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintGuia.Enabled = false;
            this.btnPrintGuia.Location = new System.Drawing.Point(182, 347);
            this.btnPrintGuia.Name = "btnPrintGuia";
            this.btnPrintGuia.Size = new System.Drawing.Size(75, 23);
            this.btnPrintGuia.TabIndex = 9;
            this.btnPrintGuia.Text = "Imprimir guia";
            this.btnPrintGuia.UseVisualStyleBackColor = true;
            this.btnPrintGuia.Click += new System.EventHandler(this.btnPrintGuia_Click);
            // 
            // cbPrinterLabel
            // 
            this.cbPrinterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrinterLabel.FormattingEnabled = true;
            this.cbPrinterLabel.Location = new System.Drawing.Point(9, 320);
            this.cbPrinterLabel.Name = "cbPrinterLabel";
            this.cbPrinterLabel.Size = new System.Drawing.Size(121, 21);
            this.cbPrinterLabel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Impresora Label";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Impresora Guia";
            // 
            // cbPrinterGuia
            // 
            this.cbPrinterGuia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrinterGuia.FormattingEnabled = true;
            this.cbPrinterGuia.Location = new System.Drawing.Point(136, 320);
            this.cbPrinterGuia.Name = "cbPrinterGuia";
            this.cbPrinterGuia.Size = new System.Drawing.Size(121, 21);
            this.cbPrinterGuia.TabIndex = 8;
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintLabel.Enabled = false;
            this.btnPrintLabel.Location = new System.Drawing.Point(37, 347);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(93, 23);
            this.btnPrintLabel.TabIndex = 7;
            this.btnPrintLabel.Text = "Imprimir Label";
            this.btnPrintLabel.UseVisualStyleBackColor = true;
            this.btnPrintLabel.Click += new System.EventHandler(this.btnPrintLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gbGuiaData);
            this.groupBox1.Controls.Add(this.btnPrintLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbPrinterGuia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbPrinterLabel);
            this.groupBox1.Controls.Add(this.btnPrintGuia);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(824, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 391);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPlanilla);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbConsecClient);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbProveedor);
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 83);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // cbPlanilla
            // 
            this.cbPlanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanilla.FormattingEnabled = true;
            this.cbPlanilla.Location = new System.Drawing.Point(391, 19);
            this.cbPlanilla.Name = "cbPlanilla";
            this.cbPlanilla.Size = new System.Drawing.Size(168, 21);
            this.cbPlanilla.TabIndex = 7;
            this.cbPlanilla.SelectedIndexChanged += new System.EventHandler(this.cbPlanilla_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Planilla #:";
            // 
            // gbGuiaData
            // 
            this.gbGuiaData.Controls.Add(this.tbGuia);
            this.gbGuiaData.Controls.Add(this.tbObservaciones);
            this.gbGuiaData.Controls.Add(this.tbPesoRealVol);
            this.gbGuiaData.Controls.Add(this.tbPeso);
            this.gbGuiaData.Controls.Add(this.label4);
            this.gbGuiaData.Controls.Add(this.label7);
            this.gbGuiaData.Controls.Add(this.label6);
            this.gbGuiaData.Controls.Add(this.label9);
            this.gbGuiaData.Controls.Add(this.label5);
            this.gbGuiaData.Controls.Add(this.btnSave);
            this.gbGuiaData.Controls.Add(this.label8);
            this.gbGuiaData.Controls.Add(this.tbPesoLiq);
            this.gbGuiaData.Controls.Add(this.dtFechaEnvio);
            this.gbGuiaData.Location = new System.Drawing.Point(6, 8);
            this.gbGuiaData.Name = "gbGuiaData";
            this.gbGuiaData.Size = new System.Drawing.Size(259, 293);
            this.gbGuiaData.TabIndex = 32;
            this.gbGuiaData.TabStop = false;
            // 
            // Imp_Etqueta
            // 
            this.Imp_Etqueta.HeaderText = "Imp Etqueta";
            this.Imp_Etqueta.Name = "Imp_Etqueta";
            this.Imp_Etqueta.Width = 70;
            // 
            // CONSECUTIVO_CLIENTE
            // 
            this.CONSECUTIVO_CLIENTE.DataPropertyName = "CONSECUTIVO_CLIENTE";
            this.CONSECUTIVO_CLIENTE.HeaderText = "CONSECUTIVO_CLIENTE";
            this.CONSECUTIVO_CLIENTE.Name = "CONSECUTIVO_CLIENTE";
            this.CONSECUTIVO_CLIENTE.Width = 160;
            // 
            // DESPACHO_ID
            // 
            this.DESPACHO_ID.DataPropertyName = "DESPACHO_ID";
            this.DESPACHO_ID.HeaderText = "DESPACHO_ID";
            this.DESPACHO_ID.Name = "DESPACHO_ID";
            this.DESPACHO_ID.Visible = false;
            this.DESPACHO_ID.Width = 108;
            // 
            // CONSECUTIVO
            // 
            this.CONSECUTIVO.DataPropertyName = "CONSECUTIVO";
            this.CONSECUTIVO.HeaderText = "CONSECUTIVO";
            this.CONSECUTIVO.Name = "CONSECUTIVO";
            this.CONSECUTIVO.Width = 109;
            // 
            // FECHA_REDENCION
            // 
            this.FECHA_REDENCION.DataPropertyName = "FECHA_REDENCION";
            this.FECHA_REDENCION.HeaderText = "FECHA_REDENCION";
            this.FECHA_REDENCION.Name = "FECHA_REDENCION";
            this.FECHA_REDENCION.Width = 137;
            // 
            // CODIGO_PREMIO
            // 
            this.CODIGO_PREMIO.DataPropertyName = "CODIGO_PREMIO";
            this.CODIGO_PREMIO.HeaderText = "CODIGO_PREMIO";
            this.CODIGO_PREMIO.Name = "CODIGO_PREMIO";
            this.CODIGO_PREMIO.Width = 122;
            // 
            // PREMIO
            // 
            this.PREMIO.DataPropertyName = "PREMIO";
            this.PREMIO.HeaderText = "PREMIO";
            this.PREMIO.Name = "PREMIO";
            this.PREMIO.Width = 74;
            // 
            // Remitente
            // 
            this.Remitente.DataPropertyName = "REMITENTE_NOMBRE";
            this.Remitente.HeaderText = "REMITENTE";
            this.Remitente.Name = "Remitente";
            this.Remitente.Visible = false;
            this.Remitente.Width = 95;
            // 
            // REMITENTE_VAL
            // 
            this.REMITENTE_VAL.DataPropertyName = "REMITENTE_VAL";
            this.REMITENTE_VAL.HeaderText = "REMITENTE_VAL";
            this.REMITENTE_VAL.Name = "REMITENTE_VAL";
            this.REMITENTE_VAL.Width = 121;
            // 
            // REMITENTE_DIRECCION
            // 
            this.REMITENTE_DIRECCION.DataPropertyName = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.HeaderText = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.Name = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.Visible = false;
            this.REMITENTE_DIRECCION.Width = 160;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "ORIGEN_ID";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.Visible = false;
            this.Origen.Width = 63;
            // 
            // ORIGEN_VAL
            // 
            this.ORIGEN_VAL.DataPropertyName = "ORIGEN";
            this.ORIGEN_VAL.HeaderText = "ORIGEN";
            this.ORIGEN_VAL.Name = "ORIGEN_VAL";
            this.ORIGEN_VAL.Width = 74;
            // 
            // Nombre_destinatario
            // 
            this.Nombre_destinatario.DataPropertyName = "DESTINATARIO_NOMBRE";
            this.Nombre_destinatario.HeaderText = "NOMBRE";
            this.Nombre_destinatario.Name = "Nombre_destinatario";
            this.Nombre_destinatario.Width = 79;
            // 
            // Direccion_Destinatario
            // 
            this.Direccion_Destinatario.DataPropertyName = "DESTINATARIO_DIRECCION";
            this.Direccion_Destinatario.HeaderText = "DIRECCION";
            this.Direccion_Destinatario.Name = "Direccion_Destinatario";
            this.Direccion_Destinatario.Width = 91;
            // 
            // Telefono_Destinatario
            // 
            this.Telefono_Destinatario.DataPropertyName = "DESTINATARIO_TELEFONO";
            this.Telefono_Destinatario.HeaderText = "TELEFONO";
            this.Telefono_Destinatario.Name = "Telefono_Destinatario";
            this.Telefono_Destinatario.Width = 89;
            // 
            // Destino_Id
            // 
            this.Destino_Id.DataPropertyName = "DESTINO_ID";
            this.Destino_Id.HeaderText = "Destino";
            this.Destino_Id.Name = "Destino_Id";
            this.Destino_Id.Visible = false;
            this.Destino_Id.Width = 68;
            // 
            // DESTINO_VAL
            // 
            this.DESTINO_VAL.DataPropertyName = "DESTINO";
            this.DESTINO_VAL.HeaderText = "Destino";
            this.DESTINO_VAL.Name = "DESTINO_VAL";
            this.DESTINO_VAL.Width = 68;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "UNIDADES";
            this.Unidades.HeaderText = "Cantidad";
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 74;
            // 
            // Valor_Declarado
            // 
            this.Valor_Declarado.DataPropertyName = "VALOR";
            this.Valor_Declarado.HeaderText = "Vr. Declarado";
            this.Valor_Declarado.Name = "Valor_Declarado";
            this.Valor_Declarado.Width = 97;
            // 
            // GUIA_ID
            // 
            this.GUIA_ID.DataPropertyName = "GUIA_ID";
            this.GUIA_ID.HeaderText = "GUIA_ID";
            this.GUIA_ID.Name = "GUIA_ID";
            this.GUIA_ID.Visible = false;
            this.GUIA_ID.Width = 75;
            // 
            // GUIA
            // 
            this.GUIA.DataPropertyName = "GUIA";
            this.GUIA.HeaderText = "GUIA";
            this.GUIA.Name = "GUIA";
            this.GUIA.Width = 58;
            // 
            // CreacionGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDespachos);
            this.Name = "CreacionGuia";
            this.Text = "CreacionDespachos";
            this.Load += new System.EventHandler(this.CreacionGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespachos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbGuiaData.ResumeLayout(false);
            this.gbGuiaData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsecClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.DataGridView dgvDespachos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaEnvio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPesoRealVol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPesoLiq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbGuia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrintGuia;
        private System.Windows.Forms.ComboBox cbPrinterLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPrinterGuia;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPlanilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGuiaData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imp_Etqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSECUTIVO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESPACHO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSECUTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REDENCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PREMIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREMIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMITENTE_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMITENTE_DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEN_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Declarado;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIA;
    }
}