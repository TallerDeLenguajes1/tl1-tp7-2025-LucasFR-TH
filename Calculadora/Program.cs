// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calc = new Calculadora();

Console.WriteLine("--------------------------------------");
Console.WriteLine(".............CALCULADORA..............");
Console.WriteLine("--------------------------------------");
int opern = 1;
while (opern != 0)
{
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");

    string oper = Console.ReadLine();

    if (int.TryParse(oper, out opern))
    {
        if (opern != 0)
        {
            Console.WriteLine("Ingrese el numero a computar:");
            string termino = Console.ReadLine();

            double terminon;

            if (double.TryParse(termino, out terminon))
            {
                switch (opern)
                {
                    case 1:
                        calc.Sumar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        break;
                    case 2:
                        calc.Restar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        break;
                    case 3:
                        calc.Multiplicar(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        break;
                    case 4:
                        calc.Dividir(terminon);
                        Console.WriteLine("Resultado:" + calc.Resultado.ToString());
                        break;
                    default:
                        break;
                }
            }
        }
    }

        
}