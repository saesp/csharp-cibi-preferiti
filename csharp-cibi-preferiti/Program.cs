// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] favoriteFoods = { "pizza", "cheesecake", "donuts", "chocolate", "piadina" };

Console.WriteLine("Length: " + favoriteFoods.Length);

Console.WriteLine("Favorite foods list: "); 
for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"{i}. {favoriteFoods[i]}"); 
}

Console.WriteLine($"First: {favoriteFoods[0]}");

Console.WriteLine("Last: " + favoriteFoods[favoriteFoods.Length - 1]);

Console.WriteLine("Middle: " + favoriteFoods[(favoriteFoods.Length- 1)/ 2]);


