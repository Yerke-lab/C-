int row  = 10;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i -1, j - 1] + triangle[i - 1, j];
        }
    }
}
void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
            Console.Write($"{triangle[i, j], cellWidth}");
                    }
    Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write("*");
            col += cellWidth * 2;
         }
            col = cellWidth * row - cellWidth * (i + 1);
            Console.WriteLine();
        }
}
Console.ReadLine();
FillTriangle();
//PrintTriangle();
Console.ReadLine();
Magic();


//вариант 2
/* Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());
        
int[][] triangle = new int[n][];
triangle[0] = new int[] { 1 };

for (int i = 1; i < triangle.Length; i++)
  {
triangle[i] = new int[i + 1];  
for (int j = 0; j <= i; j++)
   {
     if (j == 0 || j == i)
     triangle[i][j] = 1;
      else
    {
  triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
 }
 }
 }
 
 for (int i = 0; i < triangle.Length; i++)
  {
  for (int j = 0; j < triangle[i].Length; j++)
   {
   Console.Write("{0,-3} ", triangle[i][j]);
  }
   Console.WriteLine();
 }
Console.ReadKey();
*/
