using HotelTaskNewYear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTaskNewYear.Services
{
    internal class RoomService : IRoomService
    {
        Otel Otel = new Otel();

        public void AddRoom(int price)
        {
            
            Rooms Room = new Rooms();
            Room.Price=price;
            Array.Resize(ref Otel.Rooms, Otel.Rooms.Length + 1);
            Otel.Rooms[Otel.Rooms.Length - 1] = Room;

        }

        public void GetAllRoom()
        {
            for (int i = 0; i < Otel.Rooms.Length; i++)
            {
                Console.WriteLine($"Id:{ Otel.Rooms[i].RoomId} Room No:{Otel.Rooms[i].RoomNo} Room Price:{Otel.Rooms[i].Price} Rezervation Status:{Otel.Rooms[i].isrezerved} ");

            }
           
        }

        public void RezervationRoom(int id)
        {
           

                for (int i = 0; i < Otel.Rooms.Length; i++)
                {
                    if (Otel.Rooms[i].RoomId == id)
                    {
                    Console.Clear();
                        if  (Otel.Rooms[i].isrezerved == false)
                        {
                            Otel.Rooms[i].isrezerved = true;
                        Console.WriteLine($"You Have successfuly reserved room that has this id {id}");
                        break;
                        
                            
                        }
                        else
                        {

                        int Order;
                            Console.Clear();
                            Console.WriteLine("This Room Already reserved.");
                            Console.WriteLine("If you want to delete rezervation press 0");
                            Console.WriteLine("Press any number to just continue ");
                            Console.Write("Give Order:");
                       
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
                                Console.WriteLine("Wrong Order Please Try again.Please click Number.");

                                Console.Write("Give your Order:");
                                continue;


                            }

                        } while (true);
                        if (Order==0)

                        {
                            Console.Clear();
                            Otel.Rooms[i].isrezerved=false;
                            Console.WriteLine($"You have deleted rezervation that has this id {id}");
                            break;

                        }
                       


                        Console.Clear();   
                        break;
                        }

                    
                    }
                     else
                     {
                       Console.WriteLine("There is no such room.");
                     }
                    
                   
                



                }
            
            
            

            

           

        }
    }
}
