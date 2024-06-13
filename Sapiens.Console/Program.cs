using Sapiens.Shared.Models;
using System.Text.Json;

Console.Write("Informe o CEP: ");
var cep = Console.ReadLine();

var http = new HttpClient();
var jsonCep = await http.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
var endereco =  JsonSerializer.Deserialize<CepModel>(jsonCep, new JsonSerializerOptions()
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
});
if (endereco != null)
{
    Console.WriteLine($"Endereço: {endereco.Logradouro}");
    Console.WriteLine($"Bairro: {endereco.Bairro}");
    Console.WriteLine($"Cidade: {endereco.Localidade}");
    Console.WriteLine($"Estado: {endereco.Uf}");
    Console.WriteLine($"DDD: {endereco.Ddd}");
}

//ConsoleHelper.Menu();




