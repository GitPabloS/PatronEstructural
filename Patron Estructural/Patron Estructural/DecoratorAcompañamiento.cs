using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public abstract class DecoratorAcompañamiento : CarneParrilla
    {
        protected CarneParrilla _carne;
        public DecoratorAcompañamiento(CarneParrilla carne)
        {
            _carne = carne;
        }
    }
}
