using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_c_
{
    public class Reservation
    {
        public int table_no = 02;
        public String costumer_name = "Husnain";
        public DateTime reserve_datetime = DateTime.Now;

        public void check_reserve()
        {
            Console.WriteLine("Enter your name : ");
            var name = Console.ReadLine();
            if (name == costumer_name)
            {
                Console.WriteLine("You have reservation on table no : {0}. Please have a seat. ", table_no);
                Console.WriteLine("Please confirm that your reservation time is {0}", reserve_datetime);

            }
            else
                Console.WriteLine("No reservation for You");
        }
        public void make_reserve()
        {
            Console.WriteLine("Enter your name : ");
            var name = Console.ReadLine();
            if(name !="")
                Console.WriteLine("Your Reservation has been made with name : "+ name);
        }
    }
}
