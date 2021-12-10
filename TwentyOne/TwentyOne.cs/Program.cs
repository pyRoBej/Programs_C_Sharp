using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne.cs
{
    class Program  //la diferencia de una clase con una libreria es que la libreria es una coleccion de clases
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Manuel", "David", "Mayra" };
            //game.ListPlayer();
            //Console.ReadLine();

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Manuel";
            game += player;  // se puede esscribir asi o de la sig manera: game = game + player; es excatamente lo mismo
            game -= player;  // se puede esscribir asi o de la sig manera: game = game - player; es excatamente lo mismo

            Deck deck = new Deck();  //crea un nuevo maso de cartas 
            deck.Shuffle(3);         //se revuelven las cartas con la funcion Shuffle

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
