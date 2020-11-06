using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public class Yuca : DecoratorAcompañamiento
    {
        public Yuca(CarneParrilla carne) : base(carne) { }
        public override double Costo => _carne.Costo + 12;

        public override string Descripcion => string.Format($"{_carne.Descripcion}, Yuca");
    }
}
