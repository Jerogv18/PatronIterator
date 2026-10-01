using Patron_Iterador;

var biblioteca = new Biblioteca();

var Terror = new Genero("Terror");
var Romance = new Genero("Romance");
var Biografia = new Genero("Biografia");
Terror.Agregar(new Libro("It"));
Terror.Agregar(new Libro("Resplandor"));
Terror.Agregar(new Libro("Drácula"));
Romance.Agregar(new Libro("Boulevar"));
Biografia.Agregar(new Libro("Diario de Anne Frank"));
Biografia.Agregar(new Libro("Stephen Hawking: Su vida y obra"));

biblioteca.Agregar(Terror);
biblioteca.Agregar(Romance);
biblioteca.Agregar(Biografia);

IIterador<Libro> iterador = biblioteca.CrearIterador();

while (iterador.HaySiguiente())
{
    Libro libro = iterador.Siguiente();
    Console.WriteLine(libro.Titulo);
}