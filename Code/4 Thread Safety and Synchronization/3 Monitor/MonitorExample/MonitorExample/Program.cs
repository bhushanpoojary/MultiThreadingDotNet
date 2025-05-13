namespace MonitorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Increment();
            Console.WriteLine(counter.GetCount().ToString());
        }
    }
    class Counter
    {
        private int _count = 0;
        private readonly object _lock = new object();

        public void Increment()
        {
            try
            {
                Monitor.Enter(_lock);// Acquires monitor lock
                {
                    _count++;
                } // Releases lock automatically here
            }
            finally
            {
                Monitor.Exit(_lock);
            }
            
        }

        public int GetCount()
        {
            lock (_lock)
            {
                return _count;
            }
        }

        public void Decrement()
        {
            if (Monitor.TryEnter(_lock, TimeSpan.FromSeconds(2)))
            {
                try
                {
                    _count--;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
            else
            {
                // Handle timeout (e.g., log, retry)
            }
        }
    }
}
