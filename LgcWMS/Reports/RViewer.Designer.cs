namespace LgcWMS.Reports
{
    partial class RViewer
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
            this.components = new System.ComponentModel.Container();
            this.V_GUIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.V_GUIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // V_GUIABindingSource
            // 
            this.V_GUIABindingSource.DataSource = typeof(LgcWMS.Data.Model.V_GUIA);
            // 
            // rv
            // 
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(507, 345);
            this.rv.TabIndex = 0;
            // 
            // RViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 345);
            this.Controls.Add(this.rv);
            this.Name = "RViewer";
            this.Text = "RViewer";
            this.Load += new System.EventHandler(this.RViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_GUIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource V_GUIABindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rv;
    }
}