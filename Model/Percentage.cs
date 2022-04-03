namespace Model
{
    /// <summary>
    /// Класс "Процентная скидка".
    /// </summary>
    public class Percentage : Calc
    {
        public override string Name()
        {
            return "Процентная скидка";
        }


        /// <summary>
        /// Расчёт c процентной скидкой.
        /// </summary>
        /// <returns>Расчёт с процентной скидкой</returns>
        public override string Get()
        {
            // Расчёт с процентной скидкой и возвращение результата.
            return (S - S * I * 0.01).ToString();
        }
    }
}
