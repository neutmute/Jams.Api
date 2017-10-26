using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVPSI.JAMS;

namespace Jams.Api
{
    public class FolderService : JamsService, IFolderService
    {
        public FolderService(IJamsContext context) : base(context)
        {
        }

        public Folder Get(string name)
        {
            return Folder.Find(name, Server).ToList().FirstOrDefault();
        }
    }
}
