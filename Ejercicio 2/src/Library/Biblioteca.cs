using System;

namespace SRP
{
    public class Biblioteca
    {

        public static void AlmacenarLibro(Libro a, string sector, string estante)
        {
            a.SectorBiblioteca = sector;
            a.EstanteBiblioteca = estante;
        }

    }
}
