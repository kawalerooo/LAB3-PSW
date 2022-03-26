using System;

class Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź rozmiar tablicy");
        int size = int.Parse(Console.ReadLine());  
        Console.WriteLine("Wprowadź elementy tablicy odzielając je spacją");

        string[] usrInput = Console.ReadLine().Split(' '); 

        int[] inputArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            inputArray[i] = int.Parse(usrInput[i]); 
        }

        BubbleSort(inputArray);

        Console.WriteLine("Posortowane elementy");

        for (int k = 0; k < inputArray.Length; k++)
        {
            Console.Write(inputArray[k] + " "); 
        }
        Console.ReadLine();
    }

    public static void BubbleSort(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}
