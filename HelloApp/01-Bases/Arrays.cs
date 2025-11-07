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

    // desde el final el arreglo
    Console.WriteLine($"Ultimo elemento {numbersArray[^1]}");
    Console.WriteLine($"Penultimo elemento {numbersArray[^2]}");

    //Ranges for get subarray
    int[] firstThree = numbersArray[..3];
    int[] fromIndexTwo = numbersArray[2..];

    Console.WriteLine($"Primeros 3 elementos {string.Join(",", firstThree)}");
    Console.WriteLine($"Desde el index 2 {string.Join(",", fromIndexTwo)}");

  }
}
