using System;
using System.Collections.Generic;
using System.Text;

namespace WestminsterCafe
{
    class Customer
    {
        public string name;
        public string email;
        public string gender;
        public DateTime timeVisited;
        public int age;

        public void orderFood()
        {
            Console.WriteLine("Ordering food");
        }

        public void makeReservation()
        {
            Console.WriteLine("Making reservation");
        }
    }
}
