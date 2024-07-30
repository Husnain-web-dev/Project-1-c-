using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_c_
{
    public class Menu
    {
       public int table_no;
       public String menu_items ="1.Chicken Karhai \n2.Chicken Steak \n3.Lasania \n4.Seekh Kabab(6pcs) \n5.Mix Sabzi \n6.Beef Pulao";

        public void menu()
        {
            Console.WriteLine(menu_items);
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0&&n<7)
            {
                Console.WriteLine("Your Order has been placed.\nPlease visit the counter to pay your bill and wait for few minutes \n");
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Your bill is 850rs");
                        break;
                    case 2:
                        Console.WriteLine("Your bill is 1050rs");
                        break;
                    case 3:
                        Console.WriteLine("Your bill is 599rs");
                        break;
                    case 4:
                        Console.WriteLine("Your bill is 380rs");
                        break;
                    case 5:
                        Console.WriteLine("Your bill is 270rs");
                        break;
                    case 6:
                        Console.WriteLine("Your bill is 420rs");
                        break;
                }
            }
        }
    }

 
}
