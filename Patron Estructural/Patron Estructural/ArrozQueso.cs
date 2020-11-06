using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public class ArrozQueso : DecoratorAcompañamiento
    {
        public ArrozQueso(CarneParrilla carne) : base(carne) { }
        public override double Costo => _carne.Costo + 9;

        public override string Descripcion => string.Format($"{_carne.Descripcion}, Arroz con queso");
    }
}
