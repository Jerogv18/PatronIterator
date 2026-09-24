using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public interface IColeccion<T>
{
    IIterador<T> CrearIterador();
}
