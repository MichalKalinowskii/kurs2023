using kurs2023;
namespace KlawiaturaKlasyczna
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string michal = "tomek";
            string result = "";

            foreach (var letter in michal)
            {
                result += LetterCode.GetLetterCode(letter);
            }

            Console.WriteLine(result);

        }
    }
}