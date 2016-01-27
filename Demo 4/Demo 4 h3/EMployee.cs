using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_h3
{
    class EMployee
    {
        private float salary;
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary
        {
            get { return salary; }
            set { if (value >= 0.0f) salary = value; else salary = 0.0f; }
        }

        public EMployee (string name, string profession,float salary  )
        {
            Name = name;
            Profession = profession;
            Salary = salary;

        }

        public void Work()
        {
            Console.WriteLine("Working. Too much. Will die too young or fall in to debersion ");


        }

    }
}
