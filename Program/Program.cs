string [] Create_Array(int n)
{
  string[] array = new string[n];
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine("Введи слово");
    array[i] = Console.ReadLine();
  }
  return array;
}

void Print_Array(string[] array)
{
    Console.WriteLine("Массив");
    foreach (string x in array)
    {
        Console.Write(" " + x + " ");
    }
    Console.WriteLine(); 
}

string[] Create_Short_Array(string[] array)
{
    string[] short_words = array.Where(element => element.Length <= 3).ToArray();
    return short_words;
}


Console.WriteLine("Привет, сколько слов вводим?");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = Create_Array(n);
Print_Array(array);
string [] short_words = Create_Short_Array(array);
Console.WriteLine("Результат");
Print_Array(short_words);