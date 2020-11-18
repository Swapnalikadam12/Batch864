using System;


namespace FirstApplication
{
    class enumex
    {
        enum grade {C,B,A};
        static void Main()
        {
            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            int score;
            
            if (marks >=85)
            {
                score = 2;
            }
            else if (85>marks && marks>=65 )
            {
                score = 1;
            }
            else
            {
                score = 0;
            }

            Console.WriteLine("The grade with marks {0} is {1}",marks,(grade)score);
            Console.ReadKey();
        }
    }
}
