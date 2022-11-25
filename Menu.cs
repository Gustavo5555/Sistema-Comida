using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Comida
{
    class Menu : GuardarMenu
    {
        private string nombre;
        private double precio;


        public void HamburguesaSimple(double h)
        {
            nombre = "Hamburguesa";
            precio = 500.00;

            double valor = h * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(h, nombre, valorFinal);
        }

        public void HamburguesaQueso(double h)
        {
            nombre = "Hamburguesa c/ Queso";
            precio = 650.00;

            double valor = h * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(h, nombre, valorFinal);
        }

        public void Pollo(double h)
        {
            nombre = "Hamburguesa de Pollo";
            precio = 700.00;

            double valor = h * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(h, nombre, valorFinal);
        }

        public void DobleCarne(double h)
        {
            nombre = "Doble Carne Doble Queso";
            precio = 800.00;

            double valor = h * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(h, nombre, valorFinal);
        }

        public void PapasFritasSimple(double p)
        {
            nombre = "Papas Fritas";
            precio = 300.00;

            double valor = p * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(p, nombre, valorFinal);
        }

        public void PapasCheddar(double p)
        {
            nombre = "Papas Cheddar";
            precio = 450.00;

            double valor = p * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(p, nombre, valorFinal);
        }

        public void CocaCola(double b)
        {
            nombre = "Coca Cola";
            precio = 250.00;

            double valor = b * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(b, nombre, valorFinal);
        }

        public void Fanta(double b)
        {
            nombre = "Fanta";
            precio = 250.00;

            double valor = b * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(b, nombre, valorFinal);
        }

        public void Sprite(double b)
        {
            nombre = "Sprite";
            precio = 250.00;

            double valor = b * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(b, nombre, valorFinal);
        }

        public void Agua(double b)
        {
            nombre = "Agua";
            precio = 290.00;

            double valor = b * precio;
            string valorFinal = valor.ToString("0.00");

            Guardar(b, nombre, valorFinal);
        }


    }
}
