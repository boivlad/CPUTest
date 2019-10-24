using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    public class ALU
    {
        double sum = 0;
        private CPU cpu; // Box of cpu data

        public ALU(CPU cpu) // Copy of CPU
        {
            this.cpu = cpu;
        }
        public double Summ() // Implementation of addition operation
        {
            sum = cpu.registers[0] + cpu.registers[1];
            return sum; 
        }
        public double SumReg() // Putting the result of operation into summ register
        {
            double sumreg = Summ();
            return sumreg;
        }
        public double BackNumber() // Return of result into CPU
        {
            cpu.GetDataBus().GetAddresBus().GetRAM().ramRegisters[0] = 0;
            cpu.GetDataBus().GetAddresBus().GetRAM().ramRegisters[1] = 0;
            return cpu.GetDataBus().GetAddresBus().GetRAM().ramRegisters[2] = SumReg();
        }
    }
}
