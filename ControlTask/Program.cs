 //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
 //длина которых меньше, либо равна 3 символам.

string[] array = new string[4] {"one", "two", "three", "four"};
string[] array2 = new string[array.Length];

void FillOfArray(string[] array, string[] array2)
{
    
    int j = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
}



void ShowArray(string[] array2)
{
    for(int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + " ");
    }
    Console.WriteLine();
}

FillOfArray(array, array2);
ShowArray(array2);
