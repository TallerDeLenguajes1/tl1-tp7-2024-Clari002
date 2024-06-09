// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;
using EspacioCalculadora;
using EspacioEmpresa;

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
                    Console.WriteLine("Ingresar otro valor: ");
                    if (!int.TryParse(Console.ReadLine(), out int numero))
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                        return;
                    }

                    Console.WriteLine("Realizarle a: "+cal.Resultado);
                    
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

//punto 2
Empleado[] empleados = new Empleado[3];

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine("CARGAR DATOS DEL EMPLEADO "+(i+1)+":");

    Console.WriteLine("Nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Apellido: ");
    string apellido = Console.ReadLine();
    Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
    DateTime fechaDeNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    Console.WriteLine("Estado civil (s)soltera/o, (c)casada/o");
    char estadoCivil = Console.ReadLine()[0];
    Console.WriteLine("Fecha de ingreso en la empresa (dd/mm/aaaa): ");
    DateTime fechaIngreso = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

    Console.WriteLine("Sueldo Básico: ");
    double sueldoBasico = double.Parse(Console.ReadLine());

    Console.WriteLine("Cargo (Auxiliar, Administrativo, Ingeniero, Especialista, Investigador): ");
    Cargos cargo = (Cargos)Enum.Parse(typeof(Cargos), Console.ReadLine());

    // Crear instancia de Empleado y asignar los valores ingresados
    Empleado empleado = new Empleado(nombre, apellido, fechaDeNacimiento , estadoCivil, fechaIngreso, sueldoBasico, cargo);

    // Agregar el empleado al arreglo
    empleados[i] = empleado;

    Console.WriteLine();
}

double montoTotalDeSalarios =  0;
foreach (Empleado empl in empleados)
{
    montoTotalDeSalarios = montoTotalDeSalarios + empl.CalcularSalario();
}

Empleado emplProxAJubilarse = empleados[0];
foreach (Empleado empl in empleados)
{
    if (empl.cantidadDeAniosParaJubilarse < emplProxAJubilarse.cantidadDeAniosParaJubilarse)
    {
        emplProxAJubilarse = empl;
    }
}

Console.WriteLine("-------------RESULTADOS--------------");
Console.WriteLine("Empleado mas proximo a jubilarse: ");
Console.WriteLine("Nombre: "+ emplProxAJubilarse.Nombre);
Console.WriteLine("Apellido: "+emplProxAJubilarse.Apellido);
Console.WriteLine("Edad: "+emplProxAJubilarse.edadDeEmpleado);
Console.WriteLine("Años para jubilarse: "+ emplProxAJubilarse.cantidadDeAniosParaJubilarse);
Console.WriteLine("Salario: "+ emplProxAJubilarse.CalcularSalario());

Console.WriteLine("Monto total de salarios: "+montoTotalDeSalarios);

