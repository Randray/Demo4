using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_h3
{
    class Program
    {
        static void Main(string[] args)
        {
            EMployee kirsi = new EMployee("Kirsi Kernel", "TEacher", 4200.50f);
            Boss jussi = new Boss("jussi Jurkka", "Head of Institute", 9000.00f,  5000.00f,"Audi");


            kirsi.Salary += 2000.0f;
            jussi.Salary -= 1000.0f;
            jussi.Bonus = 4000.0f;

            ShowSomeWokr(kirsi);
            ShowSomeWokr(jussi);



        }


        static void ShowSomeWokr(EMployee empl)
        {

            empl.Work();



        }


    }
}
