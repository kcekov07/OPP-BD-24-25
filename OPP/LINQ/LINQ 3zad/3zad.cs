namespace LINQ_3zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Въведете текст:");
            string input = Console.ReadLine();

            
            char[] delimiters = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

           
            var shortWords = input
                .ToLower()                            
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries) 
                .Where(word => word.Length < 5)       
                .Distinct()                           
                .OrderBy(word => word)                
                .ToList();

            
            Console.WriteLine("Кратки думи (с по-малко от 5 знака), подредени азбучно:");
            Console.WriteLine(string.Join(", ", shortWords));
        }
    }
}
