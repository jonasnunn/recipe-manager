UserMenu menu = new UserMenu();
FileManager file = new FileManager();
WeekPlan weekplan = new WeekPlan();

int choiceInt = - 1;
int recInt = - 1;
int mealInt = - 1;

// Load in recipes
file.loadRecipes();

while (choiceInt != 0)
{
    choiceInt = menu.MainMenu();
    // Recipe Book menu
    if (choiceInt == 1)
    {
        while (recInt != 0)
        {
            recInt = menu.RecipeMenu();
            if (recInt == 1)
            {
                RecipeBook.DisplayRecipes();
            }
            
            else if (recInt == 2)
            {
                RecipeBook.DisplayAllRecipeInfo();
            }
            
            else if (recInt == 3)
            {
                RecipeBook.AddRecipe();
            }

            else if (recInt == 4)
            {
                file.SaveRecipes();
            }
        }
        // Set the value back to default
        recInt = - 1;
    }
    // Meal Planner Menu
    else if (choiceInt == 2)
    {
        while (mealInt != 0)
        {
            mealInt = menu.MealMenu();
            
            if (mealInt == 1)
            {    
                weekplan.DisplayPlan();
            }

            else if (mealInt == 2)
            {
                weekplan.AddMeal(); 
            }

            else if (mealInt == 3)
            {
                weekplan.DisplayIngredients(); 
            }

        }
        mealInt = -1;
    }
}

