using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"{receta.GetTextToPrint()}");
        }
    }
}