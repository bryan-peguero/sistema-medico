namespace Proyecto_Final
{
    partial class RMédico
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
            this.DataSetMédico = new Proyecto_Final.DataSetMédico();
            this.MédicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MédicosTableAdapter = new Proyecto_Final.DataSetMédicoTableAdapters.MédicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMédico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MédicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MédicosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.IMédico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetMédico
            // 
            this.DataSetMédico.DataSetName = "DataSetMédico";
            this.DataSetMédico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MédicosBindingSource
            // 
            this.MédicosBindingSource.DataMember = "Médicos";
            this.MédicosBindingSource.DataSource = this.DataSetMédico;
            // 
            // MédicosTableAdapter
            // 
            this.MédicosTableAdapter.ClearBeforeFill = true;
            // 
            // RMédico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RMédico";
            this.Text = "RMédico";
            this.Load += new System.EventHandler(this.RMédico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMédico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MédicosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MédicosBindingSource;
        private DataSetMédico DataSetMédico;
        private DataSetMédicoTableAdapters.MédicosTableAdapter MédicosTableAdapter;
    }
}