namespace Empleado;

public class Empleado
{
    public enum cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
    private string nombre;
    private string apellido;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private DateTime fechaingreso;
    private double sueldobasico;
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
}