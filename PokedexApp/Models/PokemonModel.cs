using Newtonsoft.Json;

namespace PokedexApp.Models;

public class PokemonModel
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int id { get; set; }
        public string name { get; set; }
        public List<Type> types { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public List<Ability> abilities { get; set; }
    }

    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
