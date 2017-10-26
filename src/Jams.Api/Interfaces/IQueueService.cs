using System.Collections.Generic;
using MVPSI.JAMS;

namespace Jams.Api
{
    public interface IQueueService
    {
        BatchQueue Create();
        List<BatchQueue> Find(string queueName);
    }
}