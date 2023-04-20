4) Contestar sobre el siguiente programa:
```

Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");

class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
    public Auto() { }
}

class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
}

```
¿Por qué no es necesario agregar :base en el constructor de Taxi? Eliminar el segundo constructor
de la clase Auto y modificar la clase Taxi para el programa siga funcionando


RTA: No es necesario invocar al constructor de la superclase debido a que al ejecutarse el de Taxi,
se llama implicitamente al constructor por defecto, siendo este el de firma sin parámetros.

Modificación: 

```

Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");

class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}

class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros, string marca): base(marca) => this.Pasajeros = pasajeros;
}

```
