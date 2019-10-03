using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else y switch

            //EsMayor();

            // Premiar4();

            Validar2();

            Console.ReadKey();

        }

        static void EsMayor() /*los métodos estáticos no requieren ser instanciados para ser utilizados*/
        {
            int num1 = 0, num2; // int de 32 bits. C# no obliga a inicilizar las variables para compilar.

            num2 = 0; // Alternativa a inicializar en la misma sentencia.

            num1 = 30;
            num2 = 20;

            if (num1 > num2)
            {
                Console.WriteLine("Num1 es mayor que Num2"); // Al ejecutar una sola sentencia, podría omitir las {}.
            }
            else
            {
                Console.WriteLine("Num1 no es mayor que Num2");
            }

            Console.WriteLine("Fin");
        }

        static void Premiar()
        {
            int respuesta = 0;

            Console.WriteLine("Por favor ingrese un número del 1 al 3:");

            respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
                Console.WriteLine("Ganaste una camiseta");
            else if (respuesta == 2)
                Console.WriteLine("Ganaste una bandera");
            else if (respuesta == 3)
                Console.WriteLine("No ganaste nada");
            else
                Console.WriteLine("No ingresó un valor correcto.");
        }

        static void Premiar2()
        {
            string respuesta = "";

            Console.WriteLine("Por favor ingrese un número del 1 al 3:");

            respuesta = Console.ReadLine();

            if (respuesta == "1")
                Console.WriteLine("Ganaste una camiseta");
            else if (respuesta == "2")
                Console.WriteLine("Ganaste una bandera");
            else if (respuesta == "3")
                Console.WriteLine("No ganaste nada");
            else
                Console.WriteLine("No ingresó un valor correcto.");
        }

        static void EsMayor2()
        {
            int num1, num2, num3;

            string mensaje;

            num1 = 3;
            num2 = 1;
            num3 = 2;

            if (num1 > num2)
                if (num1 > num3)
                    mensaje = "num1 " + num1 + " es el mayor";
                //Console.WriteLine("num1 {0} es el mayor", num1);
                else
                    mensaje = "num3 " + num3 + " es el mayor";               
            else
                if (num2 > num3)
                    mensaje = "num2 " + num2 + " es el mayor";
            else
                mensaje = "num3 " + num3 + " es el mayor";

            Console.WriteLine(mensaje);
        }

        static void Premiar4()
        {
            string respuesta = "", mensaje = "";

            Console.WriteLine("Por favor ingrese un número del 1 al 3:");

            respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "1":
                    mensaje = "Ganaste una camiseta";
                    break;
                case "2":
                    mensaje = "Ganaste una bandera";
                    break;
                case "3":
                    mensaje = "No ganaste nada";
                    break;
                default:
                    mensaje = "No ingresó un valor correcto.";
                    break;
            }

            Console.WriteLine(mensaje);
        }

        static void Validar()
        {
            string user, password, mensaje;

            user = "";
            password = "";
            mensaje = "";

            Console.Write("Por favor ingrese su usuario: ");

            user = Console.ReadLine();

            user = user.ToUpper(); //Paso el usuario a mayúscula.

            Console.Write("Por favor ingrese su contraseña: ");

            password = Console.ReadLine();

            //if(user == "PEPE" && password == "123")
            //    //mensaje = "Bienvenido " + user;
            //    mensaje = "Bienvenido Pepe";
            //else if(user != "PEPE")
            //    mensaje = "Usuario incorrecto";
            //else
            //    mensaje = "Contraseña incorrecta";

            //Console.WriteLine(mensaje);

            if (user == "PEPE")
                if (password == "123") 
                    mensaje = "Bienvenido Pepe";
                else
                    mensaje = "Contraseña incorrecta";
            else
                mensaje = "Usuario incorrecto";

            Console.WriteLine(mensaje);
        }

        static void Validar2()
        {
            string user, password, mensaje;

            user = "";
            password = "";
            mensaje = "";

            Console.Write("Por favor ingrese su usuario: ");

            user = Console.ReadLine().ToUpper(); // Alternativa para pasar el usuario a mayúscula.

            Console.Write("Por favor ingrese su contraseña: ");

            password = Console.ReadLine();

            switch(user)
            {
                case "PEPE":
                    if(password=="123")
                        mensaje = "Bienvenido Pepe";
                    else
                        mensaje = "Contraseña incorrecta";
                    break;
                case "PEDRO":
                    if (password == "abc")
                        mensaje = "Bienvenido Pedro";
                    else
                        mensaje = "Contraseña incorrecta";
                    break;
                case "JUAN":
                    if (password == "xxx")
                        mensaje = "Bienvenido Juan";
                    else
                        mensaje = "Contraseña incorrecta";
                    break;
                default:
                    mensaje = "Usuario incorrecto";
                    break;
            }

            Console.WriteLine(mensaje);
        }

    }
}