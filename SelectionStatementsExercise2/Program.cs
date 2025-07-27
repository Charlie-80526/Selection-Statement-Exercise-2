namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't prefer math at all");
                    break;
                case "science":
                    Console.WriteLine("Science Rocks");
                    break;
                case "languages":
                    Console.WriteLine("languages are fun");
                    break;
                case "coding":
                    Console.WriteLine("Coding is interesting");
                    break;
                case "literature":
                    Console.WriteLine("Literature is my favorite too");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;
            }
        }
    }
}