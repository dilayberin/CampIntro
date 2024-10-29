namespace OOP3
{
    class Program
    {
        static void Main(string[] args) 
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();    
            ICreditManager houseCreditManager = new HouseCreditManager();
        
            ApplyManager applyManager = new ApplyManager();
            //applyManager.Apply(personalFinanceCreditManager);

            List<ICreditManager>credits = new List<ICreditManager>(){ personalFinanceCreditManager , vehicleCreditManager };

            applyManager.CreditInformation(credits);

        }

    }
}
