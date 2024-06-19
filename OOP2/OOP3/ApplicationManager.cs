using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        public void DoApplication(ICreditManager creditManager ,ILoggerService loggerService)
        {

            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
