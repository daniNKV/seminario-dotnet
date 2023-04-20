// 7) Ofrecer una implementación polimórfica para mejorar el siguiente programa:

Imprimidor.Imprimir(new A(), new B(), new C(), new D());


class A: IImprimible {
    public void Imprimir() => Console.WriteLine("Soy una instancia A");
}
class B: IImprimible {
    public void Imprimir() => Console.WriteLine("Soy una instancia B");
}
class C: IImprimible {
    public void Imprimir() => Console.WriteLine("Soy una instancia C");
}
class D: IImprimible {
    public void Imprimir() => Console.WriteLine("Soy una instancia D");
}
static class Imprimidor {
    public static void Imprimir(params IImprimible[] vector) {
        foreach (IImprimible o in vector) {
            o.Imprimir();
        }
    }
}