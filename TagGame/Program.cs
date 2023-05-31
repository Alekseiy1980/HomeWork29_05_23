// void PlaceTag(int[] pole)
// {
//    int[] tags = new int[16];


//    for (int i = 0; i < tags.Length; i++)
//    {
//       int tmp = new Random().Next(1, 16);
//       for (int j = 0; j < i; j++)
//       {
//          if (tmp == tags[j])
//          {
//             tmp = new Random().Next(1, 16);

//          }
//          else
//          {
//             tags[j] = tmp;
//             break;
//          }
//       }
//    }


//    for (int i = 0; i < 16; i++)
//    {
//       Console.Write(tags[i] + " ");
//    }
//    Console.WriteLine();
//}
// int[,] GoGame(int[,] tags)
// {
//    int xPos = 0, yPos = 0;
//    int tag = tags[xPos, yPos];
//    for (int i = 0; i < tags.GetLength(0); i++)
//    {
//       for (int j = 0; j < tags.GetLength(1); j++)
//       {
//          if (tags[i, j] == 0)
//          {
//             xPos = i;
//             yPos = j;

//          }
//       }
//    }

//    tag = tags[xPos, yPos];
//    char key = Convert.ToChar(Console.Read());
//    if (key == 'w' && key == 'W')
//    {
//       tags[xPos, yPos] = tags[xPos, yPos - 1];
//       tags[xPos, yPos - 1] = tag;
//    }
//    if (key == 's' && key == 'S')
//    {
//       tags[xPos, yPos] = tags[xPos, yPos + 1];
//       tags[xPos, yPos + 1] = tag;
//    }
//    if (key == 'a' && key == 'A')
//    {
//       tags[xPos, yPos] = tags[xPos - 1, yPos];
//       tags[xPos - 1, yPos] = tag;
//    }
//    if (key == 'd' && key == 'D')
//    {
//       tags[xPos, yPos] = tags[xPos + 1, yPos];
//       tags[xPos + 1, yPos] = tag;
//    }
//    return tags;
// }

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


int[,] pole = {
   {15,9,4,11},
   {8,3,1,12},
   {2,6,10,5},
   {7,14,0,13}};

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