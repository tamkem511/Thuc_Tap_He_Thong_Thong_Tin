using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_week1
{
    public class Program2
    {
    // Create a console application named Exercise02 that prompts the user to enter
    // a regular expression, and then prompts the user to enter some input and compare
    // the two for a match until the user presses Esc, as shown in the following output

        public static void Enter(ref string s)
        {
            Console.Write("\nInput Your Email : ");
            s = Console.ReadLine();
        }

        public static void CheckGmail(ref string s) {
            string strRegex = @"^[a-z0-9](\.?[a-z0-9]){5,}@g(oogle)?mail\.com$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(s))
            {
                Console.WriteLine("Success Email");
            }
            else
            {
                Console.WriteLine("Error Email");
            }
        }

        public static void Main(string[] args)
        {
            string s = "";
            Enter(ref s);
            CheckGmail(ref s);
        }
    }
}
