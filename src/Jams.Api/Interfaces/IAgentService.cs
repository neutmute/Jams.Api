using System.Collections.Generic;
using MVPSI.JAMS;

namespace Jams.Api
{
    public interface IAgentService
    {
        Agent Create();

        List<Agent> Find(string agentName);

        void SetPlatform(Agent agent);
    }
}