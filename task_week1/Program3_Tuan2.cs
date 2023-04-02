using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_week1
{
    public class Program3_Tuan2
    {
        class PrimeFactors
        {
            public int number;
            public List<int> result;

            public PrimeFactors()
            {
                number = 0;
                result = new List<int>();
            }

            public void InputNumber() {
                Console.Write("\nInput a number : ");
                number = System.Convert.ToInt32(Console.ReadLine());
            }

            public void handleNumber()
            {
                int s = number;
                while(s != 1) {
                    for(int i = 2; i < number; i++)
                    {
                        if(s % i == 0)
                        {
                            s = s / i;
                            result.Add(i);
                            break;
                        }
                    }
                }
                string value = "";
                foreach(int i in result)
                {
                    value += i + " x "; 
                }
                Console.WriteLine("Result = " + value.Substring(0,value.Length-1));
            }
        }

        public static void Main(string[] args)
        {
            PrimeFactors factors = new PrimeFactors();
            factors.InputNumber();
            factors.handleNumber();
        }
    }
}
