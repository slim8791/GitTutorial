using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fond_Fourth_Part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            try
            {
                checkAge(age);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ExceptionJdida ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program continue");
            Console.Read();
        }
        static void checkAge(int age)
        {
            if(age < 0)
            {
                throw new ArgumentNullException("Access denied - age must be more than 0.");
            }
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            if (age == 20)
            {
                throw new ExceptionJdida("inside Ma3inichException ");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

    }
}
