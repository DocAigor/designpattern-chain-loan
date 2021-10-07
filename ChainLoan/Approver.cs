namespace ChainLoan
{
    public abstract class Approver
    {
        public bool IsAvailable { get; set; }
        public abstract void ProcessLoan(Loan loan);
    }
}
