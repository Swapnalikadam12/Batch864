using System;


namespace FirstApplication
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("Enter Name");
			string name = Console.ReadLine();

			Console.WriteLine("Enter Age");
	        int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Address");
			string address = Console.ReadLine();

			Console.WriteLine("Enter Stream");
			string stream = Console.ReadLine();

			Console.WriteLine("Enter Percentage");
			float percentage = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Name: {0}   Age: {1}  Address: {2}  Stream: {3} Percentage {4} ",name,age,address,stream,percentage);
			Console.ReadKey();

		}
    }
}
