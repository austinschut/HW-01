// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome");
Console.WriteLine("Please type your name in the space below then press [ENTER].");
Console.WriteLine();
DateTime started = DateTime.Now;
Console.ReadLine();
DateTime finished = DateTime.Now;
Console.WriteLine("Hello User");
Console.WriteLine($"You were able to type your name in {finished - started} seconds!");