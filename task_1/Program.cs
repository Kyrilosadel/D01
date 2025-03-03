namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small rooms:");
            int smallRooms = Convert.ToInt32( Console.ReadLine());
            Console.Write("Number of large rooms:");
            int largeRooms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            int cost = (smallRooms * 25) + (largeRooms * 35);
            double taxs = cost * 0.06;
            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax: ${taxs}");
            Console.WriteLine("-_______________-");

            double total = cost + taxs;
            Console.WriteLine($"Total estimate: ${total}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
