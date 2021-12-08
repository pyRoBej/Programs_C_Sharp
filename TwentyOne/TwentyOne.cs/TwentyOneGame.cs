using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class TwentyOneGame : Game   //para heredar simplemente hay que poner ":" (dos puntos) y la clase de la que heredara
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
    }
}
