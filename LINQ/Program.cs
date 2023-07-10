using System.Threading.Channels;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] gameTitles = { 
                "Fire Emblem: Shadow Dragon and the Blade of Light", "Fire Emblem: Path of Radiance", "Fire Emblem: Radiant Dawn", "Fire Emblem: Awakening",
                "Fire Emblem: Fates", "Fire Emblem: Three Houses", "Super Mario Bros. 3", "Super Mario Bros.", "Tetris", "Dr. Mario", "Sonic the Hedgehog",
                "Momodora: Moonlight under the Reverie", "Paper Mario", "Rocket League"
            };
            // Method 1: Query Sytax
            var sortedTitles = from title in gameTitles
                               orderby title.Length
                               select title;
            foreach (var title in sortedTitles)
            {
                Console.WriteLine(title);
            }
            // Some Spaces
            Console.WriteLine();
            Console.WriteLine();
            // Method 2: Method Sytax
            var leTitles = gameTitles.OrderBy(title => title.Length ).ToArray();
            foreach ( var title in leTitles )
            {
                Console.WriteLine( title );
            }
        }
    }
}
