using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class TwentyOneGame : Game, IWalkAway   //para heredar simplemente hay que poner ":" (dos puntos) y la clase de la que heredara;
                                                   //la segunda que se hereda no es una clase, es una interfaz, es por eso que es posible heredarla
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayer()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayer();
        }

        public void WalkAway(Player player)   //para poder heredar esto, es porque no es una clase propiamente, es mas bien una interfaz
        {
            throw new NotImplementedException();
        }
    }
}
