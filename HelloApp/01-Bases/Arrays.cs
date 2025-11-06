partial class Program
{
  static void Arrays()
  {
    int[] numbers = new int[5];
    numbers[0] = 1;
    numbers[1] = 3;

    int[] numbersArray = [5, 12, 15, 20, 25, 30];

    // Indexes

    Console.WriteLine($"Primer elemento {numbersArray[0]}");
    Console.WriteLine($"Tercer elemento {numbersArray[2]}");

    // Size of array

    Console.WriteLine($"Tamaño del array {numbersArray.Length}");


  }
}
