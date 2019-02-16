using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace ConsoleApp1
{
    class main
    {
        public static void Main(string[] args)
        {
            int iUserChoice = 0;
            int iLoopParam = 0;
            int iProgramParam = 0;
            Manage Manager = new Manage();
            Console.WriteLine("Hello, Welcome to Grad Assist!");
            Console.WriteLine("Please Create an Account or Log In...");

            do
            {
                do
                {
                    Console.WriteLine("Enter 1 to create an account");
                    Console.WriteLine("Enter 2 to log in");
                    Console.WriteLine("Enter 3 to exit");
                    Console.WriteLine("Please make your selection (1/2/3):");
                    iUserChoice = int.Parse(Console.ReadLine());
                    if (iUserChoice > 0 && iUserChoice < 4)
                    {
                        iLoopParam = 1;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 3...");
                        Console.Write("\n\r\n\r");
                    }
                } while (iLoopParam != 1);

                switch (iUserChoice)
                {
                    case 1: //Account Creation
                        string strEmail = "";
                        Console.WriteLine("Please enter your email: ");
                        strEmail = Console.ReadLine();

                        iLoopParam = 0;
                        do
                        {
                            string strPassword = "";
                            string strPasswordConfirm = "";

                            Console.WriteLine("Please enter a password: ");
                            strPassword = Console.ReadLine();
                            Console.WriteLine("Please confirm your password: ");
                            strPasswordConfirm = Console.ReadLine();

                            if (strPassword == strPasswordConfirm)
                            {
                                iLoopParam = 1;
                                Manager.CreateAccount(new User(strEmail, strPassword));
                            }
                            else
                            {
                                Console.WriteLine("Passwords do not match, please try again");
                            }

                        } while (iLoopParam != 1);


                        Console.WriteLine("Success!");

                        break;

                    case 2: //Log In

                        iLoopParam = 0;
                        do
                        {
                            string strPassword = "";
                            string strEmailAccess = "";
                            Console.WriteLine("Please enter your email: ");
                            strEmailAccess = Console.ReadLine();

                            if(strEmailAccess == "Quit")
                            {
                                break;
                            }
                            Console.WriteLine("Please enter your password: ");
                            strPassword = Console.ReadLine();

                            if (strPassword == "Quit")
                            {
                                break;
                            }

                            User Temp = new User(strEmailAccess, strPassword);
                            if (Manager.LogIn(Temp) != -1)
                            {
                                iLoopParam = 1;
                            }
                            else
                            {
                                Console.WriteLine("Either your email or password is incorrect, type \"Quit\" to quit (no quotes)");
                            }

                        } while (iLoopParam != 1);

                        Console.WriteLine("The login was successful, unfortunately, this the extent of the function of the project so far, please check back later!");

                        break;

                    case 3: //Exit
                        iProgramParam = 1;
                        break;
                } 
            } while (iProgramParam != 1); 

        }//end Main
    }//end main
}
