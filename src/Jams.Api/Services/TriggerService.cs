using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVPSI.JAMS;

namespace Jams.Api
{
    public class TriggerService : JamsService, ITriggerService
    {
        public TriggerService(IJamsContext context) : base(context)
        {
        }

        ///// <summary>
        ///// Unreliable - some characters won't produce a hit
        ///// </summary>
        //public List<Trigger> Find(string fullyQualifedName)
        //{
        //    var jobs = Trigger.Find(fullyQualifedName, Server);
        //    return jobs.ToList();
        //}

        /// <summary>
        /// Reliable version
        /// </summary>
        public Trigger Get(Folder folder, string name)
        {
            var job = Find(folder)
                        .Where(j => j.Name == name)
                        .FirstOrDefault();

            return job;
        }

        public List<Trigger> Find(Folder folder)
        {
            var jobs = Trigger.Find(folder.FolderID, Server);
            return jobs.ToList();
        }
        
        public Trigger Create(Folder folder)
        {
            Trigger newTrigger;
            Trigger.Load(out newTrigger, string.Empty, 0, Server);

            newTrigger.ParentFolder = folder;
            newTrigger.ParentFolderName = folder.Name;

            return newTrigger;
        }
                    
    }
}
