using System;
using System.Threading;
/*
 *//*Clase Contador

 * Contiene el método Contar 
 * @parámetro: tipo objeto con valor max 
 * 
 * Escribe el hilo que lo ejecuta
 * El número de veces muestra por consola el número que le pasamos por parámetro.
 * */
namespace PaseParametro
{
    internal class Contador
    {
        //Método que permite contar.
        //@param max: valor máximo hasta el que se contará de tipo objeto
        public void Contar(object max)
        {
            int maxNumero = (int)max;
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




