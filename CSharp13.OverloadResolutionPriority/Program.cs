using System.Runtime.CompilerServices;


X.DoSomething(1, 2, 3, 4, 5);
Y.DoSomething(1, 2, 3, 4, 5);


public class X
{
    public static void DoSomething(params int[] values)
    {
        Console.WriteLine($"X: int[].Length = {values.Length}");
    }

    public static void DoSomething(params Span<int> values)
    {
        Console.WriteLine($"X: Span<int>.Length = {values.Length}");
    }
}

public class Y
{
    [OverloadResolutionPriority(1)]
    public static void DoSomething(params int[] values)
    {
        Console.WriteLine($"Y: int[].Length = {values.Length}");
    }

    public static void DoSomething(params Span<int> values)
    {
        Console.WriteLine($"Y: Span<int>.Length = {values.Length}");
    }
}