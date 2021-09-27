using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    class structData
    {
        private void intro()
        {
            Console.WriteLine("\n\n\n BANK");
            Console.WriteLine("\n\n\n MANAGEMENT");
            Console.WriteLine("\n\n\n SYSTEM");
        }
        public void showintro()
        {
            intro();
        }
        public void load()
        {
            Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
