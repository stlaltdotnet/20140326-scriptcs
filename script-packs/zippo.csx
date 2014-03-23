// scriptcs -install ScriptCS.Request

String country = "us";
String zip = "63031";
String url = "http://api.zippopotam.us/%country%/%zip%"
  .Replace("%country%", country)
  .Replace("%zip%", zip);

Console.WriteLine("Getting " + url);

var client = Require<Request>();
var result = client.GetJson(url);
result.Content.ReadAsStringAsync().ContinueWith(s => {
  Console.WriteLine(s.Result);
});