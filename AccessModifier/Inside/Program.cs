using System;


namespace Inside;


class Program
{
    public static void Main(string[]args)
    {
        Son son =new ();//accssesin public variable
        Console.WriteLine(son.PublicNumber);
        Console.WriteLine(son.PrivateOutNumber);
        Console.WriteLine(son.internalParentNumber);
    }
}