namespace ChainLoan
{
    public class Loan
    {
        public int Number { get; }
        public double Amount { get; }

        public Loan(int number, double amount) => (Number, Amount) = (number, amount);
    }
}
