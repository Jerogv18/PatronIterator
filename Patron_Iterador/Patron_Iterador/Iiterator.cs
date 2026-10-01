using Patron_Iterador;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Iterador;

public interface IIterador<T>
{
    bool HaySiguiente(); 
    T Siguiente();   
}
