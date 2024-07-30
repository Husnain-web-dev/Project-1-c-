using Project_1_c_;

Console.WriteLine("********************************************\n");
Console.WriteLine("     : WELCOME TO DELIGHT RESTAURANT :  \n  ");
Console.WriteLine("********************************************\n\n\n");

Console.WriteLine("Enter the number of the field you want to consult");
Console.WriteLine("1.Reservation \n2.Menu \n3.Delivery \n4.Complaints ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num <= 4 )
{
    switch (num)
    {
        case 1: {
                bool reserve = true;
                while (reserve)
                {
                    var client = new Reservation();
                    Console.WriteLine("Do you have any reservation ? Enter 1 for 'YES' and 0 for 'No' ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {

                        client.check_reserve();
                        reserve = false;
                    }
                    else
                    {
                        Console.WriteLine("Please make your reservation ");
                        client.make_reserve();
                    }
                }
            }
            break;
            case 2: {
                var order = new Menu();
                order.menu();
            }
            break;
            case 3: {
                var deliver = new Delivery();
                deliver.delivery();
            }
            break;
            case 4: {
                Console.WriteLine("Do you want to register a complaint ? ");
                var comp = Console.ReadLine();
                if(comp !="")
                    Console.WriteLine("Your complaint has been registered .");
            } 
            break;
    }
}
else
    Console.WriteLine("Invalid Input");

//var restaurant = new Menu();
//restaurant.menu();