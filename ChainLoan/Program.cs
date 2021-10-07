using System;
using System.Collections.Generic;

namespace ChainLoan
{
    class MainApp
    {
        static void Main()
        {
            var president1 = new President() { IsAvailable = false };
            var president2 = new President() { IsAvailable = true };
            var vice1 = new VicePresident(new List<Approver> { president1, president2 },25000) { IsAvailable = true };
            var clark = new Clark(new List<Approver> { vice1 },10000) { IsAvailable = true };
            var subClarck = new SubClark(new List<Approver> { clark }, 5000) { IsAvailable = true };

            var loan = new Loan(1, 350.00);
            subClarck.ProcessLoan(loan);
            
            loan = new Loan(12, 500.10);
            subClarck.ProcessLoan(loan);
            
            loan = new Loan(2, 24000.10);
            subClarck.ProcessLoan(loan);

            loan = new Loan(3, 122100.00);
            subClarck.ProcessLoan(loan);

            Console.ReadKey();
        }
    }

}
