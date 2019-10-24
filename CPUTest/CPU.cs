using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    public class CPU
    {
        private DataBus dataBus;
        int i = 0, j = 0;
        public double[] registers = new double[3]; // CPU registers
        public int[] addres = new int[3]; // CPU addreses 
        int comandCounter = 0; // Counter of comand

        public CPU(DataBus dataBus) // Getting of data from Data Bus
        {
            this.dataBus = dataBus;
        }
        public void GetCommand() // Getting the code of comand
        {
            Console.WriteLine("Я получил команду 1");
            DecodeComand(comandCounter);
            comandCounter++;
        }
        public DataBus GetDataBus() // Getting addres of numbers register to get it
        {
            return dataBus;
        }
        public void DecodeComand(int comandCounter) // Decoding of comand
        {
            if ( comandCounter==0 )
            {
                Console.WriteLine("Команда обработана. Опецация сумма");
                Console.WriteLine("Мне необходим адрес операнда");
            }
        }
        public double [] Reg( ) // Add number from Addres Bus to CPU register
        {
            if (i == registers.Length)
            {
                i = 0;
            }
            registers[i] = dataBus.Number();
            Adr();
            i++;
            return registers;
        }
        public int[] Adr() // Add addres of data in CPU registers
        {
            if (j == addres.Length)
            {
                j = 0;
            }
            addres[j] = j + 1;
            j++;
            return addres;
        }
        public double SetSummCPU(double sum) // Add result of summ to third register
        {
            return registers[2] = sum;
        }
        public double GetSum() // Getting of summ result
        {
            return registers[2];
        }
    }
}
