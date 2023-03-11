using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Mostrar : Form
    {
        public Licores licores = new Licores();
        public Mostrar()
        {
            InitializeComponent();
        }

     
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvVer.DataSource = licores.ListLicores;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cbOpcion.Text)
            {
                case "Nombre":
                    dgvVer.DataSource = licores.LicorXNom(txtDatos.Text);
                    break;
                case "Precio":
                    dgvVer.DataSource = licores.LicorXPre(Convert.ToInt32(txtDatos.Text));
                    break;
                case "Tipo":
                    dgvVer.DataSource = licores.LicorXTipo(txtDatos.Text);
                    break;
                default:
                    MessageBox.Show("Seleccion una opcion:");
                    break;
            }
        }

        private void cbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Desea salir?", "Uso ListView", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }
    }

    
}
