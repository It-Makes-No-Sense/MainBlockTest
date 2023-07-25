// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//

string[] getStringArray()
{
      Console.WriteLine("Введите длину массива");
      int array_len = Int32.Parse(Console.ReadLine()!);
      string [] array = new string[array_len];
      for (int i = 0; i < array_len; i++)
      {
            Console.WriteLine("Введите любое слово или символы.");
            array[i] = Console.ReadLine()!;
      }

      return array;
}


string[] newArray(string[] array)
{
      string[] res = new string[array.Length];
      int index = 0;
      for (int i = 0; i < array.Length; i++)
      {
            string str_len = array[i];
            if (str_len.Length <= 3 && str_len!="")
            {
                  res[index] = array[i];
                  index++;
            }
      }
      Array.Resize(ref res,index);
      return res;
}

string[] array = getStringArray();
string[] res = newArray(array);
Console.WriteLine($"{String.Join(',',array)} --> {String.Join(',',res)}");