using PaseParametro;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Objeto obligatorio para pasar parámetro.
        Contador contador = new Contador();

        //Hilos que lanzan métodos sin parámetros.
        Thread hilo1 = new Thread(Contar1);
        Thread hilo2 = new Thread(new ThreadStart(Contar1));

        //Hilos que lanzan métodos con parámetros.
        Thread hilo3 = new Thread(new ParameterizedThreadStart(contador.Contar));
        Thread hilo4 = new Thread(new ParameterizedThreadStart(contador.Contar));

        //Nombre de hilos
        hilo1.Name = "Hilo 1";
        hilo2.Name = "Hilo 2";
        hilo3.Name = "Hilo 3";
        hilo4.Name = "Hilo 4";


        hilo1.Start();
        hilo2.Start();
        //Inicio de hilo con parámetro.
        hilo3.Start(5);
        hilo4.Start(10);

        //Finalizar  hilos.
        hilo1.Join();
        hilo2.Join();
        hilo3.Join();
        hilo4.Join();

        Console.WriteLine("Todos los hilos han terminado de contar.");

        //método Contar1
        static void Contar1()
        {
            Console.WriteLine("Método ejecutado desde un hilo: " + Thread.CurrentThread.Name);
        }

        //Método que no utilizaremos porque no da error y que se pasa a la clase Contador.
        static void Contar2(int max)
        {
            int maxNumero = max;
            for (int i = 1; i <= maxNumero; i++)
            {
                //Mostramos el id del hilo ejecutandose, y el número que está contando
                Console.WriteLine($"Hilo {Thread.CurrentThread.Name} valor: {max} ,{i} veces");

                // Se para el hilo medio segundo
                Thread.Sleep(500);
            }
        }
    }


}

