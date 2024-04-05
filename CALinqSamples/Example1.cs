using System.Linq;

namespace CALinqSamples
{
    class Example1
    {
        static void Main(string[] args)
        {
            int[] ar = { 25, 96, 41, 25, 67, 95, 32, 38, 97, 11, 54, 73, 85 };
            //Copy the elements into another array, whose value is greater than 30
            //int size = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (ar[i] > 30)
            //    {
            //        size = size + 1;
            //    }
            //}
            //int[] br = new int[size];
            //int count = 0;
            //for (int i = 0; i < ar.Length; i++)
            //{

            //    if (ar[i] > 30)
            //    {
            //        br[count] = ar[i];
            //        count++;
            //    }
            //}

            //var br = from item in ar select item;
            //var br = from x in ar where x>30 select x;
            //var br = (from x in ar where x > 30 orderby x ascending select x);
            var br = from x in ar where x > 30 orderby x descending select x;

            Console.WriteLine("Elements of new array are: ");
            foreach (var item in br)
            {
                Console.Write(item+" ");
            }


        }
    }
}
