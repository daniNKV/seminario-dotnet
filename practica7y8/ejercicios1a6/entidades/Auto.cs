
class Auto : IVendible, ILavable, IReciclable, IComercial, IImportante
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

    void IComercial.Importar(){
        Console.WriteLine("Vendiendo auto al exterior");
    }

    void IImportante.Importar() {
        Console.WriteLine("Auto importante");
    }

    public void Importar() {
        Console.WriteLine("Método Importar() de la clase Auto ");
    }

}