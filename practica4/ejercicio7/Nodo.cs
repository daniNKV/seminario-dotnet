class Nodo
{
    int valor;
    Nodo? hijoIzquierdo;
    Nodo? hijoDerecho;

    public Nodo(int valor)
    {
        this.valor = valor;
        this.hijoDerecho = null;
        this.hijoIzquierdo = null;
    }

    private void setValor(int valor) 
    {
        this.valor = valor;
    }

    private int getValor()
    {
        return this.valor;
    }
    public void InsertarValor(int valor)
    {
        if (valor < this.getValor()){
            if (this.hijoIzquierdo == null) {
                this.hijoIzquierdo = new Nodo(valor);

            } else {
                this.hijoIzquierdo.InsertarValor(valor);
            }

        } else if (valor > this.getValor()){
            if (this.hijoDerecho == null) {
                this.hijoDerecho = new Nodo(valor);
            } else {
                this.hijoDerecho.InsertarValor(valor);
            }

        } else 
            return;
    }


    public List<int> GetInorden()
    {
        List<int> arbol = new List<int>();
        
        this.RecorrerEnOrden(arbol);

        return arbol;
    }


    private void RecorrerEnOrden(List<int> lista) 
    {
        if (this.hijoIzquierdo != null) {
            this.hijoIzquierdo.RecorrerEnOrden(lista);
        }

        lista.Add(this.getValor());
           
        if (this.hijoDerecho != null) {
            this.hijoDerecho.RecorrerEnOrden(lista);
        }
    }

    public int GetAltura() {
        return Altura(this);
    }

    private int Altura(Nodo nodo)
    {
        if (nodo == null) {
            return 0;
        }

        int alturaIzquierda = Altura(nodo.hijoIzquierdo);
        int alturaDerecha = Altura(nodo.hijoDerecho);

        return 1 + Math.Max(alturaIzquierda, alturaDerecha);
    }

}