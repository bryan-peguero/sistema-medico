using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Pacientes : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        CPacientes CP = new CPacientes();
        string query;
        public Pacientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CP.Nombre = txtNombre.Text;
            CP.Cedula = long.Parse(txtCedula.Text);
            CP.Asegurado = txtAS.Text;
            try
            {
                if (txtNombre.Text == "" && txtAS.Text == "" && txtCedula.Text == "")
                {
                    CP.Incorrecto();
                }
                else
                {
                    query = "Insert into Pacientes (Nombre, Cédula, Asegurado) values (@nombre, @ced, @asg)";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ced", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@asg", txtAS.Text);
                    cmd.ExecuteNonQuery();

                    CP.Agregado();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.Close();
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Pacientes", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CP.ID = int.Parse(txtID.Text);
            CP.Nombre = txtNombre.Text;
            CP.Cedula = long.Parse(txtCedula.Text);
            CP.Asegurado = txtAS.Text;

            try
            {
                if (txtID.Text == "" && txtNombre.Text == "" && txtCedula.Text == "" && txtAS.Text == "")
                {
                    CP.Incorrecto();
                }
                else
                {
                    query = "Update Pacientes set Nombre = @nombre, Cédula = @ced, Asegurado = @asg where ID = @id";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ced", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@asg", txtAS.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    CP.Agregado();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CP.ID = int.Parse(txtID.Text);
            try
            {
                if (txtID.Text == "")
                {
                    CP.Incorrecto();
                }
                else
                {
                    query = "Delete from Pacientes where ID = @id";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    CP.Agregado();
                }

            }
            catch (Exception error)

            {
                MessageBox.Show("Error.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.Close();
            }
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.sistemaMédicoDataSet.Pacientes);
            cmbFiltro.SelectedIndex = 1;

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                    pacientesBindingSource.Filter = string.Empty;
                else
                    pacientesBindingSource.Filter = string.Format("{0}='{1}'", cmbFiltro.Text, txtBuscar.Text);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            RPacientes RP = new RPacientes();
            RP.Show();
        }
    }
    }

