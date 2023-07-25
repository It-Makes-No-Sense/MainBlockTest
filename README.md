# MainBlockTest
## Контрольная работа по основному блоку 

### Комментарий к реализации кода:
***Метод создающий массив строк через ввод пользователя:***
```
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
```

***Метод который создает новый массив строк на основе введенного пользователем. (Берёт только строки длинна которых равна или меньше 3 символов.)***
```
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
```

***Пример использования:***
```
string[] array = getStringArray();
string[] res = newArray(array);
Console.WriteLine($"{String.Join(',',array)} --> {String.Join(',',res)}");

------------------------------
Good,God,Dammed --> God
```


### Диаграмма для понимания логики процесса:
![Диаграмма](/Diagram.png)