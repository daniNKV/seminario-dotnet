Señalar el error en cada uno de los siguientes casos:

(6.1) El método M1 no es virtual por lo que no se puede invalidar
class A
{
    public string M1() => "A.M1";
}
class B : A
{
    public override string M1() => "B.M1";
}

(6.2) No tiene que tener override en implementaciones abstractas
class A
{
    public abstract string M1();
}
class B : A
{
    public override string M1() => "B.M1";
}

(6.3) Los métodos abstractos no pueden tener implementación
abstract class A
{
    public abstract string M1() => "A.M1";
}
class B : A
{
    public override string M1() => "B.M1";
}

(6.4) A no hereda de ninguna clase de la cual sobreescribir métodos
class A
{
    public override string M1() => "A.M1";
}
class B : A
{
    public override string M1() => "B.M1";
}

(6.5) El método que invalida no puede tener acceso más restringido que el invalidado
class A
{
    public virtual string M1() => "A.M1";
}
class B : A
{
    protected override string M1() => "B.M1";
}

(6.6)
class A
{
    public static virtual string M1() => "A.M1";
}
class B : A
{
    public static override string M1() => "B.M1";
}

(6.7) Como M1 no es protected, B no lo puede ver
class A
{
    virtual string M1() => "A.M1";
}
class B : A
{
    override string M1() => "B.M1";
}

(6.8) Al poner un constructor con firma, se invalida el defecto por lo que B tiene que llamar a base(int i)
class A
{
    protected A(int i) { }
}
class B : A
{
    B() { }
}

(6.9) El constructor de B no tiene acceso a _id
class A
{
    private int _id;
    protected A(int i) => _id = i;
}
class B : A
{
    B(int i): base(5) 
    {
        _id = i;
    }
}

(6.10)
class A
{
    private int Prop    
    {
    set; public get;
    }
}
class B : A
{ }

(6.11) Las propiedades abstractas no pueden estar autoimplementadas
abstract class A
{
    public abstract int Prop {set; get;}
}
class B : A
{
    public override int Prop
    {
    get => 5;
    }
}

(6.12) Prop en A no es virtual
abstract class A
{
    public int Prop {set; get;}
}
class B : A
{
    public override int Prop 
    {
        get => 5;
        set {}
    }
}
