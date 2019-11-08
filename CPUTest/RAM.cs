using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    public class RAM
    {
        int i = 0, j = 0;
        public double[] ramRegisters = new double[5]; // RAM registers
        public int[] ramAddres = new int[5]; // RAM addreses 
        
        
        public double [] AddNumber(double number) // Add number into register
        {
            if (i == ramRegisters.Length)
            {
                i = 0;
            }
            ramRegisters[i] = number;
            RAMAdr();
            i++;
            return ramRegisters;
        }
        public int[] RAMAdr() // Add an addres of numbers register
        {
            if (j == ramAddres.Length)
            {
                j = 0;
            }
            ramAddres[j] = j;
            j++;
            return ramAddres;
        }
        public int GetElementAddres() // Gettint of number addres
        {
            return ramAddres[0];
        }
        public void AddresChange() // Supporting method to change addres of register to get the second number
        {
            double temp = ramAddres[0];
            for (int a= 1; a<ramAddres.Length; a++)
            {
                ramAddres[a - 1] = ramAddres[a];
            }
            ramAddres[ramAddres.Length - 1] = 0;
        }
        public double GetNumberByAddres(int address) // Getting of number inside the register by it's addres
        {
            return ramRegisters[address];
        }
        public void ShowMass() // Output of registers and it's addreses
        {
            Console.WriteLine("Registers");
            for (int a=0; a<ramRegisters.Length; a++)
            {
                Console.Write(" " + ramRegisters[a]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Addres");
            for (int a = 0; a < ramAddres.Length; a++)
            {
                Console.Write(" "+ ramAddres[a]);
            }
        }
    }
}
