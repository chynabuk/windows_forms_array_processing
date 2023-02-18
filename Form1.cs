namespace second_project
{
    public partial class Form1 : Form
    {
        private int size;
        private int actualSize;
        private int[] arrays;
        private Random random;
        private Task1 taskOne;
        private Task2 taskTwo;
        private Task3 taskThree;
        private Task4 taskFour;
        public Form1()
        {
            random = new Random();
            taskOne = new Task1();
            taskTwo = new Task2();
            taskThree = new Task3();
            taskFour = new Task4();
            InitializeComponent();
        }


        private void generate_Click_1(object sender, EventArgs e)
        {
            try
            {
                actualSize = Convert.ToInt32(arraySize.Text);
                size = actualSize + 1;
                arrays = GenerateArray(size);
                array.Text = ArrayToString(arrays, actualSize);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось сгенерировать, входное значение должно быть числом");
            }
        }

        private string ArrayToString(int[] array, int actualSize)
        {
            string strArray = "[";
            for(int i = 0; i < actualSize; i++)
            {
                if (i == actualSize - 1) strArray += array[i] + "]";
                else strArray += array[i] + ", ";
            }
            return strArray;
        }

        private int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            for(int i = 0; i < actualSize; i++)
            {
                array[i] = GenerateNumber();
            }

            return array;
        }

        private int GenerateNumber()
        {
            return random.Next(-10, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            checkTask2ClickOn();
            checkClick3On();
            try
            {
                taskOne.setArray(actualSize, arrays);
                result.Text = taskOne.Execute();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось выполнить задачу: " + ex.Message);
            }
        }

        private void task2_Click(object sender, EventArgs e)
        {
            result.Text = "";

            checkClick3On();
            checkTask2ClickOn();
            checkTask2ClickOff();
        }

        private void checkTask2ClickOn()
        {
            if (labelDeleteN.Visible && labelDeleteN.Enabled && inpN.Visible && inpN.Enabled && task22.Visible && task22.Enabled)
            {
                inpN.Visible = false;
                inpN.Enabled = false;
                task22.Visible = false;
                task22.Enabled = false;
                labelDeleteN.Visible = false;
                labelDeleteN.Enabled = false;
            }
        }
        private void checkTask2ClickOff()
        {            
            if(!(labelDeleteN.Visible && labelDeleteN.Enabled && inpN.Visible && inpN.Enabled && task22.Visible && task22.Enabled))
            {
                inpN.Visible = true;
                inpN.Enabled = true;
                task22.Visible = true;
                task22.Enabled = true;
                labelDeleteN.Visible = true;
                labelDeleteN.Enabled = true;
            }
        }

        private void task22_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(inpN.Text);

                try
                {
                    taskTwo.setArray(actualSize, arrays);
                    result.Text = taskTwo.delete(n) + ArrayToString(taskTwo.arrayAfterDelete(), taskTwo.actualSizeAfterDelete());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось выполнить удаление: " + ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось выполнить, значение должно быть числом");
            }
        }

        private void task3_Click(object sender, EventArgs e)
        {
            result.Text = "";

            checkTask2ClickOn();
            checkClick3On();
            checkClick3Off();
        }

        private void checkClick3On()
        {
            if (labelElementToPut.Visible && labelElementToPut.Enabled && elementToPut.Visible && elementToPut.Enabled && labelK.Visible && labelK.Enabled && k.Visible && k.Enabled && put.Visible && put.Enabled)
            {
                labelElementToPut.Visible = false;
                labelElementToPut.Enabled = false;
                elementToPut.Visible = false;
                elementToPut.Enabled = false;
                labelK.Visible = false;
                labelK.Enabled = false;
                k.Visible = false;
                k.Enabled = false;
                put.Visible = false;
                put.Enabled = false;
            }
        }

        private void checkClick3Off()
        {
            if(!(labelElementToPut.Visible && labelElementToPut.Enabled && elementToPut.Visible && elementToPut.Enabled && labelK.Visible && labelK.Enabled && k.Visible && k.Enabled && put.Visible && put.Enabled))
            {
                labelElementToPut.Visible = true;
                labelElementToPut.Enabled = true;
                elementToPut.Visible = true;
                elementToPut.Enabled = true;
                labelK.Visible = true;
                labelK.Enabled = true;
                k.Visible = true;
                k.Enabled = true;
                put.Visible = true;
                put.Enabled = true;
            }
        }

        private void put_Click(object sender, EventArgs e)
        {
            try
            {
                int elToPut = Convert.ToInt32(elementToPut.Text);
                int kIndex = Convert.ToInt32(k.Text);

                try
                {
                    taskThree.setArray(actualSize, arrays);

                    result.Text = taskThree.put(elToPut, kIndex) + ArrayToString(taskThree.arrayAfterPut(), taskThree.actualSizeAfterPut());
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                    MessageBox.Show("Не удалось выполнить вставку: " + ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось выполнить, значение для вставки/индекс должны быть числами");
            }
        }

        private void task4_Click(object sender, EventArgs e)
        {
            result.Text = "";
            checkTask2ClickOn();
            checkClick3On();
            taskFour.setArray(actualSize, arrays);
            result.Text = taskFour.execute();
        }

        private void info1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Определить сумму элементов массива, расположенных между максимальным и 'центральным' элементами массива (предполагается, что число эле ментов - нечётное и максимальный - единственный). Если по какой-либо причине вычислить сумму не удается, выдать об этом сообщение с указанием причины.");
        }

        private void info2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед каждым элементом с заданным значением удалить один элемент, если он отличен от заданного значения. Если удаление элементов невозможно, выдать об этом сообщение.");
        }

        private void info3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вставить в массив элемент с заданным значением после элемента с заданным номером k. Если вставка элементов невозможна, выдать об этом сообщение.");
        }

        private void info4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверить, содержатся ли в массиве два подряд идущих нулевых элемента.");
        }

    }
}