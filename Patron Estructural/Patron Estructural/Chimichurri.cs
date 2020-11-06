using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public class Chimichurri : DecoratorAcompañamiento
    {
        public Chimichurri(CarneParrilla carne) : base(carne) { }
        public override double Costo => _carne.Costo+8;

        public override string Descripcion => string.Format($"{_carne.Descripcion}, Chimichurri");
    }
}
