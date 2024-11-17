namespace LINQ_4zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Въведете числа:");
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = nums.Length / 4; 

            
            var row1Left = nums.Take(k).Reverse();               
            var row1Right = nums.Reverse().Take(k);              
            var row1 = row1Left.Concat(row1Right).ToArray();   

            
            var row2 = nums.Skip(k).Take(2 * k).ToArray();       

            
            var sum = row1.Select((x, index) => x + row2[index]);

            
            Console.WriteLine("Сгънатият и сумиран масив:");
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
    

