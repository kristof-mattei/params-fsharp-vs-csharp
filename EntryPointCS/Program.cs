namespace EntryPointCS
{
    using Lib;

    class Program
    {
        static void Main(string[] args)
        {
            var foo1 = new Foo();
            var foo2 = new Foo();

            var asParams = Test.TestMethod(foo1, foo2);
            var asArray = Test.TestMethod(new Foo[] { foo1, foo2 });
        }
    }
}
