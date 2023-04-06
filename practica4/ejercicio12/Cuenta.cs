class Cuenta
{
    private double _monto;
    private int _titularDNI;
    private string? _titularNombre;

    public Cuenta(string? nombre, int dni) 
    {
        this._titularNombre = nombre;
        this._titularDNI = dni;
        this._monto = 0;
    }

    public Cuenta(int dni): this(null, dni) {}

    public Cuenta (string nombre): this(nombre, 0) {}

    public Cuenta(): this(null, 0) {}

    public void Imprimir() 
    {
        Console.WriteLine($"Nombre: {this._titularNombre}, DNI: {this._titularDNI}, Monto: {this._monto}");
    }

    public void Depositar(double monto)
    {
        this.SetMonto(this.GetMonto() + monto);
    }
    public void Extraer(double monto)
    {
        this.SetMonto(this.GetMonto() - monto);
    }
    private double GetMonto()
    {
        return this._monto;
    }
    private void SetMonto(double monto) 
    {
        this._monto = monto;
    }
}
