class Cuenta 
{
    private static int cuentas;
    private int _id;
    private double _saldo;

    static Cuenta()
    {
        cuentas = 0;
    }

    public Cuenta() 
    {
        this._saldo = 0;
        this.cuentas += 1;
        this._id = this.cuentas;
        Console.WriteLine($"Se creó la cuenta ID = {id}");
    } 

    public void Extraer(double monto) 
    {
        try {
            RetirarMonto(monto);
        } catch (e) 
        {
            Console.WriteLine(e.message);
        }
        Console.WriteLine($"Se extrajo {monto} en la cuenta {this._id}");
        return this;
    }

    public void Depositar(double monto)
    {
        this._saldo += monto;
        Console.WriteLine($"Se depositaron {monto} en la cuenta {this._id}");
        
        return this;
    }

    void RetirarMonto(double monto)
    {
        if (monto > this._saldo) 
        {
            throw new Exception("Saldo insuficiente");
        }

        this._saldo -= monto;
    }
}