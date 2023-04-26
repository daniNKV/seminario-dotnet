namespace ejercicios1a6;

class Persona : IAtendible<Persona>
{
    void SeAtiende()
    {
        Console.WriteLine("Atendiendo persona");
    }
}