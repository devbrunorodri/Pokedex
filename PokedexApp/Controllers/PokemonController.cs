using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokedexApp.Models;
using RestSharp;

namespace PokedexApp.Controllers;

public class PokemonController : Controller
{

    public IActionResult GetAllPokemon()
    {
        var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");

        var request = new RestRequest("pokemon", Method.Get);
        request.AddQueryParameter("name", "clefairy");

        // var response = await client.GetAsync(request);

        return View();
    }
}
