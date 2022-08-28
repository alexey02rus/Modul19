using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer<int>> computers = new List<Computer<int>>()
            {
                new Computer<int>(1, "Apple", "Apple Silicon", 3.2, 16, 512, 16, 260000, 51),
                new Computer<int>(2, "Asus", "Intel Core", 4.3, 32, 1024, 8, 120000, 27),
                new Computer<int>(3, "Lenovo", "AMD", 3.3, 32, 1536, 8, 110000, 21),
                new Computer<int>(4, "Apple", "Intel Core", 2.5, 8, 256, 8, 70000, 35),
                new Computer<int>(5, "Asus", "AMD", 3.6, 32, 1024, 12, 92000, 20),
                new Computer<int>(6, "MSI", "Intel Core", 3.1, 8, 512, 2, 31000, 25),
                new Computer<int>(7, "Lenovo", "Intel Core", 4.6, 24, 2048, 16, 170000, 18),
                new Computer<int>(8, "MSI", "AMD", 4.1, 32, 2044, 8, 75000, 65),
            };

            Console.WriteLine("Введите тип процессора");
            string processor = Console.ReadLine();
            Console.WriteLine($"Компьютеры с типом процессора {processor}:");
            List<Computer<int>> computersProcessorType = computers.Where(comp => comp.ProcessorType == processor).ToList();
            Print(computersProcessorType);
            Console.WriteLine();
            Console.WriteLine("Введите объем ОЗУ");
            int memoryRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Компьютеры с объемом ОЗУ не менее {memoryRam}:");
            List<Computer<int>> computersMemoryRam = computers.Where(comp => comp.MemoryRam >= memoryRam).ToList();
            Print(computersMemoryRam);
            Console.WriteLine();
            Console.WriteLine("Сортировка компьютеров по увеличению стоимости");
            List<Computer<int>> computersSortPrice = computers.OrderBy(price => price.Price).ToList();
            Print(computersSortPrice);
            Console.WriteLine();
            Console.WriteLine("Группировка компьютеров по типу процессора");
            List<IGrouping<string, Computer<int>>> computersGroupProcessorType = computers.GroupBy(processorType => processorType.ProcessorType).ToList();
            foreach (IGrouping<string, Computer<int>> gr in computersGroupProcessorType)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer<int> comp in gr)
                {
                    Console.WriteLine(comp.GetInfo());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computers.Any(comp => comp.Quantity >= 30) ? "Да": "Нет");
            Console.WriteLine();
            Console.WriteLine("Список компьютеров в количестве не менее 30 штук");
            List<Computer<int>> computersQuantity = computers.Where(comp => comp.Quantity >= 30).ToList();
            Print(computersQuantity);
            Console.ReadKey();
        }
        static void Print(List<Computer<int>> computers)
        {
            if (computers.Any())
            {
                foreach (Computer<int> comp in computers)
                {
                    Console.WriteLine(comp.GetInfo());
                }
            }
            else
            {
                Console.WriteLine("Компьютеры не найдены");
            }
            
        }
    }
}
