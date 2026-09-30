namespace OOPExercisesOnsdag
{
    public class BankAccount
    {
        // Attributer
        // Ett privat fält balance
        private decimal balance;

        // Metoder
        // Metoder: Deposit (amount) och 
        // Withdraw (amount) som uppdaterar saldot på ett säkert sätt.
        public void Deposit(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Balance has been updated to : {balance}");
        }

        public void Withdraw(decimal amount)
        {
            balance = balance - amount;
            Console.WriteLine($"Balance has been updated to : {balance}");
        }

        public void GetBalance()
        {
            Console.WriteLine($"Current balance is : {balance}");
        }
    }
}