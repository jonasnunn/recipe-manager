public static class RecipeBook
{
    
    public static List<Recipe> Recipes = new List<Recipe>();
    private static int counter = 0;

    public static void AddRecipe()
    {
       Recipe newRecipe = new Recipe();
       Recipes.Add(newRecipe);
    }
    public static void AddRecipe(string name, int time, List<string> ingredients, List<string> steps)
    {
       Recipe newRecipe = new Recipe(name, time, ingredients, steps);
       Recipes.Add(newRecipe);
    }

    public static Recipe GetRecipe(int recipeInt) // Return the recipe based on the number it is in the list
    {
       return Recipes[recipeInt];
    }

    public static void DisplayRecipes()
    {
        counter = 0;
        Console.WriteLine("");
        Console.WriteLine("=====RECIPES=====");
        foreach (Recipe currentRecipe in Recipes)
        {
            counter ++;
            Console.WriteLine($"{counter}: {currentRecipe.Name}");
        }
    }
    public static void DisplayAllRecipeInfo()
    {
        Console.Clear();
        foreach (Recipe currentRecipe in Recipes)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Name: {currentRecipe.Name}");
            Console.WriteLine($"Time: {currentRecipe.cookTime} minutes");
            
            Console.WriteLine("");
            Console.WriteLine("Ingredients:");
            foreach (string currentIng in currentRecipe.Ingredients)
            {
                Console.WriteLine($">{currentIng}");
            }  

            Console.WriteLine("");
            Console.WriteLine("Directions:");
            int counter =  0;
            foreach (string currentStep in currentRecipe.Directions)
            {
                counter ++;
                Console.WriteLine($"{counter}: {currentStep}");
            }  
        }
        Thread.Sleep(3000);
    }
}