using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
          IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Test";
            customer1.LastName = "tessst";
            customer1.TcNo = "1234533";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.CustomerNo = "12345";
            customer2.Id = 3;
            customer2.NameOfCompany = "Test2";
            customer2.TaxNo = "12345";


            Customer customer3 = new IndividualCustomer();

            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            CustomerManager.Add(customer1);
            CustomerManager.Add(customer2);


        
        
        
        }
    }
}
