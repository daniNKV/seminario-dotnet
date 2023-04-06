10) ¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?
```
class A
{
    public void Metodo(short n)  // 
    {
        Console.Write("short {0} - ", n);
    }
    public void Metodo(int n) // 
    {
        Console.Write("int {0} - ", n); 
    }
    public int Metodo(int n) // No se pueden sobrecargar métodos variando el tipo de salida, sin variar la cantidad y tipo de firma (parámetros).
    {
        return n + 10;
    }
}

```
