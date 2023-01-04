using HotelTaskNewYear.Models;
using HotelTaskNewYear.Services;
using System.Reflection.Metadata.Ecma335;
int Order;
int price;
int id;
RoomService Service = new RoomService();
while (true)
{
  
    
    Console.WriteLine("Welcome to our Miami Hotel Room Control Service.");
    Console.WriteLine("Here is your options:");
    Console.WriteLine("1-Add a new room.");
    Console.WriteLine("2-See All the rooms you added.");
    Console.WriteLine("3-Reserve the room.");
    Console.WriteLine("0-Exit the Room Control Service.");
    Console.Write("Give Your Order---");
    do
    {
        try
        {
            Order = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Wrong Order Please Try again.");

            Console.Write("Give your Order---");
            continue;


        }

    } while (true);

    switch (Order)
    {
        case 1:
            
            Console.Write("Enter the Room Price:");
            do
            {
                try
                {
                    price = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Price Please Try again.");

                    Console.Write("Give your Price:");
                    continue;


                }

            } while (true);

            Console.Clear();
            Service.AddRoom(price);

            break;
        case 2:
            Console.Clear();
            Service.GetAllRoom();

            break;
        case 3:
            Console.Write("Enter the Room Id to Reserve:");
            do
            {
                try
                {
                    id = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Id Please Try again.");

                    Console.Write("Give your Id:");
                    continue;


                }

            } while (true);

            Console.Clear();
            Service.RezervationRoom(id);
            break;
        case 0:
            return;
        default:
            Console.Clear();
            Console.WriteLine("There is no such order Try Again");
            continue;
    }
    

}




