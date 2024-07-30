using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_c_
{
    public class Delivery
    {
        public String address = "";
        public String name = "";
        public String item = "";

        public void delivery()
        {
            Console.WriteLine("For home delivery enter Yes or else press enter");
            var del = Console.ReadLine();
            if (del == "Yes")
            {
                Console.WriteLine("Please Enter Your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Please Enter Food item to deliver: ");
                item = Console.ReadLine();
                Console.WriteLine("Please Enter Your Address: ");
                name = Console.ReadLine();
                Console.WriteLine("Your order placed for \nName : {0} \nAddress : {1} \nFood Item : {2} ",name,address,item);

            }
            else
                Console.WriteLine("Thank you for visiting.");
        }

    }
}
