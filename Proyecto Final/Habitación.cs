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
    public partial class Habitación : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        string query;
        CHabitación CH = new CHabitación();

        public Habitación()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CH.Numero = int.Parse(txtNumero.Text);
            CH.Tipo = txtTipo.Text;
            CH.Precio = int.Parse(txtPrecio.Text);

            try
            {
                if (txtNumero.Text == "" && txtTipo.Text == "" && txtPrecio.Text == "")
                {
                    CH.Incorrecto();
                }
                else
                {
                    query = "Insert into Habitación(Tipo, Número, Precio) values (@tipo, @num, @precio)";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@num", txtNumero.Text);
                    cmd.Parameters.AddWithValue("precio", txtPrecio.Text);
                    cmd.ExecuteNonQuery();

                    CH.Agregado();
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

        private void btnAct_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Habitación", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CH.ID = int.Parse(txtID.Text);
            CH.Precio = int.Parse(txtPrecio.Text);
            CH.Numero = int.Parse(txtNumero.Text);
            CH.Tipo = txtTipo.Text;

            try
            {
                if (txtID.Text == "" && txtPrecio.Text == "" && txtNumero.Text == "" && txtTipo.Text == "")
                {
                    CH.Incorrecto();
                }
                else
                {
                    query = "Update Habitación set Número = @num, Tipo = @tipo, Precio = @precio where ID = @id";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@num", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.ExecuteNonQuery();

                    CH.Agregado();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Habitación", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer.Visible = true;

            conectar.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    CH.Incorrecto();
                }
                else
                {
                    query = "Delete from Habitación where ID = @id";
                    conectar.Open();

                    SqlCommand cmd = new SqlCommand(query, conectar);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    CH.Agregado();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Habitación", conectar);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
            dtVer.DataSource = tabla;
            dtVer.Visible = true;

            conectar.Close();
        }

        private void Habitación_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaMédicoDataSet.Habitación' Puede moverla o quitarla según sea necesario.
            this.habitaciónTableAdapter.Fill(this.sistemaMédicoDataSet.Habitación);
            cmbFiltro.SelectedIndex = 0;

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                    habitaciónBindingSource.Filter = string.Empty;
                else
                    habitaciónBindingSource.Filter = string.Format("{0}='{1}'", cmbFiltro.Text, txtBuscar.Text);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            RHabitación RH = new  RHabitación();
            RH.Show();
        }
    }
}
