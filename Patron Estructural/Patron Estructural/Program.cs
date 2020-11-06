using System;

namespace Patron_Estructural
{
    class Program
    {
        static void Main(string[] args)
        {
            CarneParrilla carne = new Cuadrilla();
            carne = new PapasFritas(carne);
            carne = new PapasFritas(carne);
            carne = new Chimichurri(carne);

            Console.WriteLine($"Plato: {carne.Descripcion} cuesta en total: {carne.Costo}Bs.");

            //Añadimos la clase Arrcoz con queso

            CarneParrilla carneBife = new BifeLomo();
            carneBife = new PapasFritas(carneBife);
            carneBife = new Yuca(carneBife);
            carneBife = new Chimichurri(carneBife);
            carneBife = new ArrozQueso(carneBife);

            Console.WriteLine($"Plato: {carneBife.Descripcion} cuesta en total: {carneBife.Costo}Bs.");
            carneBife = new ArrozQueso(carneBife);

            Console.WriteLine($"Plato: {carneBife.Descripcion} cuesta en total: {carneBife.Costo}Bs.");
            Console.ReadKey();
        }
    }
}
