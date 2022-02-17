using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WalkWorker : IWorker
    {
        private string event_worker = "Walk";
        public void InfoWorker()
        {
            Console.WriteLine($"Занятие работника {event_worker}");
        }
    }
}
