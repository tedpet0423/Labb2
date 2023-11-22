// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        //deklarerar variabler som ska användas senare
        string[] familyNames = null;
        int[] familyAge = null;
        int familySum = 0;
        int ageSum = 0;
      
        //while loop för meny och olika val
        while (true)
        {
            // Skriver ut meny
            Console.WriteLine(
                "\n----------------------------------------------------" +
                "\nChoose an option from the menu below" +
                "\n(1)  Enter the names and ages of your family members" +
                "\n(2)  Calculate the average age of your family" +
                "\n(3)  Print the entered family members name and age" +
                "\n(4)  Calculate the combined age of the entered family" +
                "\n(5)  Exit" +
                "\n------------------------------------------------------"
            );
            //hämtar input från användaren och deklarerar variabel för val i meny
            string mainMenu = Console.ReadLine();
            //switch för valet i meny
            switch (mainMenu)
            {
                //för val 1
                case "1":
                    Console.Clear();
                    // tillskriver värden från användaren till de tidigare deklarerade variablerna
                    Console.WriteLine("How many family members do you have? (Including you)");
                    familySum = int.Parse(Console.ReadLine());
                    familyNames = new string[familySum];
                    familyAge = new int[familySum];
                    //for-loop för att hämta information om användaren 
                    for (int i = 0; i < familySum; i++)
                    {
                        Console.WriteLine($"What is the name of family member {i + 1}?");
                        familyNames[i] = Console.ReadLine();
                        Console.WriteLine($"What is the age of family member {i + 1}?");
                        familyAge[i] = int.Parse(Console.ReadLine());
                    }

                    break;
                case "2":
                    if (familySum == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("No family members entered, please choose option (1) first.");
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("The average age is:\n");
                        ageSum = familyAge.Sum();
                        double dAgeSum = Convert.ToDouble(ageSum);
                        double dFamilySum = Convert.ToDouble(familySum);
                        double ageAvg = (dAgeSum / dFamilySum);
                        Console.WriteLine(ageAvg.ToString("##.00"));
                    }
                    
                    break;
                case "3":
                    if (familySum == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("No family members entered, please choose option (1) first.");
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        for (int i = 0; i < familySum; i++)
                            Console.WriteLine($"{familyNames[i]} is {familyAge[i]} years old\n");
                    }

                    break;
                case "4":
                    if (familySum == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("No family members entered, please choose option (1) first.");
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Thinking");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking.");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking..");
                            Thread.Sleep(200);
                            Console.Clear();
                            Console.WriteLine("Thinking...");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("The combined age is:\n" + ageSum);
                    }

                  
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Press any key to exit" +
                                      "\n-----------------------");
                    return;
                default:
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Thinking");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Thinking.");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Thinking..");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Thinking...");
                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    Console.Clear();
                    Console.WriteLine("Invalid input, please choose from list.");
                    break;
                    
                    
                    


            } 
        }
    }
}