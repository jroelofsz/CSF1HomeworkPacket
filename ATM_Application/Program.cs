using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //console title and inital promt
            Console.Title = "-===ATM===-";
            Console.WriteLine("Welcome to the Bank of Missouri ATM");

            int moneyInAccount = 0;
            int attempts = 0;
            int pinAttempts = 0;

            bool mainRepeat = true;
            do
            {
                //Declaresa and initializes the users account number
                int userActNbr = 123456;
                
                Console.WriteLine("What is your account number? ");
                int userActNbrInput = int.Parse(Console.ReadLine());
                if (userActNbrInput == userActNbr)
                {
                    Console.Clear();
                    int userPin = 1234;
                    Console.WriteLine("What is your account pin? ");
                    int userPinInput = int.Parse(Console.ReadLine());
                    if (userPin == userPinInput)
                    {
                        Console.Clear();
                        bool actRepeat = true;
                        do
                        {
                            Console.WriteLine("Bank Of Missouri ATM");
                            Console.WriteLine("D) DEPOSIT\nW) WITHDRAWL\nT) TRANSFER\nB) BALANCE\nE) EXIT");
                            string userMenuInput = Console.ReadLine().ToUpper();
                            Console.Clear();
                            //Processes user input through switch case which gives the menu functionality
                            switch (userMenuInput)
                            {
                                case "D":
                                case "DEPOSIT":
                                    Console.WriteLine("How much would you like to deposit? ");
                                    int amtToAdd = int.Parse(Console.ReadLine());
                                    moneyInAccount += amtToAdd;
                                    Console.WriteLine($"You added {amtToAdd:c} to account number 123456.");
                                    break;
                                case "W":
                                case "WITHDRAWL":
                                    Console.WriteLine("How much would you like to withdrawl? ");
                                    int amtToSub = int.Parse(Console.ReadLine());
                                    moneyInAccount -= amtToSub;
                                    Console.WriteLine($"You withdrew {amtToSub:c} from account number 123456.");
                                    break;
                                case "T":
                                case "TRANSFER":
                                    Console.WriteLine("What account number would you like to transfer to?");
                                    int transferActNbr = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How much would you like to transfer? ");
                                    int transferAmt = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"You transfered {transferAmt:c} from account number 123456 to account number {transferActNbr}.");
                                    moneyInAccount -= transferAmt;
                                    break;
                                case "B":
                                case "BALANCE":
                                    Console.WriteLine($"Account number 123456 has a balance of {moneyInAccount:c}");
                                    break;
                                case "E":
                                case "EXIT":
                                    Console.WriteLine("Thank you for your business! We can't wait to see you again.");
                                    actRepeat = false;
                                    mainRepeat = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (actRepeat);
                    }
                    else if (userPin != userPinInput)
                    {
                        Console.WriteLine($"Invalid pin number. Please try again. You have {2 - pinAttempts} attempts left.");
                        pinAttempts++;
                        if (pinAttempts >= 3)
                        {
                            Console.WriteLine("You have locked out this account. Please try again later.");
                            break;
                        }
                    }
                }
                else if (userActNbr != userActNbrInput)
                { 
                    Console.WriteLine($"Invalid account number. Please try again. You have {2 - attempts} attempts left.");
                    attempts++;
                    if (attempts == 3)
                    {
                        Console.WriteLine("You have locked out this account. Please try again later.");
                        mainRepeat = false; 
                    }
                }
            } while (mainRepeat);

        }
    }
}
