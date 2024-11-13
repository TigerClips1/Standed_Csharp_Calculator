/*This program is standed calcletor made in C#*/

//Enable the namespace just in case i want to use it leater
namespace Calicator
{
    //put it in a class to help keep it orgnize
    public class Program
    {
        //the main function ik this is old but it still wwork
        public static void Main(string[] args)
        {
            //ask the user for input
            Console.WriteLine("Please enter an number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an oprator: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string op = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Please enter an num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //read the oprator the user pick
            if(op == "+")
            {
                Console.WriteLine("The anwser is {0}", num1 + num2);
            }
            else if(op == "-")
            {
                Console.WriteLine("The anwser is {0}", num1 - num2);
            }
            else if(op == "*")
            {
                Console.WriteLine("The anwser is {0}", num1 * num2);
            }
            else if(op == "/")
            {
                Console.WriteLine("The anwser is {0}", num1 / num2);
            } 
            else if(op == "%")
            {
                Console.WriteLine("The anwser is {0}", num1 % num2);
            }
            //return it just in case the oprator is not vaild
            else
            {
                Console.WriteLine("Please Enter a valid Number or oprator");
            }
        }
    }
}