using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3HW4
{
    public class Class1
    {
        public Class1()
        {
        }

        public event Func<int, int, int> SumHandler;

        public void Run()
        {
            SumHandler += Sum;
            SumHandler += Sum;

            var result = 0;

            TryCatch(() =>
            {
                result = SumOfSums(3, 4);
            });

            Console.WriteLine(result);
        }

        public void TryCatch(Action handler)
        {
            try
            {
                handler();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public int SumOfSums(int x, int y)
        {
            var result = 0;

            var listOfSums = SumHandler.GetInvocationList();
            foreach (var item in listOfSums)
            {
                result += (int)item.DynamicInvoke(x, y);
            }

            return result;
        }

        public int Sum(int x, int y)
        {
            var result = x + y;

            return result;
        }
    }
}
