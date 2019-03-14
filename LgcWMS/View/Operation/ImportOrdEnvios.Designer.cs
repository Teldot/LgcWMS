namespace LgcWMS.View.Operation
{
    partial class ImportOrdEnvios
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
            this.tbRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.dgEnvios = new System.Windows.Forms.DataGridView();
            this.Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consecutvo_AVMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consecutivo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Envio_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Redencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregar_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.tbError = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbWorkSheet = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRutaArchivo
            // 
            this.tbRutaArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRutaArchivo.Location = new System.Drawing.Point(89, 61);
            this.tbRutaArchivo.Name = "tbRutaArchivo";
            this.tbRutaArchivo.ReadOnly = true;
            this.tbRutaArchivo.Size = new System.Drawing.Size(736, 20);
            this.tbRutaArchivo.TabIndex = 0;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarArchivo.Location = new System.Drawing.Point(1081, 87);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(97, 23);
            this.btnCargarArchivo.TabIndex = 1;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // dgEnvios
            // 
            this.dgEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consecutivo,
            this.Consecutvo_AVMK,
            this.Consecutivo_Cliente,
            this.Fecha_Envio_Archivo,
            this.Mes,
            this.Ano,
            this.Fecha_de_Redencion,
            this.Cedula,
            this.Cliente,
            this.Entregar_a,
            this.Direccion,
            this.Ciudad,
            this.Departamento,
            this.Teléfono,
            this.Celular,
            this.Correo_Electronico,
            this.Codigo_Premio,
            this.Premio,
            this.Especificaciones,
            this.Nombre_Proveedor,
            this.Codigo_Proveedor,
            this.Cantidad,
            this.Valor});
            this.dgEnvios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgEnvios.Location = new System.Drawing.Point(12, 197);
            this.dgEnvios.MultiSelect = false;
            this.dgEnvios.Name = "dgEnvios";
            this.dgEnvios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgEnvios.Size = new System.Drawing.Size(1196, 281);
            this.dgEnvios.TabIndex = 2;
            this.dgEnvios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgEnvios.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgEnvios_DataError);
            this.dgEnvios.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgEnvios_RowsAdded);
            this.dgEnvios.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgEnvios_RowsRemoved);
            // 
            // Consecutivo
            // 
            this.Consecutivo.DataPropertyName = "Consecutivo";
            this.Consecutivo.HeaderText = "Consecutivo";
            this.Consecutivo.Name = "Consecutivo";
            // 
            // Consecutvo_AVMK
            // 
            this.Consecutvo_AVMK.DataPropertyName = "Consecutvo AVMK";
            this.Consecutvo_AVMK.HeaderText = "Consecutvo AVMK";
            this.Consecutvo_AVMK.Name = "Consecutvo_AVMK";
            // 
            // Consecutivo_Cliente
            // 
            this.Consecutivo_Cliente.DataPropertyName = "Consecutivo Cliente";
            this.Consecutivo_Cliente.HeaderText = "Consecutivo Cliente";
            this.Consecutivo_Cliente.Name = "Consecutivo_Cliente";
            // 
            // Fecha_Envio_Archivo
            // 
            this.Fecha_Envio_Archivo.DataPropertyName = "Fecha Envio Archivo";
            this.Fecha_Envio_Archivo.HeaderText = "Fecha Envio Archivo";
            this.Fecha_Envio_Archivo.Name = "Fecha_Envio_Archivo";
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Año";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // Fecha_de_Redencion
            // 
            this.Fecha_de_Redencion.DataPropertyName = "Fecha de Redencion";
            this.Fecha_de_Redencion.HeaderText = "Fecha de Redencion";
            this.Fecha_de_Redencion.Name = "Fecha_de_Redencion";
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Entregar_a
            // 
            this.Entregar_a.DataPropertyName = "Entregar a";
            this.Entregar_a.HeaderText = "Entregar a";
            this.Entregar_a.Name = "Entregar_a";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Teléfono
            // 
            this.Teléfono.DataPropertyName = "Teléfono";
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.DataPropertyName = "Correo Electronico";
            this.Correo_Electronico.HeaderText = "Correo Electronico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            // 
            // Codigo_Premio
            // 
            this.Codigo_Premio.DataPropertyName = "Codigo Premio";
            this.Codigo_Premio.HeaderText = "Codigo Premio";
            this.Codigo_Premio.Name = "Codigo_Premio";
            // 
            // Premio
            // 
            this.Premio.DataPropertyName = "Premio";
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            // 
            // Especificaciones
            // 
            this.Especificaciones.DataPropertyName = "Especificaciones";
            this.Especificaciones.HeaderText = "Especificaciones";
            this.Especificaciones.Name = "Especificaciones";
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Nombre Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            // 
            // Codigo_Proveedor
            // 
            this.Codigo_Proveedor.DataPropertyName = "Codigo Proveedor";
            this.Codigo_Proveedor.HeaderText = "Codigo Proveedor";
            this.Codigo_Proveedor.Name = "Codigo_Proveedor";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(131, 30);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(352, 21);
            this.cbCliente.TabIndex = 4;
            this.cbCliente.SelectedValueChanged += new System.EventHandler(this.cbCliente_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1081, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Importar Datos";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(966, 159);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(82, 23);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // tbError
            // 
            this.tbError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbError.Location = new System.Drawing.Point(89, 87);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(986, 66);
            this.tbError.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tbWorkSheet
            // 
            this.tbWorkSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWorkSheet.Location = new System.Drawing.Point(832, 60);
            this.tbWorkSheet.Name = "tbWorkSheet";
            this.tbWorkSheet.Size = new System.Drawing.Size(243, 20);
            this.tbWorkSheet.TabIndex = 8;
            this.tbWorkSheet.Text = "Nombre de la hoja";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.Location = new System.Drawing.Point(1081, 57);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarArchivo.TabIndex = 9;
            this.btnBuscarArchivo.Text = "Buscar Archivo";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // ImportOrdEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 490);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.tbWorkSheet);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEnvios);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.tbRutaArchivo);
            this.Name = "ImportOrdEnvios";
            this.Text = "ImportOrdEnvios";
            this.Load += new System.EventHandler(this.ImportOrdEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRutaArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.DataGridView dgEnvios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbWorkSheet;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutvo_AVMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Envio_Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Redencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregar_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especificaciones;
        private System.Windows.Forms.DataGridViewComboBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}