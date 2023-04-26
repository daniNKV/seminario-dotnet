
class Perro : IAtendible, IVendible
{
    public Perro() {}
    public void SeAtiende()
    {
        Console.WriteLine("Atendiendo perro");
    }

    public void SeVendeA(Persona p)
    {
        Console.WriteLine("Vendiendo perro a persona");
    }
}