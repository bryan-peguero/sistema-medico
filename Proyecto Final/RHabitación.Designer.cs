namespace Proyecto_Final
{
    partial class RHabitación
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
            this.HabitaciónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HabitaciónTableAdapter = new Proyecto_Final.SistemaMédicoDataSetTableAdapters.HabitaciónTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitaciónBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HabitaciónBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.IHabitación.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(661, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaMédicoDataSet
            // 
            this.SistemaMédicoDataSet.DataSetName = "SistemaMédicoDataSet";
            this.SistemaMédicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HabitaciónBindingSource
            // 
            this.HabitaciónBindingSource.DataMember = "Habitación";
            this.HabitaciónBindingSource.DataSource = this.SistemaMédicoDataSet;
            // 
            // HabitaciónTableAdapter
            // 
            this.HabitaciónTableAdapter.ClearBeforeFill = true;
            // 
            // RHabitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 370);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RHabitación";
            this.Text = "RHabitación";
            this.Load += new System.EventHandler(this.RHabitación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaMédicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitaciónBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HabitaciónBindingSource;
        private SistemaMédicoDataSet SistemaMédicoDataSet;
        private SistemaMédicoDataSetTableAdapters.HabitaciónTableAdapter HabitaciónTableAdapter;
    }
}