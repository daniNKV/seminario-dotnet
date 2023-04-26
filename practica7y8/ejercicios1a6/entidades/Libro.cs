namespace ejercicios1a6;

class Libro : IAlquilable<Libros>, IReciclable<Libro>
{
    void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando libro a persona");
    }

    void SeRecicla()
    {
        Console.WriteLine("Reciclando libro");
    }
}