using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SecondHW
{
    class Program
    {
        #region enum
        enum HTTP_Errors : int { Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found,
            Method_Not_Allowed,
            Not_Acceptable,
            Proxy_Authentication_Required,
            Request_Timeout,
            Conflict, Gone,
            Length_Required,
            Payload_Too_Large,
            URI_Too_Long,
            Unsupported_Media_Type,
            Range_Not_Satisfiable,
            Expectation_Failed,
            I_am_a_teapot

        }
        #endregion
        static void Main(string[] args)
        {
            #region A
            Console.Write("Enter 3 nums please (float): ");

            float firstNum = Convert.ToSingle(Console.ReadLine());
            float secondNum = Convert.ToSingle(Console.ReadLine());
            float thirdNum = Convert.ToSingle(Console.ReadLine());
            var floatNum = new List<float> { firstNum, secondNum, thirdNum };
            foreach (float number in floatNum)
            {
                if (number > -5.0 & number < 5.0)
                {
                    Console.WriteLine($"You entered number {number}, and this number is belong to the range[-5, 5]");
                }
                else
                {
                    Console.WriteLine($"You entered number { number}, and this number isn't belong to the range[-5, 5]");
                }
            }
            #endregion
            #region B
            Console.WriteLine("Enter 3 values (int): ");
            List<int> numbers = new List<int>() { };
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"Max value is {numbers.Max()}");
            Console.WriteLine($"Min value is {numbers.Min()}");
            #endregion
            #region C
            Console.Write("Enter number of HTTP Error: ");
            int enterdeNum = Convert.ToInt32(Console.ReadLine());
            HTTP_Errors n = (HTTP_Errors)(enterdeNum);
            Console.WriteLine($"Your error number {enterdeNum}, name of this error is : {n}");
            Console.ReadKey();
            #endregion
            #region D
            Dog dog;
            Console.Write("Enter dogs name: ");
            dog.Name = Console.ReadLine();
            Console.Write("Enter dogs mark: ");
            dog.Mark = Console.ReadLine();
            Console.Write("Enter dogs age: ");
            dog.Age = Convert.ToInt32(Console.ReadLine());
            string myDog = $"Dogs name is {dog.Name.ToString()}\nDogs mark is { dog.Mark.ToString()}\nDogs age is { dog.Age.ToString()}";
            #endregion
        }
    }
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;
    }
}
