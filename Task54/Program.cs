int[,] myArray = new int[6, 7];
 
            Random random = new Random();
            for (int i = 0; i < 6 ; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    myArray[i, j] = random.Next(0,100);
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }
    
    Console.WriteLine("  -------------------------- ");
    
    for (var i = 0; i < myArray.GetLength(0); i++)
                for (var j = 0; j < myArray.GetLength(1); j++)
                    for (var k = 0; k < myArray.GetLength(1); k++)
                    {
                        if (myArray[i, j] <= myArray[i, k]) continue;
                        var temp = myArray[i, j];
                        myArray[i, j] = myArray[i, k];
                        myArray[i, k] = temp;
                    }
    for (var i = 0; i < myArray.GetLength(0); i++, Console.WriteLine())
                for (var j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", myArray[i, j]);
                }





// Variation
Console.WriteLine("Введите количество строк в двумерном массиве: ");
int Line = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int Column = Convert.ToInt16(Console.ReadLine());
int[,] myArray1 = new int[Line, Column];
 
            Random random1 = new Random();
            for (int i = 0; i < Line ; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    myArray1[i, j] = random1.Next(0,100);
                    Console.Write("{0,4}", myArray1[i, j]);
                }
                Console.WriteLine();
            }
    
    Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
    
    for (var i = 0; i < myArray1.GetLength(0); i++)
                for (var j = 0; j < myArray1.GetLength(1); j++)
                    for (var k = 0; k < myArray1.GetLength(1); k++)
                    {
                        if (myArray1[i, j] <= myArray1[i, k]) continue;
                        var temp = myArray1[i, j];
                        myArray1[i, j] = myArray1[i, k];
                        myArray1[i, k] = temp;
                    }
    for (var i = 0; i < myArray1.GetLength(0); i++, Console.WriteLine())
                for (var j = 0; j < myArray1.GetLength(1); j++)
                {
                    Console.Write("{0,4}", myArray1[i, j]);
                }