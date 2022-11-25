namespace Sistema_Comida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFecha1.Text = DateTime.Now.ToString();
        }

        int n;

        private void vista()
        {
            dtgv.Rows.Clear();
            try
            {
                StreamReader lista = new StreamReader("Lista.txt", true);
                while (!lista.EndOfStream)
                {
                    n = dtgv.Rows.Add();

                    dtgv.Rows[n].Cells[0].Value = lista.ReadLine();
                    dtgv.Rows[n].Cells[1].Value = lista.ReadLine();
                    dtgv.Rows[n].Cells[2].Value = lista.ReadLine();
                }
                lista.Close();
            }
            catch
            {
                MessageBox.Show("No seleccionó ningun dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAgregarHamburguesa_Click(object sender, EventArgs e)
        {
            Menu hamburguesa = new Menu();
            if (tbHamburguesa.Text != "")
            {
                double h = double.Parse(tbHamburguesa.Text);
                hamburguesa.HamburguesaSimple(h);
                tbHamburguesa.Text = "";
            }

            if (tbHamburguesaQueso.Text != "")
            {
                double h = double.Parse(tbHamburguesaQueso.Text);
                hamburguesa.HamburguesaQueso(h);
                tbHamburguesaQueso.Text = "";
            }

            if (tbDobleCarne.Text != "")
            {
                double h = double.Parse(tbDobleCarne.Text);
                hamburguesa.DobleCarne(h);
                tbDobleCarne.Text = "";
            }

            if (tbPollo.Text != "")
            {
                double h = double.Parse(tbPollo.Text);
                hamburguesa.Pollo(h);
                tbPollo.Text = "";
            }

            vista();
        }

        private void btAgregarPapas_Click(object sender, EventArgs e)
        {
            Menu papas = new Menu();
            if (tbPapasFritas.Text != "")
            { 
                double p = double.Parse(tbPapasFritas.Text);
                papas.PapasFritasSimple(p);
                tbPapasFritas.Text = "";
            }

            if (tbPapasCheddar.Text != "")
            {
                double p = double.Parse(tbPapasCheddar.Text);
                papas.PapasCheddar(p);
                tbPapasCheddar.Text = "";
            }

            vista();
        }

        private void btAgregarGaseosa_Click(object sender, EventArgs e)
        {
            Menu bebida = new Menu();

            if (tbCoca.Text != "")
            {
                double g = double.Parse(tbCoca.Text);
                bebida.CocaCola(g);
                tbCoca.Text = "";
            }

            if (tbFanta.Text != "")
            {
                double g = double.Parse(tbFanta.Text);
                bebida.Fanta(g);
                tbFanta.Text = "";
            }

            if (tbSprite.Text != "")
            {
                double g = double.Parse(tbSprite.Text);
                bebida.Sprite(g);
                tbSprite.Text = "";
            }

            if (tbAgua.Text != "")
            {
                double g = double.Parse(tbAgua.Text);
                bebida.Agua(g);
                tbAgua.Text = "";
            }

            vista();
        }

        private void btQuitar_Click_1(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            try
            {
                dtgv.Rows.Remove(dtgv.CurrentRow);
            }
            catch
            {
                MessageBox.Show("Está seleccionando una celda vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            File.Delete("Lista.txt");

            StreamWriter nuevo = new StreamWriter("Lista.txt", true);
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    nuevo.WriteLine(row.Cells[0].Value);
                    nuevo.WriteLine(row.Cells[1].Value);
                    nuevo.WriteLine(row.Cells[2].Value);
                }
            }
            nuevo.Close();

            vista();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            dtgv.Rows.Clear();
            File.Delete("Lista.txt");
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader lista = new StreamReader("Lista.txt", true);
                double suma = 0;
                while (!lista.EndOfStream)
                {
                    string producto = lista.ReadLine();
                    string cantidad = lista.ReadLine();
                    string precio = lista.ReadLine();

                    double numero = double.Parse(precio);
                    suma = suma + numero;
                }

                lblTotal.Text = "$ " + suma.ToString("0.00");
                lista.Close();
            }
            catch
            {
                MessageBox.Show("No hay datos seleccionados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btImprimirTicket_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            try
            {
                GuardarMenu lista = new GuardarMenu();
                lista.Guardarnuevo();

                dtgv.Rows.Clear();

                Ticket ticket = new Ticket();
                ticket.Show();
            }
            catch
            {
                MessageBox.Show("Ticket vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("Cantidad.txt");
            File.Delete("Producto.txt");
            File.Delete("Precio.txt");
            File.Delete("Signo.txt");
            File.Delete("Lista.txt");
        }
        private static void soloNumero(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se aceptan numeros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void tbHamburguesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbHamburguesaQueso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbDobleCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbPollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbPapasFritas_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbPapasCheddar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbCoca_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbFanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbSprite_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void tbPapasFritas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPapasCheddar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFanta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}