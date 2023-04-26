namespace ejercicios1a6;

class Auto : IVendible<Auto>, ILavable<Auto>
{
    void SeLava(Auto auto) {
        Console.WriteLine("Lavando Auto");
    }

    void SeVendeA(Personas p) {
        Console.WriteLine("Vendiendo auto a persona");
    }
}