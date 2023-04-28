
class Persona : IAtendible, IComercial, IImportante, INombrable, IComparable
{
    public string Nombre { get; set; }

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

    public override string ToString() {
        return this.Nombre + " es una persona";
    }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        
        INombrable otroNombre = obj as INombrable;
        if (otroNombre != null)
            return this.Nombre.CompareTo(otroNombre.Nombre);
        else
           throw new ArgumentException("Un elemento no es nombrable");
    
    }
}