namespace Model
{
    /// <summary>
    /// Класс "Скидка по сертификату".
    /// </summary>
    public class Certificate : Calc
    {
        
        public override string Name()
        {
            return "Скидка по сертификату";
        }


        /// <summary>
        /// Расчёт со скидкой по сертификату.
        /// </summary>
        /// <returns>Расчёт со скидкой по сертификату.</returns>
        public override string Get()
        {
            // Расчёт со скидкой по сертификату и возвращение результата.
            return ((S - I).ToString());
        }
    }
}
