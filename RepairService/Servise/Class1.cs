using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servise
{
    public class RepairRequest
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// ФИО пассажира
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
    }
    public enum Currency
    {
        Rubles
    }
    public class FaultType
    {
        /// <summary>
        /// Описание неисправности
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Решение
        /// </summary>
        public string Solution { get; set; }
    }
    public enum DeviceType
    {
        Smartphone,
        Tablet,
        Laptop,
        PC,
    }
}
