int[,] Spiral = new int[4,4];
int Cell = 1;
for (int Column = 0; Column < 4; Column++)
   {
    Spiral[0, Column] = Cell;
    Cell++;
   }
for (int Line = 1; Line < 4; Line++)
   {
    Spiral[Line, 4-1] = Cell;
    Cell++;
   }
for (int Column = 4 - 2; Column >= 0; Column--)
   {
    Spiral[4-1, Column] = Cell;
    Cell++;
   }
for (int Line = 4 - 2; Line > 0; Line--)
   {
    Spiral[Line, 0] = Cell;
    Cell++;
   }

int NextCellLine = 1;
int NextCellColumn = 1;
while (Cell < 4*4)
    { while (Spiral[NextCellLine, NextCellColumn +1] == 0)
      {
        Spiral[NextCellLine, NextCellColumn] = Cell;
        Cell++;
        NextCellColumn++;
      }
    
      while (Spiral[NextCellLine + 1, NextCellColumn] == 0)
      {
        Spiral[NextCellLine, NextCellColumn] = Cell;
        Cell++;
        NextCellLine++;
      }  
      while (Spiral[NextCellLine, NextCellColumn -1] == 0)
       {
        Spiral[NextCellLine, NextCellColumn] = Cell;
        Cell++;
        NextCellColumn--;
       } 
       while (Spiral[NextCellLine - 1, NextCellColumn] == 0)
       {
        Spiral[NextCellLine, NextCellColumn] = Cell;
        Cell++;
        NextCellLine--;
       } 
    }
for (int Line = 0; Line < 4; Line++)
     {
       for (int Column = 0; Column < 4; Column++)
        {
            if (Spiral[Line,Column] == 0)
             {
                Spiral[Line, Column] = Cell;
             }
        }
     }
for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0,4}", Spiral[i, j] + "  ");
                }
                Console.WriteLine();
            }
 
