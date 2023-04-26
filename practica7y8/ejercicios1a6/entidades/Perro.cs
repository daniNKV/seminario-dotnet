namespace ejercicios1a6;

class Perro : IAtendible, IVendible
{
    public void SeAtiende()
    {
        Console.WriteLine("Atendiendo perro");
    }

    public void SeVendeA(Persona p)
    {
        Console.WriteLine("Vendiendo perro a persona");
    }
}