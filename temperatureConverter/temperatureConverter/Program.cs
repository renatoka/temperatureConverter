using System;

namespace temperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple temperature converter.");
            Console.WriteLine("Starting...");
            //System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Write(@" 
[0] Celsius converter
[1] Kelvin converter
[2] Fahrenheit converter" + System.Environment.NewLine + Environment.NewLine);

            Console.Write("Please pick a number: ");
            int userPick = int.Parse(Console.ReadLine());
            bool returnCheck = false;
            Console.Clear();

            do
            {
                if (userPick == 0)
                {    
                    userPick = 69;
                    Console.Write(@"
[A] Celsius to Kelvin
[B] Celsius to Fahrenheit" + Environment.NewLine + Environment.NewLine);

                    Console.Write("Please pick a letter: ");
                    string nextMenu = Console.ReadLine();
                    Console.Clear();
                    if(nextMenu == "A")
                    {
                        userPick = 69;
                        double tempKel;
                        double tempCel;

                        Console.Write("Please enter a number in Celsius: ");
                        tempCel = double.Parse(Console.ReadLine());
                        tempKel = tempCel + 273.15f;
                        Math.Round(tempKel, 2);
                        Console.WriteLine($"{tempCel} C is equal to {tempKel} K." + Environment.NewLine);
                    }

                    if(nextMenu == "B")
                    {
                        userPick = 420;
                        double tempCel;
                        double tempF;

                        Console.Write("Please enter a number in Celsius: ");
                        tempCel = double.Parse(Console.ReadLine());
                        tempF = tempCel * (9 / 5f) + 32;
                        Math.Round(tempF, 2);
                        Console.WriteLine($"{tempCel} C is equal to {tempF} F.");
                    }
                }
                else if(userPick == 1)
                {
                    Console.Write(@"
[A] Kelvin to Celsius
[B] Kelvin to Fahrenheit" + Environment.NewLine + Environment.NewLine);
                    Console.Write("Please pick a letter: ");
                    string nextMenu = Console.ReadLine();
                    Console.Clear();
                    if (nextMenu == "A")
                    {
                        userPick = 1337;
                        double tempCel;
                        double tempKel;
                        Console.Write("Please enter a number in Kelvin: ");
                        tempKel = int.Parse(Console.ReadLine());
                        tempCel = tempKel - 273.15f;
                        Console.WriteLine($"{tempKel} K is equal to {tempCel} C.");
                    }
                    else if (nextMenu == "B")
                    {
                        userPick = 6969;
                        double tempKel;
                        double tempFah;
                        Console.Write("Please enter a number in Kelvin: ");
                        tempKel = int.Parse(Console.ReadLine());
                        tempFah = tempKel * (9 / 5f) - 459.67f;
                        Console.WriteLine($"{tempKel} K is equal to {tempFah} F.");
                    }   
                }
                else if (userPick == 2)
                {
                    Console.Write(@"
[A] Fahrenheit to Celsius
[B] Fahrenheit to Kelvin" + Environment.NewLine + Environment.NewLine);
                    Console.Write("Please pick a letter: ");
                    string nextMenu = Console.ReadLine();
                    Console.Clear();
                    if (nextMenu == "A")
                    {
                        userPick = 1234;
                        double tempFah;
                        double tempCel;
                        Console.Write("Please enter a number in Fahrenheit: ");
                        tempFah = int.Parse(Console.ReadLine());
                        tempCel = (tempFah - 32) * 5 / 9f;
                        Console.WriteLine($"{tempFah} F is equal to {tempCel} C.");
                    }

                    if(nextMenu == "B")
                    {
                        userPick = 1232;
                        double tempFah;
                        double tempKel;
                        Console.Write("Please enter a number in Fahrenheit: ");
                        tempFah = int.Parse(Console.ReadLine());
                        tempKel = (tempFah + 459.67f) * 5 / 9f;
                        Console.WriteLine($"{tempFah} F is equal to {tempKel} K.");
                    }
                }
            } while (returnCheck == false);
            
        }
    }
}
    