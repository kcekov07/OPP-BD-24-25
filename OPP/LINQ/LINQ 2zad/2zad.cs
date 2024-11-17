namespace LINQ_2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Въведете списък от реални числа, разделени с интервал:");
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

           
            var topThree = nums
                .OrderByDescending(x => x) 
                .Take(3)                   
                .ToList();

           
            Console.WriteLine("Трите най-големи числа са:");
            Console.WriteLine(string.Join(", ", topThree));
        }
    }
}
