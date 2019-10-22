using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccounts john = new Premium();
            john.loans = 1000;
            john.balance = 5000;

            Console.WriteLine(john.GetBalance());

            IAccounts mary = new Premium();
            mary.pin =1234;
        }
    }
    interface IAccounts
    {
          string kRA { get; set; }
          int pin { get; set; }     
          int balance { get; set; }
          int loans { get; set; }
          int accNo { get; set; }
          int GetBalance();

    }

    class Premium : IAccounts,ITrial
    {

         public string kRA { get; set; }
         public int pin { get; set; }     
         public int balance { get; set; }
         public int accNo { get; set; }
         public int loans { get; set; }
         public int GetBalance()
         {
           int x = balance - loans;
           return x;

         }

    }

     class Local : IAccounts
    {

         public string kRA { get; set; }
         public int pin { get; set; }     
         public int balance { get; set; }
         public int accNo { get; set; }
         public int loans { get; set; }
         public int GetBalance()
         {
           int x = balance - loans;
           return x;

         }

    }
       interface ITrial
    {
          string kRA { get; set; }
          int pin { get; set; }     
          int balance { get; set; }
          int loans { get; set; }
          int accNo { get; set; }
          int GetBalance();

    }
}
