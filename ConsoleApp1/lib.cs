using System;

namespace tic_tac_toe
{
    class lib
    {
        public class Field
        {
            public static void Write(string[,]XO)
            {
                for (int i = 2; i >= 0; i -= 1)
                {
                    for (int j = 0; j <= 2; j += 1)
                    {
                        Console.Write(XO[i, j] + " ");
                        System.Threading.Thread.Sleep(50);
                        //Console.WriteLine(Convert.ToString(i) + Convert.ToString(j));
                    }
                    Console.WriteLine();
                }
            }
            public static string[,] ReadStrike(string[,] XO, int player, string pl)
            {
                string[] xy;
                int x, y;

                static string[] getXY(string pl)
                {
                    string[] coordinates = { "0", "0" };
                    string x, y;
                    Console.Write("'" + pl + "'`s strike, axis X: ");
                    x = Console.ReadLine();
                    Console.Write("'" + pl + "'`s strike, axis Y: ");
                    y = Console.ReadLine();
                    bool isTry = false;
                    while (isTry == false)
                    {
                        try
                        {
                            x = Convert.ToString(Convert.ToInt32(x) - 1);
                            y = Convert.ToString(Convert.ToInt32(y) - 1);
                            coordinates[0] = x;
                            coordinates[1] = y;
                            isTry = true;
                        }
                        catch
                        {
                            Console.WriteLine("'" + pl + "'`s strike is invalid please enter another one");
                            Console.Write("'" + pl + "'`s strike, axis X: ");
                            x = Console.ReadLine();
                            Console.Write("'" + pl + "'`s strike, axis Y: ");
                            y = Console.ReadLine();
                        }
                    }
                    return coordinates;
                }

                xy = getXY(pl);
                x = Convert.ToInt32(xy[0]);
                y = Convert.ToInt32(xy[1]);
                // Console.WriteLine(x + "," + y);
                while ((x > 3 || y > 3) || (x < 0 || y < 0))
                {
                    if (x > 3 || y > 3)
                    {
                        Console.WriteLine("Coordinate is too big, enter another one ");
                        Console.WriteLine(x + y);
                    }
                    if (x < 0 || y < 0)
                    {
                        Console.WriteLine("Coordinate is too small, enter another one ");
                        Console.WriteLine(x + y);
                    }
                    xy = getXY(pl);
                    x = Convert.ToInt32(xy[0]);
                    y = Convert.ToInt32(xy[1]);
                }

                // 
                while ((XO[y, x] == "x" || XO[y, x] == "x") || (XO[y, x] == "o" || XO[y, x] == "o"))
                {
                    Console.WriteLine("There was already a mark enter it in other place, ");
                    xy = getXY(pl);
                    x = Convert.ToInt32(xy[0]);
                    y = Convert.ToInt32(xy[1]);
                }
                if (player == 1)
                {
                    XO[y, x] = "x";
                }
                else if (player == 2)
                {
                    XO[y, x] = "o";
                }
                return XO;
            }
        }
        public class Win
        {
            public static string DefineWin(string[,] XO)
            {
                int number_of_dots = 0;
                for (int i = 2; i >= 0; i -= 1)
                {
                    for (int j = 0; j <= 2; j += 1)
                    {
                        if (XO[i, j] == ".") { number_of_dots += 1; }
                    }
                }
                for (int j = 2; j >= 0; j += -1)
                {
                    if (XO[j, 1] == "x" && XO[j, 0] == "x" && XO[j, 2] == "x") { return "f"; }
                    if (XO[j, 1] == "o" && XO[j, 0] == "o" && XO[j, 2] == "o") { return "s"; }
                    if (XO[1, j] == "x" && XO[0, j] == "x" && XO[2, j] == "x") { return "f"; }
                    if (XO[1, j] == "o" && XO[0, j] == "o" && XO[2, j] == "o") { return "s"; }
                }

                if (XO[2, 0] == "x" && XO[1, 1] == "x" && XO[0, 2] == "x") { return "f"; }
                if (XO[0, 0] == "x" && XO[1, 1] == "x" && XO[2, 2] == "x") { return "f"; }
                if (XO[2, 0] == "o" && XO[1, 1] == "o" && XO[0, 2] == "o") { return "s"; }
                if (XO[0, 0] == "o" && XO[1, 1] == "o" && XO[2, 2] == "o") { return "s"; }
                if (number_of_dots == 0)
                {
                    return "d";
                }
                return "n";
            }
            public static void End(string win, string fpl, string spl)
            {
                if (win == "f")
                {
                    Console.WriteLine(fpl + " player won!");
                }
                else if (win == "s")
                {
                    Console.WriteLine(spl + " player won!");
                }
                else if (win == "d")
                {
                    Console.WriteLine("Draw!");
                }
                Console.ReadKey();
            }
        }
        public class Player
        {
            public static string[] DefinePlayerName()
            {
                Console.Write("First player name: ");
                string fpl = Console.ReadLine();
                Console.Write("Second player name: ");
                string spl = Console.ReadLine();
                string[] pl = { fpl, spl };
                return pl;
            }
        }
    }
}
