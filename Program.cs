using DataStructures_CSharp.DynamicArray;
using System.Collections;

namespace DataStructures_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Dynamic Array Calling"

            DynamicArray<int> ar = new DynamicArray<int>(4);
            ar.add(3);
            ar.add(7);
            ar.add(6);
            ar.add(-2);

            ar.sort(); // [-2, 3, 6, 7]

            //// Prints [-2, 3, 6, 7]
            for (int i = 0; i < ar.Length; i++)
                Console.WriteLine(ar.Get(i));

            // Prints [-2, 3, 6, 7]
            Console.WriteLine(ar.array);
            Console.WriteLine(ar.binarySearch(5));

            #endregion

            Console.ReadLine();
        }
    }
}