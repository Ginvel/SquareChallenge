using System;

namespace SquareChallenge.Exeptions
{
    public class SquareExeption : Exception
    {
        public SquareExeption(string errorMassage)
            : base(errorMassage)
        {
        }
    }
}
