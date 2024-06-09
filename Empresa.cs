namespace EspacioEmpresa;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargos cargo;

    //construcctor
    public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaDeIngreso, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaDeNacimiento = fechaDeNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaDeIngreso = fechaDeIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }
    //propiedades
    public int antiguedadDeEmpleado
    {
        get{
            TimeSpan antiguedad = DateTime.Now - FechaDeIngreso;
            return (int)antiguedad.TotalDays/365;
        }
    }
    public int edadDeEmpleado
    {
        get{
            TimeSpan edad = DateTime.Now - fechaDeNacimiento;
            return (int)edad.TotalDays/365;
        }
    }
    public int cantidadDeAniosParaJubilarse
    {
        get{
            int edadJubilacion = 65;
            return edadJubilacion - edadDeEmpleado;
        }
    }
    

    public double CalcularSalario() 
    {
    int antiguedad = antiguedadDeEmpleado;
    double adicional = 0;

    if (antiguedad <= 20)
    {
        adicional = SueldoBasico * (0.01 * antiguedad);
    }
    else
    {
        adicional = SueldoBasico * 0.25;
    }

    if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
    {
        adicional = adicional * 1.5;
    }

    if (EstadoCivil == 'c')
    {
        adicional = adicional + 150000;
    }

    return SueldoBasico + adicional;
}



    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
}

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
    
}