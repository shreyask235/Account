// simulated change from teammate on GitHub

namespace Capstone_assignment;




class Program
{
    static void Main(string[] args)
    {
        // two different instances of account class have been created
        Account account1 = new Account(100, "Bob");
        Account account2 = new Account(100, "Mary");

        account1.show();
        if (account1.withdraw(150))
        {
            Console.WriteLine("The withdraw was successful");
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine("The withdraw was unsuccessful");
            Console.WriteLine("----------------------------");
        }
        account1.deposit(200);
        Console.WriteLine($"Deposited $200 to Bob");
        account1.show();
        if (account1.withdraw(150))
        {
            Console.WriteLine("The withdraw was successful");
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine("The withdraw was unsuccessful");
            Console.WriteLine("----------------------------");
        }
        account1.show();




        if (account1.transfer(50, account1))
        {
            Console.WriteLine("Transfered $50 to Bob");
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine("Transfer failed");
            Console.WriteLine("----------------------------");
        }
        account1.show();
        account2.show();
    }
}
