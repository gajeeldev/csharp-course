var names = new List<string> { "Camila", "Sebastian", "Homero", "Maggie", "Rodrigo" };

var namesResult = from n in names
                  where n.Length > 6 && n.Contains('a')
                  orderby n descending
                  select n;

var namesResult2 = names.Where(n => n.Length > 6 && n.Contains('a'))
                        .OrderByDescending(n => n)
                        .Select(n => n);

foreach (var name in namesResult)
{
  Console.WriteLine(name);
}

foreach (var name in namesResult2)
{
  Console.WriteLine(name);
}

