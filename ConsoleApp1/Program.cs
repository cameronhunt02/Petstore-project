using System.Text.Json;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type exit to quit");
string userInput = Console.ReadLine().ToLower();

while (userInput.ToLower() != "exit")
{
    if (userInput.ToLower() == "1")
    {
        CatFood item = new CatFood();
        Console.WriteLine("Press 1 for Cat Food or 2 for Kitten Food");
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            item.KittenFood = false;
            
        }
        else if(answer == "2")
        {
                item.KittenFood = true;
               
            
        }
        Console.WriteLine("How many pounds do you need?");
        double weight = Double.Parse(Console.ReadLine());
        Console.WriteLine($"You need {weight} pounds of food, someone has a hungy kitty!");
        item.WeightPounds = weight;
        Console.WriteLine(JsonSerializer.Serialize(item));











    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type exit to quit");
    userInput = Console.ReadLine();
    
}     

public class Product
{
    public string Name;
    public decimal Price;
    public int Quantity;
    public string Description;
}
public class CatFood : Product
{
    public double WeightPounds;
    public bool KittenFood;
}
public class DogLeash : Product
{
    public int LengthInches;
    public string Material;
}