Qué líneas del código siguiente provocan error de compilación? Analizar cuándo es posible acceder a miembros estáticos y de instancia.
```

class A
{
    char c;
    static string st;
    void metodo1()
    {
        st = "string"; // No es posible acceder a campos de clase en metodos de instancia
        c = 'A';
    }
    static void metodo2()
    {
        new ClaseA().c = 'a';
        st = "st2";
        c = 'B'; // No se puede acceder a c desde un miembro estático
        new A().st = "otro string";
    }
}

```
