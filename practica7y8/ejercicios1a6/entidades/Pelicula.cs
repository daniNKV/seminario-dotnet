namespace ejercicios1a6;

class Pelicula: IAlquilable
{
    public void SeAlquilaA(Persona p) 
    {
        Console.WriteLine("Alquilando pelicula a persona");
    }

    public void Devuelve(Persona p)
    {
        Console.WriteLine("Pelicula devuelta por persona");
    }
}