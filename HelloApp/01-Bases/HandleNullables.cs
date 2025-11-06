partial class Program
{
  static void HandleNullables()
  {
    // No nullables
    string firstNamee = "Gilbert";

    // Nullables
    string? lastName = null;

    Console.WriteLine($"Nombre: {firstNamee}");

    if (lastName == null)
    {
      Console.WriteLine("El apellido es nulo.");
    }
    else
    {
      Console.WriteLine($"Apellido: {lastName}");
    }

    // Operator null coalescing
    Console.WriteLine($"Apellido: {lastName ?? "El apellido es nulo.!!!"}");

    // Operator secured null coalescing
    string? text = null;
    Console.WriteLine(text?.Length);
    Console.WriteLine("Sigue ejecutando");

  }

}

