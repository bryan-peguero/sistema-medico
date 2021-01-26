namespace Proyecto_Final
{
    partial class RCitas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaMédicoDataSet = new Proyecto_Final.SistemaMédicoDataSet();
            this.CitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CitasTableAdapter = new Proyecto_Final.SistemaMédicoDataSetTableAdapters.CitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ICitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(607, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaMédicoDataSet
            // 
            this.SistemaMédicoDataSet.DataSetName = "SistemaMédicoDataSet";
            this.SistemaMédicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CitasBindingSource
            // 
            this.CitasBindingSource.DataMember = "Citas";
            this.CitasBindingSource.DataSource = this.SistemaMédicoDataSet;
            // 
            // CitasTableAdapter
            // 
            this.CitasTableAdapter.ClearBeforeFill = true;
            // 
            // RCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 434);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RCitas";
            this.Text = "RCitas";
            this.Load += new System.EventHandler(this.RCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CitasBindingSource;
        private SistemaMédicoDataSet SistemaMédicoDataSet;
        private SistemaMédicoDataSetTableAdapters.CitasTableAdapter CitasTableAdapter;
    }
}