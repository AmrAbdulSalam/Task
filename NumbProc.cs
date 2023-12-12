
namespace Task
{
    public class NumbProc
    {
        private readonly int[] _arr;

        public NumbProc(int[] arr)
        {
            _arr = arr;
        }

        private void GetValues(int number, Func<int, int, int> fun)
        {
            for (int i = 0; i < _arr.Length;i++)
            {
                _arr[i] = fun(_arr[i] , number);
            }
        }

        public NumbProc Add(int number)
        {
            GetValues(number , (x,y) => x + y);
            return this;
        }

        public NumbProc Sub(int number)
        {
            GetValues(number, (x, y) => x - y);
            return this;
        }

        public NumbProc Div(int number)
        {
            GetValues(number, (x, y) => x / y);
            return this;
        }

        public void DisplayArray()
        {
            foreach (var elment in _arr)
            {
                Console.WriteLine(elment);
            }
        }
    }
}