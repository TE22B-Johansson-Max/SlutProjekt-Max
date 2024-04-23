public class Metodish
{
    static public string Karta(string[] tillgångar, int[,] plan)
    {
        string planString = "";
        
        for (int y = 0; y < plan.GetLength(0); y++)
        {
            for (int x = 0; x < plan.GetLength(1); x++)
            {
                planString += tillgångar[plan[x, y]];
            }
            planString += "\n";
        }
        return planString;
    }

}

