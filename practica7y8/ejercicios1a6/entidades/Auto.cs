
class Auto : IVendible, ILavable, IReciclable
{
    public Auto() {}
    public void SeLava() {
        Console.WriteLine("Lavando Auto");
    }

    public void SeVendeA(Persona p) {
        Console.WriteLine("Vendiendo auto a persona");
    }

    public void SeRecicla() {
        Console.WriteLine("Reciclando auto");
    }

    public void SeSeca() {
        Console.WriteLine("Secando auto");
    }

}