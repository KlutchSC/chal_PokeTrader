using System;
using System.Collections.Generic;
using System.Linq;

namespace chal_PokeTrader
{
    class Program
    {
        static void Main()
        {
            var pokeList = CreatePokeList();

            Console.WriteLine("EXCHANGE POKEMON");
            var index = 0;
            foreach (var pokemon in pokeList)
            {
                Console.WriteLine(index + ". " + pokemon);
                index++;
            }

            Console.WriteLine("Choose a Pokemon to swap by entering the number");
            var firstPokeToSwap = Console.ReadKey();
            Console.WriteLine("Choose a Pokemon to swap with by entering the number");
            var secondPokeToSwap = Console.ReadKey();

            SwapListItem(pokeList, );
        }

        // Fills a list with a set ammount and type of pokemon
        static IEnumerable<string> CreatePokeList()
        {
            var pokeList = new List<string>
            {
                "Pikachu",
                "Charmeleon",
                "Geodude",
                "Gyarados",
                "Butterfree",
                "Mankey"
            };
            return pokeList;
        }

        static void SwapListItem(List<string> list, int curPosition, int newPosition)
        {
            var pokemon = list.ElementAt(curPosition);
            list.RemoveAt(curPosition);
            if (newPosition > curPosition) newPosition--;
            list.Insert(newPosition, pokemon);
        }
    }
}
