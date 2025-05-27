namespace Empleado;

public class Empleado
{
    public enum cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
    private string nombre;
    private string apellido;
    private DateTime fechadenacimiento;
    public DateTime Fechadenacimiento
    {
        get => fechadenacimiento;
    }
    private char estadocivil;
    private DateTime fechaingreso;
    public DateTime Fechaingreso
    {
        get => fechaingreso;
    }
    private double sueldobasico;
    public double Sueldobasico
    {
        get => sueldobasico;
    }
    private cargos MyProperty;

    public int Antiguedad()
    {
        return DateTime.Now.Year - fechaingreso.Year;
    }

    public int Edad()
    {
        return DateTime.Now.Year - fechadenacimiento.Year;
    }

    public int CantidadJubil()
    {
        return 65 - Edad();
    }

    public double Salario()
    {
        double adicional;
        if (Antiguedad() < 20)
        {
            adicional = (sueldobasico + sueldobasico * 0.01) * Antiguedad();
        }
        else
        {
            adicional = ((sueldobasico + sueldobasico * 0.01) * 20) + ((sueldobasico + sueldobasico * 0.25) * (Antiguedad() - 20));
        }

        return sueldobasico + adicional;
    }
}