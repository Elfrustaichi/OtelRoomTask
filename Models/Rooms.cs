using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelTaskNewYear.Models
{
    internal class Rooms:Otel
    {
        private static int _id;
        private static int _no=101;
        private int _price;
        public  bool _isrezerved=false;
        public int RoomId;
        public int RoomNo;
        public bool isrezerved { 
            get 
            { 
                return _isrezerved;
            } 
            set 
            {
                _isrezerved = value;
            } 
        }




        public int Price { get { return _price; } set 
            {
                while (true)
                {
                    if (value > 100 && 250 > value)
                    {
                        _price = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Price must be between 100-250.");
                        Console.Write("Enter the Price:");
                        do
                        {
                            try
                            {
                                value = int.Parse(Console.ReadLine());
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
                        Console.Clear() ;
                        continue;
                    }

                   


                   


                }






            } 
        }


        public Rooms() 
        {
            if (_no%10==0)
            {
                _no = _no - 9 + 100;

            }
            _id++;
            RoomId = _id;

            _no++;
            RoomNo= _no;
        
        }






    }
}
