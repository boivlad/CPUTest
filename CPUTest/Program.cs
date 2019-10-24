using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    //lab work 1
    //student Daria Ezerovich
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
            Console.Write("Введите первый операнд в десятичном виде: ");
            element = double.Parse(Console.ReadLine());
            ram.AddNumber(element);
            Console.Write("Введите второй операнд в десятичном виде: ");
            element = double.Parse(Console.ReadLine());
            ram.AddNumber(element);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // RAM work
            Console.WriteLine("Ваши данные хранятся в Оперативной памяти следующим образом ");
            ram.ShowMass();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            Console.WriteLine();
            cPU.GetCommand();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Addres Bus work 
            Console.WriteLine("Адрес операнда: " + addresBus.AddresBusData());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write("На шину данных поступило: " );
            dataBus.GetIntBinaryNumber(dataBus.Number());
            Console.WriteLine();
            Console.WriteLine("В десятичном виде "+dataBus.Number());
            cPU.Reg();
            ram.AddresChange();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            Console.WriteLine();
            Console.WriteLine("Мне необходим адрес операнда");
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Addres Bus work 
            Console.WriteLine("Адрес операнда: " + addresBus.AddresBusData());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write("На шину данных поступило: ");
            dataBus.GetIntBinaryNumber(dataBus.Number());
            Console.WriteLine();
            Console.WriteLine("В десятичном виде " + dataBus.Number());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Нормализация чисел"); // Этого я не сделала так как нормализовать нечего я не привела числа к мантиссе и порядку
            Console.WriteLine("Числа из регистров процессора извлекаются в АЛУ");
            Console.WriteLine();
            cPU.Reg();
            Console.ForegroundColor = ConsoleColor.Green;// ALU work
            Console.WriteLine("Сумма равна АЛУ " + aLU.Summ());
            cPU.SetSummCPU(aLU.Summ());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;// CPU work
            Console.WriteLine("Сумма в регистре процессора " + cPU.GetSum());
            Console.WriteLine();
            aLU.BackNumber();
            Console.ForegroundColor = ConsoleColor.Red; // Data Bus work
            Console.Write("На шину данных поступило: " );
            dataBus.GetIntBinaryNumber(cPU.GetSum());
            Console.WriteLine();
            Console.WriteLine("В десятичном виде " +cPU.GetSum());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta; // RAM work
            Console.WriteLine("В оперативную память поступил результат суммы " + ram.GetNumberByAddres(2));
            ram.ShowMass();
            
            Console.ReadKey();
        }
    }
}
