using System;

namespace fagsdhjGDASfdhgsfdd.cs
{
    internal class Program
    {
        static void method1(string name4)   //METHOD
        {
            Console.WriteLine("This is a method, works like a function?");
            Console.WriteLine("All the things go here gvfugegwua");
            Console.WriteLine("HAHAHAHAH \"Noobs\" "); //Having the " in a string
            Console.WriteLine(name4);
        }
        static void Main(string[] args)
        {
            Console.Write("Input required: ");
            double input_value = Convert.ToDouble(Console.ReadLine());  //Input
            Console.Write("Input index; power: ");
            int index_value = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();        //number Randomizer 
            int rannum = random.Next(1, 7);
            double rannum2 = random.NextDouble();
            double x = 100.123;
            int y = Convert.ToInt32(x);      //Converter
            Console.WriteLine(y);
            Console.WriteLine(y.GetType());
            Console.WriteLine(x.ToString().GetType());
            Console.WriteLine(input_value);
            double integers = Math.Pow(input_value, index_value);                    //Mathy shits
            double Round = Math.Round(Convert.ToDouble(input_value));
            double Ceiling = Math.Ceiling(Convert.ToDouble(input_value));  //Rounds up
            double Floor = Math.Floor(Convert.ToDouble(input_value));    //Rounds down
            Console.WriteLine(input_value + " to the power of " + index_value + " = " + integers);
            Console.WriteLine("Rounded input: " + Round);
            Console.WriteLine("Ceiling input (Rounded up): " + Ceiling);
            Console.WriteLine("Floor input (Rounded down): " + Floor);
            string name = "aAbrKMEdj248q-12BiR-2rIQEwh";
            name = name.ToUpper(); //Makes everything in string uppercase
            name = name.ToLower(); //Vice versa of line 31
            string name2 = name.Replace("-", "/"); //Replaces all the "-" in the string to "/". If replaced to "" then all the "-" will be removed.
            string name3 = name.Insert(0, "@"); //Adds "@" to before the "name". (0 means the first letter of the string)
            Console.WriteLine(name);
            Console.WriteLine(name.Length); //Length of string (dont need the "()")
            Console.WriteLine(name.Substring(0, 3));  //takes the first 3 letters of the string  (name.Substring(from_which_letter, how_many_letters_after_it))
            Console.WriteLine(name2);
            Console.WriteLine(name3);

            // IF STATEMENT
            Console.WriteLine("//IF STATEMENT//");
            Console.Write("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Age equal or above 18");
            }
            else
            {
                Console.WriteLine("Age below 18");
            }

            //SWITCHES (use if u use too many if else statements)
            /*switch (age)
            {
                case 0:
                    Console.WriteLine("really, 0 age?");
                    break;
                case -1:
                    Console.WriteLine("stfu ur not even being serious");
                    break;
                case 18:
                    Console.WriteLine("welcome to the adulthood");
                    break;
                case 100:
                    Console.WriteLine("bro ur dead");
                    break;
                default:   //If non of the cases above matches, this one occurs.
                    Console.WriteLine("afhbuae");
                    break;*/

            //WHILE LOOP
            Console.WriteLine("//WHILE LOOP//");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            while (name.Length <= 0)
            {
                Console.WriteLine("Please enter your name and dont leave it blank.");
                name = Console.ReadLine();
            }
            Console.WriteLine("Welcome, " + name);

            //FOR LOOP, quite the same as JavaScript honestly
            Console.WriteLine("//FOR LOOP");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //ARRAYS: Multiple values in a single variable
            Console.WriteLine("//ARRAYS//");
            String[] car = { "Car1", "Car2" };
            Console.WriteLine(car[0]);
            car[0] = "not a car";
            Console.WriteLine(car[0]);
            for (int i = 0; i < car.Length; i++)    //Printing all values in the variable
            {
                Console.WriteLine(car[i]);
            }

            //ARRAYS: Fixed amount of value
            Console.WriteLine("//ARRAYS: FIXED AMOUNT OF VALUE//");
            String[] cars = new string[2];
            cars[0] = "hi";
            cars[1] = "hi";

            //Foreach loop (what)
            Console.WriteLine("//FOREACH LOOP (Alternative for loop)//");
            foreach (String i in car)   //Alternative way to the loop above but less flexible
            {
                Console.WriteLine(i);
            }

            //CALLING METHOD (method is at the top of this script)
            Console.WriteLine("//METHODS//");
            string name4 = "hi";
            method1(name4);


            Console.ReadKey();
        }
    }
}