using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public class Biblioteca : IColeccion<Libro>
{
    private readonly List<Genero> _generos = new List<Genero>();

    public void Agregar(Genero genero)
    {
        _generos.Add(genero);
    }

    public IIterador<Libro> CrearIterador()
    {
        return new IteradorLibros(_generos);
    }
}