using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class MedicalScience
    {
        public int id { get; set; }
        /// <summary>
        /// наука
        /// </summary>
        public string Science { get; set; }
        /// <summary>
        /// сложность изучения
        /// </summary>
        public string Difficulty { get; set; }

        /// <summary>
        /// система
        /// </summary>
        public string System { get; set; }
        /// <summary>
        /// смертность
        /// </summary>
        public string Mortality { get; set; }
        /// <summary>
        /// Оплата труда низкая везде. Имеется ввиду в сравнении с другими мед. науками
        /// </summary>
        public string Payment { get; set; }
    }
}
