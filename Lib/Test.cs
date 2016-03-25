namespace Lib
{
    using System.Linq;

    public static class Test
    {
        public static Return TestMethod(params object[] parameters)
        {
            if (parameters.All(p => p is Foo))
            {
                return Return.AllFoo;
            }
            else if (parameters.Any(p => p is Foo))
            {
                return Return.NoneFoo;
            }
            else
            {
                return Return.Mixed;
            }
        }
    }

    public enum Return
    {
        AllFoo,
        NoneFoo,
        Mixed
    }
}
