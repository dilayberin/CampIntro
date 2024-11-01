﻿namespace OOP3
{
    class Program
    {
        static void Main(string[] args) 
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();    
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager tradesmanCreditManager=new TradesmanCreditManager();

            ILoggerService databaseLoggerService =new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();

            //List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(),new FileLoggerService() };



            ApplyManager applyManager = new ApplyManager();

            applyManager.Apply(tradesmanCreditManager, 
                new List<ILoggerService> {new DatabaseLoggerService() , new SmsLoggerService()} );

            List<ICreditManager>credits = new List<ICreditManager>(){ personalFinanceCreditManager , vehicleCreditManager };

            //applyManager.CreditInformation(credits);

        }

    }
}
