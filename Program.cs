namespace SQ20.NET_WEEK1_TASK
   {
  
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml.Schema;

    class Program
        {
        static void Main()
        {

            
            
            


            Console.WriteLine("Enter the number of courses:");
            int numCourses = Convert.ToInt32(Console.ReadLine());

            string[] courseCode = new string[numCourses];
            int[] courseUnit = new int[numCourses];
            char[] grade = new char[numCourses];
            int[] gradeUnit = new int[numCourses];
            int[] weightPoint = new int[numCourses];
            string[] remark = new string[numCourses];
            int totalcourseUnitReg;
            int totalcourseUnitpassed;
            int totalweightPoint;
            int totalgradeUnit;
            int GPA;

            for (int i = 0; i < numCourses; i++)
            {
                Console.WriteLine("Enter the name of course and code:");
                courseCode[i] = Console.ReadLine();

                Console.WriteLine("Enter the course unit for courseCode");
                courseUnit[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the course Score");
                int courseScore = Convert.ToInt32(Console.ReadLine());

                if ((courseScore >= 70) && (courseScore <= 100))
                {
                    grade[i] = 'A';
                    gradeUnit[i] = 5;
                    remark[i] = "Excellent";
                }
                else if ((courseScore >= 60) && (courseScore <= 69))
                {
                    grade[i] = 'B';
                    gradeUnit[i] = 4;
                    remark[i] = "Very Good";
                }
                else if ((courseScore >= 50) && (courseScore <= 59))
                {
                    grade[i] = 'C';
                    gradeUnit[i] = 3;
                    remark[i] = "Good";
                }
                else if ((courseScore >= 45) && (courseScore <= 49))
                {
                    grade[i] = 'D';
                    gradeUnit[i] = 2;
                    remark[i] = "Fair";
                }
                else if ((courseScore >= 40) && (courseScore <= 44))
                {
                    grade[i] = 'E';
                    gradeUnit[i] = 1;
                    remark[i] = "Pass";
                }
                else
                {
                    grade[i] = 'F';
                    gradeUnit[i] = 0;
                    remark[i] = "Fail";
                }

                /*totalweightPoint += weightPoint;
                totalcourseUnitReg[i] += courseUnit[i];
                totalcourseUnitpassed[i] += gradeUnit[i];*/
               // totalgradeUnit += gradeUnit;
                //GPA = totalweightPoint[i] / totalgradeUnit[i];


               // weightPoint[numCourses] = courseUnit[i] * gradeUnit[i]; 



            }

            Console.WriteLine("|---------------|-------------|----------|------------|------------|------------|");
            Console.WriteLine("| COURSE & CODE | COURSE UNIT |  GRADE   | GRADE-UNIT | WEIGHT Pt. |   REMARK   |");
            Console.WriteLine("|---------------|-------------|----------|------------|------------|------------|");

            for (int i = 0; i < numCourses; i++)
            {
                int wgtPoint = courseUnit[i] * gradeUnit[i];
                Console.WriteLine($"|{courseCode[i]}         |\t{courseUnit[i]}     |\t    {grade[i]}\t |\t {gradeUnit[i]}    |\t   {wgtPoint}      | {remark[i]}  |");

            }
            Console.WriteLine("|---------------|-------------|----------|------------|------------|------------|");

        
            
            }
        }
    }
