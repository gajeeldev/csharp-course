partial class Program
{
  static void Operators()
  {
    int number = 12;
    bool isEven = number % 2 == 0;
    bool isGreaterThan10 = number > 10;

    if (isEven && isGreaterThan10)
    {
      Console.WriteLine("El número es par y mayor que 10");

    }
    else if (!isEven && isGreaterThan10)
    {
      Console.WriteLine("El número es impar y mayor que 10");

    }
    else
    {

      Console.WriteLine($"El número {number} no cumple con las condiciones.");
    }


    // Ternary operator
    int age = 21;
    string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";

    Console.WriteLine(message);
  }

}

