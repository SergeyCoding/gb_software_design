namespace Singleton
{
    class Summator
    {
        public int A { get; }
        public int B { get; }

        public Summator(int a, int b)
        {
            A = a;
            B = b;
        }
        public int GetResult()
        {
            return A + B;
        }

    }

    class WrapperSummator(int a, int b) : Summator(a, b)
    {
        public new int GetResult()
        {
            Console.WriteLine($"logger: До вызова a={A}, b={B}");
            var result = base.GetResult();
            Console.WriteLine($"logger: После вызова a={A}, b={B}, result={result}");
            return result;
        }
    }
}
