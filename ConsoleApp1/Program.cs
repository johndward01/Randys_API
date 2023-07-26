

using ConsoleApp1;
using Newtonsoft.Json;
using RestSharp;

var client = new RestClient("https://free-nba.p.rapidapi.com/players?page=0&per_page=25");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "c69daab450msh8d841055c912583p1f9399jsnb02781781271");
request.AddHeader("X-RapidAPI-Host", "free-nba.p.rapidapi.com");
var response = client.Execute(request).Content;

Console.WriteLine(response);

// var myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);

//foreach(var item in myDeserializedClass.data)
//{
//    Console.WriteLine(item.last_name);
//    Console.WriteLine(item.first_name);
//    Console.WriteLine(item.position);
//    Console.WriteLine(item.team.name);
//    Console.WriteLine(item.team.city);
//    Console.WriteLine();
//}