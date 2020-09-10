using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        //No cumple con SRP porque además de crearse el Libro debe Ubicarse en la biblioteca
        //No cumple con EXPERT porque no conoce Biblioteca, el experto deberia ser un Objeto biblioteca
        //se debe crear una clase biblioteca
        

    }
}
