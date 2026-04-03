using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tk_v16
{
    // Допустим, что спецификация для этого класса составлена именно так, что они делают настолько мало, как тут
    internal class Calc
    {
        /// <summary>
        /// Вычисляет ток по данным показаниям напряжения и сопротивления. Кидает исключения при некорректном вводе, тип исключений не уточняется.
        /// </summary>
        /// <param name="volt">Напряжение в вольтах</param>
        /// <param name="ohm">Сопротивление в омах</param>
        /// <returns>Ток в амперах</returns>
        public static double current(double volt, double ohm)
        {
            return volt / ohm;
        }
        /// <summary>
        /// Вычисляет напряжение по данным показаниям сопротивления и тока. Кидает исключения при некорректном вводе, тип исключений не уточняется.
        /// </summary>
        /// <param name="ohm">Сопротивление в омах</param>
        /// <param name="ampere">Ток в амперах</param>
        /// <returns>Напряжение в вольтах</returns>
        public static double voltage(double ohm, double ampere)
        {
            return ohm * ampere;
        }
        /// <summary>
        /// Вычисляет напряжение по данным показаниям сопротивления и тока. Кидает исключения при некорректном вводе, тип исключений не уточняется.
        /// </summary>
        /// <param name="ampere">Ток в амперах</param>
        /// <param name="volt">Напряжение в вольтах</param>
        /// <returns>Сопротивление в омах</returns>
        public static double resistance(double ampere, double volt)
        {
            return volt / ampere;
        }
    }
}
