
using Kraken.Core;
using MVPSI.JAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jams.Api
{

    public abstract class JamsService
    {
        IJamsContext _context;

        protected MVPSI.JAMS.Server Server {
            get
            {
                return _context.Server;
            }
        }

        protected JamsService(IJamsContext context)
        {
            _context = context;
        }

    }
}
