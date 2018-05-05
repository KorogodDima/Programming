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
        /// ФИО Клиента
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Тип устройства
        /// </summary>
        public DeviceType Type { get; set; }
        /// <summary>
        /// Описание неисправности
        /// </summary>
        public List<FaultType> Faults { get; set; }
        /// <summary>
        /// Итоговая цена
        /// </summary>
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

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
        /// Коэффициент сложности
        /// </summary>
        public string Coefficient { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return string.Format("{0}      Цена {1} руб.", Description, Cost);
        }

        public FaultType Clone()
        {
            return new FaultType { Description = Description, Coefficient=Coefficient};
        }
    }

    public enum DeviceType
    {

        Smartphone,
        Tablet,
        Laptop,
        PC,
    }
}
