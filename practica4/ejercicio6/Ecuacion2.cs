using System;
class Ecuacion2
{
    double _a;
    double _b;
    double _c;

    public Ecuacion2(double a, double b, double c)
    {
        this._a = a;
        this._b = b;
        this._c = c;
    }

    public double GetDiscriminante(){
        return (Math.Pow(_b, 2)) - 4 * _a * _c;
    }

    public int GetCantidadRaices() {
        double discriminante = this.GetDiscriminante();

        if (discriminante < 0) return 0;
        else if (discriminante == 0) return 1;
        else return 2;
    }

    public void ImprimirRaices(){
        int cantidadRaices = this.GetCantidadRaices();
        string leyenda;
        double raiz;
       
        if (cantidadRaices == 0) leyenda = "No posee raices reales";
        else {
            raiz = (-_b + this.GetDiscriminante()) / 2 * _a;

            if (cantidadRaices == 1) leyenda = $"Raiz = {raiz}";
            else leyenda = $"Raiz positiva = {raiz}, Raiz negativa = -{raiz}";
        }
    }


}