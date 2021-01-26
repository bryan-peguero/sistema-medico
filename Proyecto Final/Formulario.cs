using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            btnMedicos_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormMed(object formmed)
        {
            if (this.Panel.Controls.Count > 0)
                this.Panel.Controls.RemoveAt(0);
            Form me = formmed as Form;
            me.TopLevel = false;
            me.Dock = DockStyle.Fill;
            this.Panel.Controls.Add(me);
            this.Panel.Tag = me;
            me.Show();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FormMed(new Médicos());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FormMed(new Pacientes());

        }

        private void btnHabt_Click(object sender, EventArgs e)
        {
            FormMed(new Habitación());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormMed(new Citas());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            FormMed(new Ingresos());
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            FormMed(new Altas());
        }
    }
}
