class Account
{
    float amount;
    string accountUser;


    public Account(float amount, string accountUser)
    {
        this.amount = amount;
        this.accountUser = accountUser;
    }


    public void show()
    {
        Console.WriteLine("Account Details:");
        Console.WriteLine($"User: {accountUser} Balance: {amount}");
        Console.WriteLine("---------------------------------------");
    }


    public void deposit(float amount)
    {
        this.amount += amount;
    }


    public float getBalance()
    {
        return amount;
    }


    public bool withdraw(float amount)
    {
        if (this.amount >= amount)
        {
            this.amount -= amount;
            return true;
        }
        return false;
    }


    public bool transfer(float amount, Account other)
    {
        if (this.amount >= amount)
        {
            other.amount += amount;
            return true;
        }
        return false;
    }
}