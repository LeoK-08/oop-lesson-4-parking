using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();
        public CarParkCharge carparkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the CarPark");
        }
        public override string ToString()
        {
            return "I am the CarPark()";
        }
        public void CalculateCharges()
        {

            foreach (Customer currentCustomer in listOfCustomers)
            {
                int calculatedCharge = carparkCharge.CalculateCharge(currentCustomer.hoursParked);
                Console.WriteLine($"Calculating Charges for customer: cost is {calculatedCharge} for registration {currentCustomer.carRegistration}");

            }

        }

    }
}
