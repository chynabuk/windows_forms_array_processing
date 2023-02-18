using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    internal class Task1
    {
        private int[] array;
        private int actualSize;


        public void setArray(int actualSize, int[] array)
        {
            CheckSizeOfArray(actualSize);
            this.actualSize = actualSize;
            this.array = array;
        }

        private void CheckSizeOfArray(int actualSize)
        {
            if (actualSize % 2 == 0)
            {
                throw new Exception("Количество элементов должно быть нечетным\n");
            }
        }

        private void CheckAmountOfMaxElements(int maxElement)
        {
            int counter = 0;
            for (int i = 0; i < actualSize; i++)
            {
                if (array[i] == maxElement)
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                throw new Exception("Сумма не может быть найдена, потому-что количество максимального элемента больше одного");
            }
        }

        private void CheckDistanceBetweenMaxAndMiddle(int maxElementIndex, int middleElementIndex)
        {
            if (Math.Abs(maxElementIndex - middleElementIndex) - 1 <= 0)
            {
                throw new Exception("Сумма не может быть найдена, потому-что центральный и максимальный элементы близко находятся, то есть между ними нет элементов");
            }
        }

        private int[] FindMaxElementWithIndex()
        {
            int max = 0;
            int indexOfMax = 0;

            for (int i = 0; i < actualSize; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    indexOfMax = i;
                }
            }

            return new int[2] { max, indexOfMax };
        }

        private int FindSum(int maxIndex, int middleIndex)
        {
            int summa = 0;

            if (maxIndex > middleIndex)
            {
                for (int i = middleIndex + 1; i < maxIndex; i++)
                {
                    summa += array[i];
                }
            }
            else
            {
                for (int i = maxIndex + 1; i < middleIndex; i++)
                {
                    summa += array[i];
                }
            }

            return summa;
        }

        public string Execute()
        {
            int[] maxs = FindMaxElementWithIndex();

            CheckAmountOfMaxElements(maxs[0]);

            int middleIndex = (actualSize - 1) / 2;

            CheckDistanceBetweenMaxAndMiddle(maxs[1], middleIndex);

            int summa = FindSum(maxs[1], middleIndex);

            string result = "";
            result += "Максимальный элемент: " + maxs[0] + "\n";
            result += "Центральный элемент: " + array[middleIndex] + "\n";
            result += "Сумма: " + summa + "\n";

            return result;
        }
    }
}