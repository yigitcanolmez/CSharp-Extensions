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
Console.WriteLine(json.FromJson<User>().Name);
Console.WriteLine(listJson.FromJson<List<User>>().First().Surname);


var list = listJson.FromJson<List<User>>();
var _object = json.FromJson<User>();

Console.WriteLine(list.ToJson());
Console.WriteLine(_object.ToJson());