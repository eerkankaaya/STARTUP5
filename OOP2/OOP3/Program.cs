using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditManager neededCreditManager = new NeededCreditManager();
            ICreditManager carCredit_Manager = new CarCredit_Manager();
            ICreditManager buildingCredit = new BuildingCredit();
            ILoggerService databaseLoggerService = new DatabaseLoggerService;
            ILoggerService fileLoggerService = new DatabaseLoggerService.FileLoggerService;
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(buildingCredit,new DatabaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { neededCreditManager,carCredit_Manager};

            //applicationManager.CreditPreliminaryInformation(credits);


        }
    }
}
