
namespace Task
{
    public class Program
    {
        public static void Main()
        {
            var arr = new[] { 1, 2, 3, 4 };

            var obj = new NumbProc(arr);

            obj
                .Add(5)
                .Sub(1)
                .Div(1);

            obj.DisplayArray();


            var arr2 = new[] { 1, 2, 3, 4 };

            var obj2 = new NumbProc2(arr2);

            obj2
                .Add(5)
                .Sub(1)
                .Div(1);

            obj2.DisplayArray();
        }
    }
}