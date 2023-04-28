interface INombrable: IComparable
{
    string Nombre { get; set;}

    int CompareTo(object obj);

}