using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineshopping
{
    class customer
    {
        internal string name;
        internal string phno;
        internal string emailid;
       internal  string loginid;
        internal string password;
        internal string gender;


        internal void register(string name, string phno,string emailid,
            string loginid,string password,string gender)
            {
            this.name = name;
            this.phno = phno;
            this.emailid = emailid;
            this.loginid = loginid;
            this.password = password;
            this.gender = gender;
            }
        internal void display()
        {
            Console.WriteLine($"Name: {name} phnumber: {phno} " + $"password : {password} gender : {gender}");

        }
    }

}
