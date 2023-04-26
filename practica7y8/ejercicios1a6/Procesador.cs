namespace ejercicios1a6;

static class Procesador
{
    public static void Alquilar(IAlquilable x, Persona p) => x.SeAlquilaA(p);
    public static void Atender(IAtendible x, Persona p) => x.SeAtiende();
    public static void Lavar(ILavable x) => x.SeLava();
    public static void Vender(IVendible x, Persona p) => x.SeVendeA(p);
    public static void Reciclar(IReciclable x) => x.SeRecicla();
    public static void Devolver(IAlquilable x, Persona p) => x.Devuelve(p);



}