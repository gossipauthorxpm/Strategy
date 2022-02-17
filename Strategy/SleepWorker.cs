using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SleepWorker : IWorker
    {
        private string event_worker = "Sleep";
        public void InfoWorker()
        {
            Console.WriteLine($"Занятие работника {event_worker}");
        }
    }
}
