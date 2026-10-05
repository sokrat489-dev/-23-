using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Егиазарян_23_ИС
{
    class Computer
    {
        public int inventoryNumber;
        public double cpuFrequency;
        public int hddVolume;
        public void DisplayInfo()
        {
            Console.WriteLine($"Инвентарный номер: {inventoryNumber}");
            Console.WriteLine($"Частота процессора: {cpuFrequency} ГГц");
            Console.WriteLine($"Объем жесткого диска: {hddVolume} Гб");
        }
        public double CalculateMemoryCost(double pricePerGb)
        {
            return hddVolume * pricePerGb;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();
            myComputer.inventoryNumber = 123345;
            myComputer.cpuFrequency = 1.5;
            myComputer.hddVolume = 400;
            Console.WriteLine("Данные о компьютере");
            myComputer.DisplayInfo();
            double pricePerGb = 100.0;
            double totalCost = myComputer.CalculateMemoryCost(pricePerGb);
            Console.WriteLine("\nРасчет стоимости памяти");
            Console.WriteLine($"Стоимость внешней памяти: {totalCost} рублей.");
            Console.ReadKey();
        }
    }
}
