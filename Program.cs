// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

System.Console.Write("Начальный массив: ");

for (int i = 0; i < array1.Length; i++)
{
    array1[i] =  Convert.ToString(new Random().Next(0, 9999));
}
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{array1[i]} ");
}

Console.WriteLine();

string[] newArray = new string[size];
System.Console.Write("Новый массив: ");

for (int i = 0; i < newArray.Length; i++)

{
   if(array1[i].Length <= 3)
newArray[i] = array1[i];
else newArray[i] = "";

}

for (int i = 0; i < newArray.Length; i++)
{
  if (i != newArray.Length) Console.Write($"{newArray[i]} ");
else Console.WriteLine($"{newArray[i]}");  
}
