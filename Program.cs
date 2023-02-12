/*Задача: сформировать из имеющегося массива строк, новый массив, состоящий из элементов длинной не более 3 символов.*/
string [] arrayStr= new string[] {"thh","udww","uujf","563","***","yhn","*","//"};

/*метод для создания нового массива*/
string[] CreateNewArray(string[] array1) {
    int k=0;
  for (int i=0;i<array1.Length;i++)  {
    if (array1[i].Length<4) 
    {k++;}
  };
  string [] array2=new string [k];
  k=0;
  for (int i=0;i<array1.Length;i++)  {
    if (array1[i].Length<4) 
    { array2[k]=array1[i]; k++;}
  }
  return array2;
} 
/*печать массива*/
void Print (string [] array) {
  for (int i=0;i<array.Length;i++)  {
Console.Write(array[i]+", ");
  };
  Console.WriteLine();
} ;
string [] arrayNew=CreateNewArray(arrayStr);
Print(arrayStr);
Print(arrayNew);
