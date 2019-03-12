namespace LgcWMS.View.Operation
{
    partial class IngMovInv
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPocision = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bExportar = new System.Windows.Forms.Button();
            this.bMovimiento = new System.Windows.Forms.Button();
            this.tbCampoValidar = new System.Windows.Forms.TextBox();
            this.lCampoValidar = new System.Windows.Forms.Label();
            this.tbValorValidar = new System.Windows.Forms.TextBox();
            this.lValorValidar = new System.Windows.Forms.Label();
            this.Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_recogida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Validar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Movimiento";
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(112, 19);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(200, 21);
            this.cbTipoMovimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(112, 46);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(200, 21);
            this.cbProducto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(112, 76);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(200, 20);
            this.tbCantidad.TabIndex = 9;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(289, 348);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 15;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Movimiento,
            this.Orden_recogida,
            this.Producto,
            this.Cantidad,
            this.POSICION,
            this.Campo_Validar});
            this.dataGridView1.Location = new System.Drawing.Point(372, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 268);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbValorValidar);
            this.groupBox2.Controls.Add(this.lValorValidar);
            this.groupBox2.Controls.Add(this.tbCampoValidar);
            this.groupBox2.Controls.Add(this.lCampoValidar);
            this.groupBox2.Controls.Add(this.tbCantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTipoMovimiento);
            this.groupBox2.Controls.Add(this.cbProducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(30, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 162);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cbPocision
            // 
            this.cbPocision.FormattingEnabled = true;
            this.cbPocision.Location = new System.Drawing.Point(136, 49);
            this.cbPocision.Name = "cbPocision";
            this.cbPocision.Size = new System.Drawing.Size(163, 21);
            this.cbPocision.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modificar posicion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Posicion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPocision);
            this.groupBox1.Location = new System.Drawing.Point(30, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(899, 36);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(75, 23);
            this.bExportar.TabIndex = 18;
            this.bExportar.Text = "Exportar";
            this.bExportar.UseVisualStyleBackColor = true;
            // 
            // bMovimiento
            // 
            this.bMovimiento.Location = new System.Drawing.Point(899, 65);
            this.bMovimiento.Name = "bMovimiento";
            this.bMovimiento.Size = new System.Drawing.Size(107, 23);
            this.bMovimiento.TabIndex = 19;
            this.bMovimiento.Text = "Movimiento Prod";
            this.bMovimiento.UseVisualStyleBackColor = true;
            // 
            // tbCampoValidar
            // 
            this.tbCampoValidar.ForeColor = System.Drawing.Color.Red;
            this.tbCampoValidar.Location = new System.Drawing.Point(112, 102);
            this.tbCampoValidar.Name = "tbCampoValidar";
            this.tbCampoValidar.ReadOnly = true;
            this.tbCampoValidar.Size = new System.Drawing.Size(200, 20);
            this.tbCampoValidar.TabIndex = 11;
            // 
            // lCampoValidar
            // 
            this.lCampoValidar.AutoSize = true;
            this.lCampoValidar.Location = new System.Drawing.Point(20, 105);
            this.lCampoValidar.Name = "lCampoValidar";
            this.lCampoValidar.Size = new System.Drawing.Size(84, 13);
            this.lCampoValidar.TabIndex = 10;
            this.lCampoValidar.Text = "Campo a Validar";
            // 
            // tbValorValidar
            // 
            this.tbValorValidar.Location = new System.Drawing.Point(112, 128);
            this.tbValorValidar.Name = "tbValorValidar";
            this.tbValorValidar.Size = new System.Drawing.Size(200, 20);
            this.tbValorValidar.TabIndex = 13;
            // 
            // lValorValidar
            // 
            this.lValorValidar.AutoSize = true;
            this.lValorValidar.Location = new System.Drawing.Point(20, 131);
            this.lValorValidar.Name = "lValorValidar";
            this.lValorValidar.Size = new System.Drawing.Size(75, 13);
            this.lValorValidar.TabIndex = 12;
            this.lValorValidar.Text = "Valor a Validar";
            // 
            // Tipo_Movimiento
            // 
            this.Tipo_Movimiento.DataPropertyName = "TIPO";
            this.Tipo_Movimiento.HeaderText = "TIPO MOVIMIENTO";
            this.Tipo_Movimiento.Name = "Tipo_Movimiento";
            // 
            // Orden_recogida
            // 
            this.Orden_recogida.DataPropertyName = "RECOLECCION_ID";
            this.Orden_recogida.HeaderText = "ORDEN RECOGIDA";
            this.Orden_recogida.Name = "Orden_recogida";
            this.Orden_recogida.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "PRODUCTO";
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "CANTIDAD";
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            // 
            // POSICION
            // 
            this.POSICION.HeaderText = "POSICION";
            this.POSICION.Name = "POSICION";
            // 
            // Campo_Validar
            // 
            this.Campo_Validar.HeaderText = "CAMPO A VALIDAR";
            this.Campo_Validar.Name = "Campo_Validar";
            // 
            // IngMovInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 422);
            this.Controls.Add(this.bMovimiento);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngMovInv";
            this.Text = "Ingreso o movimiento Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPocision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.Button bMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_recogida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Campo_Validar;
        private System.Windows.Forms.TextBox tbValorValidar;
        private System.Windows.Forms.Label lValorValidar;
        private System.Windows.Forms.TextBox tbCampoValidar;
        private System.Windows.Forms.Label lCampoValidar;
    }
}