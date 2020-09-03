using System;

namespace MoreDifficultStudentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(5, "Adam", "Ackerman", 1000);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            try
            {
                myStudent.MakePayment(-500);
                Console.WriteLine(myStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
