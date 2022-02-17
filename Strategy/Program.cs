namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            Worker worker = new Worker();

            worker.InfoOfWokerEvent(new WalkWorker());
            worker.InfoOfWokerEvent(new SleepWorker());
        }
    }
}