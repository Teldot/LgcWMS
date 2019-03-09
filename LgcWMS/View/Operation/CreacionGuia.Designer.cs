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
            this.lConsecutivoCliente = new System.Windows.Forms.Label();
            this.cbConsecutivoCliente = new System.Windows.Forms.ComboBox();
            this.lNombreProveedor = new System.Windows.Forms.Label();
            this.cbNombreProveedor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Remitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMITENTE_DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMITENTE_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Declarado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dice_Contener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elaborado_por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ELABORADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CONSECUTIVO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lConsecutivoCliente
            // 
            this.lConsecutivoCliente.AutoSize = true;
            this.lConsecutivoCliente.Location = new System.Drawing.Point(56, 29);
            this.lConsecutivoCliente.Name = "lConsecutivoCliente";
            this.lConsecutivoCliente.Size = new System.Drawing.Size(101, 13);
            this.lConsecutivoCliente.TabIndex = 0;
            this.lConsecutivoCliente.Text = "Consecutivo Cliente";
            // 
            // cbConsecutivoCliente
            // 
            this.cbConsecutivoCliente.FormattingEnabled = true;
            this.cbConsecutivoCliente.Location = new System.Drawing.Point(163, 26);
            this.cbConsecutivoCliente.Name = "cbConsecutivoCliente";
            this.cbConsecutivoCliente.Size = new System.Drawing.Size(151, 21);
            this.cbConsecutivoCliente.TabIndex = 1;
            this.cbConsecutivoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lNombreProveedor
            // 
            this.lNombreProveedor.AutoSize = true;
            this.lNombreProveedor.Location = new System.Drawing.Point(329, 29);
            this.lNombreProveedor.Name = "lNombreProveedor";
            this.lNombreProveedor.Size = new System.Drawing.Size(96, 13);
            this.lNombreProveedor.TabIndex = 4;
            this.lNombreProveedor.Text = "Nombre Proveedor";
            // 
            // cbNombreProveedor
            // 
            this.cbNombreProveedor.FormattingEnabled = true;
            this.cbNombreProveedor.Location = new System.Drawing.Point(431, 26);
            this.cbNombreProveedor.Name = "cbNombreProveedor";
            this.cbNombreProveedor.Size = new System.Drawing.Size(168, 21);
            this.cbNombreProveedor.TabIndex = 5;
            this.cbNombreProveedor.SelectedIndexChanged += new System.EventHandler(this.cbNombreProveedor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remitente,
            this.REMITENTE_DIRECCION,
            this.REMITENTE_TELEFONO,
            this.Origen_VAL,
            this.ORIGEN,
            this.Nombre_destinatario,
            this.Direccion_Destinatario,
            this.Telefono_Destinatario,
            this.Destino,
            this.DESTINO_VAL,
            this.Unidades,
            this.Valor_Declarado,
            this.Dice_Contener,
            this.Elaborado_por,
            this.COD_ELABORADO,
            this.CONSECUTIVO_CLIENTE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 420);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Remitente
            // 
            this.Remitente.DataPropertyName = "REMITENTE_NOMBRE";
            this.Remitente.HeaderText = "Remitente";
            this.Remitente.Name = "Remitente";
            // 
            // REMITENTE_DIRECCION
            // 
            this.REMITENTE_DIRECCION.DataPropertyName = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.HeaderText = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.Name = "REMITENTE_DIRECCION";
            this.REMITENTE_DIRECCION.Visible = false;
            // 
            // REMITENTE_TELEFONO
            // 
            this.REMITENTE_TELEFONO.DataPropertyName = "REMITENTE_TELEFONO";
            this.REMITENTE_TELEFONO.HeaderText = "REMITENTE_TELEFONO";
            this.REMITENTE_TELEFONO.Name = "REMITENTE_TELEFONO";
            this.REMITENTE_TELEFONO.Visible = false;
            // 
            // Origen_VAL
            // 
            this.Origen_VAL.DataPropertyName = "ORIGEN_VAL";
            this.Origen_VAL.HeaderText = "Origen";
            this.Origen_VAL.Name = "Origen_VAL";
            // 
            // ORIGEN
            // 
            this.ORIGEN.DataPropertyName = "ORIGEN";
            this.ORIGEN.HeaderText = "ORIGEN";
            this.ORIGEN.Name = "ORIGEN";
            this.ORIGEN.Visible = false;
            // 
            // Nombre_destinatario
            // 
            this.Nombre_destinatario.DataPropertyName = "DESTINATARIO_NOMBRE";
            this.Nombre_destinatario.HeaderText = "Nombre";
            this.Nombre_destinatario.Name = "Nombre_destinatario";
            // 
            // Direccion_Destinatario
            // 
            this.Direccion_Destinatario.DataPropertyName = "DESTINATARIO_DIRECCION";
            this.Direccion_Destinatario.HeaderText = "Direccion";
            this.Direccion_Destinatario.Name = "Direccion_Destinatario";
            // 
            // Telefono_Destinatario
            // 
            this.Telefono_Destinatario.DataPropertyName = "DESTINATARIO_TELEFONO";
            this.Telefono_Destinatario.HeaderText = "Telefono";
            this.Telefono_Destinatario.Name = "Telefono_Destinatario";
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "DESTINO_VAL";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // DESTINO_VAL
            // 
            this.DESTINO_VAL.DataPropertyName = "DESTINO";
            this.DESTINO_VAL.HeaderText = "DESTINO_VAL";
            this.DESTINO_VAL.Name = "DESTINO_VAL";
            this.DESTINO_VAL.Visible = false;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "UNIDADES";
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            // 
            // Valor_Declarado
            // 
            this.Valor_Declarado.DataPropertyName = "VALOR_DECLARADO";
            this.Valor_Declarado.HeaderText = "Vr. Declarado";
            this.Valor_Declarado.Name = "Valor_Declarado";
            // 
            // Dice_Contener
            // 
            this.Dice_Contener.DataPropertyName = "DICE_CONTENER";
            this.Dice_Contener.HeaderText = "Dice contener";
            this.Dice_Contener.Name = "Dice_Contener";
            // 
            // Elaborado_por
            // 
            this.Elaborado_por.DataPropertyName = "ELABORADO_POR_VAL";
            this.Elaborado_por.HeaderText = "Elaborado por";
            this.Elaborado_por.Name = "Elaborado_por";
            // 
            // COD_ELABORADO
            // 
            this.COD_ELABORADO.DataPropertyName = "ELABORADO_POR";
            this.COD_ELABORADO.HeaderText = "COD_ELABORADO";
            this.COD_ELABORADO.Name = "COD_ELABORADO";
            this.COD_ELABORADO.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(857, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de envio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso (KG)";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(118, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso Vol.  real (KG)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(139, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Peso liq (kG)";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(118, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observaciones";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(118, 182);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(121, 102);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(118, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "No Guia";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(164, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(55, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 0);
            this.button3.TabIndex = 21;
            this.button3.Text = "Imprimir label";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(182, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Imprimir guia";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(9, 344);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Impresora Label";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Impresora Guia";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(136, 344);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(37, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Imprimir Label";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(823, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 410);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // CONSECUTIVO_CLIENTE
            // 
            this.CONSECUTIVO_CLIENTE.HeaderText = "CONSECUTIVO_CLIENTE";
            this.CONSECUTIVO_CLIENTE.Name = "CONSECUTIVO_CLIENTE";
            // 
            // CreacionGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbNombreProveedor);
            this.Controls.Add(this.lNombreProveedor);
            this.Controls.Add(this.cbConsecutivoCliente);
            this.Controls.Add(this.lConsecutivoCliente);
            this.Name = "CreacionGuia";
            this.Text = "CreacionGuia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConsecutivoCliente;
        private System.Windows.Forms.ComboBox cbConsecutivoCliente;
        private System.Windows.Forms.Label lNombreProveedor;
        private System.Windows.Forms.ComboBox cbNombreProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMITENTE_DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMITENTE_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Declarado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dice_Contener;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elaborado_por;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ELABORADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSECUTIVO_CLIENTE;
    }
}