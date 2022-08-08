Console.WriteLine("Введите количество строк в двумерном массиве: ");
int Line = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int Column = Convert.ToInt16(Console.ReadLine());
int[,] Matrix = new int[Line, Column];
 
            Random random = new Random();
            for (int i = 0; i < Line ; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Matrix[i, j] = random.Next(0,100);
                    Console.Write("{0,4}", Matrix[i, j]);
                }
                Console.WriteLine();
            }
int SumOfLineElements = 0;
int IndexOfLine = 0;
    for (int i = 0; i < Line; i++)
        {
            int temp = 0;
            for (int j = 0; j < Column; j++)
            {
                temp += Matrix[i,j];
            }
            if (temp < SumOfLineElements)
            {
                SumOfLineElements = temp;
                IndexOfLine = i;
            }
        }
Console.WriteLine($"Строка с наименьшей суммой элементов: ", SumOfLineElements);
Console.WriteLine();
 for (int i = 0; i < Column; i++)
            {
                Console.Write(Matrix[IndexOfLine,i] + " ");
            }