using System;

namespace Labstats
{
    class Program
    {
        static void Main(string[] args)
        {
            int red = 0;
            int russet = 0;
            string bags = "";

            Console.WriteLine("Enter the amount of bags of potatoes: ");
            bags = Console.ReadLine();

            getBags(bags);
            int[] bags_O_Taters = new int[getBags(bags)];

            convert(bags_O_Taters, ref red, ref russet);
            display(difference(red, russet));
            

        }

        /*********************************************
        * Get the amount of bags from the user
        ***********************************************/        
        public static int getBags(string bags)
        {
            int new_bags = Convert.ToInt32(bags);
            if (new_bags < 0 || new_bags > 40)
            {
                Console.WriteLine("We can only handle sacks of potatoes from 0 to 40 potatoes");
                Environment.Exit(0);
            }

            return new_bags + 1;
            
        }

        /*********************************************
        * Identify if the potatoes are "Russet" or "Red"
        ***********************************************/        
        public static void convert(int[] bags_O_Taters, ref int red, ref int russet)
        {

            for(int i = 1; i < bags_O_Taters.Length; i++)
            {
                bags_O_Taters[i] = i * i;
                if (bags_O_Taters[i] % 2 == 0)
                {
                    red += bags_O_Taters[i];
                }
                else
                {
                    russet += bags_O_Taters[i];
                }
            }
        }

        /*********************************************
        * Get the difference between "Russet" and "Red"
        ***********************************************/        
        public static int difference(int red, int russet)
        {
            int difference = red - russet;
            if (difference < 0)
            {
                difference = difference * -1;
            }
            return difference;
            // display(difference);

        }
        /*********************************************
        * Display the difference
        ***********************************************/        
        public static void display(int difference)
        {
            Console.WriteLine($"The total difference between Red potatoes and Russet potates: {difference}\n");
        }
    }
}
