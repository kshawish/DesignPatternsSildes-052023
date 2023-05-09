using Prototype_Design_Pattern.Classes;


Rectangle a = new();
a.LoadData();
Console.WriteLine($"a -> width = {a.GetWidth()}, height = {a.GetHeight()}");

/*Rectangle b = new();
b.SetWidth(a.GetWidth());
b.SetHeight(a.GetHeight());
Console.WriteLine($"a -> width = {a.GetWidth()}, height = {a.GetHeight()}, hash code = {a.GetHashCode()}");
Console.WriteLine($"b -> width = {b.GetWidth()}, height = {b.GetHeight()}, hash code = {b.GetHashCode()}");*/

/*
Rectangle b = (Rectangle)a.Clone();
Console.WriteLine($"a -> width = {a.GetWidth()}, height = {a.GetHeight()}, hash code = {a.GetHashCode()}");
Console.WriteLine($"b -> width = {b.GetWidth()}, height = {b.GetHeight()}, hash code = {b.GetHashCode()}");
Console.WriteLine("----------------------------------------");
b.SetWidth(1);
Console.WriteLine($"a -> width = {a.GetWidth()}, height = {a.GetHeight()}, hash code = {a.GetHashCode()}");
Console.WriteLine($"b -> width = {b.GetWidth()}, height = {b.GetHeight()}, hash code = {b.GetHashCode()}");*/


