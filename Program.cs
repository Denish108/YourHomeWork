// Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] CreateArray()
{
    Console.Write("Input number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\" ");
    }
    Console.WriteLine();
}

string[] myArray = CreateArray();
ShowArray(myArray);//not necessary
//Console.Write("create a new array with elements <= ");
// int filter = Convert.ToInt32(Console.ReadLine());  // if you need to change the selection condition
int filter = 3;

int Сalculation(string[] array, int filter)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= filter)
        {
            newSize++;
        }

    }
    return newSize;
}

string[] ResultArray = new string[Сalculation(myArray, filter)];
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= filter)
    {
        ResultArray[count] = myArray[i];
        count++;
    }
}

ShowArray(ResultArray); //not necessary

int resLength = ResultArray.Length; //not necessary
Console.WriteLine("number of new elements = " + resLength); //not necessary