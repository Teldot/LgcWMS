﻿namespace LgcWMS.View.Access
{
    partial class MainMenu
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
            this.btnRecoleccion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnDespachos = new System.Windows.Forms.Button();
            this.btnImpEnvios = new System.Windows.Forms.Button();
            this.btnAsignRepartos = new System.Windows.Forms.Button();
            this.btnAdmonDespachos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslVer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecoleccion
            // 
            this.btnRecoleccion.Enabled = false;
            this.btnRecoleccion.Location = new System.Drawing.Point(89, 10);
            this.btnRecoleccion.Name = "btnRecoleccion";
            this.btnRecoleccion.Size = new System.Drawing.Size(201, 55);
            this.btnRecoleccion.TabIndex = 0;
            this.btnRecoleccion.Text = "1. Recoleccion";
            this.btnRecoleccion.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Enabled = false;
            this.btnInventario.Location = new System.Drawing.Point(89, 71);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(201, 55);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "2. Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnDespachos
            // 
            this.btnDespachos.Location = new System.Drawing.Point(89, 193);
            this.btnDespachos.Name = "btnDespachos";
            this.btnDespachos.Size = new System.Drawing.Size(201, 55);
            this.btnDespachos.TabIndex = 2;
            this.btnDespachos.Text = "4. Despachos";
            this.btnDespachos.UseVisualStyleBackColor = true;
            this.btnDespachos.Click += new System.EventHandler(this.btnDespachos_Click);
            // 
            // btnImpEnvios
            // 
            this.btnImpEnvios.Location = new System.Drawing.Point(89, 132);
            this.btnImpEnvios.Name = "btnImpEnvios";
            this.btnImpEnvios.Size = new System.Drawing.Size(201, 55);
            this.btnImpEnvios.TabIndex = 3;
            this.btnImpEnvios.Text = "3. Importar Orden de Envios";
            this.btnImpEnvios.UseVisualStyleBackColor = true;
            this.btnImpEnvios.Click += new System.EventHandler(this.btnImpEnvios_Click);
            // 
            // btnAsignRepartos
            // 
            this.btnAsignRepartos.Enabled = false;
            this.btnAsignRepartos.Location = new System.Drawing.Point(89, 254);
            this.btnAsignRepartos.Name = "btnAsignRepartos";
            this.btnAsignRepartos.Size = new System.Drawing.Size(201, 55);
            this.btnAsignRepartos.TabIndex = 4;
            this.btnAsignRepartos.Text = "5. Asignacion Repartos";
            this.btnAsignRepartos.UseVisualStyleBackColor = true;
            // 
            // btnAdmonDespachos
            // 
            this.btnAdmonDespachos.Enabled = false;
            this.btnAdmonDespachos.Location = new System.Drawing.Point(89, 315);
            this.btnAdmonDespachos.Name = "btnAdmonDespachos";
            this.btnAdmonDespachos.Size = new System.Drawing.Size(201, 55);
            this.btnAdmonDespachos.TabIndex = 5;
            this.btnAdmonDespachos.Text = "6. Admon Despachos";
            this.btnAdmonDespachos.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(320, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.AllowMerge = false;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVer,
            this.tsslUser});
            this.ssStatus.Location = new System.Drawing.Point(0, 376);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssStatus.Size = new System.Drawing.Size(407, 22);
            this.ssStatus.TabIndex = 7;
            // 
            // tsslVer
            // 
            this.tsslVer.Name = "tsslVer";
            this.tsslVer.Size = new System.Drawing.Size(27, 17);
            this.tsslVer.Text = "Ver:";
            this.tsslVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(47, 17);
            this.tsslUser.Text = "Usuario:";
            this.tsslUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(407, 398);
            this.ControlBox = false;
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmonDespachos);
            this.Controls.Add(this.btnAsignRepartos);
            this.Controls.Add(this.btnImpEnvios);
            this.Controls.Add(this.btnDespachos);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnRecoleccion);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIL WMS - MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecoleccion;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnDespachos;
        private System.Windows.Forms.Button btnImpEnvios;
        private System.Windows.Forms.Button btnAsignRepartos;
        private System.Windows.Forms.Button btnAdmonDespachos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslVer;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
    }
}