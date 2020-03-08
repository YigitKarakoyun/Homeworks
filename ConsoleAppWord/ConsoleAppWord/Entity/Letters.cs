using System.Linq;

namespace ConsoleAppWord.Entity
{
    class Letters
    {
        public static string[] Letter { get;private set; } = new string[]
        {
            "A","B","C","Ç","D","E","F",
            "G","Ğ","H","I","İ","J","K",
            "L","M","N","O","Ö","P","R",
            "S","Ş","T","U","Ü","V","Y","Z"
        };
        public static int LetterCount
        {
            get { return Letter.Count(); }
        }
        public static string Get_Letter(int index) 
        {
            return Letter?[index];
        }
    }
}
