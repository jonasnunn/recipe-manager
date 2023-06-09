public class Recipe
{
    
    public string Name = "";
    public int cookTime = 0;
    public List<string> Directions = new List<string>();
    public List<string> Ingredients = new List<string>();
    
    public Recipe()
    {
        Console.Write("What is the name of the recipe: ");
        Name = Console.ReadLine();

        Console.Write("How many minutes does it take to make: ");
        cookTime = int.Parse(Console.ReadLine());

        Console.Write("What is the first ingredient you need: ");
        string userStr = Console.ReadLine();
        while (userStr != "0")
        {
            Ingredients.Add(userStr); 
            Console.Write("What is the next ingredient you need (0 when done): ");
            userStr = Console.ReadLine();
        }

        Console.Write("What is the first step to make it: ");
        string Step = Console.ReadLine();
        while (Step != "0")
        {
            Directions.Add(Step); 
            Console.Write("What is the next step (0 when done): ");
            Step= Console.ReadLine();
        }        
    }
    public Recipe(string name, int time, List<string> ingredients, List<string> steps)
    {
        Name = name;

        cookTime =  time;

        Ingredients = ingredients; 

        Directions = steps;
    }

    public List<string> GetIngredients()
    {
        return Ingredients;
    }
}