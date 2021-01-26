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
    public partial class Login : Form
    {
        SqlConnection conectar = new SqlConnection("Server = localhost\\SQLEXPRESS; DataBase = SistemaMédico; Integrated Security = true");
        private int conteo;
        Form form = new Formulario();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Loguear();
        }
        public void Loguear()
        {
            try
            {
                conectar.Open();

                SqlCommand cmd = new SqlCommand("Select Contraseña from Loguear where Contraseña = '" + txtContraseña.Text + "'", conectar);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    tiempo.Enabled = true;
                    pgBarra.Value = 0;
                    lblBienvenido.Visible = true;
                    lblBienvenido.Text = "¡Hola, usted ha ingresado como " + cmbUsuarios.Text + "!";
                    pgBarra.Visible = true;
                }
                else
                {
                    MessageBox.Show("La contraseña ingresada esta incorrecta.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.");
            }
            finally
            {
                conectar.Close();
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (pgBarra.Value < 100)
            {
                pgBarra.Value++;

            }
            if (pgBarra.Value == 100)
            {
                tiempo.Enabled = false;
                form.Show();
                this.Hide();
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Usuario from Loguear", conectar);
            conectar.Open();

            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                cmbUsuarios.Items.Add(sda["Usuario"].ToString());
            }
            conectar.Close();
        }
    }
}
