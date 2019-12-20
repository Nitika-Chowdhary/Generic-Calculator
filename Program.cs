using System;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCalculator calculator = new GenericCalculator();
            Console.WriteLine($"The numbers when added, the result is {calculator.Add(8.4, 3.5)}");
            Console.WriteLine($"The numbers when subtracted, the result is {calculator.Subtract(8, 3.5)}");
            Console.WriteLine($"The numbers when multiplied, the result is {calculator.Multiply(8, 3)}");
            Console.WriteLine($"The numbers when divided, the result is {calculator.Divide(8.4, 3.5)}");
        }
    }

    interface IBasicCalculator
    {
        public T Add<T>(T a, T b);
        public T Subtract<T>(T a, T b);
        public T Multiply<T>(T a, T b);
        public T Divide<T>(T a, T b);

    }
    public class GenericCalculator : IBasicCalculator
    {
        //public T Add<T>(T a, T b)
        //{
        //    //object num1 = a;
        //    //object num2 = b;
        //    //I result= (I)(object)((int)num1 + (int)num2);
        //    //return (O)Convert.ChangeType(result, typeof(I));
        //}

        public T Add<T>(T a, T b)
        {
            try
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 + num2;
            }
            catch
            {
                throw new NotImplementedException("Cant add the numbers");
            }
        }

        public T Divide<T>(T a, T b)
        {
            try
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 / num2;
                //return (num1 > num2) ? num1 / num2 : num2 / num1;
            }
            catch 
            {
                throw new NotImplementedException("Cant divide the numbers");
            }
        }

        public T Multiply<T>(T a, T b)
        {
            try
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 * num2;
            }
            catch 
            {
                throw new NotImplementedException("Cant multiply the numbers");
            }
        }

        public T Subtract<T>(T a, T b)
        {
            try
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 - num2;
                //return (num1 > num2) ? num1 - num2 : num2 - num1;
            }
            catch 
            {
                throw new NotImplementedException("Cant subtract the numbers"); 
            }
        }
    }
}
