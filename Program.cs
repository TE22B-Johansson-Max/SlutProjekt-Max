Console.OutputEncoding = System.Text.Encoding.UTF8;

int[,] plan = new int[8, 8];
string[] tillgångar = { "⬜", "🈴", "C", "D", };
int[] spelarPos = { 0, 0};
plan[spelarPos[0], spelarPos[1]] = 1;

List<int[]> Blocks = new List<int[]>();



while (true)
{
    Console.Clear();
    Console.WriteLine(Metodish.Karta(tillgångar, plan));
    var key = Console.ReadKey().Key;
    plan[spelarPos[0], spelarPos[1]] = 0;
    switch (key)
    {
        case ConsoleKey.W or ConsoleKey.UpArrow when spelarPos[1] > 0:
            spelarPos[1]--;
            break;

        case ConsoleKey.S or ConsoleKey.DownArrow when spelarPos[1] < 7:
            spelarPos[1]++;
            break;

        case ConsoleKey.A or ConsoleKey.LeftArrow when spelarPos[0] > 0: 
            spelarPos[0]--;
            break;

        case ConsoleKey.D or ConsoleKey.RightArrow when spelarPos[0] < 7:
            spelarPos[0]++;
            break;

        case ConsoleKey.Enter:
            Blocks.Add(new int[] {spelarPos[0], spelarPos[1]});
            break;
    }
    plan[spelarPos[0], spelarPos[1]] = 1;

    foreach (var blockPos in Blocks)
    {
        plan[blockPos[0], blockPos[1]] = 1;
    }



    // ...

    //Objekt();



}





