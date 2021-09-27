using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    class Program: Bank_Account
    {
        static void Main(string[] args)
        {
            Bank_Account bank = new Bank_Account();
            int num, n;
            structData show = new structData();
            show.load();
            show.showintro();


            do
            {
                Console.WriteLine("\n\n*****Main Menu*****");
                Console.WriteLine("\n\n 01.NEW ACCOUNT");
                Console.WriteLine("\n\n 02.DEPOSIT AMOUNT");
                Console.WriteLine("\n\n 03.WITHDRAW AMOUNT");
                Console.WriteLine("\n\n 04.BALANCE ENQUIRY");
                Console.WriteLine("\n\n 05.ALL ACCOUNT HOLDER LIST");
                Console.WriteLine("\n\n 06.MODIFY AN ACCOUNT");
                Console.WriteLine("\n\n 07.EXIT");
                Console.WriteLine("\n\tSelect your Option(1-7)");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            show.load();
                            bank.Createaccount();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            show.load();
                            bank.Accountdep();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            show.load();
                            bank.Accountdraw();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            show.load();
                            bank.account_report();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            show.load();
                            bank.Show_Account();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            show.load();
                            Console.Write("\n\n\tEnter the account No.: ");
                            num = int.Parse(Console.ReadLine());
                            bank.Modifyaccount();
                            break;
                        }

                }
            } while (n != 7);
        }
    }
}
