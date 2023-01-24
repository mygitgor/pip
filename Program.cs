string[] strings = { "hello", "world", "2", "(.v.)", "12", "\0" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();