using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Game game = new Game();
            //    game.Dealer = "Manuel";
            //    game.Name = "21";
            //Card card = new Card() { Face = "King", Suit = "Spades" };   //inicializacion de objeto
            
            
            //Game game = new Game();
            //game.Players = new List<string>() { "pyRo", "David", "Mayra" };
            //game.ListPlayer();
            //game.Play();
            Console.ReadLine();


            Deck deck = new Deck();
            deck.Shuffle(3);
      
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
