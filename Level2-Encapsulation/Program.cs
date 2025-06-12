// "Encapsulation is like putting your logic in a black box—users can use it, but can’t mess with the internal stuff."
// 📜 Concept:
// Keep variables private
// Give controlled access via public methods or properties
// This keeps data safe and consistent

namespace Level2_Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ₹{amount}. New balance: ₹{balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ₹{amount}. Remaining balance: ₹{balance}");
            }
            else
            {
                Console.WriteLine("Invalid or insufficient funds for withdrawal.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current balance: ₹{balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            myAccount.Deposit(1000);
            myAccount.Withdraw(200);
            myAccount.Withdraw(10000); // Should fail
            myAccount.Deposit(-50);    // Should fail
            myAccount.ShowBalance();
        }
    }
}
