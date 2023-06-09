// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// int [] arrey = new int [20];

// int posNumber=0;

// for (int i = 0; i < arrey.Length; i++)
// {
//     arrey[i] = new Random().Next(100,1000);

//     Console.Write(arrey[i] + " ");

//     if (arrey[i] % 2 == 0)
//     {
//         posNumber++;
//     }

// }
// Console.Write($"Четных чисел: {posNumber}");





//***********************************************************
 




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0





// int [] arrey = new int [3];

// int sumNumber=0;



// for (int i = 0; i < arrey.Length; i++)
// {
//     arrey[i] = new Random().Next(0,100);                                     

//     Console.Write(arrey[i] + " ");

// }
//     for (int z = 0; z < arrey.Length; z+=2)
//     {
//     sumNumber = sumNumber + arrey[z];
//     }

// Console.WriteLine($"Сумма чисел на нечетных позициях массива: {sumNumber}");





//****************************************************************





// Задача 38: Задайте массив. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76




int [] num = new int [5];

int min = Int32.MaxValue;
int max = Int32.MinValue;

Console.Write("[");
for (int i = 0; i < num.Length; i++)
{
  
    num[i] = new Random().Next(0,100);                                        
    Console.Write(num[i] + " ");
   
}
Console.Write("] ");

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }    
}


Console.WriteLine($"Разница между числами: {max - min} ");