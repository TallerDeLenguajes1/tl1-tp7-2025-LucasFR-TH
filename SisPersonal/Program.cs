// See https://aka.ms/new-console-template for more information
using CargarEmpleados;

Console.WriteLine("SISPERSONAL");
Empleado[] empleados = new Empleado[3]; //para cargar el arreglo con corchetes y la cantidad, con el tipo de dato

// Cargar manualmente los datos
empleados[0] = new Empleado
{
    Nombre = "Juan",
    Apellido = "Perez",
    FechaNacimiento = new DateTime(1985, 6, 15),
    Estadocivil = 'S',
    FechaIngreso = new DateTime(2010, 3, 1),
    Sueldobasico = 50000,
    Cargo = Empleado.cargos.Auxiliar,
};

empleados[1] = new Empleado
{
    Nombre = "Maria",
    Apellido = "Gomez",
    FechaNacimiento = new DateTime(1990, 8, 20),
    Estadocivil = 'C',
    FechaIngreso = new DateTime(2015, 5, 10),
    Sueldobasico = 70000,
    Cargo = Empleado.cargos.Ingeniero
};

empleados[2] = new Empleado
{
    Nombre = "Carlos",
    Apellido = "Lopez",
    FechaNacimiento = new DateTime(1975, 12, 5),
    Estadocivil = 'C',
    FechaIngreso = new DateTime(2000, 7, 15),
    Sueldobasico = 90000,
    Cargo = Empleado.cargos.Especialista
};

// Mostrar los empleados y su salario
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"Empleado {i + 1}: {empleados[i].Nombre} {empleados[i].Apellido}");
    Console.WriteLine($"Edad: {empleados[i].Edad()} años");
    Console.WriteLine($"Antigüedad: {empleados[i].Antiguedad()} años");
    Console.WriteLine($"Años para jubilación: {empleados[i].CantidadJubil()}");
    Console.WriteLine($"Salario: $ {empleados[i].Salario()}");
    Console.WriteLine();
}

float totalSalario = 0;
// Calcular el total de salarios
for (int i = 0; i < empleados.Length; i++)
{
    totalSalario += (float)empleados[i].Salario();
}

Console.WriteLine($"Total de salarios: $ {totalSalario}");