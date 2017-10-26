using System.Collections.Generic;
using MVPSI.JAMS;

namespace Jams.Api
{
    public interface ITriggerService
    {
        Trigger Create(Folder folder);
        List<Trigger> Find(Folder folder);
        Trigger Get(Folder folder, string name);
    }
}