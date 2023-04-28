class ComparadorLongitudNombre: IComparer<INombrable>
{
      public int Compare(INombrable x, INombrable y)
      {
        if (x.Nombre.Length == y.Nombre.Length) return 1;

        else {
            return x.Nombre.Length - y.Nombre.Length;
        }

      }
}