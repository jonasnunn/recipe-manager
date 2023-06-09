public class FileManager{


    public void SaveRecipes()
    {
        using (StreamWriter outputFile = new StreamWriter("recipes.txt"))
        {
            foreach (Recipe currentRecipe in RecipeBook.Recipes)
            {
                outputFile.WriteLine($"{currentRecipe.Name}");
                outputFile.WriteLine($"{currentRecipe.cookTime}");
                
                int counter = 1;
                foreach (string currentIng in currentRecipe.Ingredients)
                {
                    outputFile.Write($"{currentIng}");
                    if (counter < currentRecipe.Ingredients.Count)
                    {
                        outputFile.Write(",");
                        counter ++;
                    }
                }  

                counter = 1;
                outputFile.WriteLine("");
                foreach (string currentStep in currentRecipe.Directions)
                {
                    outputFile.Write($"{currentStep}");
                    if (counter < currentRecipe.Directions.Count)
                    {
                        outputFile.Write(",");
                        counter ++;
                    }
                    else
                    {
                        outputFile.WriteLine("");
                    }
                }  
            }
        }
    }
    
    public void loadRecipes()
    {
        string newName = "blank";
        int newTime = 0;
        List<string> Ings = new List<string>();
        List<string> Dirs = new List<string>();
        string[] lines = System.IO.File.ReadAllLines("recipes.txt");
        for (int i = 0; i < lines.Count(); i++)
        {
            
            if (i % 4 == 0)
            {
                newName = lines[i];
            }

            else if (i % 4 == 1)
            {
                newTime = int.Parse(lines[i]);
            }

            else if (i % 4 == 2)
            {
                Ings = lines[i].Split(",").ToList();
            }

            else if (i % 4 == 3)
            {
                Dirs = lines[i].Split(",").ToList();

                RecipeBook.AddRecipe(newName, newTime, Ings, Dirs);
            }
        }
    }
}