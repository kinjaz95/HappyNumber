using System;
using System.Collections.Generic;

namespace HappyNumber
{
    public class Test
    {
        public int SplitNumber(int number)
        {
            var convertedNumber = number.ToString();
            string[] convertedNumberList = convertedNumber.Split();

            int summedNumber = 0;

            foreach (string nr in convertedNumberList)
            {
                summedNumber += Int32.Parse(nr) ^ 2;
            }

            return summedNumber;
        }

        public bool IsNumberInList(int number, IList<int> numberList)
        {
            return numberList.Contains(number);
        }

        public bool IsCrossSumEqualsOne(int number)
        {
            var convertedNumber = number.ToString();
            string[] convertedNumberList = convertedNumber.Split();

            int summedNUmber = 0;

            foreach (string nr in convertedNumberList)
            {
                summedNUmber += Int32.Parse(nr);
            }

            return summedNUmber == 1;
        }

    }
}