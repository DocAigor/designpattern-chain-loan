using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainLoan
{
    public abstract class Dipendenti : Approver
    {
        protected IEnumerable<Approver> _boss;
        public int MaxLoan { get; }

        public Dipendenti(IEnumerable<Approver> boss, int maxLoan) => ( _boss,MaxLoan) = (boss,maxLoan);
        

        public override void ProcessLoan(Loan loan)
        {
            if (loan.Amount < MaxLoan)
                Console.WriteLine($"{GetType().Name} approved request# {GetType().Name}");
            else
                _boss.Where(x => x.IsAvailable).FirstOrDefault()?.ProcessLoan(loan);
        }
    }
    
}
