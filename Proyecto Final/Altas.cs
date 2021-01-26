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
    public partial class Altas : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        string query;
        CMédicos med = new CMédicos();
        public Altas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Insert into Alta_Médica(Ingresos ,Fecha_Salida) values (@id, @fecha)";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@fecha", txtFecha.Text);
                cmd.ExecuteNonQuery();

                med.Agregado();
            }
            catch (Exception error)
            {
                med.Incorrecto();
            }

            SqlCommand cmd2 = new SqlCommand("Select * from AltaM", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer2.Visible = false;

            conectar.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            query = "Select * from Internamientos where ID = @id";
            conectar.Open();
            SqlCommand cmd = new SqlCommand(query, conectar);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer2.DataSource = tabla;
            dtVer2.Visible = true;

            conectar.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Update Alta_Médica set Fecha_Salida = @fecha where Ingresos = @id";
                conectar.Open();

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@fecha", txtFecha.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();

                if (txtFecha.Text == "" && txtID.Text == "")
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

            SqlCommand cmd2 = new SqlCommand("Select * from AltaM", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer2.Visible = false;

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
                    query = "Delete from Alta_Médica where Ingresos = @id";
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
            SqlCommand cmd2 = new SqlCommand("Select * from AltaM", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer2.Visible = false;

            conectar.Close();
        }

        private void Altas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.Internamientos' Puede moverla o quitarla según sea necesario.
            this.internamientosTableAdapter.Fill(this.sistemaMédicoDataSet.Internamientos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.AltaM' Puede moverla o quitarla según sea necesario.
            this.altaMTableAdapter.Fill(this.sistemaMédicoDataSet.AltaM);
            cmbFiltro.SelectedIndex = 1;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                    altaMBindingSource.Filter = string.Empty;
                else
                    altaMBindingSource.Filter = string.Format("{0}='{1}'", cmbFiltro.Text, txtBuscar.Text);
            }
        }
        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            RAltaMédica form = new RAltaMédica();
            form.Show();
        }
    }
}
