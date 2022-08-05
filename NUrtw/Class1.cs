namespace FunMiLowoMiJo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicleCode = new Vehicles();
            int totalAmount = 0;
            for (int i = 0; i < 5; i++)
            {
                int vehicleFee = vehicleCode.Vehicle_Type();
                int trip = vehicleCode.Trip();
                double membershipRate = vehicleCode.MembershipRate();

                double amount = vehicleFee * trip * membershipRate;
                int amountInt = Convert.ToInt32(amount);
                totalAmount = totalAmount + amountInt;
                Console.WriteLine("FUN MI NI " + amountInt + ". fun mi lo wo mi joor \n");
            }
            Console.WriteLine("The total amount is " + totalAmount);

        }
    }
}