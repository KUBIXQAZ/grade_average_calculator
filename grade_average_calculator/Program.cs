//made by kubixqaz the god of programming//
namespace grade_average_calculator
{
    internal class Program
    {
        static void Main()
        {
            string type = "";

            float gradeMinValue = 1.0f;
            float gradeMaxValue = 6.0f;

            string grades = "";
            float gradesWeight = 0.0f;

            float sum = 0.0f;
            float gradeAverage = 0.0f;

            while (type == "" || !(int.TryParse(type, out int parsedType)) || parsedType < 1 || parsedType > 2)
            {
                Console.Clear();

                Console.WriteLine("Enter number of option that you want to choose:");
                Console.WriteLine("==========================");
                Console.WriteLine("1. Normal grade average,");
                Console.WriteLine("2. Grade weighted average.");
                Console.WriteLine("==========================");

                type = Console.ReadLine();
            }

            while(!(int.TryParse(grades, out int parsedGrades)) || parsedGrades <= 0)
            {
                Console.Clear();

                Console.WriteLine("Enter how much grades you have:");
                Console.WriteLine("==========================");

                grades = Console.ReadLine();
            }

            if (int.Parse(type) == 1)
            {
                for (int i = 1; i <= int.Parse(grades); i++)
                {
                    Console.Clear();
                    Console.WriteLine("Enter your " + i + " grade:");
                    Console.WriteLine("==========================");

                    string grade = Console.ReadLine();

                    if (!(float.TryParse(grade, out float parsedGrade)) || parsedGrade < gradeMinValue || parsedGrade > gradeMaxValue) i--;
                    else sum += parsedGrade;
                }

                gradeAverage = sum / float.Parse(grades);

                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("Your grade average is: " + gradeAverage + ".");
                Console.WriteLine("Sum: " + sum + " grades: " + grades);
                Console.WriteLine("==========================");
                Console.WriteLine("\n==========================");
                Console.WriteLine("Do you want to calculate again? (y/n)");
                Console.WriteLine("==========================");
                string again = Console.ReadLine();
                if (again.ToLower() == "y") Main();
            }

            if(int.Parse(type) == 2)
            {
                for (int i = 1; i <= int.Parse(grades); i++)
                {
                    Console.Clear();
                    Console.WriteLine("Enter your " + i + " grade:");
                    Console.WriteLine("==========================");

                    string grade = Console.ReadLine();

                    Console.WriteLine("Enter grade " + grade + " weight:");
                    Console.WriteLine("==========================");

                    string weight = Console.ReadLine();

                    if (!(float.TryParse(grade, out float parsedgrade)) || !(int.TryParse(weight, out int parsedWeight)) || parsedgrade < gradeMinValue || parsedgrade > gradeMaxValue) i--;
                    else
                    {
                        sum += parsedWeight * parsedgrade;
                        gradesWeight += parsedWeight;
                    }
                }

                gradeAverage = sum / gradesWeight;

                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("Your grade average is: " + gradeAverage + ".");
                Console.WriteLine("Sum: " + sum + " grades: " + grades + " grades weight: " + gradesWeight);
                Console.WriteLine("==========================");
                Console.WriteLine("\n==========================");
                Console.WriteLine("Do you want to calculate again? (y/n)");
                Console.WriteLine("==========================");
                string again = Console.ReadLine();
                if (again.ToLower() == "y") Main();
            }
        }
    }
}