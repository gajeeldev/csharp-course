partial class Program
{
  static void StringTypes()
  {
    string name = "Juan";
    string message = "Hola " + name + "!";
    string interpolatedMessage = $"Hola {name}!";

    Console.WriteLine(message);
    Console.WriteLine(interpolatedMessage);
    Console.WriteLine($"Tu nombre tiene {name.Length} letras.");
    Console.WriteLine($"Tu nombre en mayúsculas es {name.ToUpper()}.");
    Console.WriteLine($"Tu nombre en minúsculas es {name.ToLower()}.");

    int number = 42;
    string numberAsString = number.ToString();

    Console.WriteLine(numberAsString);

    bool isTrue = true;
    string booleanAsString = isTrue.ToString();

    Console.WriteLine(booleanAsString);
  }
}