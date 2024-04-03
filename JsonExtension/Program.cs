using JsonExtension;
using System.Text.Json;

var json = """
{
  "name": "John",
  "surname": "Doe"
}
""";

var listJson = """
    [{
      "name": "John",
      "surname": "Doe"
    },{
      "name": "ASd",
      "surname": "asdasdsa"
    }]
    """;
Console.WriteLine(json.ToJson<User>().Name);
Console.WriteLine(listJson.ToJson<List<User>>().First().Surname);

Console.WriteLine(json.ToJson<User>(new JsonSerializerOptions
{
    IgnoreReadOnlyFields = true
}).Name);

Console.Read();
