
class Perro : IAtendible, IVendible, ILavable
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

    public void SeLava()
    {
        Console.WriteLine("Lavando perro");
    }

    public void SeSeca()
    {
        Console.WriteLine("Secando perro");
    }
}