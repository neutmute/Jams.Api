using System.Collections.Generic;
using MVPSI.JAMS;

namespace Jams.Api
{
    public interface IJobService
    {
        Job Create(Folder folder);
        List<Job> Find(Folder folder);
        List<Job> Find(string fullyQualifedName);
        Job Get(Folder folder, string name);
    }
}