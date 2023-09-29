using System;
using System.Globalization;
namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main()
        {
            //Способ 2: Convert
            int va11 = Convert.ToInt32("123456"); //123456
            int va12 = Convert.ToInt32("10000", 2); //16
            int va13 = Convert.ToInt32("100", 16); //256//256
            Console.WriteLine($"{ va11}{ va12}{ va13}");
            //Обработка исключений при преобразованиях 1 и 2:
            string str1 = "100f";
            try
            {
                int vall = Int32.Parse(str1);
                Console.WriteLine("Неверный формат Parse: " + str1);
            }
            catch
            {

            }
            try
            {
                int vall = Convert.ToInt32(str1);
                Console.WriteLine(vall);
            }
            catch (Exception e)
            {
                double comment = 5;
                double str = 56;
                if (comment > str)
                {
                    Console.WriteLine("Невозможные переменные. Комментарев больше чем строк");
                }
                else
                {
                    double F = comment / str;
                    Console.WriteLine(F);

                    {

                        Console.WriteLine("Неверный формат ToInt32:" + str1);
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}
