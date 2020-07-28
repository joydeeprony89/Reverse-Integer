using System;
using System.Linq;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().Reverse(1534236469));
        }

        public int Reverse(int x)
        {
            int y = x;
            x = x < 0 ? x * -1 : x;
            string str = x.ToString();
            var arr = str.ToCharArray();
            int length = str.Length;
            for (int i = 0, j = length - 1; i < j; i++, j--)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            int reverseNumber;
            int.TryParse(string.Join("", arr), out reverseNumber);
            return y < 0 ? reverseNumber * -1 : reverseNumber;
        }
    }
}
