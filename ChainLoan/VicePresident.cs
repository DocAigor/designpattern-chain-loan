using System.Collections.Generic;


namespace ChainLoan
{
    public class VicePresident : Dipendenti
    {
        public VicePresident(IEnumerable<Approver> boss,int maxLoan) : base(boss,maxLoan)
        {
        }
    }
}
