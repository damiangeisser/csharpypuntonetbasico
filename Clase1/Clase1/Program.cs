using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1 //Namespace
{
    class Program //Clase
    {
        static void Main(string[] args)//Método
        {
            //String nombre;

            //Console.WriteLine("Por favor ingrese su nombre y presione enter:");

            //nombre = Console.ReadLine();

            //Console.WriteLine("Hola " + nombre);

            //Console.ReadKey(); /*Pauso el programa*/

            ////msdn.microsoft.com/library para ver las clases y su info

            int num;


            Console.WriteLine("Por favor ingrese un número y presione enter:");

            num = Convert.ToInt32(Console.ReadLine()); //para indentar, alcanza con borrar y escribir el ;

            Console.WriteLine("Usted ingresó: " + num);

            if (num%2 == 0)
            {
                Console.WriteLine(num + " es par");
            }
            else
            {
                Console.WriteLine(num + " es impar");
            }

            Console.ReadKey();

        }
    }
}
