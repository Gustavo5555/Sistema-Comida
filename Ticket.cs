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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

            lbFecha.Text = DateTime.Now.ToString();

            try
            {
                string cantidad = File.ReadAllText("Cantidad.txt");
                lbCantidad.Text = cantidad;

                string producto = File.ReadAllText("Producto.txt");
                lbProducto.Text = producto;

                string precio = File.ReadAllText("Precio.txt");
                lbPrecio.Text = precio;

                string signo = File.ReadAllText("Signo.txt");
                lbSigno.Text = signo;

                StreamReader lista = new StreamReader("Lista.txt", true);
                double suma = 0;
                while (!lista.EndOfStream)
                {
                    string pro = lista.ReadLine();
                    string cant = lista.ReadLine();
                    string pre = lista.ReadLine();

                    double numero = double.Parse(pre);
                    suma = suma + numero;
                }

                lbTotalTicket.Text = suma.ToString("0.00");
                lista.Close();

            }
            catch
            {
                MessageBox.Show("No selecciono ningun dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            File.Delete("Cantidad.txt");
            File.Delete("Producto.txt");
            File.Delete("Precio.txt");
            File.Delete("Signo.txt");
            File.Delete("Lista.txt");

            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
