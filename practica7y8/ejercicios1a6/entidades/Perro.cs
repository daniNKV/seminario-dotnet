namespace ejercicios1a6;

class Perro : IAtendible<Perro>, IVendible<Perro>
{
    void SeAtiende()
    {
        Console.WriteLine("Atendiendo perro");
    }

    void SeVendeA(Personas p)
    {
        Console.WriteLine("Vendiendo perro a persona");
    }
}