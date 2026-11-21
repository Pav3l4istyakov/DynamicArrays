namespace DynamicArrays
{
    internal class Program
    {
        static int[]VidDynamicMemoryPoint(int size)
        {
            return new int[size];
        }

        static void RandomNumbers(int[] arr)
        {
            Random randomNumbers = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomNumbers.Next(1, 10);
            }
        }

        static void PrintArr(int[] arr, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static void DeleteArr(ref int[] arr)
        {
            arr = null;
            Console.WriteLine("Память освобождена");
        }

        static int[]AddNumberEnd(int[] arr, int number)
        {
            int[]newArr = new int[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length-1] = number;

            return newArr;
        }

        static int[]AddEl(int[] arr, int elem, int index)
        {
            int[] newArr = new int[arr.Length+1];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < index)
                {
                    newArr[i] = arr[i];
                }
                else if (i == index)
                {
                    newArr[i] = elem;
                }
                else
                {
                    newArr[i] = arr[i-1];
                }
            }

            return newArr;
        }

        static int[]DeleteElIndex(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < index)
                {
                    newArr[i] = arr[i];
                }
                else if (i > index)
                {
                    newArr[i-1] = arr[i];
                }
            }

            return newArr;
        }



        static void Main(string[] args)
        {
            int size = 5;

            int[]ptr = null;

            ptr = VidDynamicMemoryPoint(size);

            Console.WriteLine("Создан массив из " + ptr.Length + " элементов\n");

            RandomNumbers(ptr);

            PrintArr(ptr, "Изначальный массив\n");

            ptr = AddNumberEnd(ptr, 10);
            PrintArr(ptr, "После добавления в конец\n");

            ptr = AddEl(ptr, 1, 2);
            PrintArr(ptr, "После вставки по индексу\n");

            ptr = DeleteElIndex(ptr, 0);
            PrintArr(ptr, "После удаления элемента\n");

            DeleteArr(ref ptr);
    }

    }
       
 }

