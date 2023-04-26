
class Libro : IAlquilable, IReciclable
{
    public Libro() {}
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando libro a persona");
    }

    public void SeRecicla()
    {
        Console.WriteLine("Reciclando libro");
    }

    public void Devuelve(Persona p)
    {
        Console.WriteLine("Libro devuelto por persona");
    }
}
