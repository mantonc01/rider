    using System;
    using System.Threading;

    /*public class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Hola Mundo!!!!!!");
        Thread.Sleep(30000);
        
        }
    }
    */
    using System;

    /*public class Program
    {
        public static void Main(string[] args)
        {
            
            //bucle while
            int numero;
            Console.Write("introduce un numero : " );
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                if (numero>0)
                {
                    Console.WriteLine("numero posivo");
                }
                else
                {
                    Console.WriteLine("numero negativo");
                }
                Console.Write("introduce un numero ( el 0 para salir) : " );
                numero = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
    */
    public class Program
    {
        public static void Main(string[] args)
        {

            //calcula cuantas cifras tiene un numero entero positivo
            int numero;
            Console.Write("introduce un numero : ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                int cifras=0;
                while (numero > 0)
                {
                    
                    cifras++;
                    numero=numero / 10;

                }
                Console.WriteLine("tiene " + cifras + " cifras");

            }
            else
            {
                Console.WriteLine("tiene 0 cifras");
            }
        }
    }