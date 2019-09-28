using System;

namespace Fun_Places_to_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = string.Empty, wtd = string.Empty, act = string.Empty, trav = string.Empty;
            int result = 0, ppl = 0;

            bool isTrue = true;
            bool Truth = true;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}, What do you want to do today?", name);
            

            while (isTrue)
            {
                Console.WriteLine("1) Action\n2) Chilling\n3) Danger\n4) Good Food\n");
                var isValidInt = int.TryParse(Console.ReadLine(), out result);

                if (isValidInt)
                {
                    if (result == 1)
                    {
                        wtd = "action";
                        act = "Stock Car Racing";
                        isTrue = false;
                    }
                    else if (result == 2)
                    {
                        wtd = "chilling";
                        act = "Hiking";
                        isTrue = false;
                    }
                    else if (result == 3)
                    {
                        wtd = "danger";
                        act = "Skydiving";
                        isTrue = false;
                    }
                    else if (result == 4)
                    {
                        wtd = "good food";
                        act = "to Taco Bell";
                        isTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("I do not understand. Please select again");
                    }
                }
                else
                {
                    Console.WriteLine("Use numbers instead");
                }
                
            }


            //Second part. How many People
            while (Truth)
            {
                Console.WriteLine("How many people are you bring with you?");
                var ValidInt = int.TryParse(Console.ReadLine(), out ppl);

                if (ValidInt)
                {
                    if (ppl == 0)
                    {
                        trav = "sneakers";
                        Truth = false;
                    }
                    else if (ppl > 0 && ppl <= 4)
                    {
                        trav = "a sedan";
                        Truth = false;
                    }
                    else if (ppl >= 5 && ppl <= 10)
                    {
                        trav = "a Volkswagon bus";
                        Truth = false;
                    }
                    else
                    {
                        trav = "an airplane";
                        Truth = false;
                    }
                }
                else
                {
                    Console.WriteLine("Use numbers instead");
                }
            }
            Console.WriteLine("Okay. If you are in the mood for " + wtd + ", then you should go " + act + " and travel in " + trav +".");
            //Console.WriteLine("Okay. You are in the mood for " + wtd);
            //Console.WriteLine("You should go " + act);
            //Console.WriteLine("You should travel in " + trav);
            Console.WriteLine("Have a great day!");

        }
    }
}
