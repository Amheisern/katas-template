// using System;

// public static class Kata
// {

//     public static string Hello(string name)
//     {
//         Console.WriteLine("What is your name?");
//         Console.ReadLine(name);

//         // If (name == ()
//         if (name == "")
//         {
//             return "Hello, World!";
//         }
//         return "Hello, name is " + name;
//         //  return "Hello, CodeWarrior!";
//     }
// }
using System;

public static class Kata
{
    public static string Hello()
    {
        return Hello("");
    }
    public static string Hello(string name)
    {
        string nam = "";
        if (name == "") nam = "World";
        else nam = Char.ToUpperInvariant(name[0]) + name.Substring(1).ToLower();

        return "Hello, " + nam + "!";
    }
}