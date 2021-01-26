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
    public partial class Ingresos : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        string query;
        CMédicos med = new CMédicos();
        public Ingresos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Insert into Internamientos values (@pacfk, @habfk, @fecha)";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@pacfk", cmbP.Text);
                cmd.Parameters.AddWithValue("@habfk", cmbH.Text);
                cmd.Parameters.AddWithValue("@fecha", txtFecha.Text);
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

        private void Ingresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.Internamientos' Puede moverla o quitarla según sea necesario.
            this.internamientosTableAdapter.Fill(this.sistemaMédicoDataSet.Internamientos);
            cmbFiltro.SelectedIndex = 1;

            SqlCommand cmd = new SqlCommand("Select Paciente from Citas", conectar);
            conectar.Open();

            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                cmbP.Items.Add(sda["Paciente"].ToString());
            }
            conectar.Close();

            SqlCommand cmd2 = new SqlCommand("Select Tipo from Habitación", conectar);
            conectar.Open();

            SqlDataReader sda2 = cmd2.ExecuteReader();
            while (sda2.Read())
            {
                cmbH.Items.Add(sda2["Tipo"].ToString());
            }
            conectar.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Internamientos", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Update Internamientos set Paciente = @pafk, Habitacion = @habtfk, Fecha_Inicio = @fecha where ID = @id";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@pafk", cmbP.Text);
                cmd.Parameters.AddWithValue("@habtfk", cmbH.Text);
                cmd.Parameters.AddWithValue("@fecha", txtFecha.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();

                if (txtFecha.Text == "" && cmbH.Text == "" && cmbP.Text == "" && txtID.Text == "")
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

            SqlCommand cmd2 = new SqlCommand("Select * from Internamientos", conectar);
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
                    query = "Delete from Internamientos where ID = @id";
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
            SqlCommand cmd2 = new SqlCommand("Select * from Internamientos", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;

            conectar.Close();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                    internamientosBindingSource.Filter = string.Empty;
                else
                    internamientosBindingSource.Filter = string.Format("{0}='{1}'", cmbFiltro.Text, txtBuscar.Text);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            RIngresos RI = new RIngresos();
            RI.Show();
        }
    }
}
