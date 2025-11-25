using System.Text.Json;

var gilbert = new People() { Name = "Gilbert", Age = 30 };

string jsonString = JsonSerializer.Serialize(gilbert);
Console.WriteLine(jsonString);

string myJson = @"{""Name"":""Jose"",""Age"":30}";

People? person = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine($"Name: {person?.Name}, Age: {person?.Age}");

public class People
{
  public string Name { get; set; }
  public int Age { get; set; }


}