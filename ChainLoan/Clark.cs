using System.Collections.Generic;

namespace ChainLoan
{
    public class Clark : Dipendenti
    {
        public Clark(IEnumerable<Approver> boss, int maxLoan) : base(boss,maxLoan)
        {
        }
    }
}
