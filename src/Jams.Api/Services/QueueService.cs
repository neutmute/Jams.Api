using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVPSI.JAMS;

namespace Jams.Api
{
    public class QueueService : JamsService, IQueueService
    {
        public QueueService(IJamsContext context) : base(context)
        {
        }

        public BatchQueue Create()
        {
            BatchQueue newQueue;
            BatchQueue.Load(out newQueue, string.Empty, Server);
            return newQueue;
        }

        public List<BatchQueue> Find(string queueName)
        {
            return BatchQueue.Find(queueName, Server).ToList();
        }
    }
}
