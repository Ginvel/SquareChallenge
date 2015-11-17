using System;
using SquareChallenge.Exeptions;

namespace SquareChallenge.Logic
{
    
    /// <summary>
    ///  Класс для расчета площади прямоугольника
    /// </summary>
    public static class SquareCalculator
    {
        private const string CALCULATE_ERROR_MESSAGE = "Неизвестная ошибка расчета площади прямоугольника.";
        private const string ARGUMENTS_ERROR_MESSAGE = "Входные параметры не должны быть меньше 0.";
        /// <summary>
        ///  Метод расчитывает значение площади при целочисленных параметрах
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public static int? CalculatSquare(int width, int height)
        {
            if (width < 0 || height < 0)
                throw new SquareExeption(ARGUMENTS_ERROR_MESSAGE);
            try
            {
                return width * height;
            }
            catch (Exception ex)
            {
                throw new SquareExeption(CALCULATE_ERROR_MESSAGE);
            }
        }
        /// <summary>
        ///  Метод расчитывает значение площади при целочисленных параметрах
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public static long CalculatSquare(long width, long height)
        {
            if (width < 0 || height < 0)
                throw new SquareExeption(ARGUMENTS_ERROR_MESSAGE);
            try
            {
                return width * height;
            }
            catch (Exception ex)
            {
                throw new SquareExeption(CALCULATE_ERROR_MESSAGE);
            }
        }
        /// <summary>
        ///  Метод расчитывает значение площади для параметров с типом double
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public static double CalculatSquare(double width, double height)
        {
            if (width < 0 || height < 0)
                throw new SquareExeption(ARGUMENTS_ERROR_MESSAGE);
            try
            {
                return width * height;
            }
            catch (Exception ex)
            {
                throw new SquareExeption(CALCULATE_ERROR_MESSAGE);
            }
        }


    }
}
