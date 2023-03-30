using BancoABCHeranca.Entidades;
using System;

namespace BancoABCHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Diovana", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Sarah", 0.0, 500.0);

            //UPCASTING (implícito)
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Larah", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Eduardo", 0.0, 0.01);
            
            //UPCASTING (explícito)
            BusinessAccount bacc2 = (BusinessAccount)acc2;
            bacc2.Loan(100.0);
            //acc2.Loan(100.0);
            //BusinessAccount bacc3 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount bacc3 = (BusinessAccount)acc3;
                BusinessAccount bacc3 = acc3 as BusinessAccount;
                bacc3.Loan(100.0);
                Console.WriteLine("Loan was successful!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount bacc3 = (SavingsAccount)acc3;
                SavingsAccount bacc3 = acc3 as SavingsAccount;
                bacc3.UpdateBalance();
                Console.WriteLine("Update was successful!");
            }
        }
    }
}