using System.Globalization;

partial class Program
{
  static void DaysOfLife()
  {
    DateTime birthDate = new DateTime(1996, 5, 9);
    TimeSpan difference = DateTime.Now - birthDate;

    Console.WriteLine($"I've been alive for {difference.Days} days.");


  }

  // 🏆 Ejercicio:
  // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
  // Consideraciones:
  // - La fecha de nacimiento ingresada debe ser interpretada correctamente,
  //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
  // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
  // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual,
  //   sumando un año para calcular la fecha del próximo (opcional).

  static void DaysUntilNextBirthday()
  {

    Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
    DateTime birthDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy",CultureInfo.InvariantCulture);

    DateTime nextBirthday = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);

    if (nextBirthday < DateTime.Now)
    {
      nextBirthday = nextBirthday.AddYears(1);
    }

    TimeSpan difference = nextBirthday - DateTime.Now;

    Console.WriteLine($"Faltan {difference.Days} días para tu próximo cumpleaños.");


  }

}