namespace Repro.S126
{
    public class FooService
    {
        public string Foo(string name)
        {
            if (name == null)
            {
                return "Foo";
            }
            else if (name == string.Empty)
            {
                return "Bar";
            }

            return "FooBar";
        }

        public string FooWithoutRedundantElse(string name)
        {
            if (name == null)
            {
                return "Foo";
            }

            if (name == string.Empty)
            {
                return "Bar";
            }

            return "FooBar";
        }
    }
}
