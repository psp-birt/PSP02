using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareas
{
    internal class Almacen
    {
        //Unidades de stock que se guardan en el almacén
        double Stock { get; set; } //!Dato compartido por todos los hilos
        //private Object bloqueaAlmacen = new Object(); //Objeto creado y necesario para el bloqueo

        //Constructor
        public Almacen(double Stock)
        {
            this.Stock = Stock;
        }

        //Método Retirara Producto
        public double RetirarProducto(double cantidad) // método con el que el fendwich retirará el producto
        {

            if ((Stock - cantidad) < 0)
            {
                Console.WriteLine("No puedes retirar esa cantidad, quedan sólo {0} del producto en el almacén. Soy el hilo {1}.", Stock, Thread.CurrentThread.Name);
                return Stock;
            }
           // lock (bloqueaAlmacen)
            //{
                if ((Stock - cantidad) >= 0)
                {
                    Console.WriteLine("Has sacado {0} producto del almacén y quedan {1} en Stock. Soy el hilo {2}.", cantidad, Stock - cantidad, Thread.CurrentThread.Name);
                    Stock = Stock - cantidad;
                }
            //}
            return Stock;

        }

        //Método auxiliar, se indica la cantidad que queremos eliminar.
        public void RetirarProducto()
        {
            Console.WriteLine("Sacando producto del almacén. Soy el hilo {0}.", Thread.CurrentThread.Name);
            RetirarProducto(500);
        }
    }
}
