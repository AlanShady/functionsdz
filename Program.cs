// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// while(true)
// {
//     System.Console.WriteLine("Введите число");
//     string userInput = Console.ReadLine();

//     if(userInput== "q")
//     {
//         return;
//     }

//     int num = Convert.ToInt32(userInput);

// int copeNum = num;
// int sum=0;

// while(copeNum>0)
// {
//     sum += copeNum%10;
//     copeNum /=10;
// }

// if(sum%2==0)
// {
//     return;
// }
// }

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 999);
// }
// int evenCount(int [] arrNum) //функция возвращает кол-во четных чиел из массива
// {
//     int evenNum = 0;
//     for (int i = 0; i < arrNum.Length; i++)
//     {
//         if(arrNum[i]%2 == 0) evenNum++;
//     }
//     return evenNum;
// }
// int countEven = evenCount(array);
// System.Console.WriteLine($"\nКоличество четных чисел: {countEven}");


//Задача3: Напишите программу, которая перевернёт 
//одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = {1,2,3,4,5,6,7,8,9};

int[] reverseArr(int[] arr)
{
    int lenArr = arr.Length-1; //переменная содержащая длину массива.
    int[] revArr = new int[lenArr+1]; // перевернутый массив
    for(int i = lenArr; i >= 0; i--)
    {
        revArr[lenArr-i] = arr[i];
    }
    return revArr;
}
int[] arr2 = reverseArr(array);

for (int i = 0; i < arr2.Length; i++)
{
    System.Console.Write(arr2[i]);
}