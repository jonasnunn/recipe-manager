public class WeekPlan
{
    private List<string> _days = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
    private List<string> _breakfast = new List<string>() {"_______","_______","_______","_______","_______","_______","_______"};
    private List<string> _lunch = new List<string>() {"_______","_______","_______","_______","_______","_______","_______"};
    private List<string> _dinner = new List<string>() {"_______","_______","_______","_______","_______","_______","_______"};
    private List<Meal> _mealsInWeek = new List<Meal>();

    public WeekPlan()
    {
        
    }

    public void DisplayPlan()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("======================================= MEAL PLAN =======================================");
        foreach (string day in _days)
        {
         Console.Write("     ");
         Console.Write(day);
        } 
        
        Console.WriteLine("");

        foreach (string meal in _breakfast)
        {
         Console.Write("     ");
         Console.Write(meal);
        } 
        
        Console.WriteLine("");
        
        foreach (string meal in _lunch)
        {
         Console.Write("     ");
         Console.Write(meal);
        } 
        
        Console.WriteLine("");
        
        foreach (string meal in _dinner)
        {
         Console.Write("     ");
         Console.Write(meal);
        } 
        Console.WriteLine("");
    }

    public void DisplayIngredients()
    {
        foreach (Meal currentmeal in _mealsInWeek)
        {
            currentmeal.DisplayMealIngredients();
        }
    }

    public void AddMeal()
    {
        Console.WriteLine("");
        Console.WriteLine("What type of meal is this? ");
        Console.Write("1. Breakfast\n2. Lunch\n3. Dinner\n>:");
        int mealInt = int.Parse(Console.ReadLine());
        if (mealInt == 1)
        {
            AddBreakfast();
        } 
        else if (mealInt == 2)
        {
            AddLunch();
        } 
        else if (mealInt == 3)
        {
            AddDinner();
        } 
        else
        {
            Console.WriteLine("InvalidInput");
        }
    }

    public void AddBreakfast()
    {
        Console.WriteLine("");
        Console.Write($"What day do you want to add this meal(1-7 Sun = 1): ");
        int dayInt = int.Parse(Console.ReadLine()) - 1;
        Breakfast newBrek = new Breakfast();
        _breakfast[dayInt] = newBrek.Name;
        _mealsInWeek.Add(newBrek);
    }
    public void AddLunch()
    {
        Console.WriteLine("");
        Console.Write("What day do you want to add this meal(1-7 Sun = 1): ");
        int dayInt = int.Parse(Console.ReadLine()) - 1;
        Lunch newLun = new Lunch();
        _lunch[dayInt] = newLun.Name;
        _mealsInWeek.Add(newLun);
    }
    public void AddDinner()
    {
        Console.WriteLine("");
        Console.Write("What day do you want to add this meal(1-7 Sun = 1): ");
        int dayInt = int.Parse(Console.ReadLine()) - 1;
        Dinner newDin= new Dinner();
        _dinner[dayInt] = newDin.Name;
        _mealsInWeek.Add(newDin);
    }
}