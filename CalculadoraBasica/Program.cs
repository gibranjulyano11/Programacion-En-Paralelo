using System;

namespace CalculadoraBasica
{
    class CalculadoraBasica
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora Básica";
            string respuesta = "";
            do
            {
                int primerNumero = 0;
                int segundoNumero = 0;
                int resultado = 0;

                Console.WriteLine("¿Qué operación deseas realizar?");
                Console.WriteLine("Para sumar [+]");
                Console.WriteLine("Para restar [-]");
                Console.WriteLine("Para multiplicar [*]");
                Console.WriteLine("Para dividir [/]");
                Console.Write("Elije una operación: ");

                respuesta = Console.ReadLine();
                string operacion = Convert.ToString(respuesta);

                Console.Write("Primer número: ");
                primerNumero = int.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                segundoNumero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacion)
                {
                    case "+":
                        {
                            Console.WriteLine("El resultado de su operación (suma) es:");
                            resultado = primerNumero + segundoNumero;
                            Console.WriteLine("{0} + {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("El resultado de su operación (resta) es:");
                            resultado = primerNumero - segundoNumero;
                            Console.WriteLine("{0} - {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("El resultado de su operación (multiplicación) es:");
                            resultado = primerNumero * segundoNumero;
                            Console.WriteLine("{0} * {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("El resultado de su operación (división) es:");
                            resultado = primerNumero / segundoNumero;
                            Console.WriteLine("{0} / {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                }
                Console.WriteLine("¿Deseas Continuar?");
                Console.WriteLine("Si deseas continuar pon la [s] seguido del enter");
                Console.Write("Si deseas salir pon la [n] seguido del enter");

                respuesta = Console.ReadLine();
            }
            while (respuesta == "s" || respuesta == "s");
        }
    }
}