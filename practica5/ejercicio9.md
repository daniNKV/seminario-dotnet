9) ¿Cuál es el error en el siguiente programa?
```
Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);

class Auto
{
    private string marca;
    public string Marca 
    {
        set => Marca = value; // Tiene que setear el campo privado marca, no la propiedad. marca = value
        get => marca; 
    }
}
```
Nota: Observar que utilizar la convención de prefijar a los campos privados con guión bajo, hace más
difícil cometer este tipo de errores


RTA: 