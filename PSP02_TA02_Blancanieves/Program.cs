//BLANCANIEVES
//El programa blancanieves sin final
 
 using System;
using System.Threading;

class Program
{
    static int enanitos = 7;
    static int sillas = 4;
    static int comiendo = 0;
    static int servido = 0;
    static object bloquear = new object();

    static void Main(string[] args)
    {
        Thread[] enanito = new Thread[enanitos];
        for (int i = 0; i < enanitos; i++)
        {
            enanito[i] = new Thread(Trabajar);
            enanito[i].Start(i);
        }
        Thread blancanieves = new Thread(Servir);
        blancanieves.Start();
        blancanieves.Join();
    }

    static void Trabajar(object id)
    {
        while (true)
        {
            lock (bloquear)
            {
                if (sillas > 0)
                {
                    Console.WriteLine("Enanito " + (int)id + " se sienta a comer.");
                    sillas--;
                    servido++;
                    Monitor.Pulse(bloquear);
                }
                else
                {
                    Console.WriteLine("Enanito " + (int)id + " regresa a la mina (no hay sillas disponibles).");
                }
            }
            Thread.Sleep(1000);
        }
    }

    static void Servir()
    {
        while (true)
        {
            lock (bloquear)
            {
                if (servido == 0)
                {
                    Console.WriteLine("Blancanieves se va a dar una vuelta (no hay enanitos sentados).");
                }
                else
                {
                    Console.WriteLine("Blancanieves atiende a enanito.");
                    servido--;
                    comiendo++;
                    Monitor.PulseAll(bloquear);
                }
            }
            Thread.Sleep(1000);
            lock (bloquear)
            {
                if (comiendo > 0)
                {
                    Console.WriteLine("Blancanieves indica a enanito que puede empezar a comer.");
                    comiendo--;
                    sillas++;
                    Monitor.PulseAll(bloquear);
                }
            }
            Thread.Sleep(1000);
        }
    }
}
