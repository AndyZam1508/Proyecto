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
    public partial class Form1 : Form
    {
        Licores licores = new Licores();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Licor licor = new Licor();
            licor.Nombre = txtNombre.Text;
            licor.Apellido = txtApellido.Text;
            licor.Direccion = txtDireccion.Text;
            licor.Precio = Convert.ToInt32(mtxtPrecio.Text);
            licor.Tipo = cmbTipo.SelectedItem.ToString();
            licor.Grado = cmbGrado.SelectedItem.ToString();
            licores.Agregar(licor);
            MessageBox.Show("Datos Guardados Correctamente");
            Limpiar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Mostrar mostrar = new Mostrar();
            mostrar.Show();
            mostrar.licores = licores;
        }
        void Limpiar ()
        {
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtDireccion.Text = " ";
            mtxtPrecio.Text = " ";
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
