namespace SampleSpinLockExample
{
    using System;
    using System.Threading;

    class SpinLockExample
    {
        static SpinLock spinLock = new SpinLock();

        static void DoWork(int id)
        {
            bool lockTaken = false;
            try
            {
                spinLock.Enter(ref lockTaken);
                Console.WriteLine($"Thread {id} acquired the lock");
                Thread.Sleep(100); // Simulate work
            }
            finally
            {
                if (lockTaken)
                    spinLock.Exit();
            }
        }

        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                int localId = i;
                new Thread(() => DoWork(localId)).Start();
            }
        }
    }
}
