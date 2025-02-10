////Task 1 - Massivin cəmini tapın.
using System.Diagnostics.CodeAnalysis;

//Console.Write("Enter the number of characters in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] numbers  = new int[n];
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//    sum += numbers[i];
//}
//for (int i = 0; i < n; i++)
//{
//    if (i == n - 1)
//    {
//        Console.Write(numbers[i] + "=" + sum);
//    }
//    else
//    {
//        Console.Write(numbers[i] + "+");
//    }
//}


////Task 2 - Massivlərin elementləri arasında ortalamanı tapın
//Console.WriteLine("Enter the number of characters in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] nums  = new int[n];
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    nums[i] = int.Parse(Console.ReadLine());
//    sum += nums[i];
//}
//double avg = (double)sum / n;
//Console.WriteLine("here is the average: " + avg);


////Task 3 - Massivdə müəyyən bir ədədin olub-olmamasını yoxlayın
//Console.WriteLine("Enter the number of characters in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] nums = new int[n];
//for (int i = 0; i < n; i++)
//{
//    nums[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Enter the number you are looking for: ");
//int num = int.Parse(Console.ReadLine());
//bool numberExistsInsideArray = true;
//for (int i = 0;i < nums.Length; i++)
//{
//    if (nums[i] == num)
//    {
//        numberExistsInsideArray = true;
//        break;
//    }
//}
//if (numberExistsInsideArray)
//    Console.WriteLine($"{num} exists inside the array");
//else Console.WriteLine($"{num} does not exist inside the array");


////Task 4 - Massivdəki ən kiçik və ən böyük ədədləri tapın.
//Console.WriteLine("Enter the number of characters in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] nums = new int[n];
//for (int i = 0; i < n; i++)
//{
//    nums[i] = int.Parse(Console.ReadLine());
//}
//int min = nums[0];
//int max = nums[0];
//for (int i = 1; i < nums.Length; i++)
//{
//    if (nums[i] < min)
//    {
//        min = nums[i];
//    }
//    if (nums[i] > max)
//    {
//        max = nums[i];
//    }
//}
//Console.WriteLine($"Minimum: {min}");
//Console.WriteLine($"Maximum: {max}");


////Task 5 - Massivdəki cüt ədədlərin cəmini tapın.
//Console.WriteLine("Enter the number of characters in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0;i < mass.Length; i++)
//{
//    if (mass[i] % 2 == 0)
//    {
//        sum += mass[i];
//    }
//}
//Console.WriteLine(sum);


////Task 6 - Massivin tərsinə dövr etməklə yeni massiv yaradın.
Console.WriteLine("Enter the number of characters in your array: ");
int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];
for (int i = 0; i < n; i++)
{
    array1[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i < n-1; i++)
{
    array2[i] = array1[n - i];
}
for (int i = 0; i<n ; i++)
{
    Console.WriteLine(array2[i]);
}
//7 - Massivdeki en boyuk iki ededi tapin
//Console.Write("Enter the number of elements you want to have in your array: ");
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for (int j = 0; j < n; j++)
//{
//    Console.Write($"Enter the array element: ");
//    arr[j] = int.Parse(Console.ReadLine()); // [1, 2, 54, 6, 8, 3] , output: 54, 8
//}
//if (n < 2)
//{
//    Console.WriteLine("The number of elements should be at least 2");
//    return;
//}

//int max1 = int.MinValue; //this gives the possible minimum value
//int max2 = int.MinValue;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max1)
//    {
//        max2 = max1;
//        max1 = arr[i];
//    }
//    else if (arr[i] > max2 && arr[i] != max1)
//    {
//        max2 = arr[i];
//    }
//}

//Console.WriteLine($"Top 2 largest numbers are {max1} and {max2}");

//8. Massivin bütün elementlərinin 2 qatını tapın və yeni massiv yaradın.
//Console.Write("Enter the number of elements you want in your array: ");
//int n = int.Parse(Console.ReadLine()); 
//int[] array = new int[n];
//int[] doubleArray = new int[n];
//int index = 0;
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Enter the value of the element of the array: ");
//    array[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < n; i++)
//{
//        doubleArray[index++] = array[i] * 2;

//}
//Console.WriteLine("The first array: " + string.Join(", ", array));
//Console.WriteLine("The second array: " + string.Join(", ", doubleArray));
