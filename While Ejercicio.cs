using System;

namespace Practica_quinta_clase
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Ingresar 5 números y mostrar su promedio.

            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("Ingresa aqui:");

            Console.WriteLine("Ingresa 5 numeros");

            Console.WriteLine("Ingrese el primer numero");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            int Num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero");
            int Num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto numero");
            int Num5 = int.Parse(Console.ReadLine());

            int Suma = Num1 + Num2 + Num3 + Num4 + Num5;
            int Cantidad = 5;
            int Promedio = Suma / Cantidad;

            Console.WriteLine("El promedio es..." + Promedio);







            //2.Ingresar un número y mostrar el cuadrado del
            //mismo.El número debe ser mayor que cero, en caso de error que aparezca el
            //mensaje "ERROR. Reingresar numero”.

            Console.WriteLine("Ejercicio 2");

            int Numero = int.Parse(Console.ReadLine());
            int Cuadrado = Numero * Numero;
            Console.WriteLine(Cuadrado);

            while (Cuadrado == 0)
            {
                Console.WriteLine("Error. Reingresar numero");
                break;
            }







            //3.De 10 números ingresados indicar cuántos son mayores a cero y cuántos son menores a cero.

            Console.WriteLine("Ejercicio 3");

            Console.WriteLine("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());

            while (numero1 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero1 < 0)
            {
                Console.WriteLine("El numero es menor a 0");
                break;
            }


            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            while (numero2 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero2 < 0)
            {
                Console.WriteLine("El numero es menor a 0");
                break;
            }


            Console.WriteLine("Ingrese el tercer numero");
            int numero3 = int.Parse(Console.ReadLine());

            while (numero3 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero3 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el cuarto numero");
            int numero4 = int.Parse(Console.ReadLine());

            while (numero4 > 0)
            {
                Console.WriteLine("El numero es mayor que 0");
                break;
            }
            while (numero4 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el quinto numero");
            int numero5 = int.Parse(Console.ReadLine());

            while (numero5 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero5 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }

            Console.WriteLine("Ingrese el sexto numero");
            int numero6 = int.Parse(Console.ReadLine());

            while (numero6 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero6 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el septimo numero");
            int numero7 = int.Parse(Console.ReadLine());

            while (numero7 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero7 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el octavo numero");
            int numero8 = int.Parse(Console.ReadLine());

            while (numero8 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero8 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el noveno numero");
            int numero9 = int.Parse(Console.ReadLine());

            while (numero9 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero9 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }


            Console.WriteLine("Ingrese el decimo numero");
            int numero10 = int.Parse(Console.ReadLine());

            while (numero10 > 0)
            {
                Console.WriteLine("El numero es mayor a 0");
                break;
            }
            while (numero10 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
                break;
            }



            //4.Realizar un programa que imprima en pantalla los números del 1 al 50.

            Console.WriteLine("Ejercicio 4");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + ",");
            }
            Console.ReadKey();


            //5.Realizar un programa que dado un numero n entero, imprima consecutivamente hasta n.

            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Ingrese un numero:");

            for (int a = int.Parse(Console.ReadLine()); a < 100; a++)
            {
                Console.WriteLine(a + ",");
            }
            Console.ReadKey();


            //6.Realizar un programa que muestre sólo los números pares entre 1 y 100. 

            Console.WriteLine("Ejercicio 6");

            

            for (int NumerosPares = 0; NumerosPares < 100; NumerosPares += 2)
            {
                Console.WriteLine(NumerosPares + ",");
            }
            Console.ReadKey();
        }
    }
}