using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public class IteradorLibros : IIterador<Libro>
{
    private readonly List<Genero> _generos;
    private int _posicionGenero = 0;
    private int _posicionLibro = 0;

    public IteradorLibros(List<Genero> generos)
    {
        _generos = generos;
    }

    public bool HaySiguiente()
    {
        while (_posicionGenero < _generos.Count && _posicionLibro>= _generos[_posicionGenero].Libros.Count)
        {
            _posicionGenero++;
            _posicionLibro = 0;
        }
        return _posicionGenero < _generos.Count;
    }

    public Libro Siguiente()
    {
        Genero GeneroActual = _generos[_posicionGenero];
        Libro LibroActual = GeneroActual.Libros[_posicionLibro];
        _posicionLibro++;
        return LibroActual;
    }
}