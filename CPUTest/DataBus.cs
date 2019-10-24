using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    public class DataBus
    {
        private AddresBus addresBus; // Box of addres bus

        public DataBus(AddresBus addresBus) // Copy of addres box
        {
            this.addresBus = addresBus;
        }
        public double Number() // Getting of number from ram register by addres from Addres Bus
        {
            
            int a = addresBus.AddresBusData();
            return addresBus.GetRAM().GetNumberByAddres(a);
        }
        public AddresBus GetAddresBus() // Method that tooks an addres from addres bus to import date from ram register to cpu register by it's addres
        {
            return addresBus;
        }
        public void GetIntBinaryNumber(double number) // Translation into binary form
        {
            int int_number = (int)number;
            int n = 1, i = 0;
            while ( int_number != 0 )
            {
                int binN = int_number % 2;
                int_number = int_number / 2;
                if ( int_number != 0)
                {
                    n++;
                    i++;
                }
                Console.Write(" | " + binN);
            }
        }
        public void GetDoubleBinaryNumber(double number) // Translation into binary form
        {
            double double_number = number - (int)number;
            int n = 1, i = 0;
            while (double_number != 0 && (int)number !=0)
            {
                int binN = (int)(double_number * 2);
                if (double_number != 0 && (int)number != 0)
                {
                    n++;
                    i++;
                }
                Console.Write(" | " + binN);
            }
        }
    }
}
