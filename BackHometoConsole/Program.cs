using System;

// La idea de este proyecto es solo que sea sencillo y poder escribir algunas lineas en una consola

bool active = true;

while (active)
{
    Console.WriteLine("Llevaba un tiempito sin ver a VS, tratando de probar otras alternativas pero ya volvi /n");
    Console.WriteLine("Que desea ver? /n");

    Console.WriteLine("1- Aplicaciones, 2- SobreMi ");
    Console.Write("Seleccione:");

    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            MetodoAplicaciones();
            break;

        case 2:
            MetodoSobreMi();
            break;

        default:
            Console.WriteLine();
            break;
    }


    // Cierre
    Console.WriteLine("Presione cualquier tecla");
    Console.ReadKey();
    Console.Clear();

}



void MetodoAplicaciones()
{
	Console.WriteLine("Seleccione cual aplicacion desea");
    int appOption = int.Parse(Console.ReadLine());

    switch (appOption)
    {
        // Aplicacion 1 = Hola Mundo
        case 1:
            Console.WriteLine("Hola Mundo, este es un programa de consola que realize solo para ejercitarme un poco");
            break;

        // Aplicacion 2 = Calculadora con Dos Numeros
        case 2:
            Console.WriteLine("Seleccione dos numeros");

            Console.Write("Primer Numero: ");
            float num1= int.Parse(Console.ReadLine());

            Console.Write("Segundo Numero: ");
            float num2= int.Parse(Console.ReadLine());

            Console.WriteLine("Que operacion desea realizar?");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"La suma es igual a {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"La suma es igual a {num1 - num2}");
                    break;

                case 3:
                    Console.WriteLine($"La suma es igual a {num1 * num2}");
                    break;

                case 4:

                    float dividethem = num1 / num2;
                    try
                    {
                        Console.WriteLine($"La suma es igual a {num1 / num2}");
                        break;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }

                    break;

                case 5:
                    Console.WriteLine($"La suma es igual a {num1 + num2}");
                    break;

                default:
                    break;
            }

            break;
        default:
            break;
    }
}


void MetodoSobreMi(){

}