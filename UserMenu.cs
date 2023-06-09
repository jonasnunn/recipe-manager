public class UserMenu
{
    public UserMenu()
    {

    }

    public int MainMenu()
    {
        Console.WriteLine("\n================MAIN MENU================");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("0. Quit");
        Console.WriteLine("1. Recipe Book");
        Console.WriteLine("2. Meal Planner");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }
    public int RecipeMenu()
    {
        Console.WriteLine("\n================RECIPE BOOK================");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("0. Main Menu");
        Console.WriteLine("1. See a list of recipes");
        Console.WriteLine("2. See all of the recipes information");
        Console.WriteLine("3. Add a recipe");
        Console.WriteLine("4. Save your recipes");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }
    public int MealMenu()
    {
        Console.WriteLine("\n================MEAL PLANNER================");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("0. Main Menu");
        Console.WriteLine("1. See your current plan");
        Console.WriteLine("2. Add a meal");
        Console.WriteLine("3. Generate Shopping List");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }
}


