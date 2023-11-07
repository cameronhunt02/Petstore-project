using System.Text.Json;
using System.Collections.Generic;

var productLogic = new ProductLogic();


Console.WriteLine("Press 1 to purchase Cat food");
Console.WriteLine("Press 2 to search for a dog leash");
Console.WriteLine("Type exit to quit");
string userInput = Console.ReadLine().ToLower();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        CatFood item = new CatFood();
        Console.WriteLine("Press 1 for Cat Food or 2 Kitten food");
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
        Console.WriteLine($"You need {weight} pounds of food, someone has a hungry kitty!");
        item.WeightPounds = weight;
        
        Console.WriteLine("You have added a product!");
        Console.WriteLine(JsonSerializer.Serialize(item));

    }
    else if (userInput == "2")
    {
        var DogLeash1 = new DogLeash();

        Console.WriteLine("Creating a dog leash...");

        Console.Write("Enter the material the leash is made out of: ");
        DogLeash1.Material = Console.ReadLine();

        Console.Write("Enter the length in inches: ");
        DogLeash1.LengthInches = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the leash: ");
        DogLeash1.Name = Console.ReadLine();

        Console.Write("Give the product a short description: ");
        DogLeash1.Description = Console.ReadLine();

        Console.Write("Give the product a price: ");
        DogLeash1.Price = int.Parse(Console.ReadLine());

        Console.Write("How many products do you have on hand? ");
        DogLeash1.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine(JsonSerializer.Serialize(DogLeash1));
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

public class ProductLogic
{
    List<Product> _products;
    Dictionary<string, DogLeash> _DogLeash1;
    Dictionary<string, CatFood> _CatFood1;
    
    public ProductLogic()
    {
        _products = new List<Product>();
        _DogLeash1 = new Dictionary<string, DogLeash>();  
        _CatFood1 = new Dictionary<string, CatFood>();
        }
    public void AddProduct(Product product)
    {
        if (product is DogLeash)
        {
            _DogLeash1.Add(product.Name, product as DogLeash);
        }
        if (product is CatFood)
        {
            _CatFood1.Add(product.Name, product as CatFood);
        }
        _products.Add(product);
    }
    public DogLeash GetDogLeashByName(string name)
    {
        return _DogLeash1[name];
    }
    public List<Product> GetAllProducts() 
    {
        return _products;
    }
    



}


