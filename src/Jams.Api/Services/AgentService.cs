using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSI.JAMS;
using Kraken.Tests.Tests;

namespace Jams.Api
{
    public class AgentService : JamsService, IAgentService
    {
        public AgentService(IJamsContext context) : base(context)
        {
        }

        public List<Agent> Find(string agentName)
        {
            var agents = Agent.Find(agentName, Server);
            return agents.ToList();
        }
        
        public Agent Create()
        {
            Agent newAgent;
            Agent.Load(out newAgent, string.Empty, 0, Server);
            return newAgent;
        }


        /// <summary>
        /// Sets internal property...
        /// </summary>
        public void SetPlatform(Agent agent)
        {
            agent.Platform = "Windows";

            // Hack around the internal settor
            var xray = ObjectXRay.NewType(typeof(Agent), agent);
            xray.SetField("m_AgentType", AgentType.Windows);
        }
    }
}
