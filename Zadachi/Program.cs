//Задача: задайте массив вещественных чисел и выведите его


double [,]array1 = new double[5,5];

FillArray ();
PrintArray();

async void FillArray ()
{
  
Random rand= new Random ();
  for (int i = 0;i< 5; i++)
  {
    for (int j = 0;j< 5; j++ )
    {
      array1[i,j] = rand.Next(-10,10);
    }
  }
}

void PrintArray()
{
  for (int i = 0;i<5; i++)
  {
    for (int j = 0;j<5; j++ )
    {
      Console.Write (array1[i,j] + "    ");
  
    }
    Console.WriteLine ();
    Console.WriteLine ();
  }
}

/*Задача: Напишите программу,которая принимает на вход индекс
 элемента масссива и выводит его значение или сообщение,
 что такого элемента нет*/

 
int [,] array2 = {
{4,6,7,3,0},
{9,6,4,12,55},
{14,10,8,42,33},
{2,3,10,84,13},
{11,54,2,9,17},
};
PrintArray2();

Console.WriteLine ("Введите параметр х:  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите параметр y:  ");
int y = Convert.ToInt32(Console.ReadLine());


Poisk();


void PrintArray2()
{
  for (int i = 0;i<5; i++)
  {
    for (int j = 0;j<5; j++ )
    {
      Console.Write (array2[i,j] + "    ");
  
    }
    Console.WriteLine ();
    Console.WriteLine ();
  }
}


 async void Poisk()
 {
   if ( x > array2.GetLength(0) - 1 || y > array2.GetLength(1) - 1)
      {
        Console.WriteLine (" нет");
      }
      else
    {
       Console.WriteLine (array2[x,y]);
       
     }
} 
   

 /*Задача 52  Задайте двумерный 
 массив из целых чисел. Найдите среднее 
 арифметическое элементов в каждом столбце.*/

 int [,] array3 = {
{4,6,7,3,0},
{9,6,4,12,55},
{14,10,8,42,33},
{2,3,10,84,13},
{11,54,2,9,17},
};

FindAverage();

 async void FindAverage()
 {
   int sum;
   for (int i = 0;i<array3.GetLength(1); i++)
    {
      sum=0;
     for (int j = 0;j<array3.GetLength(0); j++ )
     {
       sum = sum + array3[j,i];
     }
     Console.WriteLine (sum / array3.GetLength(0) );
    }
}