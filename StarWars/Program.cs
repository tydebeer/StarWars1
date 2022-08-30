using Newtonsoft.Json;
using StarWars.ApiIntegration;
using StarWars.Common;
using StarWars.Model;
using System;

namespace StarWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarWarsApiIntegration apiIntegration = new StarWarsApiIntegration();

            var results = apiIntegration.GetRequest();

            var json = JsonConvert.DeserializeObject<StarWarsResponse>(results.Result.ToString());

            var match = MatchCharacter.GetMatchedCharacter(json);

            Console.WriteLine(match);

        }
    }
}
