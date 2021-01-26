﻿namespace Proyecto_Final
{
    partial class Citas
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
            this.cmbP = new System.Windows.Forms.ComboBox();
            this.cmbM = new System.Windows.Forms.ComboBox();
            this.lblPresentación = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtVer = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMédicoDataSet = new Proyecto_Final.SistemaMédicoDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.citasTableAdapter = new Proyecto_Final.SistemaMédicoDataSetTableAdapters.CitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMédicoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbP
            // 
            this.cmbP.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cmbP.FormattingEnabled = true;
            this.cmbP.Location = new System.Drawing.Point(252, 166);
            this.cmbP.Name = "cmbP";
            this.cmbP.Size = new System.Drawing.Size(146, 24);
            this.cmbP.TabIndex = 81;
            // 
            // cmbM
            // 
            this.cmbM.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cmbM.FormattingEnabled = true;
            this.cmbM.Location = new System.Drawing.Point(251, 216);
            this.cmbM.Name = "cmbM";
            this.cmbM.Size = new System.Drawing.Size(147, 24);
            this.cmbM.TabIndex = 82;
            // 
            // lblPresentación
            // 
            this.lblPresentación.AutoSize = true;
            this.lblPresentación.Font = new System.Drawing.Font("Century Gothic", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentación.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPresentación.Location = new System.Drawing.Point(329, 36);
            this.lblPresentación.Name = "lblPresentación";
            this.lblPresentación.Size = new System.Drawing.Size(435, 39);
            this.lblPresentación.TabIndex = 80;
            this.lblPresentación.Text = "Proceso de Citas Médicas";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(252, 266);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(146, 20);
            this.txtFecha.TabIndex = 79;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(251, 116);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 78;
            // 
            // dtVer
            // 
            this.dtVer.AllowUserToAddRows = false;
            this.dtVer.AllowUserToDeleteRows = false;
            this.dtVer.AutoGenerateColumns = false;
            this.dtVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.medicosDataGridViewTextBoxColumn,
            this.pacienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dtVer.DataSource = this.citasBindingSource;
            this.dtVer.Location = new System.Drawing.Point(156, 379);
            this.dtVer.Name = "dtVer";
            this.dtVer.Size = new System.Drawing.Size(791, 198);
            this.dtVer.TabIndex = 77;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // medicosDataGridViewTextBoxColumn
            // 
            this.medicosDataGridViewTextBoxColumn.DataPropertyName = "Medicos";
            this.medicosDataGridViewTextBoxColumn.HeaderText = "Nombre del Médico";
            this.medicosDataGridViewTextBoxColumn.Name = "medicosDataGridViewTextBoxColumn";
            this.medicosDataGridViewTextBoxColumn.Width = 200;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            this.pacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Paciente";
            this.pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            this.pacienteDataGridViewTextBoxColumn.Width = 199;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 199;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.sistemaMédicoDataSet;
            // 
            // sistemaMédicoDataSet
            // 
            this.sistemaMédicoDataSet.DataSetName = "SistemaMédicoDataSet";
            this.sistemaMédicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(693, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 28);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(561, 332);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 28);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAct.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAct.Location = new System.Drawing.Point(429, 332);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(99, 28);
            this.btnAct.TabIndex = 74;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(299, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 28);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Controls.Add(this.lblFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(728, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 211);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opción";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(48, 114);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(178, 26);
            this.txtBuscar.TabIndex = 65;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReporte.Location = new System.Drawing.Point(58, 162);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(161, 28);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(54, 92);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(73, 19);
            this.lblBuscar.TabIndex = 11;
            this.lblBuscar.Text = "Buscador";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Fecha",
            "Paciente",
            "Medicos"});
            this.cmbFiltro.Location = new System.Drawing.Point(48, 53);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(178, 28);
            this.cmbFiltro.TabIndex = 9;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltro.Location = new System.Drawing.Point(54, 30);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 19);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar por";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(133, 266);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(113, 20);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha de Cita";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblM.ForeColor = System.Drawing.SystemColors.Control;
            this.lblM.Location = new System.Drawing.Point(85, 216);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(161, 20);
            this.lblM.TabIndex = 70;
            this.lblM.Text = "Médicos Registrados";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP.Location = new System.Drawing.Point(77, 166);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(169, 20);
            this.lblP.TabIndex = 69;
            this.lblP.Text = "Pacientes Registrados";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblID.Location = new System.Drawing.Point(221, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 68;
            this.lblID.Text = "ID";
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.cmbP);
            this.Controls.Add(this.cmbM);
            this.Controls.Add(this.lblPresentación);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtVer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMédicoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbP;
        private System.Windows.Forms.ComboBox cmbM;
        private System.Windows.Forms.Label lblPresentación;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dtVer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblID;
        private SistemaMédicoDataSet sistemaMédicoDataSet;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private SistemaMédicoDataSetTableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}