using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    internal class Task2
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
            if (actualSize <= 1)
            {
                throw new Exception("Массив должен содержать больше одного элемента для удаления");
            }
        }


        private void CheckIfIsFoundElements(int count, int n)
        {
            if (count == 0)
            {
                throw new Exception($"Массив не содержит такой элемент: {n}");
            }
        }

        private int CountElementsBeforeDeletingElement(int value)
        {
            int count = 0;

            for (int i = 1; i < actualSize; i++)
            {
                if ((array[i] == value && i < actualSize - 1 && array[i + 1] != value) || (array[i] == value && i < actualSize + 1 && array[i - 1] != value))
                {
                    count++;
                }
            }

            return count;
        }

        public int[] arrayAfterDelete()
        {
            return array;
        }

        public int actualSizeAfterDelete()
        {
            return actualSize;
        }

        public string delete(int n)
        {
            int count = CountElementsBeforeDeletingElement(n);

            CheckIfIsFoundElements(count, n);

            for(int i = 0; i < count; i++)
            {
                bool isFound = false;
                for(int j = 0; j < actualSize; j++)
                {
                    if (!isFound)
                    {
                        if (array[j + 1] == n)
                        {
                            isFound = true;
                            array[j] = array[j + 1];
                        }
                    }
                    else array[j] = array[j + 1];
                }
                actualSize--;
            }

            return "Массив после удаления элемента: \n";
        }
    }
}
