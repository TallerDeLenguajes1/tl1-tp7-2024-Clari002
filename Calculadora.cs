namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;

    //metodos
    public void Suma(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato += termino;

        }
    }

    public void Restar(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato -= termino;
        }

    }

    public void Multiplicar(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato = dato * termino;

        }
    }

    public void Dividir(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato = dato / termino;

        }
    }

    public void Limpiar()
    {
        dato = 0;
    }

    public double Resultado //propiedad
    {
        get => dato; //devuelve    set(asigna)
    }

}