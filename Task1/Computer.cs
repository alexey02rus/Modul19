using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Computer<T>
    {
        public T Code { get; set;}
        public string Name { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency{ get; set; }
        public int MemoryRam { get; set; }
        public int MemoryHardDisk { get; set; }
        public int MemoryVideoCard { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        

        public Computer(T code, string name, string processorType, double processorFrequency, int memoryRam, int memoryHardDisk, int memoryVideoCard, double price, int quantity)
        {
            Code = code;
            Name = name;
            ProcessorType = processorType;
            ProcessorFrequency = processorFrequency;
            MemoryRam = memoryRam;
            MemoryHardDisk = memoryHardDisk;
            MemoryVideoCard = memoryVideoCard;
            Price = price;
            Quantity = quantity;
        }
        public string GetInfo()
        {
            return $"Код: {Code}; Наименование: {Name}; Тип процессора: {ProcessorType} ({ProcessorFrequency} МГц); ОЗУ: {MemoryRam} Гб; VRAM: {MemoryVideoCard} Гб; Цена: {Price} руб; Количество: {Quantity} шт.";
        }
    }
}
