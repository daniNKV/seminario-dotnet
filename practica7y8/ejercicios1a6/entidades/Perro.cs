
class Perro : IAtendible, IVendible, ILavable, INombrable
{
    public string Nombre { get; set; }
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


    public override string ToString() {
        return this.Nombre + " es un perro";
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