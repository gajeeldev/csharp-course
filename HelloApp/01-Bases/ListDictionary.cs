partial class Program
{
  static void ListDictionary()
  {
    List<string> names = new List<string> { "John", "Jane", "Bob" };
    names.Add("Alice");

    Console.WriteLine($"Total de nombres: {names.Count}");

    foreach (var name in names)
    {
      Console.WriteLine(name);
    }

    names.Remove("John");

    bool isPresent = names.Contains("John");

    Console.WriteLine($"John está en la lista: {isPresent}");

    // Dictionary
    Dictionary<int, string> students = new Dictionary<int, string>
    {
      { 1, "John" },
      { 2, "Jane" },
      { 3, "Bob" }
    };

    Console.WriteLine($"El estudante 1 es: {students[1]}");

    foreach (var student in students)
    {
      Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
    }


  }
}