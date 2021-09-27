using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    class Bank_Account
    {
        private int Acno;
        public int useracno;
        protected string name;
        internal int deposit;
        protected internal char type;

        private void Create_account()
        {
            Console.Write("\nEnter the Account no:");
            useracno = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the account Holder:");
            name = Console.ReadLine();
            Console.Write("\nEnter type of the account (C/S):");
            type = char.Parse(Console.ReadLine());
            Console.Write("Enter the intial amount(>=500 for saving and >=1000 for current): ");
            deposit = int.Parse(Console.ReadLine());
            Console.Write("\n\n\nAccount Created:");
        }
        public void Createaccount()
        {
            Create_account();
        }
        protected void show_Account()
        {
            Console.WriteLine("\nAccount no. :", useracno);
            Console.WriteLine("Account Holder Name :", name);
            Console.WriteLine("type of Account:", type);
            Console.WriteLine("Balance amount :", deposit);
        }
        public void Show_Account()
        {
            show_Account();
        }
        internal void Modifyaccount()
        {
            Console.Write("\nAccount no.:", Acno);
            Console.Write("Modify Account Holder Name:");
            name = Console.ReadLine();
            Console.Write("Modify type of Account:");
            type = char.Parse(Console.ReadLine());
            Console.Write("Modify Balance amount:");
            deposit = int.Parse(Console.ReadLine());
        }
        public void Modify_account()
        {
            Modifyaccount();
        }
        public void Accountdep()
        {
            int x;
            Console.WriteLine("Enter the amount u want to deposit::");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }
        public void Accountdraw()
        {
            int x;
            Console.WriteLine("Enter the amount u want to withdraw::");
            x = int.Parse(Console.ReadLine());
            deposit -= x;
        }
        public void account_report()
        {
            Console.WriteLine("Acno:: \nName:: \nDeposit::\n", Acno, name, type, deposit);
        }
        public int retacno()
        {
            return Acno;
        }
        public int retdeposit()
        {
            return deposit;
        }
        public char rettype()
        {
            return type;
        }
    }

}
