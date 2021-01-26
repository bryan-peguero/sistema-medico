namespace Proyecto_Final
{
    partial class RAltaMédica
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
            this.Alta_MédicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Alta_MédicaTableAdapter = new Proyecto_Final.SistemaMédicoDataSetTableAdapters.Alta_MédicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alta_MédicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Alta_MédicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(628, 351);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaMédicoDataSet
            // 
            this.SistemaMédicoDataSet.DataSetName = "SistemaMédicoDataSet";
            this.SistemaMédicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Alta_MédicaBindingSource
            // 
            this.Alta_MédicaBindingSource.DataMember = "Alta_Médica";
            this.Alta_MédicaBindingSource.DataSource = this.SistemaMédicoDataSet;
            // 
            // Alta_MédicaTableAdapter
            // 
            this.Alta_MédicaTableAdapter.ClearBeforeFill = true;
            // 
            // RAltaMédica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RAltaMédica";
            this.Text = "RAltaMédica";
            this.Load += new System.EventHandler(this.RAltaMédica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alta_MédicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Alta_MédicaBindingSource;
        private SistemaMédicoDataSet SistemaMédicoDataSet;
        private SistemaMédicoDataSetTableAdapters.Alta_MédicaTableAdapter Alta_MédicaTableAdapter;
    }
}