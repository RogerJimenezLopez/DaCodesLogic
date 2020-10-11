using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private const string msnEntry = "El número debe de ser mayor a cero";
        private const string msnRange = "El número esta fuera del rango permitido";
        static void Main(string[] args)
        {
            int T = 0;
            bool _response = true;

            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine("Capture el número de casos (T):");

            int.TryParse(Console.ReadLine(), out T);
            if (!validateEntry(T)) {
                Console.WriteLine(msnEntry);
                _response = false;
            }
            if (!validateRange(T, 1)) { 
                Console.WriteLine(msnRange);
                _response = false;
            }

            if (_response)
                flowDirection(T);

            Console.WriteLine(System.DateTime.Now);
        }
       

        static void flowDirection(int T)
        {
            int N = 0;
            int M = 0;
            bool _response = true;
            
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("Capture el número de lado N de la cuadricula para el caso "+i+":");
                int.TryParse(Console.ReadLine(), out N);
                if (!validateEntry(N)){
                    Console.WriteLine(msnEntry); 
                    _response = false;
                }
                if (!validateRange(N, 2)){
                    Console.WriteLine(msnRange); 
                    _response = false;
                }

                Console.WriteLine("Capture el número de lado M de la cuadricula para el caso " + i+":");
                int.TryParse(Console.ReadLine(), out M);
                if (!validateEntry(M)) {
                    Console.WriteLine(msnEntry); 
                    _response = false;
                }
                if (!validateRange(M, 3)){
                    Console.WriteLine(msnRange);
                    _response = false;
                }

                if (_response)
                {
                    if (N > M)
                    {
                        Console.Write("Respuesta: ");
                        if (M % 2 == 0)
                            Console.Write("U\n");
                        else
                            Console.Write("D\n");
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("Respuesta: ");
                        if (N % 2 == 0)
                            Console.Write("L\n");
                        else
                            Console.Write("R\n");
                        Console.Write("\n");
                    }
                }else
                    Console.WriteLine("No hay respuesta");
                _response = true;
            }
        }

        static bool validateEntry(int _entry)
        {
            bool response = false;
            if (_entry != 0)
                response = true;

            return response;                
        }

        static bool validateRange(int _number, int _case)
        {
            bool response = false;

            switch (_case)
            {
                case 1:
                    if (_number >= 1 && _number <= 5000)
                        response = true;
                    break;
                case 2:
                    if (_number >= 1)
                        response = true;
                    break;
                case 3:
                    if (_number <= 1000000000)
                        response = true;
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
