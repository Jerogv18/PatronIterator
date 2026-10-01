using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador
{
    public class Genero
    {
        public string TipoGenero { get; }
        private readonly List<Libro> _libros = new List<Libro>();
        public Genero(string GeneroLiterario)
        {
            TipoGenero = GeneroLiterario;
        }
        public void Agregar(Libro libro)
        {
            _libros.Add(libro);
        }
        public IReadOnlyList<Libro> Libros => _libros;
    }
}
