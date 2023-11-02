using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            CronometroIniciar();
            }

        static void CronometroIniciar()
            {
            Console.Clear();
            Console.WriteLine("____________________");
            Console.WriteLine("");
            Console.Write("Digite quantos segundos quer cronometrar: ");
            int tempo = int.Parse(Console.ReadLine());
            int tempoPercorrido = 0;

            while (tempoPercorrido <= tempo)
                {
                Console.Clear();
                Console.WriteLine(tempoPercorrido);
                Thread.Sleep(999);
                tempoPercorrido++;
                }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(3000);
            }
        }
    }
