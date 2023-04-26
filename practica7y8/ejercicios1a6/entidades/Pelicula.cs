namespace ejercicios1a6;

class Pelicula: IAlquilable<Pelicula>
{
    void SeAlquilaA(Personas p) 
    {
        Console.WriteLine("Alquilando pelicula a persona");
    }
}