// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;
using EspacioCalculadora;

Calculadora calcu = new Calculadora();

Console.WriteLine(".............CALCULADORA...............");
Console.WriteLine("Ingresar primer numero: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}else{
    Console.WriteLine("Ingresar segundo numero: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("El valor ingresado no es un numero");
        return;
    }else{
        Console.WriteLine("Realizar: ");
        Console.WriteLine("(1)Suma");
        Console.WriteLine("(2)Resta");
        Console.WriteLine("(3)Multiplicacion");
        Console.WriteLine("(4)Dividision");
        Console.WriteLine("(0)Salir");
        Console.WriteLine("Respuesta: ");
        if (!int.TryParse(Console.ReadLine(), out int opcion))
        {
            Console.WriteLine("El valor ingresado no es valido");
            return;
        }

        switch (opcion)
        {
            case 1:
                calcu.Suma(num1);
                calcu.Suma(num2);
                Console.WriteLine("Resultado: " + calcu.Resultado);
            break;

            case 2:
                calcu.Restar(num1);
                calcu.Restar(num2);
                Console.WriteLine("Resultado: " + calcu.Resultado);
            break;

            case 3:
                calcu.Multiplicar(num1);
                calcu.Multiplicar(num2);
                Console.WriteLine("Resultado: " + calcu.Resultado);
            break;

            case 4:
                calcu.Dividir(num1);
                calcu.Dividir(num2);
                Console.WriteLine("Resultado: " + calcu.Resultado);
            break;

            default:
            break;
        }

        do
        {
            Console.WriteLine("¿Realizar otra operacion: 1(SI) 0(NO)");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("El valor ingresado no es valido");
                return;
            }
            else
            {
                if (opcion == 1)
                {
                    calcu.Limpiar();
                    Console.WriteLine("Ingresar primer numero: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                        return;
                    }
                    Console.WriteLine("Ingresar otro numero: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                        return;
                    }
                    Console.WriteLine("(1)Suma");
                    Console.WriteLine("(2)Resta");
                    Console.WriteLine("(3)Multiplicacion");
                    Console.WriteLine("(4)Dividision");
                    Console.WriteLine("(0)Salir");
                    Console.WriteLine("Respuesta: ");
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                        return;
                    }

                    switch (opcion)
                    {
                        case 1:
                            calcu.Suma(num1);
                            calcu.Suma(num2);
                            Console.WriteLine("Resultado: " + calcu.Resultado);
                            break;

                        case 2:
                            calcu.Restar(num1);
                            calcu.Restar(num2);
                            Console.WriteLine("Resultado: " + calcu.Resultado);
                        break;

                        case 3:
                        calcu.Multiplicar(num1);
                        calcu.Multiplicar(num2);
                        Console.WriteLine("Resultado: " + calcu.Resultado);
                        break;

                        case 4:
                        calcu.Dividir(num1);
                        calcu.Dividir(num2);
                        Console.WriteLine("Resultado: " + calcu.Resultado);
                        break;

                        default:
                        break;
                    }
                }
            }
        }while(opcion != 0);
    }
}

