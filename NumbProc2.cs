
namespace Task
{
    public class NumbProc2
    {
        private int[] _arr;

        public NumbProc2(int[] arr)
        {
            _arr = arr;
        }

        public IEnumerable<int> GetValues()
        {
            foreach (var x in _arr)
            {
                yield return x;
            }
        }

        public NumbProc2 Add (int num)
        {
            var i = 0;
            foreach (var value in GetValues())
            {
                _arr[i++] = value + num;
            }
            return this;
        }

        public NumbProc2 Sub(int num)
        {
            var i = 0;
            foreach (var value in GetValues())
            {
                _arr[i++] = value - num;
            }
            return this;
        }

        public NumbProc2 Div(int num)
        {
            var i = 0;
            foreach (var value in GetValues())
            {
                _arr[i++] = value / num;
            }
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