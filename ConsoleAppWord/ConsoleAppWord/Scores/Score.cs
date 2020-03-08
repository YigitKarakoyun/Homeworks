
namespace ConsoleAppWord.Scores
{
    public class Score
    {
        public static int Get_Score(string result)
        {
            switch (result.Length)
            {
                case 3: return 3;
                case 4: return 4;
                case 5: return 5;
                case 6: return 7;
                case 7: return 9;
                case 8: return 11;
                case 9: return 15;
                default: return 0;
            }
        

        }
    }
}
