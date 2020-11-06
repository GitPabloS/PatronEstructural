using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public class PapasFritas : DecoratorAcompañamiento
    {
        public PapasFritas(CarneParrilla carne) : base(carne) { }
        public override double Costo => _carne.Costo + 10;

        public override string Descripcion => string.Format($"{_carne.Descripcion}, Papas fritas");
    }
}
