using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    internal class Task4
    {
        private int actualSize;
        private int[] array;

        public void setArray(int actualSize, int[] array)
        {
            this.actualSize = actualSize;
            CheckSizeOfArray();
            this.array = array;
        }

        private void CheckSizeOfArray()
        {
            if(actualSize < 2)
            {
                throw new Exception("В массиве должно быть минимум 2 элемента");
            }
        }

        private bool IsFoundTwoConsecutiveZero()
        {
            bool isFoundTwoConsecutiveZero = false;
            for (int i = 0; i < actualSize - 1; i++)
            {
                if (array[i] == 0 && array[i + 1] == 0)
                {
                    isFoundTwoConsecutiveZero = true;
                }
            }

            return isFoundTwoConsecutiveZero;
        }

        public string execute()
        {
            bool isFoundTwoConsecutiveZero = IsFoundTwoConsecutiveZero();

            if (isFoundTwoConsecutiveZero)
            {
                return "Да, массив содержит 2 подряд идущих нулевых элементов";
            }
            else
            {
                return "Нет, массив не содержит 2 подряд идущих нулевых элементов";
            }
        }
    }
}
