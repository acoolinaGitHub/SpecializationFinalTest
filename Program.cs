// create new str array from str array with lenght of array[i] <= 3  

Console.Clear();
Console.Write("Please enter string separated by spaces --> ");
string str = Console.ReadLine();

string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

string[] Filter(string[] array)    // method: get new array with items >= 3
{
    int count = 0;
    foreach (var item in array)   // count length of filtered array
    {
        if ((item.Length < 4) && (item.Length > 0))
        {
            count++;
        }        
    }

    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)   // get new filtered array
    {
        if ((array[i].Length < 4) && (array[i].Length > 0))
        {
            newArray[j] = array[i];
            j++;
        }           
    }
    return newArray;
}

void PrintArray(string[] array)      //method: print of array (without comma at the end) 
{
    Console.Write("New array: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] newArr = Filter(arr);
PrintArray(newArr);

