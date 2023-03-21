// create new str array from str array with lenght of array[i] <= 3  

Console.Clear();
Console.Write("Please enter string separated by spaces --> ");
string str = Console.ReadLine();

string[] arr = str.Split(' ');

string[] newArr = new string[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i].Length < 3) || (arr[i].Length == 3))
    {
        newArr[i] = arr[i];
    }    
}

Console.Write("[");
foreach (var item in newArr)
{
    Console.Write($"{item} ");
}
Console.Write("]");

