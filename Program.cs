string[] people = { "Tom", "Sam", "Bobby", "Fy", "K", "Alex" };

ShowArray(GetSameWords(people, 3));

string [] GetSameWords (string [] array, int numberSigns)
{
    int lenOfNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberSigns)
        {
            lenOfNewArray ++;
        }
    }
    
    string[] newArray = new string[lenOfNewArray];

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberSigns)
        {
            newArray[count] = array[i];
            count++;
        }
    }

    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}