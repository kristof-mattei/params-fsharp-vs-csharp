namespace Lib
{
    public static class Test
    {
        public static int TestMethod(params object[] parameters)
        {
            return parameters.Length;
        }
    }
}
