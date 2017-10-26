using System.Collections.Generic;
using MVPSI.JAMS;

namespace Jams.Api
{
    public interface IMethodService
    {
        List<Method> Find(string name);
    }
}