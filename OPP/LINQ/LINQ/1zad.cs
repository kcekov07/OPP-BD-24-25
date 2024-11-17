namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете броя на числата:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Въведете {n} цели числа, разделени с интервал:");
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

           
            int sum = nums.Sum(); 
            int min = nums.Min();
            int max = nums.Max(); 
            int first = nums.First();
            int last = nums.Last(); 
            double average = nums.Average(); 

            
            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Първи елемент: {first}");
            Console.WriteLine($"Последен елемент: {last}");
            Console.WriteLine($"Средноаритметично: {average:F2}");
        }
    }
}
    
