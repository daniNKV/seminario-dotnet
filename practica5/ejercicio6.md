5) Qué líneas del código siguiente provocan error de compilación? Analizar cuándo es posible
acceder a miembros estáticos y de instancia.
```

class A
{
    char c;
    static string st;
    void metodo1()
    {
        st = "string";
        c = 'A';
    }
    static void metodo2()
    {
        new ClaseA().c = 'a';
        st = "st2";
        c = 'B'; // Se tiene que usar a c desde una instancia de la clase en metodos estáticos
        new A().st = "otro string"; // st al ser estático no se puede acceder desde una instancia
    }
}

Métodos no estáticos -> Sin restricciones
Métodos estáticos 
    -> Miembros no estáticos se usan desde instancias
    -> Miembros estáticos desde la clase

```
