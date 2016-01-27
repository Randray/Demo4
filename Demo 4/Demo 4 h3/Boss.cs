using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_h3
{
    class Boss:EMployee
    {
        public string Car { get; set; }
        public float Bonus { get; set; }

        public Boss(string name, string profession, float salary,float bonus,string car)
            :base(name,profession,salary)
        {

            Car = car;
            Bonus = bonus;



        }
        public  void Work()
        {
            Console.WriteLine("Working. Did work previosly. No need anymore. ");


        }


    }
}
