1) Sin borrar ni modificar ninguna línea, completar la definición de las clases B, C y D
```
class A
{
    protected int _id;
    public A(int id) => _id = id;
    public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}
class B : A
{
    public B(): base(int id);
    public override void Imprimir() 
    {
        Console.WriteLine($"B_{_id} + -->");
        base.Imprimir()
    } 
}
class C : B
{
    public B(): base(int id);
    public override void Imprimir() 
    {
        Console.Write($"C_{_id} + -->");
        base.Imprimir()
    } 
}
class D : C
{
    public C(): base(int id);    
    public override void Imprimir()
    {
        Console.Write($"D_{_id} + -->");
        base.Imprimir();
    }
}
```

para que el siguiente código produzca la salida indicada:
```

A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector)
{
    a.Imprimir();
}

Salida por consola
    A_3
    B_5 --> A_5
    C_15 --> B_15 --> A_15
    D_41 --> C_41 --> B_41 --> A_41
```
