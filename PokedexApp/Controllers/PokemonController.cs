using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokedexApp.Models;
using RestSharp;
using static PokedexApp.Models.PokemonModel;

namespace PokedexApp.Controllers;

public class PokemonController : Controller
{
    //public IActionResult GetAllPokemon()
    //{
    //    var client = new RestClient("https://pokeapi.co/api/v2/pokemon?limit=151&offset=0");

    //    var request = new RestRequest("pokemon", Method.Get);
    //    request.AddQueryParameter("name", "clefairy");

    //    var response = await client.GetAsync(request);

    //    return View();

    //}

    public IActionResult Index() 
    {
        GetAllPokemon();
        return View(); 
    }

    public async Task<Pokemon> GetAllPokemon()
    {
        Uri url = new Uri("https://pokeapi.co/api/v2/pokemon/1");
        HttpClient client = new HttpClient();

        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {

            string result = response.Content.ReadAsStringAsync().Result;
            Pokemon pokemonModel = JsonConvert.DeserializeObject<Pokemon>(result);
            
            return pokemonModel;
        }

        return null;
    }


}
