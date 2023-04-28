
class Persona : IAtendible, IComercial, IImportante
{
    public Persona() {}
    public void SeAtiende()
    {
        Console.WriteLine("Atendiendo persona");
    }
    void IComercial.Importar() {
        Console.WriteLine("Persona vendiendo al exterior");
    }
    
    void IImportante.Importar() {
        Console.WriteLine("Persona importante");
    }

    public void Importar() {
        Console.WriteLine("Método Importar() de la clase Persona");
    }
}