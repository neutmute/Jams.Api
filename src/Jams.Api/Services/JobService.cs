using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVPSI.JAMS;

namespace Jams.Api
{
    public class JobService : JamsService, IJobService
    {
        public JobService(IJamsContext context) : base(context)
        {
        }

        /// <summary>
        /// Unreliable - some characters won't produce a hit
        /// </summary>
        public List<Job> Find(string fullyQualifedName)
        {
            var jobs = Job.Find(fullyQualifedName, Server);
            return jobs.ToList();
        }

        /// <summary>
        /// Reliable version
        /// </summary>
        public Job Get(Folder folder, string name)
        {
            var job = Find(folder)
                        .Where(j => j.Name == name)
                        .FirstOrDefault();

            return job;
        }

        public List<Job> Find(Folder folder)
        {
            var jobs = Job.Find(folder.FolderID, Server);
            return jobs.ToList();
        }
        
        public Job Create(Folder folder)
        {
            Job newJob;
            Job.Load(out newJob, string.Empty, 0, Server);

            newJob.ParentFolder = folder;
            newJob.ParentFolderName = folder.Name;

            return newJob;
        }
                    
    }
}
