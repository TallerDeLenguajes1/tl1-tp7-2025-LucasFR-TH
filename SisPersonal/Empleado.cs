namespace CargarEmpleados;

public class Empleado
{
    public enum cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }

    // CAMPOS Y PROPIEDADES
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    private string apellido;
    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }
    private DateTime fechadenacimiento;
    public  DateTime FechaNacimiento
    {
        get => fechadenacimiento;
        set => fechadenacimiento = value;
    }

    private char estadocivil;
    public char Estadocivil
    {
        get => estadocivil;
        set => estadocivil = value;
    }
    private DateTime fechaingreso;
    public DateTime FechaIngreso
    {
        get => fechaingreso;
        set => fechaingreso = value;
    }

    private double sueldobasico;    
    public double Sueldobasico
    {
        get => sueldobasico;
        set => sueldobasico = value;
    }
    private cargos cargo;
    public cargos Cargo
    {
        get => cargo;
        set => cargo = value;
    }

    // METODOS
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

        if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
        {
            adicional = adicional * 1.5;
        }

        if (estadocivil == 'C')
        {
            adicional = adicional + 150000;
        }

        return sueldobasico + adicional;
    }
}