using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    internal class Task3
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
            if (actualSize < 1)
            {
                throw new Exception("Вы не можете добавить элемент после k элемента, потому-что массив не содержит элементы");
            }
        }

        private void CheckIfPuttingElementIsPossible(int k)
        {
            if (k < 0)
            {
                throw new Exception("k(index) должен быть больше ноля");
            }
            if (k >= actualSize)
            {
                throw new Exception("Вы не можете добавить элемент после k элемента, потому-что k вне диапазона индексов массива");
            }
        }

        public int[] arrayAfterPut()
        {
            return array;
        }

        public int actualSizeAfterPut()
        {
            return actualSize;
        }

        public string put(int elementToPut, int k)
        {
            for(int i = actualSize; i > k + 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[k + 1] = elementToPut;
            actualSize++;

            Console.WriteLine(array.Length);
            
            string result = $"Добавляем элемент: {elementToPut}\nДобавляем после индекса: {k}\nмассив после добавления элемента:\n";

            return result;
        }
    }
}
