using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {

            }

            //Method
            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found !");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Bensu", "Selin", "Duygu" };

                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
                //Console.WriteLine(exception.InnerException);
            }
        }
    }
}
