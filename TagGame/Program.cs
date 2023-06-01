int[,] PlaceTag(int[,] pole)
{
   int[] tags = new int[16];

   tags[0] = new Random().Next(0, 16);
   for (int i = 1; i < 16; i++)
   {
      tags[i] = new Random().Next(0, 16);
      for (int j = 0; j < i; j++)
      {
         if (tags[i] == tags[j])
         {
            i--;
         }
      }
   }
   for (int i = 0; i < 16; i++)
   {
      pole[i / 4, i % 4] = tags[i];
   }
   return pole;
}


//GAME
void PrintPole(int[,] pole)
{
   for (int i = 0; i < pole.GetLength(0); i++)
   {
      for (int j = 0; j < pole.GetLength(1); j++)
      {
         Console.Write(" {0, 2}  ", pole[i, j]);
      }
      Console.WriteLine();
   }
}


// int[,] pole = {
//    {15,9,4,11},
//    {8,3,1,12},
//    {2,6,10,5},
//    {7,14,0,13}};
int[,] pole = new int[4, 4];
pole = PlaceTag(pole);
int xPos = 0, yPos = 0;
int tag = pole[xPos, yPos];
for (int i = 0; i < pole.GetLength(0); i++)
{
   for (int j = 0; j < pole.GetLength(1); j++)
   {
      if (pole[i, j] == 0)
      {
         xPos = i;
         yPos = j;

      }
   }
}
tag = pole[xPos, yPos];
while (true)
{
   Console.Clear();
   PrintPole(pole);
   Console.WriteLine("управление осуществляется W,S,A,D ");
   char key = Convert.ToChar(Console.Read());
   if (key == 'w' || key == 'W')
   {
      if (xPos <= 0)
      {

         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[pole.GetLength(0) - 1, yPos];
         pole[pole.GetLength(0) - 1, yPos] = tag; xPos = pole.GetLength(0) - 1;
      }
      else
      {
         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[xPos - 1, yPos];
         pole[xPos - 1, yPos] = tag; xPos--;
      }
   }
   if (key == 's' || key == 'S')
   {
      if (xPos >= pole.GetLength(0))
      {
         xPos = 0;
         tag = pole[pole.GetLength(0), yPos];
         pole[pole.GetLength(0), yPos] = pole[xPos, yPos];
         pole[xPos, yPos] = tag;
      }
      else
      {
         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[xPos + 1, yPos];
         pole[xPos + 1, yPos] = tag; xPos++;
      }
   }
   if (key == 'a' || key == 'A')
   {
      if (yPos <= 0)
      {

         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[xPos, pole.GetLength(1) - 1];
         pole[xPos, pole.GetLength(1) - 1] = tag; yPos = pole.GetLength(1) - 1;
      }
      else
      {
         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[xPos, yPos - 1];
         pole[xPos, yPos - 1] = tag; yPos--;
      }
   }
   if (key == 'd' || key == 'D')
   {
      if (yPos >= pole.GetLength(1))
      {
         yPos = 0;
         tag = pole[xPos, pole.GetLength(1)];
         pole[xPos, pole.GetLength(1)] = pole[xPos, yPos];
         pole[xPos, yPos] = tag;
      }
      else
      {
         tag = pole[xPos, yPos];
         pole[xPos, yPos] = pole[xPos, yPos + 1];
         pole[xPos, yPos + 1] = tag; yPos++;
      }
   }
}