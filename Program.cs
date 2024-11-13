using System.ComponentModel.Design;

namespace Assignment_2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                {
                Console.WriteLine("Please enter your bill sub-total:");
                string userInput = Console.ReadLine();

                if (decimal.TryParse(userInput, out decimal subTotal) && subTotal > 0)

                {

                    Console.WriteLine();
                    Console.WriteLine("Please choose a tip amount from the options below (1-5");
                    Console.WriteLine("1. 10%");
                    Console.WriteLine("2. 15%");
                    Console.WriteLine("3. 20%");
                    Console.WriteLine("4. 25%");
                    Console.WriteLine("5. Custom");
                    Console.WriteLine();

                    string tipChoice = Console.ReadLine();
                    decimal tipAmount = 0;

                    switch (tipChoice)

                    {
                        case "1":
                            tipAmount = subTotal * 0.10m;
                            break;

                        case "2":
                            tipAmount = subTotal * 0.15m;
                            break;

                        case "3":
                            tipAmount = subTotal * 0.20m;
                            break;

                        case "4":
                            tipAmount = subTotal * 0.25m;
                            break;

                        case "5":
                            Console.WriteLine("Enter your custom tip dollar amount");
                            string customTipInput = Console.ReadLine();

                            if (decimal.TryParse(customTipInput, out decimal tipDollars) && tipDollars >= 0)
                            {
                                tipAmount = tipDollars;
                            }

                            else
                            {
                                Console.WriteLine("Please enter a valid tip amount");
                                return;
                            }
                            break;


                    }

                    decimal totalAmount = subTotal + tipAmount;

                    Console.WriteLine();
                    Console.WriteLine($"Bill Sub-total: ${subTotal:F2}");
                    Console.WriteLine($"Tip Amount: ${tipAmount:F2}");
                    Console.WriteLine($"Total Amount not including tax: ${totalAmount:F2}");

                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter your bill sub-total.");
                }

            }
        }
    }
}
