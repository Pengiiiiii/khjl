using System.Collections;

namespace eVoting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] games = new int[5];

           

            int[] votes = new int[20];

            for(int i = 0; i < votes.Length; i++)
            {
                votes[i] = R.Next(0, 5);
            }

            for(int i = 0; i < votes.Length; i++)
            {
                switch(votes[i])
                {
                    case 0:
                        games[0]++;
                        break;

                    case 1:
                        games[1]++;
                        break;

                    case 2:
                        games[2]++;
                        break;

                    case 3:
                        games[3]++;
                        break;

                    case 4:
                        games[4]++;
                        break;

                    case 5:
                        games[5]++;
                        break;

                    case 6:
                        games[6]++;
                        break;

                    case 7:
                        games[7]++;
                        break;

                    case 8:
                        games[8]++;
                        break;

                    case 9:
                        games[9]++;
                        break;
                        

                }
            }

            Console.WriteLine($"Spiel 1:  {games[0] * 100 / votes.Length}% : {games[0]} Stimmen");

            for(int i = 0; i < games[0] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }

            Console.WriteLine($"\nSpiel 2:  {games[1] * 100 / votes.Length}% : {games[1]} Stimmen");
            for (int i = 0; i < games[1] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 3:  {games[2] * 100 / votes.Length}% : {games[2]} Stimmen");
            for (int i = 0; i < games[2] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 4:  {games[3] * 100 / votes.Length}% : {games[3]} Stimmen");
            for (int i = 0; i < games[3] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 5:  {games[4] * 100 / votes.Length}% : {games[4]} Stimmen");
            for (int i = 0; i < games[4] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
           /* Console.WriteLine($"\nSpiel 6:  {games[5] * 100 / votes.Length}% : {games[5]} Stimmen");
            for (int i = 0; i < games[5] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 7:  {games[6] * 100 / votes.Length}% : {games[6]} Stimmen");
            for (int i = 0; i < games[6] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
          /*  Console.WriteLine($"\nSpiel 8:  {games[7] * 100 / votes.Length}% : {games[7]} Stimmen");
            for (int i = 0; i < games[7] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 9:  {games[8] * 100 / votes.Length}% : {games[5]} Stimmen");
            for (int i = 0; i < games[8] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine($"\nSpiel 10: {games[9] * 100 / votes.Length}% : {games[9]} Stimmen");
            for (int i = 0; i < games[9] * 100 / votes.Length; i++)
            {
                Console.Write("■");
            }*/

            Console.WriteLine($"\nGesamtanzahl: {votes.Length}");

        }
    }
}