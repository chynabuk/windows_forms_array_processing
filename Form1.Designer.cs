namespace second_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generate = new System.Windows.Forms.Button();
            this.arraySize = new System.Windows.Forms.TextBox();
            this.array = new System.Windows.Forms.TextBox();
            this.task1 = new System.Windows.Forms.Button();
            this.info1 = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.info3 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.info4 = new System.Windows.Forms.Button();
            this.task4 = new System.Windows.Forms.Button();
            this.labelArraySize = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelDeleteN = new System.Windows.Forms.Label();
            this.task22 = new System.Windows.Forms.Button();
            this.inpN = new System.Windows.Forms.TextBox();
            this.labelElementToPut = new System.Windows.Forms.Label();
            this.elementToPut = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.TextBox();
            this.put = new System.Windows.Forms.Button();
            this.arrayInit = new System.Windows.Forms.GroupBox();
            this.tasks = new System.Windows.Forms.GroupBox();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(601, 36);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(186, 29);
            this.generate.TabIndex = 0;
            this.generate.Text = "Сгенерировать массив";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click_1);
            // 
            // arraySize
            // 
            this.arraySize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arraySize.Location = new System.Drawing.Point(237, 38);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(101, 27);
            this.arraySize.TabIndex = 1;
            this.arraySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // array
            // 
            this.array.BackColor = System.Drawing.SystemColors.ControlLight;
            this.array.Location = new System.Drawing.Point(106, 91);
            this.array.Name = "array";
            this.array.ReadOnly = true;
            this.array.Size = new System.Drawing.Size(681, 27);
            this.array.TabIndex = 2;
            this.array.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(106, 161);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(94, 29);
            this.task1.TabIndex = 3;
            this.task1.Text = "Задание 1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // info1
            // 
            this.info1.Location = new System.Drawing.Point(215, 161);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(37, 29);
            this.info1.TabIndex = 4;
            this.info1.Text = "?";
            this.info1.UseVisualStyleBackColor = true;
            this.info1.Click += new System.EventHandler(this.info1_Click);
            // 
            // info2
            // 
            this.info2.Location = new System.Drawing.Point(215, 218);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(37, 29);
            this.info2.TabIndex = 6;
            this.info2.Text = "?";
            this.info2.UseVisualStyleBackColor = true;
            this.info2.Click += new System.EventHandler(this.info2_Click);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(106, 218);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(94, 29);
            this.task2.TabIndex = 5;
            this.task2.Text = "Задание 2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // info3
            // 
            this.info3.Location = new System.Drawing.Point(216, 274);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(37, 29);
            this.info3.TabIndex = 8;
            this.info3.Text = "?";
            this.info3.UseVisualStyleBackColor = true;
            this.info3.Click += new System.EventHandler(this.info3_Click);
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(106, 275);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(94, 29);
            this.task3.TabIndex = 7;
            this.task3.Text = "Задание 3";
            this.task3.UseVisualStyleBackColor = true;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            // 
            // info4
            // 
            this.info4.Location = new System.Drawing.Point(215, 328);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(37, 29);
            this.info4.TabIndex = 10;
            this.info4.Text = "?";
            this.info4.UseVisualStyleBackColor = true;
            this.info4.Click += new System.EventHandler(this.info4_Click);
            // 
            // task4
            // 
            this.task4.Location = new System.Drawing.Point(106, 328);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(94, 29);
            this.task4.TabIndex = 9;
            this.task4.Text = "Задание 4";
            this.task4.UseVisualStyleBackColor = true;
            this.task4.Click += new System.EventHandler(this.task4_Click);
            // 
            // labelArraySize
            // 
            this.labelArraySize.AutoSize = true;
            this.labelArraySize.Location = new System.Drawing.Point(106, 40);
            this.labelArraySize.Name = "labelArraySize";
            this.labelArraySize.Size = new System.Drawing.Size(125, 20);
            this.labelArraySize.TabIndex = 11;
            this.labelArraySize.Text = "Размер массива:";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result.Location = new System.Drawing.Point(106, 431);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(681, 142);
            this.result.TabIndex = 12;
            this.result.Text = "";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(106, 397);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(57, 20);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "Вывод:";
            // 
            // labelDeleteN
            // 
            this.labelDeleteN.AutoSize = true;
            this.labelDeleteN.Location = new System.Drawing.Point(278, 222);
            this.labelDeleteN.Name = "labelDeleteN";
            this.labelDeleteN.Size = new System.Drawing.Size(494, 20);
            this.labelDeleteN.TabIndex = 14;
            this.labelDeleteN.Text = "Введите значение, перед которым нужно удалить элементы массива:";
            this.labelDeleteN.Visible = false;
            // 
            // task22
            // 
            this.task22.Enabled = false;
            this.task22.Location = new System.Drawing.Point(875, 216);
            this.task22.Name = "task22";
            this.task22.Size = new System.Drawing.Size(94, 29);
            this.task22.TabIndex = 15;
            this.task22.Text = "Удалить";
            this.task22.UseVisualStyleBackColor = true;
            this.task22.Visible = false;
            this.task22.Click += new System.EventHandler(this.task22_Click);
            // 
            // inpN
            // 
            this.inpN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inpN.Enabled = false;
            this.inpN.Location = new System.Drawing.Point(777, 218);
            this.inpN.Name = "inpN";
            this.inpN.Size = new System.Drawing.Size(77, 27);
            this.inpN.TabIndex = 16;
            this.inpN.Visible = false;
            // 
            // labelElementToPut
            // 
            this.labelElementToPut.AutoSize = true;
            this.labelElementToPut.Enabled = false;
            this.labelElementToPut.Location = new System.Drawing.Point(269, 278);
            this.labelElementToPut.Name = "labelElementToPut";
            this.labelElementToPut.Size = new System.Drawing.Size(254, 20);
            this.labelElementToPut.TabIndex = 17;
            this.labelElementToPut.Text = "Введите значение для добавления:";
            this.labelElementToPut.Visible = false;
            // 
            // elementToPut
            // 
            this.elementToPut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.elementToPut.Enabled = false;
            this.elementToPut.Location = new System.Drawing.Point(529, 277);
            this.elementToPut.Name = "elementToPut";
            this.elementToPut.Size = new System.Drawing.Size(77, 27);
            this.elementToPut.TabIndex = 18;
            this.elementToPut.Visible = false;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Enabled = false;
            this.labelK.Location = new System.Drawing.Point(625, 280);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(120, 20);
            this.labelK.TabIndex = 19;
            this.labelK.Text = "Введите индекс:";
            this.labelK.Visible = false;
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.SystemColors.ControlLight;
            this.k.Enabled = false;
            this.k.Location = new System.Drawing.Point(762, 278);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(77, 27);
            this.k.TabIndex = 20;
            this.k.Visible = false;
            // 
            // put
            // 
            this.put.Enabled = false;
            this.put.Location = new System.Drawing.Point(875, 278);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(94, 29);
            this.put.TabIndex = 21;
            this.put.Text = "Добавить";
            this.put.UseVisualStyleBackColor = true;
            this.put.Visible = false;
            this.put.Click += new System.EventHandler(this.put_Click);
            // 
            // arrayInit
            // 
            this.arrayInit.Location = new System.Drawing.Point(88, 12);
            this.arrayInit.Name = "arrayInit";
            this.arrayInit.Size = new System.Drawing.Size(941, 125);
            this.arrayInit.TabIndex = 22;
            this.arrayInit.TabStop = false;
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tasks.ForeColor = System.Drawing.Color.Black;
            this.tasks.Location = new System.Drawing.Point(88, 143);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(941, 228);
            this.tasks.TabIndex = 23;
            this.tasks.TabStop = false;
            // 
            // groupResult
            // 
            this.groupResult.Location = new System.Drawing.Point(89, 398);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(940, 200);
            this.groupResult.TabIndex = 24;
            this.groupResult.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 610);
            this.Controls.Add(this.put);
            this.Controls.Add(this.k);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.elementToPut);
            this.Controls.Add(this.labelElementToPut);
            this.Controls.Add(this.inpN);
            this.Controls.Add(this.task22);
            this.Controls.Add(this.labelDeleteN);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.labelArraySize);
            this.Controls.Add(this.info4);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.array);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.arrayInit);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.groupResult);
            this.Name = "Form1";
            this.Text = "Операции обработки массива";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button generate;
        private TextBox arraySize;
        private TextBox array;
        private Button task1;
        private Button info1;
        private Button info2;
        private Button task2;
        private Button info3;
        private Button task3;
        private Button info4;
        private Button task4;
        private Label labelArraySize;
        private RichTextBox result;
        private Label labelResult;
        private Label labelDeleteN;
        private Button task22;
        private TextBox inpN;
        private Label labelElementToPut;
        private TextBox elementToPut;
        private Label labelK;
        private TextBox k;
        private Button put;
        private GroupBox arrayInit;
        private GroupBox tasks;
        private GroupBox groupResult;
    }
    #endregion
}