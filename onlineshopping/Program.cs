using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineshopping
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.register("venkat","1234","venkat@gmail.com","venkat@gmail.com","12332", "male");
            c1.display();
        }
    }
}
