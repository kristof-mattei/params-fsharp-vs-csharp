namespace EntryPointCS
{
    using System;
    using System.Diagnostics;
    using Lib;

    class Program
    {
        static void Main(string[] args)
        {
            object bar1 = null;
            object bar2 = null;

            var lengthAsParam = Test.TestMethod(bar1, bar2);
            var lengthAsArray = Test.TestMethod(new object[] { bar1, bar2 });

            var condition = lengthAsParam == lengthAsArray;

            Debug.Assert(condition);

            Console.WriteLine(condition);

            Console.ReadLine();
        }
    }
}
