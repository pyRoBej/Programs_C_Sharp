using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card // para crear esta clase me fui al explorador de soluciones (en la barra del lado derecho oculto),
                      // se abre se selecciona agregar/clase, y la de tipo C# (hasta arriba) es la que seleccione,
                      // despues le di nombre y enter; las clases solo son un modelo, diseño para un objeto
    {
        public Card()
            {
                Suit = "Spades";
                Face = "Two";
            }
            public string Suit { get; set; } //aqui estoy declarando esta variable publica para que se pueda acceder desde otras partes del programa y asi.
                                             //El get y set que van adentro es por que es lo unico que se puede hacer con ella
            public string Face { get; set; } //esta otra variable publica es una propiedad mas de nuestra clase Card
        
    }
}
