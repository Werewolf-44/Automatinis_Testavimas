﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis17UnitTests
{
    public class Tests
    {
        private DayOfWeek expectedResult;

        //Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        [Test]
        public void TestNumber()
        {
            //Arrange
            int number = 995;
            int divisor = 3;
            bool expectedResult;

            //Acts
            if (number % divisor == 0)
            {
                expectedResult = false;
            }
            else
            {
                expectedResult = true;
            }

            //Assert
            Assert.IsTrue(expectedResult);
        }
        //Testas “žalias” jeigu šiandien trečiadienis 
        [Test]
        public void IsWednesday()
        {
            //Arrange
            expectedResult = DayOfWeek.Wednesday;
            DateTime now = DateTime.Now;
            DayOfWeek day = now.DayOfWeek;

            //Assert
            Assert.AreEqual(expectedResult, day);
        }
        //Testas “žalias” jeigu dabar yra 13h 
        [Test]
        public void Time()
        {
            //Arrange
            DateTime now = DateTime.Now;
            DateTime expectedResult = new DateTime(now.Year, now.Month, now.Day, 13, 0, 0);

            //Assert
            Assert.AreEqual(expectedResult, now);
        }
        //Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai
        [Test]
        public void FourEvenNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int evenCount = numbers.Count(n => n % 2 == 0);

            Assert.That(evenCount, Is.EqualTo(4));
        }
    }
}
