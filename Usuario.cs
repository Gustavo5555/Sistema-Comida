using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comida
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var principal = new Form1();

            if (txtUsuario.Text == "Empleado" && txtContraseña.Text == "2022" || txtUsuario.Text == "Gerente" & txtContraseña.Text == "2022")
            {
                MessageBox.Show("Ingreso correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
