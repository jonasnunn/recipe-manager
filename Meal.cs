public class Meal
{

    public List<Recipe> MealRecipes = new List<Recipe>();
    private List<String> _mealIngredients = new List<String>();
    public string Name;

    public Meal()
    {
        Console.Write("What is the name of this meal: ");
        Name = Console.ReadLine();
        
        RecipeBook.DisplayRecipes();
        Console.Write("What recipe is in this meal: ");
        int rec = int.Parse(Console.ReadLine()) - 1;

        while (rec != -1)
        {
            Recipe newRec = RecipeBook.GetRecipe(rec);
            MealRecipes.Add(newRec);
            Console.Write("What is the next recipe in the meal (0 when done): ");
            rec = int.Parse(Console.ReadLine()) - 1;
        }  
    }

    private void _updateMealIngredients()
    {
        _mealIngredients.Clear();
        // Go through the recipes and add their ingredients to the list
        Console.WriteLine($"\n\n=====INGREDIENTS=====");
        foreach (Recipe currentRecipe in MealRecipes)
        {
            _mealIngredients.AddRange(currentRecipe.GetIngredients());
        }
    }

    public void DisplayMealIngredients()
    {
        _updateMealIngredients();
        // Go through the ingredients list and display them
        foreach (String ing in _mealIngredients)
        {
            Console.WriteLine(ing);
        }
    }
}