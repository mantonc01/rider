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
    /*public class Program
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
    }*/
    /*public class Program
    {
        public static void Main(string[] args)
        {

            /*(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña
                (ambos numéricos), y no le permita seguir hasta que introduzca como
                identificador "1234" y como contraseña "1111".#1#
            
            int identificador=1234,contraseña=1111,identifica,contra;
            Console.WriteLine("introduce tu identificador y contraseña : ");
            

            do
            {
               Console.Write("identificador: ");
                           identifica = Convert.ToInt32(Console.ReadLine());
                Console.Write("contraseña: ");
                           contra = Convert.ToInt32(Console.ReadLine());
                           if ((identifica!=identificador)&(contra!=contraseña))
                           {
                               Console.WriteLine("incorrecto");
                           }
                           else
                           {
                               Console.WriteLine("correcto");
                           }
            } while ((identifica!=identificador)&(contra!=contraseña));
            
        }
    }*/
    /*public class Program
    {
        public static void Main(string[] args)
        {

            /*(2.2.3.1.3) Crea un programa que muestre los números del 100 al 200 (ambos
            incluidos) que sean divisibles entre 7 y a la vez entre 3.#1#

            int identificador = 1234, contraseña = 1111, identifica, contra;
            Console.WriteLine("introduce tu identificador y contraseña : ");
            Console.WriteLine("numeros divisibles entre 7 y 3");
            for (int i = 100; i <= 200; i++)
            {
                if ((i % 7 == 0) & (i % 3 == 0))
                {
                    Console.WriteLine(i);
                }

            }



        }
    }*/
    /*public class Program
    {
        public static void Main(string[] args)
        {

            /*(2.2.5.3) Crea un programa que, para los números entre el 10 y el 20 (ambos
            incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles
            entre 7.#1#

            int identificador = 1234, contraseña = 1111, identifica, contra;
            Console.WriteLine("introduce tu identificador y contraseña : ");
            Console.WriteLine("numeros divisibles entre 5 , 6, y 7");
            for (int i = 10; i <= 20; i++)
            {
                for (int j = 5; j <= 7; j++)
                {
                    if ((i % j == 0))
                    {
                        Console.WriteLine(i + " es divisible entre {0}",j);
                    }
                }
            }
        }
    }*/
    /*public class Program
    { public static void Main(string[] args)
        {
            /*(2.7.2) Crea un programa que pregunte al usuario su edad y su año de nacimiento.
            Si la edad que introduce no es un número válido, mostrará un mensaje de aviso,
            pero aun así le preguntará su año de nacimiento.#1#
            int age, year;
            try
            {
                Console.Write("introduce tu edad : ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(" Has introducido un texto en la edad");
            }
            finally
            {
                try
                {
                    Console.Write("introduce tu año de nacimiento : ");
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Has introducido un texto en el año");
                }
            }
        }
    }*/
    public class Program
    { public static void Main(string[] args)
        {
            /*(2.7.2) Crea un programa que pregunte al usuario su edad y su año de nacimiento.
            Si la edad que introduce no es un número válido, mostrará un mensaje de aviso,
            pero aun así le preguntará su año de nacimiento.*/
            int age, year;
            try
            {
                Console.Write("introduce tu edad : ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(" Has introducido un texto en la edad");
            }
            finally
            {
                try
                {
                    Console.Write("introduce tu año de nacimiento : ");
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Has introducido un texto en el año");
                }
            }
        }
    }