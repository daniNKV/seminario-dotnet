class Matriz 
{   
    int filas;
    int columnas;
    double[,] matriz;

    public Matriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        this.matriz = new double[filas, columnas];
    }

    public Matriz(double[,] matriz)
    {
        this.matriz = matriz;
    }

    public void SetElemento(int fila, int columna, double elemento)
    {
        this.matriz[fila, columna] = elemento;
    }

    public double GetElemento(int fila, int columna)
    {
        return this.matriz[fila, columna];
    }

    public void Imprimir()
    {
        for (int i = 0; i < this.matriz.GetLength(0); i++) {
            for (int j = 0; j < this.matriz.GetLength(1); j++){
                Console.Write(this.matriz[i, j]);
            }
        }
    }

    // public void Imprimir(string formatString)
    // {
        
    // }

    public double[] GetFila(int fila)
    {
        double[] nuevaFila = new double[this.matriz.GetLength(0)];

        for (int i = 0; i < this.matriz.GetLength(0); i++) {
            nuevaFila[i] = this.matriz[fila, i];
        }

        return nuevaFila;
    }

    public double[] GetColumna(int columna)
    {
        double[] nuevaColumna = new double[this.matriz.GetLength(1)];

        for (int i = 0; i < this.matriz.GetLength(0); i++){
            nuevaColumna[i] = this.matriz[i, columna];
        }
        return nuevaColumna;
    }

    public void ImprimirDiagonalPrincipal()
    {
        for (int i = 0; i < this.matriz.GetLength(0); i++) {
            Console.Write(this.GetElemento(1, 1));
        }
    }

    public void ImprimirDiagonalSecundaria()
    {
        for (int i = this.matriz.GetLength(0); i > 0 ; i--) {
            Console.Write(this.GetElemento(i, i));
        }
    }

    public double[][] GetArregloDeArreglo()
    {
        double[][] nuevoArreglo = new double[this.matriz.GetLength(0)][];

        for (int i = 0; i < this.matriz.GetLength(0); i++){
            for (int j = 0; j < this.matriz.GetLength(1); j ++){
                nuevoArreglo[i][j] = this.GetElemento(i, j);
            }
        }
        return nuevoArreglo;
    }

    public void Sumarle(Matriz m) 
    {
        for (int i = 0; i < this.matriz.GetLength(0); i++){
            for (int j = 0; j < this.matriz.GetLength(1); j ++){
                this.SetElemento(i, j, this.GetElemento(i,j) + m.GetElemento(i, j));
            }
        }
    }
    public void Restarle(Matriz m) 
    {
        for (int i = 0; i < this.matriz.GetLength(0); i++){
            for (int j = 0; j < this.matriz.GetLength(1); j ++){
                this.SetElemento(i, j, this.GetElemento(i,j) + m.GetElemento(i, j));
            }
        }
    }

    public void MultiplicarPor(Matriz m) 
    {
        for (int i = 0; i < this.matriz.GetLength(0); i++){
            for (int j = 0; j < this.matriz.GetLength(1); j ++){
                
                double acc = 0;
                
                for (int k = 0; k < this.matriz.GetLength(0); k++) {
                    acc = this.GetElemento(i, k) + m.GetElemento(k, j);

                }
                
                this.SetElemento(i, j, acc);
            }
        }
    }

}