namespace leapyearw1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int year;

            Console.WriteLine("enter a year");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year", year);
            else if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);
        }
    }
}