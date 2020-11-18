using System;


namespace FirstApplication
{
    class Student
    {
        static void Main()
        {
            int[] num = { 6, 7, 9, 1, 4, 5 };
            Console.WriteLine("The Array is:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("At index {0} value {1}", i, num[i]);
            }
            Console.WriteLine("Enter element whose index to find:");
            int element = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(num, element);
            Console.WriteLine("The element {0} at position {1}", element, position);

            Console.ReadKey();

        }
    }
}
