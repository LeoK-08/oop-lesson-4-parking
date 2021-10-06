using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class Customer
    {
        public int hoursParked { get; set; }
        public string carRegistration { get; set; }
        public Customer(string _carRegistration, int _hoursParked)
        {
            Console.WriteLine("I am the customer");
            carRegistration = _carRegistration;
            hoursParked = _hoursParked;
        }
        public override string ToString()
        {
            return "I am the customer()";
        }
    }
}
