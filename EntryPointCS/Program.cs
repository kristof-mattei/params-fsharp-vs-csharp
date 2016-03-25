namespace EntryPointCS
{
    using Lib;

    class Program
    {
        static void Main(string[] args)
        {
            var bar1 = new Bar();
            var bar2 = new Bar();

            var asParams = Test.TestMethod(bar1, bar2);
            var asArray = Test.TestMethod(new Bar[] { bar1, bar2 });
        }
    }
}
