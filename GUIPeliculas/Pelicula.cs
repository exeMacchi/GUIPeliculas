using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIPeliculas1
{
    class Pelicula
    {
        public Pelicula(string titulo, string director, int estreno, string genero)
        {
            this.titulo = titulo;
            this.director = director;
            this.estreno = estreno;
            this.genero = genero;
        }

        private string titulo;
        private string director;
        private int estreno;
        private string genero;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Director { get { return director; } set { director = value; } }
        public int Estreno { get { return estreno; } set { estreno = value; } }
        public string Genero { get { return genero; } set { genero = value; } }

        public override string ToString()
        {
            return ($"Título: {Titulo}\n" +
                    $"Director: {Director}\n" +
                    $"Año de estreno: {Estreno}\n" +
                    $"Género: {Genero}");
        }
    }
}
