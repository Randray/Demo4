using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotitehtävä_4__Demo_4_h5_
{

    class ONOFF
    {
        private int onoff;

        public int OnOff
        {
            get { return onoff; }
            set {
                if (value == 1)
                { Console.WriteLine("Radio is ON"); }

                else { Console.WriteLine("You didnt put the radio on "); Environment.Exit(0);  }


                }

        }



    }



    class Volume
    {
        private int volume = 0;


        public int Volumeup
        {
            get { return volume; }
            set { if (value > 0 && value<=9)
                {
                    volume = value;
                    Console.WriteLine("Radios volume is " + volume);
                }
            else if (value <= 0)
                {
                    Console.WriteLine("Radio is muted.");
                }
                else { Console.WriteLine("Can't go higher the this"); }
            }
        }

    }



    class Taajuus
    {
        private double frequency = 2000.0;


        public double Frequency
        {

            get { return frequency; }
            set
            {
                if (value >= 20000.0 && value <= 2600.0)
                {
                    frequency = value;
                    Console.WriteLine("Radio frequency is " + frequency);
                }
                else
                {
                    Console.WriteLine("Radio doesn't know this frequency");
                }
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ONOFF on = new ONOFF();
            Volume vl = new Volume();
            Taajuus tj = new Taajuus();
            int choose = 3;


            Console.WriteLine("Do you want to put the radio on");
            Console.WriteLine("1. yes");
            Console.WriteLine("2 no");
            on.OnOff = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("What you want to do?");
                Console.WriteLine("1. Volume settings");
                Console.WriteLine("2. Frequency");
                Console.WriteLine("3. Turn off");

                choose = int.Parse(Console.ReadLine());



                if (choose == 1)
                {
                    Console.WriteLine("How high you want the volume to be (0-9)");
                    vl.Volumeup = int.Parse(Console.ReadLine());

                }

                else if (choose == 2)
                {
                    Console.WriteLine("What frequency you want (2000,0-2600,0)");
                    tj.Frequency = double.Parse( Console.ReadLine());

                }

                else if (choose == 3) on.OnOff = 3;

                else Console.WriteLine("Invalid command!!!! ");


            } while (true);





        }
    }
}
