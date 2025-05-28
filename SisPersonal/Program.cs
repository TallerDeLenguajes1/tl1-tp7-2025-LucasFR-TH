// See https://aka.ms/new-console-template for more information
using CargarEmpelados;

console.WriteLine("SISPERSONAL");
Empleado[3] empleados = new Empleado[3]; //para cargar el arreglo con corchetes y la cantidad, con el tipo de dato

// Cargar manualmente los datos
empleados[0] = new Empleado
{
    Nombre = "Juan",
    Apellido = "Perez",
    FechaNacimiento = new DateTime(1985, 6, 15),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(2010, 3, 1),
    SueldoBasico = 50000,
    Cargo = Empleado.cargos.Auxiliar
};

empleados[1] = new Empleado
{
    Nombre = "Maria",
    Apellido = "Gomez",
    FechaNacimiento = new DateTime(1990, 8, 20),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2015, 5, 10),
    SueldoBasico = 80000,
    Cargo = Empleado.cargos.Ingeniero
};

empleados[2] = new Empleado
{
    Nombre = "Carlos",
    Apellido = "Lopez",
    FechaNacimiento = new DateTime(1975, 12, 5),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2000, 7, 15),
    SueldoBasico = 100000,
    Cargo = Empleado.cargos.Especialista
};

// Mostrar los empleados y su salario
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"Empleado {i + 1}: {empleados[i].Nombre} {empleados[i].Apellido}");
    Console.WriteLine($"Edad: {empleados[i].Edad()}");
    Console.WriteLine($"Antigüedad: {empleados[i].Antiguedad()} años");
    Console.WriteLine($"Años para jubilación: {empleados[i].CantidadJubil()}");
    Console.WriteLine($"Salario: {empleados[i].Salario():C}");
    Console.WriteLine();
}