public class Vector
{
    public double Start { get; set; }
    public double End { get; set; }

    public Vector(double start, double end)
    {
        Start = start;
        End = end;
    }

    public static Vector operator +(Vector v1, Vector v2)
        => new(v1.Start + v2.Start, v1.End + v2.End);

    public static Vector operator -(Vector v1, Vector v2)
        => new(v1.Start - v2.Start, v1.End - v2.End);

    public static Vector operator *(Vector v, double d)
        => new(v.Start * d, v.End * d);

    public static double operator *(Vector v1, Vector v2)
        => v1.Start * v2.Start + v1.End * v2.End;

    public static bool operator ==(Vector v1, Vector v2)
    {
        if (v1.Start == v2.Start && v1.End == v2.End) return true;
        return false;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        if (v1.Start != v2.Start || v1.End != v2.End) return true;
        return false;
    }

    public static void operator [](Vector )
}
