using System.Collections.Generic;

namespace ChainLoan
{
    public class SubClark : Dipendenti
    {
        public SubClark(IEnumerable<Approver> boss, int maxLoan) : base(boss, maxLoan)
        {
        }
    }
}
