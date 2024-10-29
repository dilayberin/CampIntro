namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer ındividualCustomer1 = new IndividualCustomer();
            ındividualCustomer1.Id = 1;
            ındividualCustomer1.CustomerNum = "1234";
            ındividualCustomer1.CustomerName = "Dilay";
            ındividualCustomer1.CustomerSurname = "Akkan";
            ındividualCustomer1.IdNum= "1545";

            CoorporateCustomer coorporateCustomer1 = new CoorporateCustomer();
            coorporateCustomer1.Id = 2;
            coorporateCustomer1.CustomerNum= "2546";
            coorporateCustomer1.CompanyName = "dev.op";
            coorporateCustomer1.TaxNum = "15242551456";

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);





        }
    }
}
