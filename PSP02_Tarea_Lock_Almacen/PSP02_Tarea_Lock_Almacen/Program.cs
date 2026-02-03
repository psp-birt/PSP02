using System;
using System.Threading; // Necesario para utilizar thread.sleep
namespace tareas
{
    public class Tareas1
    {
        public static void Main(string[] args)
        {
            Almacen AlmacenMelocotones = new Almacen(2000);

            Thread[] Fenwick = new Thread[100];
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(AlmacenMelocotones.RetirarProducto);
                t.Name = i.ToString(); ;
                Fenwick[i] = t;
            }
            for (int i = 0; i < 10; i++)
            {
                Fenwick[i].Start();
                Fenwick[i].Join();
            }
        }
    }
}