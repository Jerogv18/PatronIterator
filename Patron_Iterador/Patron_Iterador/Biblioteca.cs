using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public class Biblioteca : IColeccion<Libro>
{
    private readonly List<Libro> _libros = new List<Libro>();

    public void Agregar(Libro libro)
    {
        _libros.Add(libro);
    }

    public IIterador<Libro> CrearIterador()
    {
        return new IteradorLibros(_libros);
    }
}