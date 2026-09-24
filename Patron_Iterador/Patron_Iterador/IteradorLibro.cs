using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public class IteradorLibros : IIterador<Libro>
{
    private readonly List<Libro> _libros;
    private int _posicion = 0;

    public IteradorLibros(List<Libro> libros)
    {
        _libros = libros;
    }

    public bool HaySiguiente()
    {
        return _posicion < _libros.Count;
    }

    public Libro Siguiente()
    {
        Libro actual = _libros[_posicion];
        _posicion++; // avanza para la próxima llamada
        return actual;
    }
}