
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Frank";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;


            int i = 5;
            dynamic d = i;
            // If dynamic type is implicitly convertible, no casting is necessary
            long l = d;
        }
    }
}
