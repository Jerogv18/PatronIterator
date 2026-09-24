using Patron_Iterador;

var biblioteca = new Biblioteca();
biblioteca.Agregar(new Libro("Cien años de soledad"));
biblioteca.Agregar(new Libro("Rayuela"));
biblioteca.Agregar(new Libro("Pedro Páramo"));

IIterador<Libro> iterador = biblioteca.CrearIterador();

while (iterador.HaySiguiente())
{
    Libro libro = iterador.Siguiente();
    Console.WriteLine(libro.Titulo);
}