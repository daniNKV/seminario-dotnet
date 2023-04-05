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

    private int getValor()
    {
        return this.valor;
    }
    public void Insertar(int valor)
    {
        if (valor < this.getValor()){
            if (this.hijoIzquierdo == null) {
                this.hijoIzquierdo = new Nodo(valor);

            } else {
                this.hijoIzquierdo.Insertar(valor);
            }

        } else if (valor > this.getValor()){
            if (this.hijoDerecho == null) {
                this.hijoDerecho = new Nodo(valor);
            } else {
                this.hijoDerecho.Insertar(valor);
            }

        } else 
            return;
    }


    public List<int> GetInOrden()
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

    private int Altura(Nodo? nodo)
    {
        if (nodo == null) {
            return 0;
        } 

        int alturaIzquierda = Altura(nodo.hijoIzquierdo);
        int alturaDerecha = Altura(nodo.hijoDerecho);

        return 1 + Math.Max(alturaIzquierda, alturaDerecha);
    
    }

    public int GetCantidadNodos() 
    {
        return Nodos(this);
    }

    private int Nodos(Nodo? nodo) 
    {
        if (nodo == null) {
            return 0;
        }
        int nodosIzquierda = Nodos(nodo.hijoIzquierdo);
        int nodosDerecha = Nodos(nodo.hijoDerecho);
        
        return 1 + nodosIzquierda + nodosDerecha;
    }

    public int GetValorMaximo() {
        return Maximo(this);
    }
    public int GetValorMinimo() {
        return Minimo(this);
    }

    private int Minimo(Nodo? nodo){
        if (nodo == null) {
            return int.MaxValue;
        }

        int minimoIzquierda = Minimo(nodo.hijoIzquierdo);
        int minimoDerecha = Minimo(nodo.hijoDerecho);

        return minimoIzquierda < minimoDerecha ? minimoIzquierda : minimoDerecha;
    }

    private int Maximo(Nodo? nodo) {
        if (nodo == null) {
            return int.MinValue;
        }

        int maximoIzquierda = Maximo(nodo.hijoIzquierdo);
        int maximoDerecha = Maximo(nodo.hijoDerecho);

        return maximoIzquierda > maximoDerecha ? maximoIzquierda : maximoDerecha;
    }


}