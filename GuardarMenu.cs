using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Comida
{
    class GuardarMenu
    {
        public void Guardar(double h, string nombre, string valorFinal)
        {
            StreamWriter archivoLista = new StreamWriter("Lista.txt", true);
            archivoLista.WriteLine(nombre);
            archivoLista.WriteLine(h);
            archivoLista.WriteLine(valorFinal);
            archivoLista.Close();
        }

        public void Guardarnuevo()
        {
            StreamReader lista = new StreamReader("Lista.txt",true);
            StreamWriter archivoProducto = new StreamWriter("Producto.txt", true);
            StreamWriter archivoCantidad = new StreamWriter("Cantidad.txt", true);
            StreamWriter archivoPrecio = new StreamWriter("Precio.txt", true);
            StreamWriter archivoSigno = new StreamWriter("Signo.txt", true);

            while (!lista.EndOfStream)
            {
                string producto = lista.ReadLine();
                string cantidad = lista.ReadLine();
                string precio = lista.ReadLine();

                archivoProducto.WriteLine(producto);
                archivoCantidad.WriteLine(cantidad);
                archivoPrecio.WriteLine(precio);
                archivoSigno.WriteLine("$");
            }

            archivoProducto.Close();
            archivoCantidad.Close();
            archivoPrecio.Close();
            archivoSigno.Close();
            lista.Close();
        }

        
    }
}
