using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Estructural
{
    public class Picanha : CarneParrilla
    {
        public override double Costo => 42;

        public override string Descripcion => "Picanha";
    }
}
