// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program
{
  static void SalaryCalculator()
  {

    Console.WriteLine("Calculadora de salario");
    Console.WriteLine();

    Console.WriteLine("Ingrese su nombre: ");
    string? userName = Console.ReadLine();
    Console.WriteLine();


    Console.WriteLine("Ingrese las horas trabajadas: ");
    int hoursWorked = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    Console.WriteLine("Ingrese la tarifa por hora: ");
    double hourlyRate = double.Parse(Console.ReadLine()!);
    Console.WriteLine();

    double salary = hoursWorked * hourlyRate;

    Console.WriteLine($"El salario para {userName} es de ${salary}");

  }
}