using System;

public class Vector
{
    public double Start { get; set; }
    public double End { get; set; }

    public Vector(double start, double end)
    {
        Start = start;
        End = end;
    }

    public double this[int index]
    {
        get
        {
            if (index == 0) return Start;
            if (index == 1) return End;
            throw new IndexOutOfRangeException("Индекс должен быть 0 или 1");
        }
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
        if (v1 is null || v2 is null) return false;
        return v1.Start == v2.Start && v1.End == v2.End;
    }

    public static bool operator !=(Vector v1, Vector v2)
        => !(v1 == v2);

    public override bool Equals(object obj)
    {
        return Equals(obj as Vector);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }

    public override string ToString()
    {
        return $"({Start}, {End})";
    }
}

public class Program
{
	public static void Main()
	{
		var v1 = new Vector(1, 2);
		var v2 = new Vector(3, 4);

		Console.WriteLine(v1 + v2);
		Console.WriteLine(v1 - v2);
		Console.WriteLine(v1 * 2);
		Console.WriteLine(v1 * v2);
		Console.WriteLine(v1[0]);
		Console.WriteLine(v1 == v2);
	}
}
