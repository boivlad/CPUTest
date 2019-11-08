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
        //List<int> bus = new List<int> { 0, 0, 0, 0 };
        //int num = 0;
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
        /*public void GetIntBinaryNumber(double number) // Translation into binary form
        {
            int i = 0;
            int int_number = (int)number;
            if (int_number >= 0)
            {
                bus[2] = 0;
                while (int_number != 0)
                {
                    bus.Add(int_number % 2);
                    int_number = int_number / 2;
                    if (int_number != 0)
                    {
                        i++;
                    }
                }
                num = bus.Count();
            }
            if (int_number < 0)
            {
                bus[2] = 1;
                while (int_number != 0)
                {
                    bus.Add(int_number % 2);
                    int_number = int_number / 2;
                    if (int_number != 0)
                    {
                        i++;
                    }
                    if (bus[i] == -1)
                    {
                        bus[i] = 0;
                    }
                    if (bus[i] == 0)
                    {
                        bus[i] = 1;
                    }
                }
                num = bus.Count();
            }
            
        }*/
        public void GetIntBinaryNumber(double number) // Translation into binary form
        {
            int int_number = (int)number;
            int n = 1, i = 0;
            if (int_number >= 0)
            {
                while (int_number != 0)
                {
                    int binN = int_number % 2;
                    int_number = int_number / 2;
                    if (int_number != 0)
                    {
                        n++;
                        i++;
                    }
                    Console.Write(" | " + binN);

                }
            }
            if (int_number < 0)
            {
                Console.Write(" 1 | ");
                while (int_number != 0)
                {
                    int binN = int_number % 2;
                    int_number = int_number / 2;
                    if (int_number != 0)
                    {
                        i++;
                    }
                    if (binN == -1)
                    {
                        binN = 0;
                    }
                    if (binN == 0)
                    {
                        binN = 1;
                    }
                    Console.Write(" | " + binN);
                }
            }
        }
        /*public void ShowBus() //Show of data on bus
        {
            if (bus.Count > 16)
            {
                for(int p = 0; p < (int)(bus.Count / 16); p++)
                {

                }
            }
            else
            {
                for (int j = 4; j <= num; j++)
                {
                    Console.Write(" {0} | {1} | {2} | {3} |  {4} |", 1, 0, bus[2], 0);
                    Console.Write(" | "+bus[j]);
                }
                for (int j = num; j <= bus.Count; j++)
                {
                    Console.Write(" {0} | {1} | {2} | {3} |  {4} |", 0, 1, bus[2], 0);
                    Console.Write(" | " + bus[j]);
                }
            }
        }*/
        /*public void GetDoubleBinaryNumber(double number) // Translation into binary form
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
        }*/
    }
}
