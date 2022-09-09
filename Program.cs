using System;

namespace Taller_Uno_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Taller Algoritmos****");

            Console.WriteLine("Digite 1 para contar del 1 al 100\n" +
                "Digite 2 para contar del 100 al 0\n" +
                "Digite 3 para imprimir los números pares entre 0 y 100.\n" +
                "Digite 4 para imprimir la suma de los 100 primeros números.\n"+
                "Digite 5 para imprimir los números impares hasta el 100 y cuantos hay.\n"+
                "Digite 6 para ingresar un numero hasta el que desea contar.\n" +
                "Digite 7 para ingresar ingresar solo S o N.\n" +
                "Digite 8 para verificar si un numero es positivo o negativo.\n" +
                "Digite 9 para verificar si un numero es par o impar.\n" +
                "Digite 10 para verificar si un numero es par o impar.\n"+
                "Digite 11 para para ingresar un numero y contar los pares y los impares.\n" +
                "Digite 12 para para ingresar un numero y contar e imprimir los multiplos de 2 y de 3.\n");
                

            int respuesta = Convert.ToInt32(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    ContarDelUnoAlCien();
                    break;
                case 2:
                    ContarDelCienAlCero();
                    break;
                case 3:
                    ContarNumerosParesHastaELCien();
                    break;
                case 4:
                    ImprimirSumaCeroCien();
                    break;
                case 5:
                    SumaCienPrimerosNumeros();
                    break;
                case 6:
                    ContarLosNumerosHastaN();
                    break;
                case 7:
                    SoloSePermite_S_N();
                    break;
                case 8:
                    Positivo_Negativo();
                    break;
                case 9:
                    ParOImpar();
                    break;
                case 10:
                    multiplosde3();
                    break;
                case 11:
                    CalcularParesImpares();
                    break;
                case 12:
                    MultiplosDe3y2();
                    break;
                default:
                    Console.Write("\t Opción no válida...");
                    break;
            }
            
            Console.Write("\tPresione cualquier tecla para cerrar la consola...");
            Console.ReadKey();

        }

        public static void ContarDelUnoAlCien()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ContarDelCienAlCero()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void ContarNumerosParesHastaELCien()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void ImprimirSumaCeroCien()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i ++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
        }
        public static void SumaCienPrimerosNumeros()
        {
            int contador = 0;
            for (int i = 0; i <= 100; i ++)
            {
                if (i % 2 == 1)
                {
                    contador++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Hay un total de " + contador + " Impares");
            
        }
        public static void ContarLosNumerosHastaN()
        {
            Console.WriteLine("Ingrese el numero hasta el que desea contar");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void SoloSePermite_S_N()
        {
            Console.WriteLine("Ingrese el S o N:");
            string letra = Console.ReadLine();
            if (letra == "s" || letra == "S")
            {
                Console.WriteLine("Ha ingresado la S");
            }
            if (letra == "n" || letra == "N")
            {
                Console.WriteLine("Ha ingresado la N");
            }
            else 
            {
                Console.WriteLine("Debe ingresar solo S o N");
            }

        }
        public static void Positivo_Negativo()
        {
            try
            {
                Console.WriteLine("Ingrese un numero: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                if (numero > 0)
                {
                    Console.WriteLine("El numero es positivo: ");
                }
                else
                {
                    Console.WriteLine("El numero es negativo: ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("¿Seguro que ingreso un numero? ");
            }
            
        }

        public static void ParOImpar()
        {
            try
            {
                Console.WriteLine("Ingrese un numero: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero es par: ");
                }
                else
                {
                    Console.WriteLine("El numero es impar: ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("¿Seguro que ingreso un numero? ");
            }

        }
        public static void multiplosde3()
        {
            try
            {
                Console.WriteLine("Ingrese un numero: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                int cantMultiplos = 0;
                for (int i = 0; i <= numero; i+=3)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                        cantMultiplos++;
                    }
                }
                Console.WriteLine("La cantidad de multiplos de 3 en el numero ingresado es de  " + cantMultiplos);
            }
            catch (Exception)
            {
                Console.WriteLine("¿Seguro que ingreso un numero? ");
            }

        }

        public static void CalcularParesImpares()
        {
            try
            {
                int sumaPares = 0;
                int sumaImpares = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0) sumaPares = sumaPares + i;
                    else sumaImpares = sumaImpares  + i;
                }
                Console.WriteLine(sumaPares + "es la suma de los pares\n");
                Console.WriteLine(sumaImpares + "es la suma de los impares\n");
            }
            catch (Exception)
            {
                Console.WriteLine("¿Seguro que ingreso un numero? ");
            }

        }
        public static void MultiplosDe3y2()
        {
            try
            {
                int multiplode2 = 0;
                int multiplode3 = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        multiplode2++;
                        Console.WriteLine(i + "es multiplo de 2\n");
                    }
                                        
                    if(i % 3 == 0) 
                    {
                        multiplode3++;
                        Console.WriteLine(i + "es multiplo de 3\n");
                    }
                }
                Console.WriteLine(multiplode2 + "es la suma de los multiplos de 2\n");
                Console.WriteLine(multiplode3 + "es la suma de los multiplos de 3\n");
            }
            catch (Exception)
            {
                Console.WriteLine("¿Seguro que ingreso un numero? ");
            }

        }
    }
}
