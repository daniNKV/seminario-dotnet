
class Pelicula: IAlquilable
{
    public Pelicula() {}
    public void SeAlquilaA(Persona p) 
    {
        Console.WriteLine("Alquilando pelicula a persona");
    }

    public void Devuelve(Persona p)
    {
        Console.WriteLine("Pelicula devuelta por persona");
    }
}