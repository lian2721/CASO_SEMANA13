using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO_TEMA07_SEMANA11
{
    internal class Program
    {
        static public void numeros_naturales()
        {
            Console.Write("Ingresar el numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int s = 0;
            for (int c = 1; c <= N; c++)
            {
                s = s + c;
            }
            Console.WriteLine("La suma es:  " + s);
        }
        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 2)
            {
                return 2;
            }
            return N + sumaNP_con_recursividad(N - 2);
        }
        static public long factorial_con_recursividad(int N)
        {
            if (N == 0 || N == 1)
            {
                return 1;
            }
            return N * factorial_con_recursividad(N - 1);
        }
        static public int potencia(int B,int exp)
        {
            if (exp== 1)
            {
                return B; 
            }
            return B * potencia(B, exp - 1);
        }
        static public void conteo_regresivo(int N)
        {
            if (N < 0)
            {
                return ;
            }
            Console.WriteLine(N);
            conteo_regresivo(N - 1);
        }
        static public int suma_arreglos(int[] numeros,int indice)
        {
            if (indice >= numeros.Length) 
            {
                return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor) 
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.WriteLine("\t\tMENU DE OPCIONES");
                Console.WriteLine("*************************************");
                Console.WriteLine("[1] suma de N numeros naturales");
                Console.WriteLine("[2] suma de N numeros con recursividad");
                Console.WriteLine("[3] suma de N numeros pares con recursividad ");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] potencia");
                Console.WriteLine("[6] conteo regresivo");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] salir");
                Console.WriteLine("******************************************");
                opc=int .Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numeros_naturales();
                        break;
                    case 2:
                        Console.Write("Ingrese numero N:");
                        int N= int .Parse(Console.ReadLine());
                        Console.WriteLine("La suma es:"+sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingrese numero N:");
                        int N1= int .Parse(Console.ReadLine()); 
                        Console.WriteLine("la suma de pares es:"+sumaNP_con_recursividad(N1*2));
                        break;
                    case 4:
                        Console.Write("Ingrese Num:");
                        int N2= int .Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: " + factorial_con_recursividad(
                            N2));
                        break;
                    case 5:
                        Console.WriteLine("Ingrese base: ");
                        int B= int .Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese exponente: ");
                        int exp= int .Parse(Console.ReadLine());
                        Console.WriteLine(B + "^" + exp + "=" + potencia(B, exp));
                        break;
                    case 6:
                        int N3;
                        N3 = int .Parse(Console.ReadLine());
                        conteo_regresivo(N3);
                        break;
                    case 7:
                        int[] numeros = { 10, 15, 20, 25, 30 };
                        Console.WriteLine("La suma del arreglo es: " + suma_arreglos(numeros, 0));
                        break;
                    case 8:
                        valor= false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
