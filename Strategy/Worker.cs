using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Worker
    {
        public void InfoOfWokerEvent(IWorker worker)
        {
            if(worker != null)
            {
                worker.InfoWorker();
            }
        }
    }
}
