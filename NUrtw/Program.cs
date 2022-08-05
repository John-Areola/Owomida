using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunMiLowoMiJo
{
    internal class Vehicles
    {
        public int Vehicle_Type()
        {
            Console.WriteLine("if Vehicle_Type is Okada enter 1");
            Console.WriteLine("if Vehicle_Type is Keke enter 2");
            Console.WriteLine("if Vehicle_Type is Korope enter 3");
            Console.WriteLine("if Vehicle_Type is Molue enter 4");
            string vehicleType = Console.ReadLine();
            switch (vehicleType)
            {
                case "1":
                    return 10;
                case "2":
                    return 20;
                case "3":
                    return 30;
                case "4":
                    return 40;
                default:
                    return 0;
            }
        }

        public int Trip()
        {
            Console.WriteLine("How many trips have you completed today?");
            int trip = Convert.ToInt32(Console.ReadLine());
            return trip;
        }

        public double MembershipRate()
        {
            Console.WriteLine("Are you a member? (yes/no)");
            string membership = Console.ReadLine().ToLower();
            if (membership == "yes")
            {
                double membershipRate = 0.7d;
                return membershipRate;
            }
            else if (membership == "no")
            {
                double membershipRate = 1d;
                return membershipRate;
            }
            else
            {
                return 0;
            }
            //if True membership
            //int membershipRate = Console.ReadLine(); 

        }

    }
}
