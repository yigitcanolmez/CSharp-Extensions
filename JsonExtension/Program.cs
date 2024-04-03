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


var list = listJson.ToJson<List<User>>();
var _object = json.ToJson<User>();

Console.WriteLine(list.ToJsonString());
Console.WriteLine(_object.ToJsonString());

