
class Persona
{
    string _nombre;
    int _edad;
    int _dni;

    public Persona(string nombre, int edad, int dni)
    {
        this._nombre = nombre;
        this._edad = edad;
        this._dni = dni;
    }

    public void Imprimir(int i)
    {
        Console.WriteLine($"{i.ToString()}) {this.toString()}");
    }

    public void Imprimir(){
        Console.WriteLine($"{this.toString()}");

    }

    public string toString()
    {
        return $"{this._nombre, -15} {this._edad, 5} {this._dni, 8}";
    }

    public bool EsMayorQue(Persona p)
    {
        return this._edad > p._edad;
    }
}

// 3) Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la persona que
// recibe el mensaje tiene más edad que la persona enviada como parámetro. Utilizarlo para realizar un programa
// que devuelva la persona más jóven de la lista.