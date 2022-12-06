using DSAClassLibrary.Recursion;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var recursion = new Recursion();
recursion.HeadRecursion(3);
Console.WriteLine("----------------");
recursion.TailRecursion(3);
//Console.ReadLine();
var fun = recursion.RecursionWithStaticVariable(5);
Console.WriteLine("----------------");
Console.WriteLine(fun);
var global = recursion.RecursionWithGloabVariable(5);
Console.WriteLine("----------------");
Console.WriteLine(global);
