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

//Console.WriteLine("Middle (odd list): " + favoriteFoods[(favoriteFoods.Length)/ 2]);

//TEST FOR EVEN LIST
//string[] favoriteFoodsEven = { "pizza", "cheesecake", "donuts", "cheeseburger", "chocolate", "piadina" };
//Console.WriteLine("Middle (even list): " + favoriteFoodsEven[(favoriteFoodsEven.Length - 1) / 2] + favoriteFoodsEven[(favoriteFoodsEven.Length) / 2]);

if (favoriteFoods.Length % 2 == 0)
    //even
    Console.WriteLine("Middle (even list): " + favoriteFoods[(favoriteFoods.Length - 1) / 2] + ", " + favoriteFoods[(favoriteFoods.Length) / 2]);
else
    //odd
    Console.WriteLine("Middle (odd list): " + favoriteFoods[(favoriteFoods.Length) / 2]);


