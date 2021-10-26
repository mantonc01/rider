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
    using System.Text;

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
    /*public class Program
    { public static void Main(string[] args)
        {
            /*(4.1.3.11) Un programa que pida al usuario 4 números enteros y calcule (y
            muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array,
            hay que comparar cada uno de los valores que tiene almacenados el array con el
            que hasta ese momento es el máximo provisional. El valor inicial de este máximo
            provisional no debería ser cero (porque el resultado sería incorrecto si todos los
            números son negativos), sino el primer elemento del array.#1#
            
            int []arrayNumeros=new int[4];
            int mayor;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.Write("introduce el {0} numero: ", i+1);
                arrayNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            mayor = arrayNumeros[0];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i]>mayor)
                {
                    mayor = arrayNumeros[i];
                }
            }
            Console.WriteLine("the biggest number is: {0}",mayor);
        }
    }*/
    /*
    public class Program
    { public static void Main(string[] args)
        {
            /*(4.2.3) Un programa que pregunte al usuario el tamaño que tendrán dos bloques
            de números enteros (por ejemplo, uno de 10 elementos y otro de 12). Luego            
            pedirá los datos para ambos bloques de datos. Finalmente deberá mostrar el
            mayor dato que se ha introducido en cada uno de ellos. #1#
            
            int rows, columns,mayorRows, mayorColumns;
            
            Console.Write("dame el tamaño de fila :");
            rows=Convert.ToInt32(Console.ReadLine());
            Console.Write("dame el tamaño de columna :");
            columns=Convert.ToInt32(Console.ReadLine());
            
            int [,]notas1=new int[rows,columns];
            
            for (int i = 0; i < notas1.GetLength(0); i++)
            {
                for (int j = 0; j < notas1.GetLength(1); j++)
                {
                    Console.WriteLine("dame la posición : {0} , {1} ",i,j);
                    notas1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            mayorRows = notas1[0, 0];
            mayorColumns = notas1[0, 0];
            for (int i = 0; i < notas1.GetLength(0); i++)
            {
                if (notas1[i,0]>mayorRows)
                {
                    mayorRows = notas1[i, 0];
                }
                
                for (int j = 0; j < notas1.GetLength(1); j++)
                {
                    if (notas1[i,j]>mayorRows)
                    {
                        mayorColumns = notas1[i, j];
                    }
                    
                }
                Console.WriteLine("mayor de fila" + mayorRows);
                Console.WriteLine();
                Console.WriteLine("mayor de columna" + mayorColumns);
            }
        }
    }
    */
    /*
    public class Program
    { public static void Main(string[] args)
        {
            /*(4.4.3.3) Un programa que pida al usuario una frase, después una letra y
            finalmente diga si aparece esa letra como parte de esa frase o no. #1#
            
            int rows, columns,mayorRows, mayorColumns;
            string frase;
            char letra;
            bool encontrado = false;
            
            Console.WriteLine("dame una frase :");
            frase=Console.ReadLine();
            Console.Write("dame una letra :");
            letra=Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i]==letra)
                {
                    encontrado = true;
                }   
            }

            if (encontrado)
            {
                Console.WriteLine("encontrada la \"{0}\" en la frase.", letra);
            }
            else
            {
                Console.WriteLine("no encontrada la \"{0}\" en la frase.", letra);
            }
              
        }
    }
    */
    /*public class Program
    { public static void Main(string[] args)
        {
            /*(4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario introduzca la
            palabra a adivinar, se muestre ésta oculta con guiones (-----) y el programa acepte
            las letras que introduzca el segundo usuario, cambiando los guiones por letras
            correctas cada vez que acierte (por ejemplo, a---a-t-). La partida terminará cuando
            se acierte la palabra por completo o el usuario agote sus 8 intentos. #1#
            
            int intentos=8,aciertos=0;
            string fraseOculta;
            StringBuilder Oculta;
            char letra;
            Console.WriteLine("JUGADOR 1");
            Console.WriteLine("dame una palabra :");
            fraseOculta=Console.ReadLine();
            Console.Write("PALABRA SECRETA : ");
            Oculta = new StringBuilder(fraseOculta);
            for (int i = 0; i < fraseOculta.Length; i++)
            {
                Console.Write("-");
                Oculta[i]='-';
            }
            Console.WriteLine();
            Console.WriteLine("JUGADOR 2");
            do
            {
                Console.WriteLine("player 2: please, enter a letter : ");
                letra=Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < fraseOculta.Length; i++)
                {
                    if (fraseOculta[i]==letra)
                    {
                        Oculta[i] = letra;
                        aciertos++;
                    } 
                }
                Console.WriteLine(Oculta.ToString());
                intentos--;
                Console.WriteLine("you have {0} attempts left",intentos); 
            } while (intentos>0 && aciertos<fraseOculta.Length);

            if (aciertos==fraseOculta.Length)
            {
                Console.WriteLine("---CONGRATULATIONS. YOU ARE WIN---");
            }
            else
            {
                Console.WriteLine("---OHHH. YOU ARE LOSE---");
            }
            Console.WriteLine("---END---");
        }
 }
 */
    public class Program
    { public static void Main(string[] args)
        {
            /*(4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario introduzca la
            palabra a adivinar, se muestre ésta oculta con guiones (-----) y el programa acepte
            las letras que introduzca el segundo usuario, cambiando los guiones por letras
            correctas cada vez que acierte (por ejemplo, a---a-t-). La partida terminará cuando
            se acierte la palabra por completo o el usuario agote sus 8 intentos. */
            
            int intentos=8,aciertos=0;
            string fraseOculta;
            StringBuilder oculta;
            char letra;
            Console.WriteLine("JUGADOR 1");
            Console.WriteLine("dame una palabra :");
            fraseOculta=Console.ReadLine();
            Console.Write("PALABRA SECRETA : ");
            oculta = new StringBuilder(fraseOculta);
            for (int i = 0; i < fraseOculta.Length; i++)
            {
                Console.Write("-");
                oculta[i]='-';
            }
            Console.WriteLine();
            Console.WriteLine("JUGADOR 2");
            do
            {
                Console.WriteLine("player 2: please, enter a letter : ");
                letra=Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < fraseOculta.Length; i++)
                {
                    if (fraseOculta[i]==letra)
                    {
                        oculta[i] = letra;
                        aciertos++;
                    } 
                }
                Console.WriteLine(oculta.ToString());
                intentos--;
                Console.WriteLine("you have {0} attempts left",intentos); 
            } while (intentos>0 && aciertos<fraseOculta.Length);

            if (aciertos==fraseOculta.Length)
            {
                Console.WriteLine("---CONGRATULATIONS. YOU ARE WIN---");
            }
            else
            {
                Console.WriteLine("---OHHH. YOU ARE LOSE---");
            }
            Console.WriteLine("---END---");
        }
 }




