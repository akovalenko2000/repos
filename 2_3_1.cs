using System;
class LECTURE2
{
  static void Main ()
  {
    int[,] myArray = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
    int rows = myArray.GetUpperBound (0) + 1;
    int columns = myArray.GetUpperBound (1) + 1;
    for (int i = 0; i < rows; i++)
      {
          for (int j =0; j<columns;j++)
          {
              if(i<j)
              {
                  myArray[i,j] = 1;
              }
              else if (i>j)
              {
                  myArray[i,j] = 0;
              }
          }
   }
}

