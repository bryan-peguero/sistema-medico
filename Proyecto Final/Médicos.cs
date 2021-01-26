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
    public partial class Médicos : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        CMédicos med = new CMédicos();
        string query;
        public Médicos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            med.Nombre = txtNombre.Text;
            med.exequatur = txtEx.Text;
            med.especialidad = txtEsp.Text;
            try
            {
                query = "Insert into Médicos values (@nombre, @exe, @esp)";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@exe", txtEx.Text);
                cmd.Parameters.AddWithValue("@esp", txtEsp.Text);
                cmd.ExecuteNonQuery();

                med.Agregado();
            }
            catch (Exception error)
            {
                med.Incorrecto();
            }
            finally
            {
                conectar.Close();
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Médicos", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            med.ID = int.Parse(txtID.Text);
            med.Nombre = txtID.Text;
            med.exequatur = txtEx.Text;
            med.especialidad = txtEsp.Text;

            try
            {
                query = "Update Médicos set Nombre = @nombre, Exequatur = @exe, Especialidad = @esp where ID = @id";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@exe", txtEx.Text);
                cmd.Parameters.AddWithValue("@esp", txtEsp.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();

                if (med.Nombre == "" && med.exequatur == "" && med.especialidad == "")
                {
                    med.Incorrecto();
                }
                else
                {
                    med.Agregado();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            SqlCommand cmd2 = new SqlCommand("Select * from Médicos", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;

            conectar.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    med.Incorrecto();
                }
                else
                {
                    query = "Delete from Médicos where ID = @id";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    med.Agregado();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Médicos", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;

            conectar.Close();
        }

        private void Médicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.Médicos' Puede moverla o quitarla según sea necesario.
            this.médicosTableAdapter.Fill(this.sistemaMédicoDataSet.Médicos);
            cmbFiltro.SelectedIndex = 1;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                    médicosBindingSource.Filter = string.Empty;
                else
                    médicosBindingSource.Filter = string.Format("{0}='{1}'", cmbFiltro.Text, txtBuscar.Text);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            RMédico RM = new RMédico();
            RM.Show();
        }
    }
}
