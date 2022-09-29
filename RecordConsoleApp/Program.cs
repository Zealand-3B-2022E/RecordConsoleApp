// See https://aka.ms/new-console-template for more information
using RecordConsoleApp;

Console.WriteLine("Hello, World!");

Person p = new ("Jens", "Jensen");

Person p1 = new Person("Jens", "Jensen");

Console.WriteLine(p);
Console.WriteLine(p1);

if (p == p1)
    Console.WriteLine("disse to record er ens");
else
    Console.WriteLine("Disse to record er ikke ens");

//With
Person p3 = p1 with { Firstname = "Søren" };

Console.WriteLine(p3);