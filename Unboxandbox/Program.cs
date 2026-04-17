using System;

class Program
{
    static void Main()
    {
        // Value type variable
        int num = 10;

        // Boxing (int -> object)
        object boxed = num;

        Console.WriteLine("After Boxing:");
        Console.WriteLine("Value: " + boxed);
        Console.WriteLine("Type of boxed object: " + boxed.GetType());

        // Unboxing (object -> int)
        int unboxed = (int)boxed;

        Console.WriteLine("\nAfter Unboxing:");
        Console.WriteLine("Value: " + unboxed);
        Console.WriteLine("Type of unboxed variable: " + unboxed.GetType());
    }
}