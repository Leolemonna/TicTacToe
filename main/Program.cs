using tic_tac_toe;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //обьявление переменных, функций

            string[,] XO =   {  { ".", ".", "." },
                                { ".", ".", "." },
                                { ".", ".", "." }};
            string[] pl = lib.Player.DefinePlayerName();
            string fpl = pl[0], spl = pl[1], win = "n";
            // основной цикл с самой игрой

            while (win == "n") {
                lib.Field.Write(XO);
                XO = lib.Field.ReadStrike(XO, 1, fpl);
                lib.Field.Write(XO);
                XO = lib.Field.ReadStrike(XO, 2, spl);
                win = lib.Win.DefineWin(XO);
            }
            lib.Win.End(win, fpl, spl);
        }
    }
}

