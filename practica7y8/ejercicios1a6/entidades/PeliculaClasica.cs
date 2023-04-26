class PeliculaClasica: Pelicula, IVendible
{
    public void SeVendeA(Persona p) {
        Console.WriteLine("Vendiendo pelicula clásica a persona");
    }
}