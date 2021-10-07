using System;

namespace ChainLoan
{
    public class President : Boss
    {
        public override void ProcessLoan(Loan loan) => Console.WriteLine($"{GetType().Name} approved request# {loan.Number}");
    }
}
