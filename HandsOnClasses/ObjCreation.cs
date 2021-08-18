using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class ObjCreation
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.custid = 12345;
            customer.custname = "mohith";
            customer.custcity = "Vij";
            Console.WriteLine("Customer id is:"+ customer.custid);
            Console.WriteLine("Customer name is:"+ customer.custname);
            Console.WriteLine("Customer city is:"+ customer.custcity);

        }
    }
}
