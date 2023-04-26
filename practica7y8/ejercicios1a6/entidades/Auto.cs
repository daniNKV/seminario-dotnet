namespace ejercicios1a6;

class Auto : IVendible, ILavable
{
    public void SeLava() {
        Console.WriteLine("Lavando Auto");
    }

    public void SeVendeA(Persona p) {
        Console.WriteLine("Vendiendo auto a persona");
    }
}