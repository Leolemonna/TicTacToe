using System;

namespace TICTACTOELibrary
{
    public class Field
    {
        void Write(string[,] XO)
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
    }
}
