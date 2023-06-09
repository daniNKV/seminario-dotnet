class Cuenta 
{
    public static List<Cuenta> cuentas;
    private static double depositos;
    private static double totalDepositos;
    private static double extracciones;
    private static double totalExtracciones;
    private static int cantidadCuentas;
    private static int denegados;
    private int _id;
    private double _saldo;

    static Cuenta()
    {
        cuentas = new List<Cuenta>();
        depositos = 0;
        extracciones = 0;
        totalDepositos = 0;
        cantidadCuentas = 0;
        totalExtracciones = 0;
        denegados = 0;

    }

    public Cuenta() 
    {
        this._saldo = 0;
        Cuenta.cantidadCuentas += 1;
        this._id = Cuenta.cantidadCuentas;
        
        cuentas.Add(this);
        
        Console.WriteLine($"Se creó la cuenta ID = {this._id}");
    } 

    public Cuenta Extraer(double monto) 
    {
        try {
            RetirarMonto(monto);
        } catch (Exception e) 
        {
            Console.WriteLine(e.Message);
            Cuenta.denegados++;
        }

        Cuenta.extracciones++;
        Cuenta.totalExtracciones += monto; 
        Console.WriteLine($"Se extrajo {monto} en la cuenta {this._id} (Saldo = {this._saldo})");
        return this;
    }

    public Cuenta Depositar(double monto)
    {
        this._saldo += monto;
        Cuenta.depositos++;
        Cuenta.totalDepositos += monto;
        Console.WriteLine($"Se depositaron {monto} en la cuenta {this._id} (Saldo= {(this._saldo)}");
        
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

    public static void ImprimirDetalle()
    {
        Console.WriteLine("DETALLE");
        Console.WriteLine($"CUENTAS CREADAS: {Cuenta.cantidadCuentas}");
        Console.WriteLine($"Depósitos: {Cuenta.depositos} - Total depositado: {Cuenta.totalDepositos}");
        Console.WriteLine($"Extracciones: {Cuenta.extracciones} - Total extraido: {Cuenta.totalExtracciones}");
        Console.WriteLine($"Saldo {Cuenta.totalDepositos - Cuenta.totalExtracciones}");
        Console.WriteLine($"Se denegaron {Cuenta.denegados} extracciones por falta de fondos");
        
    }
}