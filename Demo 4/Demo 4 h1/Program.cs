using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_h1
{


class Elevator
    {

        private int floor=1;

        public int Floor
        {
            get { return floor; }
            set
            {
                if(value >= 1 && value <=5)
                {
                    floor = value;
                    Console.WriteLine("Elevator is now in floor: "+floor);

                }
                else if(value < 1)
                {
                    Console.WriteLine("We dont have this kind of floor(too small(that what she said)) ");
                }
                else
                {
                    Console.WriteLine("We dont have this kind of floor(too big(that what he thought)) ");
                }

            }

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();


            while (true)
            {
                Console.WriteLine("Give me the floor you want to go(1 to 5)");
                elevator.Floor = int.Parse(Console.ReadLine());
            }


        }
    }
}
