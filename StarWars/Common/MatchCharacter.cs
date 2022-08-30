using StarWars.ApiIntegration;
using StarWars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Common
{
    public static class MatchCharacter
    {
        public static string GetMatchedCharacter(StarWarsResponse starWarsResponse)
        {
            string filmOne = null;
            string filmtwo = null;
            string filmthree = null;

            for (var i = 0; starWarsResponse.Films.Count < i; i++)
            {
                filmOne += starWarsResponse.Films[i].films.Where(x=> x.Contains('1')).;
            }
        }
    }
}
