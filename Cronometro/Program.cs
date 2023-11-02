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
            Menu();
            }

        static void Menu()
            {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO CRONÔMETRO!");
            Console.WriteLine("____________________");
            Console.WriteLine("");

            Console.WriteLine("Você deseja contar em:");
            Console.WriteLine("1 - Segundos");
            Console.WriteLine("2 - Minutos");
            Console.WriteLine("0 - Para sair.");

            Console.Write("Digite sua opção: ");
            int entradaUsuario = int.Parse(Console.ReadLine());

            switch (entradaUsuario)
                {
                case 1:
                    CronometroSegundos();
                    break;
                case 2:
                    CronometroMinutos();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Você digitou uma opção inválida.");
                    Thread.Sleep(1500);
                    Menu();
                    break;
                }
            }

        static void CronometroSegundos()
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
            Menu();
            }

        static void CronometroMinutos()
            {
            Console.Clear();
            Console.WriteLine("____________________");
            Console.WriteLine("");
            Console.Write("Digite quantos minutos quer cronometrar: ");
            int minuto = int.Parse(Console.ReadLine());
            int tempo = minuto * 60;
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
            Menu();
            }
        }
    }
