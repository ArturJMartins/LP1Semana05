using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Inicia contagem do tempo
            crono1.Start();

            // Pausa a leitura do programa durante 0.6 segundos
            Thread.Sleep(600);

            crono2.Start();

            Thread.Sleep(200);

            // Pára a contagem do tempo
            crono1.Stop();
            crono2.Stop();

            // crono1.ElapsedMilliseconds é onde se verifica o tempo
            Console.WriteLine("Tempo decorrido em crono1: " +
            $"{(crono1.ElapsedMilliseconds / 1000.0),0:f3} segundos"); 
            Console.WriteLine("Tempo decorrido em crono2: " +
            $"{(crono2.ElapsedMilliseconds / 1000.0),0:f3} segundos"); 
              
        }
    }
}
