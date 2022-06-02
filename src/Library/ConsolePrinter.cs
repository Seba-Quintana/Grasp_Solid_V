using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IPrintRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}