class Cuenta 
{
    private static double depositos;
    private static double totalDepositos;
    private static double extracciones;
    private static double totalExtracciones;
    private static int denegados;
    private static int cuentas;
    private int _id;
    private double _saldo;

    static Cuenta()
    {
        cuentas = 0;
        depositos = 0;
        extracciones = 0;
        totalDepositos = 0;
        totalExtracciones = 0;
        denegados = 0;
    }

    public Cuenta() 
    {
        this._saldo = 0;
        this.cuentas += 1;
        this._id = this.cuentas;
        Console.WriteLine($"Se creó la cuenta ID = {this._id}");
    } 

    public void Extraer(double monto) 
    {
        try {
            RetirarMonto(monto);
        } catch (e) 
        {
            Console.WriteLine(e.message);
            Cuenta.denegados++;
        }

        Cuenta.extracciones++;
        Cuenta.totalExtracciones += monto; 
        Console.WriteLine($"Se extrajo {monto} en la cuenta {this._id} (Saldo = {this._saldo})");
        return this;
    }

    public void Depositar(double monto)
    {
        this._saldo += monto;
        Cuenta.depositos++;
        Cuenta.depositosTotal += monto;
        Console.WriteLine($"Se depositaron {monto} en la cuenta {this._id} ${(Saldo= this._saldo)}");
        
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

    static void ImprimirDetalle()
    {
        Console.WriteLine("DETALLE");
        Console.WriteLine($"CUENTAS CREADAS: {this.cuentas}");
        Console.WriteLine($"Depósitos: {this.cuentas} - Total depositado: {this.totalDepositos}");
        Console.WriteLine($"Extracciones: {this.extracciones} - Total extraido: {this.totalExtracciones}");
        Console.WriteLine($"Saldo {this.depositos - this.extracciones}");
        Console.WriteLine($"Se denegaron {this.denegados} extracciones por falta de fondos");
        
    }
}