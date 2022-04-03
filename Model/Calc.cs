using System;
using System.Xml.Serialization;


namespace Model
{
    /// <summary>
    /// Абстрактный класс "Система скидок с различными реализациями расчёта скидок".
    /// </summary>
    [XmlInclude(typeof(Percentage)), XmlInclude(typeof(Certificate))]
    public abstract class Calc
    {
        private double _S;
        private double _I; 


        public double S
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,", S), "S");

                _S = value;
            }

            get
            {
                return _S;
            }
        }


        public double I
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньшей или равной нулю,", I), "I");

                _I = value;
            }

            get
            {
                return _I;
            }
        }

        /// <summary>
        /// Название класса.
        /// </summary>
        /// <returns>Название класса</returns>
        public abstract string Name();


        /// <summary>
        /// Расчёт итоговой скидки.
        /// </summary>
        public abstract string Get();
    }
}
