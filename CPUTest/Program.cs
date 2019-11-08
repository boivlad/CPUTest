using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RAM ram = new RAM();
            AddresBus addresBus = new AddresBus(ram);
            DataBus dataBus = new DataBus(addresBus);
            CPU cPU = new CPU(dataBus);
            ALU aLU = new ALU(cPU);
            double element;
            Console.WriteLine("Добро пожаловать в эмулятор работы ЦП по сложению двух чисел. Далее эмуляция работы всех компонентов будет следующая: процессор - синий, шина данных - красная, шина адреса - желтая, АЛУ - зеленая, оперативная память - фиолетовая, весь вспомогательный функционал - белый. Введите входные данные в соответствии с требованиями");

            Console.WriteLine();
            for (int i =1 ; i < 3; i++ )
            {
                Console.Write("Введите {0} операнд в десятичном виде: ", i);
                element = double.Parse(Console.ReadLine());
                ram.AddNumber(element);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // RAM work
            Console.WriteLine("Ваши данные хранятся в Оперативной памяти следующим образом ");
            ram.ShowMass();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            cPU.GetCommand();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Addres Bus work 
            Console.Write(" Адрес операнда:  " + addresBus.AddresBusData());
            cPU.Reg();
            ram.AddresChange();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write(" На шину данных поступило и передается " + dataBus.Number() + " : "); 
            dataBus.GetIntBinaryNumber(dataBus.Number());
            //dataBus.ShowBus();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Addres Bus work 
            Console.Write(" Адрес операнда: " + addresBus.AddresBusData());
            cPU.Reg();
            ram.AddresChange();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write(" На шину данных поступило и передается " + dataBus.Number() + " : "); 
            dataBus.GetIntBinaryNumber(dataBus.Number());
            //dataBus.ShowBus();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Нормализация чисел");
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Числа из регистров процессора извлекаются в АЛУ");

            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;// ALU work
            Console.Write(" Сумма равна АЛУ " + aLU.Summ());
            cPU.SetSummCPU(aLU.Summ());
            cPU.Reg();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            double getSum = cPU.GetSum();
            Console.Write(" Сумма в регистре процессора " + getSum);
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write(" На шину данных поступило и передается " + getSum + " : ");
            dataBus.GetIntBinaryNumber(getSum);
            //dataBus.ShowBus();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // RAM work
            Console.Write(" В оперативную память поступил результат суммы " + getSum);
            Console.WriteLine();

            
            Console.ReadKey();
        }
    }
}
