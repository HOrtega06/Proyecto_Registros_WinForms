
namespace Sol_Registros.Reportes
{
    partial class Frm_Rpt_Categorias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_Listado_caNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Registros = new Sol_Registros.Reportes.DataSet_Registros();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Listado_caNewTableAdapter = new Sol_Registros.Reportes.DataSet_RegistrosTableAdapters.USP_Listado_caNewTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Registros)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_Listado_caNewBindingSource
            // 
            this.USP_Listado_caNewBindingSource.DataMember = "USP_Listado_caNew";
            this.USP_Listado_caNewBindingSource.DataSource = this.DataSet_Registros;
            this.USP_Listado_caNewBindingSource.CurrentChanged += new System.EventHandler(this.USP_Listado_caNewBindingSource_CurrentChanged);
            // 
            // DataSet_Registros
            // 
            this.DataSet_Registros.DataSetName = "DataSet_Registros";
            this.DataSet_Registros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_Listado_caNewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Registros.Reportes.Rpt_Categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_Listado_caNewTableAdapter
            // 
            this.USP_Listado_caNewTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(80, 32);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(148, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Categorias";
            this.Text = "REPORTE DE CATEGORIAS";
            this.Load += new System.EventHandler(this.Frm_Rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_caNewBindingSource;
        private DataSet_Registros DataSet_Registros;
        private DataSet_RegistrosTableAdapters.USP_Listado_caNewTableAdapter USP_Listado_caNewTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}