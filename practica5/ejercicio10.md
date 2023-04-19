10) Identificar todos los miembros en la siguiente declaración de clase. Indicar si se trata de un
constructor, método, campo, propiedad o indizador, si es estático o de instancia, y en caso que
corresponda si es de sólo lectura, sólo escritura o lectura y escritura. En el caso de las propiedades
indicar también si se trata de una propiedad auto-implementada.
Nota: La clase compila perfectamente. Sólo prestar atención a la sintaxis, la semántica es irrelevante.
```
class A
{
    private static int a; // Campo estático lectura/escritura
    private static readonly int b; // Campo estático de solo lectura
    A() { } // Constructor de instancia
    public A(int i) : this() { } // Constructor de instancia
    static A() => b = 2; // Constructor estático
    int c; // 
    public static void A1() => a = 1; // Propiedad estática escritura
    public int A1(int a) => A.a + a; // Método de instancia
    public static int A2; // Campo de Clase estático
    static int A3 => 3; // Propiedad de Clase, solo lectura
    private int A4() => 4; // Método de instancia
    public int A5 { get => 5; } // Propiedad de instancia, solo lectura
    int A6 { set => c = value; } // Propiedad de instancia, solo escritura
    public int A7 { get; set; } // Propiedad de instancia E/L autoimplementada
    public int A8 { get; } = 8; // Propiedad de instancia solo lectura
    public int this[int i] => i; // Indizador
}
```
