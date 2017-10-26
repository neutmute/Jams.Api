using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVPSI.JAMS;

namespace Jams.Api
{
    public class MethodService : JamsService, IMethodService
    {
        public MethodService(IJamsContext context) : base(context)
        {
        }

        public List<Method> Find(string name)
        {
            var methods = Method.Find(name, Server);
            return methods.ToList();
        }        
    }
}
